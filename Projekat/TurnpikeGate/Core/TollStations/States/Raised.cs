using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.TollStations.Model;

namespace TurnpikeGate.Core.TollStations.States
{
    internal class Raised : State
    {
        public Raised(Ramp ramp) : base(ramp)
        {
            
        }

        public override String Do()
        {
            ramp.ChangeState(new Lowering(ramp));
            return "Rampa se spusta!";
        }
    }
}
