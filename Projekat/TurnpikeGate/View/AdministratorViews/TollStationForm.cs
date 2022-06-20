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
using Autofac;
using MongoDB.Bson;
using TurnpikeGate.Core.TollStations;

namespace TurnpikeGate.View.AdministratorViews
{
    public partial class TollStationForm : Form, IObserver
    {
        private ITollStationService _tollStationService;

        public TollStationForm()
        {
            InitializeComponent();
            _tollStationService = Globals.Container.Resolve<ITollStationService>();

           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TollStation tollStation = (TollStation)dgvTollStation.SelectedRows[0].Tag;
           
            _tollStationService.Delete(tollStation.ID.ToString());
            tollStation.Notify();
            

        }

        private void TollStationForm_Load(object sender, EventArgs e)
        {
            LoadTableData();
        }

        private void LoadTableData()
        {
            dgvTollStation.Rows.Clear();
            var tollStations = _tollStationService.GetAll();
            tollStations.ForEach(o =>
            {
                o.Attach(this);

                int index = dgvTollStation.Rows.Add();
                dgvTollStation.Rows[index].Tag = o;
                dgvTollStation.Rows[index].Cells["name"].Value = o.Name;
                dgvTollStation.Rows[index].Cells["address"].Value = o.Address;
                dgvTollStation.Rows[index].Cells["location"].Value = o.LocationId;

            });
        }

        public void Update(IObservable observable)
        {
            LoadTableData();
        }
    }
}
