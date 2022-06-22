using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Prices.Model
{
    public enum VehicleType
    {
        MOTOCYCLE,
        AUTOMOBILE,
        TRUCK, 
        BUS,
        MINIVAN,
        CAR_WITH_TRAILER
    }

    public class PriceListEntry
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }

        [BsonElement("vehicleType")]
        public VehicleType VehicleType { get; set; }

        public Amount Amount { get; set; }

        [BsonElement("roadSectionId")]
        public ObjectId RoadSectionId { get; set; }

        public PriceListEntry(VehicleType vehicleType, Amount amount, ObjectId roadSectionId)
        {
            ID = ObjectId.GenerateNewId();
            VehicleType = vehicleType;
            Amount = amount;
            RoadSectionId = roadSectionId;
        }
    }
}
