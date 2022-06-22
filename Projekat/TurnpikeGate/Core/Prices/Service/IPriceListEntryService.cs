using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Interfaces;
using TurnpikeGate.Core.Prices.Model;

namespace TurnpikeGate.Core.Prices.Service
{
    interface IPriceListEntryService:IService<PriceListEntry>
    {
      public PriceListEntry GetById(ObjectId id);
    }
}
