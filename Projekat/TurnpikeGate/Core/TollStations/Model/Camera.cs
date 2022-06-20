using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.TollStations.Model
{
    public class Camera
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }
        [BsonElement("toolBoothId")]
        public ObjectId ToolBoothId { get; set; }

        public Camera(ObjectId toolBoothId)
        {
            ID = ObjectId.GenerateNewId();
            ToolBoothId = toolBoothId;
        }
    }
}
