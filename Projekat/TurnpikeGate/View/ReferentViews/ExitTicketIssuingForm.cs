using Autofac;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurnpikeGate.Core.Prices.Model;
using TurnpikeGate.Core.Prices.Repository;
using TurnpikeGate.Core.Prices.Service;
using TurnpikeGate.Core.Simulation;
using TurnpikeGate.Core.TollStations;
using TurnpikeGate.Core.TollStations.Service;
using TurnpikeGate.Core.Turnpike.Model;
using TurnpikeGate.Core.Turnpike.Repository;
using TurnpikeGate.Core.TollStations.Model;
using TurnpikeGate.Core.TollStations.Service;
using TurnpikeGate.Core.TollStations.States;
using TurnpikeGate.Core.Turnpike.Service;
using TurnpikeGate.Core.Users.Model;

namespace TurnpikeGate.View.ReferentViews
{
    public partial class ExitTicketIssuingForm : Form
    {
        private PictureBox _selectedPicture;
        private VehicleType _selectedVehicleType;

        private readonly ITollStationService _tollStationService;
        private readonly IPriceListEntryService _priceListEntryService;
        private readonly IPhysicalTollPaymentService _physicalTollPaymentService;

        private readonly IPhysicalTollPaymentRepository _physicalTollPaymentRepository;
        private readonly IRoadSectionRepository _roadSectionRepository;
        private readonly IPriceListEntryRepository _priceListEntryRepository;
        private readonly IRampService _rampService;
        private readonly ITollBoothService _boothService;


        private List<System.Threading.Timer> _timers;
        private List<PhysicalTollPayment> _vehicleQueue;
        private TollStation _entranceStation;
        private TollStation _exitStation;
        private PhysicalTollPayment _currentTollPayment;
        private RoadSection _selectedRoadSection;
        private ObjectId _priceListEntryId;
        private TollBooth tollBooth;
        Ramp ramp;
        int tickCount = 0;

        public ExitTicketIssuingForm()
        {
            InitializeComponent();
            _tollStationService = Globals.Container.Resolve<ITollStationService>();
            _priceListEntryService = Globals.Container.Resolve<IPriceListEntryService>();
            _physicalTollPaymentService = Globals.Container.Resolve<IPhysicalTollPaymentService>();
            _physicalTollPaymentRepository = Globals.Container.Resolve<IPhysicalTollPaymentRepository>();
            _roadSectionRepository = Globals.Container.Resolve<IRoadSectionRepository>();
            _priceListEntryRepository = Globals.Container.Resolve<IPriceListEntryRepository>();

            _selectedPicture = pbCar;
            _selectedVehicleType = VehicleType.AUTOMOBILE;
            _exitStation = _tollStationService.GetById(StationInformation.ExitStationId);

            _vehicleQueue = new List<PhysicalTollPayment>();
            tbExitStation.Text = _exitStation.Name;
            InitTimer();
            StartSimulation();

            _rampService = Globals.Container.Resolve<IRampService>();
            _boothService = Globals.Container.Resolve<ITollBoothService>();
            tollBooth = _boothService.GetById(StationInformation.TollBoothId);
            ramp = _rampService.GetById(tollBooth.RampId);

        }

        private void pbCar_Click(object sender, EventArgs e)
        {
            SetSelectedPictureValues(pbCar, VehicleType.AUTOMOBILE);
        }

        private void SetSelectedPictureValues(PictureBox pictureBox, VehicleType vehicleType)
        {
            _selectedPicture.BorderStyle = BorderStyle.None;
            _selectedPicture.BackColor = Color.Transparent;
            pictureBox.BorderStyle = BorderStyle.None;
            pictureBox.BackColor = Color.LightBlue;

            _selectedPicture = pictureBox;
            _selectedVehicleType = vehicleType;

            _selectedRoadSection = _roadSectionRepository.GetByLocations(_entranceStation.ID, _exitStation.ID);
            CalculateTollPrice(_selectedRoadSection);

        }

        private void CalculateTollPrice(RoadSection roadSection)
        {
            Currency currency = GetSelectedCurrency();
            Console.WriteLine(currency);
            tbTollPrice.Text = _physicalTollPaymentService.CalculateTollPrice(_selectedVehicleType, roadSection.ID, currency, out _priceListEntryId).ToString();
        }

        private Currency GetSelectedCurrency()
        {
            return rbEUR.Checked ? Currency.EUR : Currency.RSD;
        }

        private void pbBus_Click(object sender, EventArgs e)
        {
            SetSelectedPictureValues(pbBus, VehicleType.BUS);
        }

        private void pbTruck_Click(object sender, EventArgs e)
        {
            SetSelectedPictureValues(pbTruck, VehicleType.TRUCK);
        }

        private void pbMotorcycle_Click(object sender, EventArgs e)
        {
            SetSelectedPictureValues(pbMotorcycle, VehicleType.MOTOCYCLE);
        }

