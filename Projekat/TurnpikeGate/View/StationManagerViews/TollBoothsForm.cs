using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using TurnpikeGate.Core.Interfaces;
using TurnpikeGate.Core.TollStations.Model;
using TurnpikeGate.Core.TollStations.Service;
using TurnpikeGate.View.AdministratorViews;

namespace TurnpikeGate.View.StationManagerViews
{
    public partial class TollBoothsForm : Form, IObserver
    {
        private readonly ITollBoothService _tollBoothService;
        private readonly ITollStationService _tollStationService;
        private readonly ICameraService _cameraService;
        private readonly IRampService _rampService;
        private readonly ITrafficLightService _trafficLightService;
        public TollBoothsForm()
        {
            InitializeComponent();
            _tollStationService = Globals.Container.Resolve<ITollStationService>();
            _tollBoothService = Globals.Container.Resolve<ITollBoothService>();
            _cameraService = Globals.Container.Resolve<ICameraService>();
            _rampService = Globals.Container.Resolve<IRampService>();
            _trafficLightService = Globals.Container.Resolve<ITrafficLightService>();
            LoadData();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvTollBooths.SelectedRows.Count > 0)
            {
                TollBooth tollBooth = (TollBooth)dgvTollBooths.SelectedRows[0].Tag;
                if (tollBooth != null)
                {
                    EditTollBooth editTollBooth = new EditTollBooth(this, tollBooth.ID.ToString(), _tollBoothService, _cameraService, _rampService, _trafficLightService);
                    editTollBooth.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Selektujte red prvo!");
            }
        }

        private void LoadData()
        {
            dgvTollBooths.Rows.Clear();
            var tollBooths = _tollBoothService.GetAll();

            // TODO 
            // izmeniti da ne bude fiksan tollstation, nego onaj iz fajla
            tollBooths.ForEach(o =>
            {
                var tollStation = _tollStationService.GetAll()[4];
                if (o.TollStationId == tollStation.ID)
                {
                    o.Attach(this);

                    int index = dgvTollBooths.Rows.Add();
                    dgvTollBooths.Rows[index].Tag = o;
                    var ramp = _rampService.GetById(o.RampId).IsWorking ? "ISPRAVNO" : "NEISPRAVNO";
                    var camera = _cameraService.GetById(o.CameraId).IsWorking ? "ISPRAVNO" : "NEISPRAVNO";
                    var trafficLight = _trafficLightService.GetById(o.TrafficLightId).IsWorking ? "ISPRAVNO" : "NEISPRAVNO";
                    dgvTollBooths.Rows[index].Cells["stationName"].Value = tollStation.Name;
                    dgvTollBooths.Rows[index].Cells["type"].Value = o.Type.ToString();
                    dgvTollBooths.Rows[index].Cells["ramp"].Value = ramp;
                    dgvTollBooths.Rows[index].Cells["camera"].Value = camera;
                    dgvTollBooths.Rows[index].Cells["trafficLight"].Value = trafficLight;
                }
            });
        }

        public void Update(IObservable observable)
        {
            LoadData();
        }
    }
}
