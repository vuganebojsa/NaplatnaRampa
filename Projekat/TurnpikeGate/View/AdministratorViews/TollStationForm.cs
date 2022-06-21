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
using TurnpikeGate.Core.Locations.Repository;
using TurnpikeGate.Core.Locations.Service;
using TurnpikeGate.Core.TollStations;

namespace TurnpikeGate.View.AdministratorViews
{
    public partial class TollStationForm : Form, IObserver
    {
        private readonly ITollStationService _tollStationService;
        private readonly ILocationService _locationService;

        public TollStationForm()
        {
            InitializeComponent();
            _tollStationService = Globals.Container.Resolve<ITollStationService>();
            _locationService = Globals.Container.Resolve<ILocationService>();



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditTollStationForm aeForm = new AddEditTollStationForm(this);
            aeForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTollStation.SelectedRows.Count > 0)
            {
                TollStation tollStation = (TollStation)dgvTollStation.SelectedRows[0].Tag;
                if (tollStation != null)
                {
                    AddEditTollStationForm aeForm = new AddEditTollStationForm(this, tollStation.ID.ToString());
                    aeForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Selektujte red prvo!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTollStation.SelectedRows.Count > 0)
            {
                var choice = MessageBox.Show("Da li ste sigurni?", "Obrisite?", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    TollStation tollStation = (TollStation)dgvTollStation.SelectedRows[0].Tag;

                    if (tollStation != null)
                    {
                        _tollStationService.Delete(tollStation.ID.ToString());
                        tollStation.Notify();
                    }
                }
            }
            else
                MessageBox.Show("Nije izabran nijedan red!");
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
                dgvTollStation.Rows[index].Cells["location"].Value = _locationService.GetById(o.LocationId).Name;

            });
        }

        public void Update(IObservable observable)
        {
            LoadTableData();
        }
    }
}
