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
using MongoDB.Bson;
using TurnpikeGate.Core.Interfaces;
using TurnpikeGate.Core.TollStations.Model;
using TurnpikeGate.Core.TollStations.Service;

namespace TurnpikeGate.View.StationManagerViews
{
    public partial class EditTollBooth : Form
    {
        private IObserver _observer;
        private readonly ITollBoothService _tollBoothService;
        private readonly ICameraService _cameraService;
        private readonly IRampService _rampService;
        private readonly ITrafficLightService _trafficLightService;
        private readonly string _tollBoothId;
        public EditTollBooth(IObserver observer, string tollBoothId, ITollBoothService tollBoothService, ICameraService cameraService, IRampService rampService, ITrafficLightService trafficLightService)
        {
            InitializeComponent();
            _tollBoothService = tollBoothService;
            _cameraService = cameraService;
            _rampService = rampService;
            _trafficLightService = trafficLightService;
            _observer = observer;
            _tollBoothId = tollBoothId;
            SetSelectRadioButtons();

        }

        private void SetSelectRadioButtons()
        {
            TollBooth tb = _tollBoothService.GetById(ObjectId.Parse(_tollBoothId));

            rbRampTrue.Checked = _rampService.GetById(tb.RampId).IsWorking ? true : false;
            rbCameraTrue.Checked = _cameraService.GetById(tb.CameraId).IsWorking ? true : false;
            rbTrafficLightTrue.Checked = _trafficLightService.GetById(tb.TrafficLightId).IsWorking ? true : false;

            rbRampFalse.Checked = _rampService.GetById(tb.RampId).IsWorking ? false : true;
            rbCameraFalse.Checked = _cameraService.GetById(tb.CameraId).IsWorking ? false : true;
            rbTrafficLightFalse.Checked = _trafficLightService.GetById(tb.TrafficLightId).IsWorking ? false : true;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            TollBooth tollStation = _tollBoothService.GetById(ObjectId.Parse(_tollBoothId));

            Ramp ramp = _rampService.GetById(tollStation.RampId);
            ramp.IsWorking = rbRampTrue.Checked;

            Camera camera = _cameraService.GetById(tollStation.CameraId);
            camera.IsWorking = rbCameraTrue.Checked;

            TraficLight light = _trafficLightService.GetById(tollStation.TrafficLightId);
            light.IsWorking = rbTrafficLightTrue.Checked;

            _tollBoothService.Update(tollStation);
            _rampService.Update(ramp);
            _cameraService.Update(camera);
            _trafficLightService.Update(light);
            tollStation.Attach(_observer);
            tollStation.Notify();
            MessageBox.Show("Uspesno ste izmenili naplatno mesto!");
            this.Close();
        }
    }
}
