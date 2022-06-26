using MongoDB.Bson;
using TurnpikeGate.Core.Prices.Model;
using TurnpikeGate.Core.Prices.Repository;

namespace TurnpikeGate.Core.Prices.Service
{
    public class RoadSectionService : IRoadSectionService
    {
        private readonly IRoadSectionRepository _roadSectionRepository;

        public RoadSectionService(IRoadSectionRepository roadSectionRepository)
        {
            _roadSectionRepository = roadSectionRepository;
        }

        public List<RoadSection> GetAll()
        {
            return _roadSectionRepository.GetAll();
        }

        public RoadSection GetById(ObjectId id)
        {
            return _roadSectionRepository.GetById(id);
        }

        public RoadSection GetByLocations(ObjectId entranceStationId, ObjectId exitStationId)
        {
            return _roadSectionRepository.GetByLocations(entranceStationId, exitStationId);
        }
    }
}
