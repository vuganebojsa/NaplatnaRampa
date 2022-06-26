using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TurnpikeGate.Core.Prices.Model
{
    public class RoadSection
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }

        // Foreign keys
        [BsonElement("departureStationId")]
        public ObjectId DepartureStationId { get; set; }

        [BsonElement("destinationStationId")]
        public ObjectId DestinationStationId { get; set; }

        public RoadSection(ObjectId departureStationId, ObjectId destinationStationId)
        {
            ID = ObjectId.GenerateNewId();
            DepartureStationId = departureStationId;
            DestinationStationId = destinationStationId;
        }
    }
}
