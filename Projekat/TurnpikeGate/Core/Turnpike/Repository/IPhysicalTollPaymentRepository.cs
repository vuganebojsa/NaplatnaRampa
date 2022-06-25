using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Turnpike.Model;
using TurnpikeGate.Core.Interfaces;

namespace TurnpikeGate.Core.Turnpike.Repository
{
    public interface IPhysicalTollPaymentRepository : IRepository<PhysicalTollPayment>
    {
        public List<PhysicalTollPayment> GetPending();
    }
}
