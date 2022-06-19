using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Data.Prices.Model
{
    public enum VehicleType
    {
        MOTOCYCLE,
        AUTOMOBILE,
        TRUCK
    }

    public class PriceListEntry
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }

        [BsonElement("vehicleType")]
        public VehicleType VehicleType { get; set; }

        // Foreign keys
        [BsonElement("amountId")]
        public ObjectId AmountId { get; set; }

        [BsonElement("roadSectionId")]
        public ObjectId RoadSectionId { get; set; }
    }
}
