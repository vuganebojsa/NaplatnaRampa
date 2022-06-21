﻿using MongoDB.Bson;
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

        // Foreign keys
        [BsonElement("amountId")]
        public ObjectId AmountId { get; set; }

        [BsonElement("roadSectionId")]
        public ObjectId RoadSectionId { get; set; }

        public PriceListEntry(VehicleType vehicleType, ObjectId amountId, ObjectId roadSectionId)
        {
            ID = ObjectId.GenerateNewId();
            VehicleType = vehicleType;
            AmountId = amountId;
            RoadSectionId = roadSectionId;
        }
    }
}
