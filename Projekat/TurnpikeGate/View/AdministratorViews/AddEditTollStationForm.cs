
using System.ComponentModel;
using System.Data;
using System.Text;
using TurnpikeGate.Core.TollStations.Service;
using Autofac;
using MongoDB.Bson;
using TurnpikeGate.Core;
using TurnpikeGate.Core.Interfaces;
using TurnpikeGate.Core.Locations.Service;
using TurnpikeGate.Core.TollStations;

namespace TurnpikeGate.View.AdministratorViews
{
    public partial class AddEditTollStationForm : Form
    {
        private readonly ITollStationService _tollStationService;
        private readonly ILocationService _locationService;
        private readonly string _tollStationId;
        private readonly List<Location> _locations;
        private readonly IObserver _observer;

        public AddEditTollStationForm(IObserver observerForm, string tollStationId = "")
        {
            InitializeComponent();
            _tollStationService = Globals.Container.Resolve<ITollStationService>();
            _locationService = Globals.Container.Resolve<ILocationService>();
            _tollStationId = tollStationId;
            _locations = _locationService.GetAll();
            _observer = observerForm;
            FillLocationComboBox();
            if (_tollStationId != "")
            {
                SetValues();
                btnAccept.Text = "AZURIRAJ";
            }

        }

            private void FillLocationComboBox()
        {
            cbLocations.DataSource = _locations;
            cbLocations.DisplayMember = "name";
        }

        private void SetValues()
        {
            TollStation tollStation = _tollStationService.GetById(ObjectId.Parse(_tollStationId));
            tbAddress.Text = tollStation.Address;
            tbName.Text = tollStation.Name;

            cbLocations.Text = _locationService.GetById(tollStation.LocationId).Name;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (_tollStationId == "")
                InsertTollStation();
            else
                UpdateTollStation();

            this.Close();

        }

        private void InsertTollStation()
        {
            TollStation tollStation =
                _tollStationService.GetTollStation(tbAddress.Text, tbName.Text, ((Location)cbLocations.SelectedItem).ID.ToString());
            _tollStationService.Insert(tollStation);
            tollStation.Attach(_observer);
            tollStation.Notify();
            MessageBox.Show("Succesfully inserted a new Toll Station!");
        }

        private void UpdateTollStation()
        {
            TollStation tollStation = _tollStationService.GetById(ObjectId.Parse(_tollStationId));
            tollStation.Address = tbAddress.Text;
            tollStation.Name = tbName.Text;
            tollStation.LocationId = ((Location)cbLocations.SelectedItem).ID;
            _tollStationService.Update(tollStation);
            tollStation.Attach(_observer);
            tollStation.Notify();
            MessageBox.Show("Succesfully updated the Toll Station!");
        }
    }
}