        private void pbMinivan_Click(object sender, EventArgs e)
        {
            SetSelectedPictureValues(pbMinivan, VehicleType.MINIVAN);
        }

        private void pbCarWithTrailer_Click(object sender, EventArgs e)
        {
            SetSelectedPictureValues(pbCarWithTrailer, VehicleType.CAR_WITH_TRAILER);
        }
        public void StartSimulation()
        {
            List<PhysicalTollPayment> tollPayments = _physicalTollPaymentRepository.GetPending();

            int i = 0;

            this._timers = new List<System.Threading.Timer>();
            foreach (PhysicalTollPayment tollPayment in tollPayments)
            {
                this._timers.Add(new System.Threading.Timer(x =>
                {
                    _vehicleQueue.Add(tollPayment);
                    Console.WriteLine("Vozilo sa tablicama: " + tollPayment.RegistrationPlate + " je doslo na rampu.");
                    Thread.Sleep(8000);

                }, null, TimeSpan.FromSeconds(i * 8), Timeout.InfiniteTimeSpan));
                i++;
            }
        }

        public void InitTimer()
        {
            vehiclesTimer = new System.Windows.Forms.Timer();
            vehiclesTimer.Tick += new EventHandler(PlatesTimer_Tick_1);
            vehiclesTimer.Interval = 1000;
            vehiclesTimer.Start();

        }
        public void PlatesTimer_Tick_1(object sender, EventArgs e)
        {
            if (tbPlates.Text == "" && _vehicleQueue.Any())
                FillFields(_vehicleQueue[0]);
        }

        private void FillFields(PhysicalTollPayment physicalTollPayment)
        {
            _currentTollPayment = physicalTollPayment;

            tbPlates.Text = physicalTollPayment.RegistrationPlate;

            _entranceStation = _tollStationService.GetById(physicalTollPayment.EntranceStationId);
            Console.WriteLine(_entranceStation.Name);
            tbEntranceStation.Text = _entranceStation.Name;

            tbEntranceTime.Text = physicalTollPayment.EntranceTime.ToString();
            tbExitTime.Text = DateTime.Now.ToString();
        }

        private void tbReceivedSum_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbSumReceived.Text == "" || tbTollPrice.Text == "")
                    MessageBox.Show("Da bi se izracunao kusur, cena putarine i preuzet iznos moraju biti popunjeni.", "Greska");
                else
                {
                    tbChange.Text = (Convert.ToDouble(tbSumReceived.Text) - Convert.ToDouble(tbTollPrice.Text)).ToString();
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbTollPrice.Text == "")
                MessageBox.Show("Da bi se izdao tiket, cena putarine mora biti izracunata.", "Greska");
            else
            {
                _currentTollPayment.ExitTime = DateTime.Parse(tbExitTime.Text);
                _currentTollPayment.RoadSectionId = _selectedRoadSection.ID;
                _currentTollPayment.PriceListEntryId = _selectedRoadSection.ID;
                _currentTollPayment.ReferentId = Globals.LoggedUser.UserId;
                _currentTollPayment.PriceListEntryId = _priceListEntryId;

                _physicalTollPaymentRepository.Update(_currentTollPayment);

                MessageBox.Show("Putarina naplacena, tiket uspesno izdat :).", "Uspeh");
                btnRaiseRamp.Enabled = true;
            }
        }

        private void ClearFields()
        {
            tbEntranceTime.Text = "";
            tbEntranceStation.Text = "";
            tbExitTime.Text = "";
            tbPlates.Text = "";
            tbTollPrice.Text = "";
            tbSumReceived.Text = "";
            tbChange.Text = "";
        }

        

        public void RaiseRamp( )
        {
            
            ramp.ChangeState(new Raising(ramp));
            lbRamp.Text = "Rampa se dize!";
            InitRampStateTimer();

        }

        private void rampTimer_Tick(object sender, EventArgs e)
        {
            if (tickCount < 3)
            {
                lbRamp.Text = ramp.State.Do();
                tickCount++;
            }
            else 
            {
                rampTimer.Enabled = false;
                tickCount = 0;
                ClearFields();
                _vehicleQueue.RemoveAt(0);
            }
        }

        private void InitRampStateTimer() 
        {
            rampTimer = new System.Windows.Forms.Timer();
            rampTimer.Tick += new EventHandler(rampTimer_Tick);
            rampTimer.Interval = 3000;
            rampTimer.Start();
        }

        private void btnRaiseRamp_Click_1(object sender, EventArgs e)
        {
            RaiseRamp();
            btnRaiseRamp.Enabled = false;

        }

        private void rbRSD_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRSD.Checked)
            {
                CalculateTollPrice(_selectedRoadSection);
            }
        }

        private void rbEUR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEUR.Checked)
            {
                CalculateTollPrice(_selectedRoadSection);
            }
        }
    }
}
