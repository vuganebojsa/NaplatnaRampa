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
using TurnpikeGate.Core.Interfaces;
using TurnpikeGate.Core.TollStations;
using TurnpikeGate.Core.TollStations.Model;
using TurnpikeGate.Core.TollStations.Service;

namespace TurnpikeGate.View.AdministratorViews
{
    public partial class TollBoothDisplay : Form, IObserver
    {
        private readonly ITollBoothService _tollBoothService;
        private readonly ITollStationService _tollStationService;
        private readonly ICameraService _cameraService;
        private readonly IRampService _rampService;
        private readonly ITrafficLightService _trafficLightService;
        public TollBoothDisplay()
        {
            InitializeComponent();
            _tollBoothService = Globals.Container.Resolve<ITollBoothService>();
            _tollStationService = Globals.Container.Resolve<ITollStationService>();
            _cameraService = Globals.Container.Resolve<ICameraService>();
            _rampService = Globals.Container.Resolve<IRampService>();
            _trafficLightService = Globals.Container.Resolve<ITrafficLightService>();
            LoadData();
        }

        public void Update(IObservable observable)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTollBoothForm addForm = new AddTollBoothForm(this, "", _cameraService, _trafficLightService, _rampService);
            addForm.ShowDialog();
        }


        private void LoadData()
        {
            dgvBooths.Rows.Clear();
            var tollBooths = _tollBoothService.GetAll();

            tollBooths.ForEach(o =>
            {
                o.Attach(this);

                int index = dgvBooths.Rows.Add();
                dgvBooths.Rows[index].Tag = o;
                var ramp = _rampService.GetById(o.RampId).IsWorking ? "ISPRAVNO" : "NEISPRAVNO";
                var camera = _cameraService.GetById(o.CameraId).IsWorking ? "ISPRAVNO" : "NEISPRAVNO";
                var trafficLight = _trafficLightService.GetById(o.TrafficLightId).IsWorking ? "ISPRAVNO" : "NEISPRAVNO";

                dgvBooths.Rows[index].Cells["type"].Value = o.Type.ToString();
                dgvBooths.Rows[index].Cells["tollStationId"].Value = _tollStationService.GetById(o.TollStationId).Name;
                dgvBooths.Rows[index].Cells["rampId"].Value = ramp;
                dgvBooths.Rows[index].Cells["trafficLightId"].Value = trafficLight;
                dgvBooths.Rows[index].Cells["cameraId"].Value = camera;
            });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Da li ste sigurni?", "Obrisati?", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                TollBooth tb = (TollBooth)dgvBooths.SelectedRows[0].Tag;

                if (tb != null)
                {
                    _tollBoothService.Delete(tb.ID.ToString());
                    tb.Notify();
                    MessageBox.Show("Uspesno ste obrisali naplatno mesto.");
                }
                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBooths.SelectedRows.Count > 0)
            {
                TollBooth tollBooth = (TollBooth)dgvBooths.SelectedRows[0].Tag;
                if (tollBooth != null)
                {
                    AddTollBoothForm aeForm = new AddTollBoothForm(this, tollBooth.ID.ToString(), _cameraService, _trafficLightService, _rampService);
                    aeForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Selektujte red prvo!");
            }
        }
    }
}