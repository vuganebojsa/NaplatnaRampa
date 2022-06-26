using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.TollStations.Model;

namespace TurnpikeGate.Core.TollStations.States
{
    public abstract class State
    {
        public Ramp ramp;
        public State(Ramp ramp) 
        { 
            this.ramp = ramp;
        }
        public abstract String Do();
    }
}
