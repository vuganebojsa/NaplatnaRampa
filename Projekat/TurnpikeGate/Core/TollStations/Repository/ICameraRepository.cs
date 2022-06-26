using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.TollStations.Model;
using TurnpikeGate.Core.Interfaces;
using MongoDB.Bson;

namespace TurnpikeGate.Core.TollStations.Repository
{
    public interface ICameraRepository : IRepository<Camera>
    {
        Camera GetByTollBoothId(ObjectId tollBoothId);
    }
}
