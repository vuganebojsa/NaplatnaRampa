using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using TurnpikeGate.Core.Interfaces;

namespace TurnpikeGate.Core.TollStations
{
    public class TollStation : IObservable
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

        [BsonElement("tollBoothIds")]
        public List<ObjectId>? TollBoothIds { get; set; }

        private List<IObserver> _observers = new List<IObserver>();

        public TollStation(string address, string name, ObjectId stationManagerId, List<ObjectId> referentIds, ObjectId locationId, List<ObjectId> tollBoothIds)
        {
            ID = ObjectId.GenerateNewId();
            Address = address;
            Name = name;
            StationManagerId = stationManagerId;
            ReferentIds = referentIds;
            LocationId = locationId;
            TollBoothIds = tollBoothIds;
        }

        public void Attach(IObserver observer)
        {
            if (_observers == null) _observers = new List<IObserver>();
            _observers.Add(observer);
        }

        public void Notify()
        {
            _observers.ForEach(o =>
            {
                o.Update(this);
            });
        }
    }
}
