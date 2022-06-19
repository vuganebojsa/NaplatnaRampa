using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Data.Prices.Model
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
    }
}
