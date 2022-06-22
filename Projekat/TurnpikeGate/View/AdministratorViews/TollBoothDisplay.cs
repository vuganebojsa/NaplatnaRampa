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
using TurnpikeGate.Core.TollStations.Service;

namespace TurnpikeGate.View.AdministratorViews
{
    public partial class TollBoothDisplay : Form, IObserver
    {
        private readonly ITollBoothService _tollBoothService;
        public TollBoothDisplay()
        {
            InitializeComponent();
            _tollBoothService = Globals.Container.Resolve<ITollBoothService>();
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

        private void TollBoothDisplay_Load(object sender, EventArgs e)
        {
            LoadData();
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
                dgvBooths.Rows[index].Cells["type"].Value = o.Type;
                dgvBooths.Rows[index].Cells["tollStationId"].Value = o.TollStationId;
                dgvBooths.Rows[index].Cells["rampId"].Value = o.RampId;
                dgvBooths.Rows[index].Cells["semaphoreId"].Value = o.TraficLightId;
                dgvBooths.Rows[index].Cells["cameraId"].Value = o.CameraId;
            });
        }
    }
}