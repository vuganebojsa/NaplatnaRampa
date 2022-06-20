using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TurnpikeGate.Core.Users.Model
{
    public class StationManager
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }

        // Foreign keys
        [BsonElement("userId")]
        public ObjectId UserId { get; set; }

        [BsonElement("tollStationId")]
        public ObjectId TollStationId { get; set; }


        public StationManager(ObjectId userId, ObjectId tollStationId)
        {
            ID = ObjectId.GenerateNewId();
            UserId = userId;
            TollStationId = tollStationId;
        }
    }
}
