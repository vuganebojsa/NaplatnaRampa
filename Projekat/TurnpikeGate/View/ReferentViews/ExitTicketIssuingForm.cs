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
using TurnpikeGate.Core.Turnpike.Service;

namespace TurnpikeGate.View.ReferentViews
{
    public partial class ExitTicketIssuingForm : Form
    {
        IPhysicalTollPaymentService _physicalTollPaymentService;

        public ExitTicketIssuingForm()
        {
            InitializeComponent();
            _physicalTollPaymentService = Globals.Container.Resolve<IPhysicalTollPaymentService>();
        }

        private void ExitTicketIssuingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
