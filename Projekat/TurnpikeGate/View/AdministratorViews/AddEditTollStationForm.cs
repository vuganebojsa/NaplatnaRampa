using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurnpikeGate.Core.TollStations.Service;
using Autofac;

namespace TurnpikeGate.View.AdministratorViews
{
    public partial class AddEditTollStationForm : Form
    {
        private ITollStationService _tollStationService;

        public AddEditTollStationForm()
        {
            InitializeComponent();
            _tollStationService = Globals.Container.Resolve<ITollStationService>();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

      

    }
}
