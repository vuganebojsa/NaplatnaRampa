using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Prices.Model;

namespace TurnpikeGate.Core.Prices.Service
{
    public interface IPriceListService
    {
        public List<PriceList> GetAll();
        public PriceList GetByDate(DateTime selectedDate);
    }
}
