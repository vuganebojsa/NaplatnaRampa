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
            /*STEPS
             1. Vozilo stize na rampu
             2. Kamera snima tablicu vozila
             3. Referent naplate izdaje list vozacu
             4. Referent pritiska dugme za podizanje rampe
            5. Rampa se podize i pali se zeleno svetlo
            */
            /*
             *MOTOCYCLE,
            AUTOMOBILE,
            TRUCK, 
            BUS,
            MINIVAN,
            CAR_WITH_TRAILER
             *
             */

            InitializeComponent();
            _selectedPicture = pbCar;
            _selectedVehicleType = VehicleType.AUTOMOBILE;
            _tollStationService = Globals.Container.Resolve<ITollStationService>();
            _priceListEntryService = Globals.Container.Resolve<IPriceListEntryService>();
            _physicalTollPaymentService = Globals.Container.Resolve<IPhysicalTollPaymentService>();
            _carPlates = new List<string>();
            GenerateVehicleThreads();
            tbEntry.Text = _tollStationService.GetAll()[0].Name;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {

            PriceListEntry pl = new PriceListEntry(_selectedVehicleType, ObjectId.Empty, ObjectId.Empty);

            _priceListEntryService.Insert(pl);

;            PhysicalTollPayment tollPayment = new PhysicalTollPayment(_carPlates[0], DateTime.Now, DateTime.MaxValue, _tollStationService.GetAll()[0].ID, ObjectId.Empty, pl.ID);
            
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
                    if (tbPlates.Text == "")
                        tbPlates.Text = randomPlate;
                }, null, TimeSpan.FromSeconds(i * 15), Timeout.InfiniteTimeSpan));
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

    }
}
