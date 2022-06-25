using Autofac;
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
using TurnpikeGate.Core.Prices.Service;
using TurnpikeGate.Core.TollStations.Service;
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


        public ExitTicketIssuingForm()
        {
            InitializeComponent();
            _tollStationService = Globals.Container.Resolve<ITollStationService>();
            _priceListEntryService = Globals.Container.Resolve<IPriceListEntryService>();
            _physicalTollPaymentService = Globals.Container.Resolve<IPhysicalTollPaymentService>();

            _selectedPicture = pbCar;
            _selectedVehicleType = VehicleType.AUTOMOBILE;
        }

        private void ExitTicketIssuingForm_Load(object sender, EventArgs e)
        {

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
    }
}
