using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.TollStations.Model
{
    public class Ramp
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }
        [BsonElement("toolBoothId")]
        public ObjectId ToolBoothId { get; set; }

        [BsonElement("isWorking")]
        public bool IsWorking { get; set; }

        public Ramp(ObjectId toolBoothId, bool isWorking = true)
        {
            ID = ObjectId.GenerateNewId();
            ToolBoothId = toolBoothId;
            IsWorking = isWorking;
        }
    }
}
