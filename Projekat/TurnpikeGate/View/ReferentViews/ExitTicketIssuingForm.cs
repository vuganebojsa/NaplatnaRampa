using Autofac;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurnpikeGate.Core.TollStations.Model;
using TurnpikeGate.Core.TollStations.Service;
using TurnpikeGate.Core.Turnpike.Service;
using TurnpikeGate.Core.Users.Model;

namespace TurnpikeGate.View.ReferentViews
{
    public partial class ExitTicketIssuingForm : Form
    {
        IPhysicalTollPaymentService _physicalTollPaymentService;
        Referent referent;
        IRampService _rampService;
        ITollBoothService _boothService;
        TollBooth tollBooth;
        Ramp ramp;

        public ExitTicketIssuingForm()
        {
            InitializeComponent();
            _rampService = Globals.Container.Resolve<IRampService>();
            _physicalTollPaymentService = Globals.Container.Resolve<IPhysicalTollPaymentService>();
            _boothService = Globals.Container.Resolve<ITollBoothService>();
            tollBooth = _boothService.GetById(ObjectId.Parse("62b6cce6c230627bbaa11635"));
            ramp = _rampService.GetById(tollBooth.RampId);
        }

        private void ExitTicketIssuingForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRaiseRamp_Click(object sender, EventArgs e)
        {
            _rampService.RaiseRamp(ramp);
        }
    }
}
