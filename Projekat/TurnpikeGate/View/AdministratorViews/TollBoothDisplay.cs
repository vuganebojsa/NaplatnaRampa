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

        public TollBoothDisplay()
        {
            InitializeComponent();
            _tollBoothService = Globals.Container.Resolve<ITollBoothService>();
            _tollStationService = Globals.Container.Resolve<ITollStationService>();
            LoadData();
        }

        public void Update(IObservable observable)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTollBoothForm addForm = new AddTollBoothForm(this);
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
                dgvBooths.Rows[index].Cells["type"].Value = o.Type.ToString();
                dgvBooths.Rows[index].Cells["tollStationId"].Value = _tollStationService.GetById(o.TollStationId).Name;
                dgvBooths.Rows[index].Cells["rampId"].Value = o.RampId;
                dgvBooths.Rows[index].Cells["trafficLightId"].Value = o.TrafficLightId;
                dgvBooths.Rows[index].Cells["cameraId"].Value = o.CameraId;
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
                    AddTollBoothForm aeForm = new AddTollBoothForm(this, tollBooth.ID.ToString());
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