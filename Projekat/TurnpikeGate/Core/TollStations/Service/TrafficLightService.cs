using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.TollStations.Model;
using TurnpikeGate.Core.TollStations.Repository;

namespace TurnpikeGate.Core.TollStations.Service
{
    public class TrafficLightService : ITrafficLightService
    {
        private readonly ITraficLightRepository _trafficLightRepository;

        public TrafficLightService(ITraficLightRepository trafficLightRepository)
        {
            _trafficLightRepository = trafficLightRepository;
        }

        public void Delete(string id)
        {
            _trafficLightRepository.Delete(ObjectId.Parse(id));

        }

        public List<TraficLight> GetAll()
        {
            return _trafficLightRepository.GetAll();
        }

        public TraficLight GetById(ObjectId id)
        {
            return _trafficLightRepository.GetById(id);
        }

        public void Insert(TraficLight trafficLightId)
        {
            _trafficLightRepository.Insert(trafficLightId);
        }

        public void Update(TraficLight entity)
        {
            _trafficLightRepository.Update(entity);
        }

    }
}
