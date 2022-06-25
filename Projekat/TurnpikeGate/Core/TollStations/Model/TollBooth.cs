using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Interfaces;
using TurnpikeGate.View.AdministratorViews;

namespace TurnpikeGate.Core.TollStations.Model
{
    public enum TypeOfPayment
    {
        ELECTRONIC, PHYSICAL
    }
    public class TollBooth : IObservable
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }
        [BsonElement("type")]
        public TypeOfPayment Type { get; set; }

        // Foreign keys
        [BsonElement("tollStationId")]
        public ObjectId TollStationId { get; set; }
        [BsonElement("rampId")]
        public ObjectId RampId { get; set; }
        [BsonElement("semaphoreId")]
        public ObjectId TrafficLightId { get; set; }
        [BsonElement("cameraId")]
        public ObjectId CameraId { get; set; }
        private List<IObserver> _observers = new List<IObserver>();

        public TollBooth(TypeOfPayment type, ObjectId tollStationId, ObjectId rampId, ObjectId trafficLightId, ObjectId cameraId)
        {
            ID = ObjectId.GenerateNewId();
            Type = type;
            TollStationId = tollStationId;
            RampId = rampId;
            CameraId = cameraId;
            TrafficLightId = trafficLightId;
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
