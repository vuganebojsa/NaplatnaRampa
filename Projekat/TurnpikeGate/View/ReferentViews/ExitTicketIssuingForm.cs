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
using TurnpikeGate.Core.TollStations.States;
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
        int tickCount = 0;

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
            RaiseRamp();
            
        }

        public void RaiseRamp( )
        {
            
            ramp.ChangeState(new Raising(ramp));
            lbRamp.Text = "Rampa se dize";
            InitRampStateTimer();

            
           

        }

        private void rampTimer_Tick(object sender, EventArgs e)
        {
            if (tickCount < 3)
            {
                lbRamp.Text = ramp.State.Do();
                tickCount++;
            }
            else 
            {
                rampTimer.Enabled = false;
                tickCount = 0;
            }
        }

        private void InitRampStateTimer() 
        {
            rampTimer = new System.Windows.Forms.Timer();
            rampTimer.Tick += new EventHandler(rampTimer_Tick);
            rampTimer.Interval = 3000;
            rampTimer.Start();
        }
    }
}
