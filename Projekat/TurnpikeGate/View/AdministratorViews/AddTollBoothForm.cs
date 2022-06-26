using Autofac;
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
using TurnpikeGate.Core.Interfaces;
using TurnpikeGate.Core.TollStations;
using TurnpikeGate.Core.TollStations.Model;
using TurnpikeGate.Core.TollStations.Service;

namespace TurnpikeGate.View.AdministratorViews
{
    public partial class AddTollBoothForm : Form
    {
        private readonly ITollBoothService _tollBoothService;
        private readonly ITollStationService _tollStationService;
        private readonly IRampService _rampService;
        private readonly ITrafficLightService _trafficLightService;
        private readonly ICameraService _cameraService;
        private readonly IObserver _observer;
        private readonly string _tollBoothId;
        public AddTollBoothForm(IObserver observer, string tollBoothId = "")
        {
            InitializeComponent();
            _observer = observer;
            _tollBoothService = Globals.Container.Resolve<ITollBoothService>();
            _tollStationService = Globals.Container.Resolve<ITollStationService>();
            _rampService = Globals.Container.Resolve<IRampService>();
            _trafficLightService = Globals.Container.Resolve<ITrafficLightService>();
            _cameraService = Globals.Container.Resolve<ICameraService>();
            _tollBoothId = tollBoothId;
            FillComboBoxes();
            if (tollBoothId != "")
            {
                btnAdd.Text = "AZURIRAJ";
                SetValues();
            }
        }

        public void FillComboBoxes()
        {
            FillTypeComboBox();

            FillStationComboBox();

            FillCameraComboBox();

            FillTrafficLightComboBox();

            FillRampComboBox();
        }

        private void FillRampComboBox()
        {
            var ramps = _rampService.GetAll();
            List<ObjectId> rampsIDs = new List<ObjectId>();
            ramps.ForEach(p => { rampsIDs.Add(p.ID); });
            cbRamps.ValueMember = null;
            cbRamps.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRamps.DisplayMember = "ID";
            cbRamps.DataSource = rampsIDs;
        }

        private void FillTrafficLightComboBox()
        {
            var trafficLights = _trafficLightService.GetAll();
            List<ObjectId> trafficLightsIDs = new List<ObjectId>();
            trafficLights.ForEach(p => { trafficLightsIDs.Add(p.ID); });
            cbTrafficLights.ValueMember = null;
            cbTrafficLights.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrafficLights.DisplayMember = "ID";
            cbTrafficLights.DataSource = trafficLightsIDs;
        }

        private void FillCameraComboBox()
        {
            var cameras = _cameraService.GetAll();
            List<ObjectId> camerasIDs = new List<ObjectId>();
            cameras.ForEach(p => { camerasIDs.Add(p.ID); });
            cbCameras.ValueMember = null;
            cbCameras.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCameras.DisplayMember = "ID";
            cbCameras.DataSource = camerasIDs;
        }

        private void FillStationComboBox()
        {
            var stations = _tollStationService.GetAll();
            cbStations.ValueMember = null;
            cbStations.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStations.DisplayMember = "Name";
            cbStations.DataSource = stations;
        }

        private void FillTypeComboBox()
        {
            List<TypeOfPayment> types = Enum.GetValues(typeof(TypeOfPayment)).Cast<TypeOfPayment>().ToList();
            cbTypes.ValueMember = null;
            cbTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypes.DisplayMember = "TypeOfPayment";
            cbTypes.DataSource = types;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_tollBoothId == "")
                AddTollBooth();
            else
                EditTollBooth();
            this.Close();
        }

        private void AddTollBooth()
        {
            TollBooth tollBooth = new TollBooth((TypeOfPayment)cbTypes.SelectedValue,
                ((TollStation)cbStations.SelectedValue).ID,
                (ObjectId)cbRamps.SelectedValue, (ObjectId)cbTrafficLights.SelectedValue, (ObjectId)cbCameras.SelectedValue);
            _tollBoothService.Insert(tollBooth);
            tollBooth.Attach(_observer);
            tollBooth.Notify();
            MessageBox.Show("Uspesno ste dodali novo naplatno mesto!");
        }

        private void EditTollBooth()
        {
            TollBooth tb = _tollBoothService.GetById(ObjectId.Parse(_tollBoothId));
            tb.CameraId = ObjectId.Parse(cbCameras.Text);
            tb.RampId = ObjectId.Parse(cbRamps.Text);
            tb.TrafficLightId = ObjectId.Parse(cbTrafficLights.Text);
            tb.Type = (TypeOfPayment)cbTypes.SelectedValue;
            tb.TollStationId = ((TollStation)cbStations.SelectedItem).ID;
            _tollBoothService.Update(tb);
            tb.Attach(_observer);
            tb.Notify();
            MessageBox.Show("Uspesno ste izmenili naplatno mesto!");
        }
        private void SetValues()
        {
            TollBooth tollBooth = _tollBoothService.GetById(ObjectId.Parse(_tollBoothId));
            TollStation ts = _tollStationService.GetById(tollBooth.TollStationId);

            cbStations.Text = ts.Name;
            cbCameras.Text = tollBooth.CameraId.ToString();
            cbRamps.Text = tollBooth.RampId.ToString();
            cbTrafficLights.Text = tollBooth.TrafficLightId.ToString();
            cbTypes.Text = tollBooth.Type.ToString();

        }
    }
}
