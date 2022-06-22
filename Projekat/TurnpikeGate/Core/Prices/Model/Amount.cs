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
        public double Total { get; set; }

        public Currency currency { get; set; }

        public Amount(double total, Currency currency)
        {
            Total = total;
            this.currency = currency;
        }
    }
}
