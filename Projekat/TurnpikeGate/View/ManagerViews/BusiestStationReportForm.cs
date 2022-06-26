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
using TurnpikeGate.Core.TollStations;
using TurnpikeGate.Core.TollStations.Service;
using TurnpikeGate.Core.Turnpike.Model;
using TurnpikeGate.Core.Turnpike.Service;

namespace TurnpikeGate.View.MainViews
{
    public partial class BusiestStationReportForm : Form
    {
        private readonly IPriceListEntryService _priceListEntryService;
        private readonly IPhysicalTollPaymentService _physicalTollPaymentService;
        private readonly ITollStationService _tollStationService;
        private readonly IRoadSectionService _roadSectionService;

        public BusiestStationReportForm()
        {
            InitializeComponent();
            _tollStationService = Globals.Container.Resolve<ITollStationService>();
            _physicalTollPaymentService = Globals.Container.Resolve<IPhysicalTollPaymentService>();
            _priceListEntryService = Globals.Container.Resolve<IPriceListEntryService>();
            _roadSectionService = Globals.Container.Resolve<IRoadSectionService>();
            FillPriceListComboBox();
        }

        public void FillPriceListComboBox()
        {
            List<String> options = new List<String>();
            options.Add("Poselednjih nedelju dana");
            options.Add("Poselednjih mesec dana");
            options.Add("Poselednjih godinu dana");
            cbPeriod.ValueMember = null;
            cbPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPeriod.DisplayMember = "Period";
            cbPeriod.DataSource = options;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (TextWriter tw = new StreamWriter(DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Minute + ".txt"))
            {
                tw.Write($"----------------IZVESTAJ STANICE----------------");
                tw.Write($"{"\nNaziv stanice: "}");
                tw.Write($"{ lblName.Text}");
                tw.Write($"{"\nAdresa: "}");
                tw.Write($"{ lblPlace.Text}");
                tw.Write($"{"\nUkupni prihodi u evrima: "}");
                tw.Write($"{ lblIncomeRsd.Text}");
                tw.Write($"{"\nUkupni prihodi u dinarima: "}");
                tw.Write($"{ lblIncomeEur.Text}");
                tw.Write($"{"\nUkupno prodatih tiketa: "}");
                tw.Write($"{ lblTickets.Text}");
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            String selectedOption = (String)cbPeriod.SelectedValue;
            DateTime untilDate = DateTime.Now;
            if (selectedOption == "Poselednjih nedelju dana")
                untilDate = DateTime.Now.AddDays(-7);
            else if (selectedOption == "Poselednjih mesec dana")
                untilDate = DateTime.Now.AddMonths(-1);
            else
                untilDate = DateTime.Now.AddYears(-1);
            List<PhysicalTollPayment> tickets = _physicalTollPaymentService.GetUntilDate(untilDate);
            List<TollStation> stations = _tollStationService.GetAll();
            double totalRSD = 0;
            double totalEUR = 0;
            int mostVisitedTimes = 0;
            TollStation mostVisitedStation = null;
            stations.ForEach(s =>
            {
                double incomeRSD = 0;
                double incomeEUR = 0;
                int timesVisited = 0;
                tickets.ForEach(t =>
                {
                    PriceListEntry entry = _priceListEntryService.GetById(t.PriceListEntryId);
                    if (_roadSectionService.GetById(entry.RoadSectionId).DestinationStationId == s.ID)
                    {
                        if (entry.Amount.Currency == Currency.RSD)
                            incomeRSD += entry.Amount.Total;
                        else
                            incomeEUR += entry.Amount.Total;
                        timesVisited++;
                    }
                });
                if(timesVisited >= mostVisitedTimes)
                {
                    mostVisitedTimes = timesVisited;
                    totalEUR = incomeEUR;
                    totalRSD = incomeRSD;
                    mostVisitedStation = s;
                }
            });
            lblIncomeEur.Text = totalEUR + " (EUR)";
            lblIncomeRsd.Text = totalRSD + " (RSD)";
            lblName.Text = mostVisitedStation.Name;
            lblPlace.Text = mostVisitedStation.Address;
            lblTickets.Text = mostVisitedTimes + " tiketa";
        }
    }
}
