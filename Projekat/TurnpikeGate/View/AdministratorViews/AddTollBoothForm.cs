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
        public AddTollBoothForm(IObserver observer, string tollBoothId, ICameraService cameraService, ITrafficLightService trafficLightService, IRampService rampService)
        {
            InitializeComponent();
            _observer = observer;
            _tollBoothService = Globals.Container.Resolve<ITollBoothService>();
            _tollStationService = Globals.Container.Resolve<ITollStationService>();
            _rampService = rampService;
            _trafficLightService = trafficLightService;
            _cameraService = cameraService;
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
            var ramp = new Ramp(ObjectId.Empty, cbRamps.Text == "ISPRAVNO");
            var camera = new Camera(ObjectId.Empty, cbCameras.Text == "ISPRAVNO");
            var trafficLight = new TraficLight(ObjectId.Empty, cbTrafficLights.Text == "ISPRAVNO");

            TollBooth tollBooth = new TollBooth((TypeOfPayment)cbTypes.SelectedValue,
                ((TollStation)cbStations.SelectedValue).ID,
                ramp.ID, trafficLight.ID, camera.ID);

            ramp.ToolBoothId = tollBooth.ID;
            camera.ToolBoothId = tollBooth.ID;
            trafficLight.ToolBoothId = tollBooth.ID;
            _rampService.Insert(ramp);
            _cameraService.Insert(camera);
            _trafficLightService.Insert(trafficLight);

            _tollBoothService.Insert(tollBooth);
            tollBooth.Attach(_observer);
            tollBooth.Notify();
            MessageBox.Show("Uspesno ste dodali novo naplatno mesto!");
        }

        private void EditTollBooth()
        {
            TollBooth tb = _tollBoothService.GetById(ObjectId.Parse(_tollBoothId));
            var ramp = _rampService.GetById(tb.RampId);
            var camera = _cameraService.GetById(tb.CameraId);
            var trafficLight = _trafficLightService.GetById(tb.TrafficLightId);

            ramp.IsWorking = cbRamps.Text == "ISPRAVNO";
            camera.IsWorking = cbCameras.Text == "ISPRAVNO";
            trafficLight.IsWorking = cbTrafficLights.Text == "ISPRAVNO";
            tb.Type = (TypeOfPayment)cbTypes.SelectedValue;
            tb.TollStationId = ((TollStation)cbStations.SelectedItem).ID;

            _rampService.Update(ramp);
            _cameraService.Update(camera);
            _trafficLightService.Update(trafficLight);
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
            cbRamps.Text = _rampService.GetById(tollBooth.RampId).IsWorking ? "ISPRAVNO" : "NEISPRAVNO";
            cbCameras.Text = _cameraService.GetById(tollBooth.CameraId).IsWorking ? "ISPRAVNO" : "NEISPRAVNO";
            cbTrafficLights.Text = _trafficLightService.GetById(tollBooth.TrafficLightId).IsWorking ? "ISPRAVNO" : "NEISPRAVNO";
            cbTypes.Text = tollBooth.Type.ToString();

        }
    }
}
