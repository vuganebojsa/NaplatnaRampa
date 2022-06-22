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

        public List<TraficLight> GetAll()
        {
            return _trafficLightRepository.GetAll();
        }

        public void Insert(TraficLight trafficLight)
        {
            _trafficLightRepository.Insert(trafficLight);
        }

    }
}
