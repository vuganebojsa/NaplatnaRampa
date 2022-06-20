using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Interfaces
{
    public interface IObservable
    {
        void Attach(IObserver observer);
        void Notify();

    }
}
