using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.TollStations.Model;

namespace TurnpikeGate.Core.TollStations.States
{
    internal class Raising : State
    {
        public Raising(Ramp ramp) : base(ramp)
        {
            Do();
        }

        public override void Do()
        {
            Console.WriteLine("Podize se");
            System.Threading.Thread.Sleep(1000);
            ramp.ChangeState(new Raised(ramp));
        }
    }
}
