using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Prices.Model;

namespace TurnpikeGate.Core.Tags.Model
{
    public class ElectronicTag
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("type")]
        public VehicleType Type { get; set; }

        [BsonElement("amount")]
        public Amount Amount { get; set; }

        public ElectronicTag(string name,string lastName,VehicleType type,Amount amount)
        {
            ID = ObjectId.GenerateNewId();
            Name = name;
            LastName = lastName;
            Type = type;
            Amount = amount;
        }
    }
}
