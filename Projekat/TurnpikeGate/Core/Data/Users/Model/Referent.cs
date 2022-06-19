using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Data.Users.Model
{
    public class Referent
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }

        // Foreign keys
        [BsonElement("userId")]
        public ObjectId UserId { get; set; }

        [BsonElement("tollStationId")]
        public ObjectId TollStationId { get; set; }


        public Referent(ObjectId userId, ObjectId tollStationId)
        {
            ID = ObjectId.GenerateNewId();
            UserId = userId;
            TollStationId = tollStationId;
        }
    }
}
