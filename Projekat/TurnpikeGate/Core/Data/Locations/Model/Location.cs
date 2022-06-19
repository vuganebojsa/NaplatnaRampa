using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TurnpikeGate.Core.Data
{
    public class Location
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }

        [BsonElement("pptx")]
        public string PPTX { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }


        public Location(string pptx, string name)
        {
            ID = ObjectId.GenerateNewId();
            PPTX = pptx;
            Name = name;
        }
    }
}
