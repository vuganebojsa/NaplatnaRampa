using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Prices.Model;
using TurnpikeGate.Core.Interfaces;
using MongoDB.Bson;

namespace TurnpikeGate.Core.Prices.Repository
{
    public interface IRoadSectionRepository : IRepository<RoadSection>
    {
        RoadSection GetByLocations(ObjectId entranceStation, ObjectId exitStation);
    }
}
