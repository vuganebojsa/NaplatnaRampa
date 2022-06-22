using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Prices.Model
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
        public Currency Currency { get; set; }

        public Amount(double total, Currency currency)
        {
            ID = ObjectId.GenerateNewId();
            Total = total;
            this.Currency = currency;
        }
    }
}
