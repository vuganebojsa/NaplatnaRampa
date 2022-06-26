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
using TurnpikeGate.Core.Prices.Model;
using TurnpikeGate.Core.Prices.Service;
using TurnpikeGate.Core.TollStations.Service;

namespace TurnpikeGate.View.AdministratorViews
{
    public partial class PriceListsDisplayForm : Form
    {
        private readonly IPriceListService _priceListService;
        private readonly IPriceListEntryService _priceListEntryService;
        private readonly IRoadSectionService _roadSectionService;
        private readonly ITollStationService _tollStationService;

        public PriceListsDisplayForm()
        {
            InitializeComponent();
            _priceListService = Globals.Container.Resolve<IPriceListService>();
            _priceListEntryService = Globals.Container.Resolve<IPriceListEntryService>();
            _roadSectionService = Globals.Container.Resolve<IRoadSectionService>();
            _tollStationService = Globals.Container.Resolve<ITollStationService>();
            FillPriceListComboBox();
        }

        public void FillPriceListComboBox()
        {
            var priceLists = _priceListService.GetAll();
            List<DateTime> dates = new List<DateTime>();
            priceLists.ForEach(p =>
            {
                dates.Add(p.ActivationDate);
            });
            cbPriceList.ValueMember = null;
            cbPriceList.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPriceList.DisplayMember = "Cenovnik";
            cbPriceList.DataSource = dates;
        }

        private void PriceListsDisplayForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvPriceList.Rows.Clear();
            DateTime selectedDate = (DateTime)cbPriceList.SelectedValue;
            PriceList priceList = _priceListService.GetByDate(selectedDate);
            priceList.PriceListEntries.ForEach(u =>
            {
                int index = dgvPriceList.Rows.Add();
                PriceListEntry entry = _priceListEntryService.GetById(u);
                dgvPriceList.Rows[index].Cells["vehicleType"].Value = entry.VehicleType;
                dgvPriceList.Rows[index].Cells["total"].Value = entry.Amount.Total;
                dgvPriceList.Rows[index].Cells["currency"].Value = entry.Amount.Currency;
                dgvPriceList.Rows[index].Cells["departure"].Value = _tollStationService.GetById(_roadSectionService.GetById(entry.RoadSectionId).DepartureStationId).Name;
                dgvPriceList.Rows[index].Cells["destination"].Value = _tollStationService.GetById(_roadSectionService.GetById(entry.RoadSectionId).DestinationStationId).Name;
        });
        }
    }
}
