using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.TollStations.Model;

namespace TurnpikeGate.Core.TollStations.States
{
    internal class Lowered : State
    {
        public Lowered(Ramp ramp) : base(ramp)
        {
        }

        public override String Do()
        {
            throw new NotImplementedException();
        }
    }
}
