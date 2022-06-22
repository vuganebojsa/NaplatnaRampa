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
        public AddTollBoothForm(IObserver observer)
        {
            InitializeComponent();
            _observer = observer;
            _tollBoothService = Globals.Container.Resolve<ITollBoothService>();
            _tollStationService = Globals.Container.Resolve<ITollStationService>();
            _rampService = Globals.Container.Resolve<IRampService>();
            _trafficLightService = Globals.Container.Resolve<ITrafficLightService>();
            _cameraService = Globals.Container.Resolve<ICameraService>();
            FillComboBoxes();
        }

        public void FillComboBoxes()
        {
            List<TypeOfPayment> types = Enum.GetValues(typeof(TypeOfPayment)).Cast<TypeOfPayment>().ToList();
            cbTypes.ValueMember = null;
            cbTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypes.DisplayMember = "Tipovi naplate";
            cbTypes.DataSource = types;

            var stations = _tollStationService.GetAll();
            List<ObjectId> stationsIDs = new List<ObjectId>();
            stations.ForEach(p =>
            {
                stationsIDs.Add(p.ID);
            });
            cbStations.ValueMember = null;
            cbStations.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStations.DisplayMember = "Stanice";
            cbStations.DataSource = stationsIDs;

            var cameras = _cameraService.GetAll();
            List<ObjectId> camerasIDs = new List<ObjectId>();
            cameras.ForEach(p =>
            {
                camerasIDs.Add(p.ID);
            });
            cbCameras.ValueMember = null;
            cbCameras.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCameras.DisplayMember = "Kamere";
            cbCameras.DataSource = camerasIDs;

            var trafficLights = _trafficLightService.GetAll();
            List<ObjectId> trafficLightsIDs = new List<ObjectId>();
            trafficLights.ForEach(p =>
            {
                trafficLightsIDs.Add(p.ID);
            });
            cbTrafficLights.ValueMember = null;
            cbTrafficLights.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrafficLights.DisplayMember = "Semafori";
            cbTrafficLights.DataSource = trafficLightsIDs;

            var ramps = _rampService.GetAll();
            List<ObjectId> rampsIDs = new List<ObjectId>();
            ramps.ForEach(p =>
            {
                rampsIDs.Add(p.ID);
            });
            cbRamps.ValueMember = null;
            cbRamps.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRamps.DisplayMember = "Rampe";
            cbRamps.DataSource = rampsIDs;
        }

        private void InsertTollBooth()
        {
            TollBooth tollBooth = new TollBooth((TypeOfPayment) cbTypes.SelectedValue, (ObjectId)cbStations.SelectedValue, 
                (ObjectId) cbRamps.SelectedValue, (ObjectId) cbTrafficLights.SelectedValue,  (ObjectId)cbCameras.SelectedValue);
            _tollBoothService.Insert(tollBooth);
            tollBooth.Attach(_observer);
            tollBooth.Notify();
        }

        private void AddTollBoothForm_Load(object sender, EventArgs e)
        {
            InsertTollBooth();
        }
    }
}
