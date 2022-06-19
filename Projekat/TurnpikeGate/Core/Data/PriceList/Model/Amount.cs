using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Data.PriceList
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
    }
}
