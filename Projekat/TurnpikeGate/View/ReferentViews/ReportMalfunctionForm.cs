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
using TurnpikeGate.Core.TollStations.Model;
using TurnpikeGate.Core.TollStations.Service;

namespace TurnpikeGate.View.ReferentViews
{
    public partial class ReportMalfunctionForm : Form
    {
        private readonly ICameraService _cameraService;
        private Camera _camera;
        private readonly IRampService _rampService;
        private Ramp _ramp;
        private readonly ITrafficLightService _trafficLightService;
        private TraficLight _trafficLight;

        public ReportMalfunctionForm()
        {
            InitializeComponent();
            _cameraService = Globals.Container.Resolve<ICameraService>();
            _rampService = Globals.Container.Resolve<IRampService>();
            _trafficLightService = Globals.Container.Resolve<ITrafficLightService>();
            LoadDevices();
            LoadColors();
        }

        private void LoadColors()
        {
            if (_camera.IsWorking)
                lblCamera.ForeColor = System.Drawing.Color.SteelBlue;
            else 
            { 
                lblCamera.ForeColor = System.Drawing.Color.Maroon;
                btnReportCamera.Enabled = false;
            }
            if (_ramp.IsWorking)
                lblRamp.ForeColor = System.Drawing.Color.SteelBlue;
            else
            {
                lblRamp.ForeColor = System.Drawing.Color.Maroon;
                btnRamp.Enabled = false;
            }
            if (_trafficLight.IsWorking)
                lblTrafficLight.ForeColor = System.Drawing.Color.SteelBlue;
            else
            {
                lblTrafficLight.ForeColor = System.Drawing.Color.Maroon;
                btnReportTrafficLight.Enabled = false;
            }
        }

        private void LoadDevices()
        {
            _ramp = _rampService.GetByTollBoothId(StationInformation.TollBoothId);
            _camera = _cameraService.GetByTollBoothId(StationInformation.TollBoothId);
            _trafficLight = _trafficLightService.GetByTollBoothId(StationInformation.TollBoothId);
        }

        private void btnReportCamera_Click(object sender, EventArgs e)
        {
            _camera.IsWorking = false;
            _cameraService.Update(_camera);
            LoadColors();
        }

        private void btnReportTrafficLight_Click(object sender, EventArgs e)
        {
            _trafficLight.IsWorking = false;
            _trafficLightService.Update(_trafficLight);
            LoadColors();
        }

        private void btnRamp_Click(object sender, EventArgs e)
        {
            _ramp.IsWorking = false;
            _rampService.Update(_ramp);
            LoadColors();
        }

        private void ReportMalfunctionForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
