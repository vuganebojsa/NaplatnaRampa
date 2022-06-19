using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Data.TollStations.Model
{
    public class TraficLight
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }
        [BsonElement("toolBoothId")]
        public ObjectId ToolBoothId { get; set; }

        public TraficLight(ObjectId toolBoothId)
        {
            ID = ObjectId.GenerateNewId();
            ToolBoothId = toolBoothId;
        }
    }
}
