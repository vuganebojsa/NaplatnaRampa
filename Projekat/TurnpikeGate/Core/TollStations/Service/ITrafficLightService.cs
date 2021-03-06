using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Interfaces;
using TurnpikeGate.Core.TollStations.Model;

namespace TurnpikeGate.Core.TollStations.Service
{
    public interface ITrafficLightService : IService<TraficLight>
    {
        TraficLight GetByTollBoothId(ObjectId tollBoothId);
    }
}
