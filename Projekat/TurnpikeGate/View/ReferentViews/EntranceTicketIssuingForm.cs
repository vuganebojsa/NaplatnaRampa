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

namespace TurnpikeGate.View.ReferentViews
{
    public partial class EntranceTicketIssuingForm : Form
    {
        private PictureBox _selectedPicture;
        private VehicleType _selectedVehicleType;

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

            // na selektovanje slika obojiti im background u sivo
            // i tu sliku cuvati selektovanu u private PictureBox _selected
            // i onda kad se selektuje nova trenutnoj se stavlja boja na belo pozadine
            // a novoj na crno

            InitializeComponent();
            _selectedPicture = pbCar;
            _selectedVehicleType = VehicleType.AUTOMOBILE;
        }

        private void btnIssue_Click(object sender, EventArgs e)
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
    }
}
