using Autofac;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using TurnpikeGate.Core.Turnpike.Service;

namespace TurnpikeGate.View.ReferentViews
{
    public partial class ExitTicketIssuingForm : Form
    {
        private PictureBox _selectedPicture;
        private VehicleType _selectedVehicleType;

        private readonly ITollStationService _tollStationService;
        private readonly IPriceListEntryService _priceListEntryService;
        private readonly IPhysicalTollPaymentService _physicalTollPaymentService;

        IPhysicalTollPaymentRepository _physicalTollPaymentRepository;
        readonly IRoadSectionRepository _roadSectionRepository;

        private List<System.Threading.Timer> _timers;
        private readonly List<PhysicalTollPayment> _vehicleQueue;
        private TollStation _entranceStation;
        private TollStation _exitStation;

        public ExitTicketIssuingForm()
        {
            InitializeComponent();
            _tollStationService = Globals.Container.Resolve<ITollStationService>();
            _priceListEntryService = Globals.Container.Resolve<IPriceListEntryService>();
            _physicalTollPaymentService = Globals.Container.Resolve<IPhysicalTollPaymentService>();
            _physicalTollPaymentRepository = Globals.Container.Resolve<IPhysicalTollPaymentRepository>();
            _roadSectionRepository = Globals.Container.Resolve<IRoadSectionRepository>();

            _selectedPicture = pbCar;
            _selectedVehicleType = VehicleType.AUTOMOBILE;
            _exitStation = _tollStationService.GetById(StationInformation.ExitStationId);

            _vehicleQueue = new List<PhysicalTollPayment>();
            InitTimer();
            StartSimulation();


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

            RoadSection roadSection = _roadSectionRepository.GetByLocations(_entranceStation.ID, _exitStation.ID);
            CalculateTollPrice(roadSection);

        }

        private void CalculateTollPrice(RoadSection roadSection)
        {
            Currency currency = GetSelectedCurrency();
            tbTollPrice.Text = _physicalTollPaymentService.CalculateTollPrice(_selectedVehicleType, roadSection.ID, currency).ToString();
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
            tbPlates.Text = physicalTollPayment.RegistrationPlate;

            _entranceStation = _tollStationService.GetById(physicalTollPayment.EntranceStationId);
            Console.WriteLine(_entranceStation.Name);
            tbEntranceStation.Text = _entranceStation.Name;

            tbEntranceTime.Text = physicalTollPayment.EntranceTime.ToString();
            tbExitTime.Text = DateTime.Now.ToString();

            // TODO: ucitati iz fajla
            tbExitStation.Text = _exitStation.Name;
        }

        private void tbReceivedSum_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Pritisnuto.", "Greska");
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

        }
    }
}
