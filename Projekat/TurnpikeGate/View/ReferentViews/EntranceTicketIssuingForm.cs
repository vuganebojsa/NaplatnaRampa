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
using TurnpikeGate.Core.TollStations.Service;
using Timer = System.Threading.Timer;
using Autofac;
using MongoDB.Bson;
using TurnpikeGate.Core.Prices.Service;
using TurnpikeGate.Core.Turnpike.Model;
using TurnpikeGate.Core.Turnpike.Service;

namespace TurnpikeGate.View.ReferentViews
{
    public partial class EntranceTicketIssuingForm : Form
    {
        private PictureBox _selectedPicture;
        private VehicleType _selectedVehicleType;
        private List<System.Threading.Timer> _timers;
        private readonly List<String> _carPlates;
        private readonly ITollStationService _tollStationService;
        private readonly IPriceListEntryService _priceListEntryService;
        private readonly IPhysicalTollPaymentService _physicalTollPaymentService;

        
        public EntranceTicketIssuingForm()
        {

            InitializeComponent();
            _selectedPicture = pbCar;
            _selectedVehicleType = VehicleType.AUTOMOBILE;
            _tollStationService = Globals.Container.Resolve<ITollStationService>();
            _priceListEntryService = Globals.Container.Resolve<IPriceListEntryService>();
            _physicalTollPaymentService = Globals.Container.Resolve<IPhysicalTollPaymentService>();
            _carPlates = new List<string>();
            
            tbEntry.Text = _tollStationService.GetAll()[0].Name;
            InitTimer();
            GenerateVehicleThreads();

           
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {


;            PhysicalTollPayment tollPayment = new PhysicalTollPayment(_carPlates[0], DateTime.Now, DateTime.MaxValue,
                                                                        _selectedVehicleType , _tollStationService.GetAll()[0].ID, ObjectId.Empty, ObjectId.Empty);
            
            _physicalTollPaymentService.Insert(tollPayment);

            _carPlates.RemoveAt(0);

            tbPlates.Text = "";
            if (_carPlates.Count > 0)
            {
                tbPlates.Text = _carPlates[0];

            }
        }

        private void pbCar_Click(object sender, EventArgs e)
        {
            SetSelectedPictureValues(pbCar, VehicleType.AUTOMOBILE);
        }

        private void SetSelectedPictureValues(PictureBox pictureBox, VehicleType vehicleType)
        {
            _selectedPicture.BorderStyle = BorderStyle.None;
            _selectedPicture.BackColor = Color.Transparent;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.BackColor = Color.Bisque;
            
            _selectedPicture = pictureBox;
            _selectedVehicleType = vehicleType;

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

        private void GenerateVehicleThreads()
        {
            this._timers = new List<Timer>();
            for (int i = 0; i < 50; i++)
            {
                this._timers.Add(new Timer(x =>
                {
                    String randomPlate = GenerateRandomPlate();
                    _carPlates.Add(randomPlate);
                    Console.WriteLine("Vozilo sa tablicama: " + randomPlate +  " je doslo na rampu.");
                    
                    Thread.Sleep(8000);
                       
                }, null, TimeSpan.FromSeconds(i * 8), Timeout.InfiniteTimeSpan));
            }
            
        }

        private String GenerateRandomPlate()
        {
            Random random = new Random();

            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";
            string firsTwo = new string(Enumerable.Repeat(letters, 2)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            string threeNumbers = new string(Enumerable.Repeat(numbers, 3)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            string lastTwo = new string(Enumerable.Repeat(letters, 2)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return firsTwo + threeNumbers + lastTwo;

        }
        public void InitTimer()
        {
            platesTimer = new System.Windows.Forms.Timer();
            platesTimer.Tick += new EventHandler(platesTimer_Tick_1);
            platesTimer.Interval = 1000;
            platesTimer.Start();

        }
        private void platesTimer_Tick_1(object sender, EventArgs e)
        {
            if (tbPlates.Text == "" && _carPlates.Any())
                tbPlates.Text = _carPlates[0];
        }
    }
}
