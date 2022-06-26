using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Prices.Model;

namespace TurnpikeGate.Core.Prices.Service
{
    public interface IRoadSectionService
    {
        public RoadSection GetById(ObjectId roadSectionId);
        public RoadSection GetByLocations(ObjectId iD1, ObjectId iD2);
    }
}
