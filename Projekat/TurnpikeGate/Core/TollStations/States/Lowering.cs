using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.TollStations.Model;

namespace TurnpikeGate.Core.TollStations.States
{
    internal class Lowering : State
    {
        public Lowering(Ramp ramp) : base(ramp)
        {
        }

        public override void Do()
        {
            throw new NotImplementedException();
        }
    }
}
