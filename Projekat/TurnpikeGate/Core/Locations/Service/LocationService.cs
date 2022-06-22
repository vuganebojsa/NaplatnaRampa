using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using TurnpikeGate.Core.Locations.Repository;
using TurnpikeGate.Core.TollStations;

namespace TurnpikeGate.Core.Locations.Service
{
    class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public void Delete(string id)
        {
            _locationRepository.Delete(ObjectId.Parse(id));

        }

        public List<Location> GetAll()
        {
            return _locationRepository.GetAll();
        }

        public Location GetById(ObjectId id)
        {
            return _locationRepository.GetById(id);
        }

        public void Insert(Location tollStation)
        {
            _locationRepository.Insert(tollStation);
        }

        public void Update(Location entity)
        {
            _locationRepository.Update(entity);
        }
    }
}
