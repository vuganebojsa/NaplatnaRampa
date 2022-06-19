﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Data.Prices.Model
{
    public class PriceList
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }

        [BsonElement("activationDate")]
        public DateTime ActivationDate { get; set;}

        // Foreign keys
        [BsonElement("priceListEntries")]
        public List<PriceListEntry>? PriceListEntries { get; set; }

        public PriceList(ObjectId iD, DateTime activationDate, List<PriceListEntry>? priceListEntries)
        {
            ID = iD;
            ActivationDate = activationDate;
            PriceListEntries = priceListEntries;
        }
    }
}
