using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
