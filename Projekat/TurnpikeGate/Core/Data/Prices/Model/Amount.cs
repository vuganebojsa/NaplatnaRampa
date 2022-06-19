﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Data.Prices.Model
{
    public enum Currency
    {
        RSD,
        EUR
    }

    public class Amount
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }

        [BsonElement("total")]
        public double Total { get; set; }

        [BsonElement("currency")]
        public Currency currency { get; set; }

        public Amount(ObjectId iD, double total, Currency currency)
        {
            ID = iD;
            Total = total;
            this.currency = currency;
        }
    }
}
