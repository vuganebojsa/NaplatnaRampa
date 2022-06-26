using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TurnpikeGate.Core.Prices.Model
{
    public class PriceList
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }

        [BsonElement("activationDate")]
        public DateTime ActivationDate { get; set;}

        // Foreign keys
        [BsonElement("priceListEntries")]
        public List<ObjectId>? PriceListEntries { get; set; }

        public PriceList(DateTime activationDate, List<ObjectId>? priceListEntries)
        {
            ID = ObjectId.GenerateNewId();
            ActivationDate = activationDate;
            PriceListEntries = priceListEntries;
        }
    }
}
