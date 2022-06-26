using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Prices.Model;
using TurnpikeGate.Core.Interfaces;

namespace TurnpikeGate.Core.Prices.Repository
{
    public interface IPriceListRepository : IRepository<PriceList>
    {
        public PriceList GetByDate(DateTime selectedDate);
        public PriceList GetActive();
    }
}
