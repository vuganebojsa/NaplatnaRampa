using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Turnpike.Model;
using TurnpikeGate.Core.Turnpike.Repository;
using TurnpikeGate.View.ReferentViews;

namespace TurnpikeGate.Core.Simulation
{
    public class ExitSimulation
    {
        IPhysicalTollPaymentRepository _physicalTollPaymentRepository;
        ExitTicketIssuingForm _exitTicketIssuingForm;
        private List<System.Threading.Timer> _timers;

        public ExitSimulation()
        {
            _physicalTollPaymentRepository = Globals.Container.Resolve<IPhysicalTollPaymentRepository>();
        }

        
        
    }
}
