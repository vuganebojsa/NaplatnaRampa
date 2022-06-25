using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [BsonElement("mileage")]
        public double Mileage { get; set; }

        public RoadSection(ObjectId departureStationId, ObjectId destinationStationId, double mileage)
        {
            ID = ObjectId.GenerateNewId();
            DepartureStationId = departureStationId;
            DestinationStationId = destinationStationId;
            Mileage = mileage;
        }
    }
}
