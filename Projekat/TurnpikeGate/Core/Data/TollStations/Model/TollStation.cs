using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Data.TollStations
{
    public class TollStation
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        // Foreign keys
        [BsonElement("stationManagerId")]
        public ObjectId? StationManagerId { get; set; }

        [BsonElement("referentIds")]
        public List<ObjectId>? ReferentIds { get; set; }

        [BsonElement("locationId")]
        public ObjectId LocationId { get; set; }


        public TollStation(string address, string name, ObjectId stationManagerId, List<ObjectId> referentIds, ObjectId locationId)
        {
            ID = ObjectId.GenerateNewId();
            Address = address;
            Name = name;
            StationManagerId = stationManagerId;
            ReferentIds = referentIds;
            LocationId = locationId;
        }
    }
}
