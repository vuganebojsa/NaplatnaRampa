using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Data.TollStations.Model
{
    public class Semaphore
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }
        [BsonElement("toolBoothId")]
        public ObjectId ToolBoothId { get; set; }

        public Semaphore(ObjectId toolBoothId)
        {
            ToolBoothId = toolBoothId;
        }
    }
}
