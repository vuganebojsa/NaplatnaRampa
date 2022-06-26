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
        private List<System.Threading.Timer> _timers;
        private readonly List<String> _carPlates;
        private readonly ITollStationService _tollStationService;
        private readonly IPhysicalTollPaymentService _physicalTollPaymentService;

        public EntranceTicketIssuingForm()
        {

            InitializeComponent();
            _tollStationService = Globals.Container.Resolve<ITollStationService>();
            _physicalTollPaymentService = Globals.Container.Resolve<IPhysicalTollPaymentService>();
            _carPlates = new List<string>();
            
            tbEntry.Text = _tollStationService.GetById(StationInformation.EntryStationId).Name;
            InitPlatesTimer();
            GenerateVehicleThreads();
            InitIssuingTimer();



        }

        private void IssueTicket()
        {
            PhysicalTollPayment tollPayment = new PhysicalTollPayment(_carPlates[0], DateTime.Now, DateTime.MaxValue,
                                                                        VehicleType.AUTOMOBILE , _tollStationService.GetAll()[0].ID, ObjectId.Empty, ObjectId.Empty, ObjectId.Empty);
            
            _physicalTollPaymentService.Insert(tollPayment);
            _carPlates.RemoveAt(0);
            tbPlates.Text = "";
            if (_carPlates.Count > 0)
            {
                tbPlates.Text = _carPlates[0];

            }
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
        private void InitPlatesTimer()
        {
            platesTimer = new System.Windows.Forms.Timer();
            platesTimer.Tick += new EventHandler(platesTimer_Tick_1);
            platesTimer.Interval = 800;
            platesTimer.Start();

        }

        private void platesTimer_Tick_1(object sender, EventArgs e)
        {
            if (tbPlates.Text == "" && _carPlates.Any())
            {
                tbPlates.Text = _carPlates[0];
                tbSuccess.Text = "";
            }
        }

        private void InitIssuingTimer()
        {
            issuingTimer = new System.Windows.Forms.Timer();
            issuingTimer.Tick += new EventHandler(issuingTimer_Tick);
            issuingTimer.Interval = 2600;
            issuingTimer.Start();
        }

        private void issuingTimer_Tick(object sender, EventArgs e)
        {
            if (tbSuccess.Text == "" && _carPlates.Any())
            {
                tbSuccess.Text = "Uspesno izdat tiket za sledece tablice: " + _carPlates[0];
                IssueTicket();
            }
        }
    }
}
