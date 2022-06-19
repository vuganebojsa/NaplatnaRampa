using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Data.Turnpike.Model
{
    public abstract class TollPayment
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }

        [BsonElement("registrationPlate")]
        public string RegistrationPlate { get; set; }

        [BsonElement("entranceTime")]
        public DateTime EntranceTime { get; set; }

        [BsonElement("exitTime")]
        public DateTime ExitTime { get; set; }

        // Foreign key
        [BsonElement("entranceStation")]
        public ObjectId EntranceStationId { get; set; }

        [BsonElement("priceListEntry")]
        public ObjectId PriceListEntryId { get; set; }


    }
}
