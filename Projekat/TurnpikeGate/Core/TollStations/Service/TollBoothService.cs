using MongoDB.Bson;
using TurnpikeGate.Core.TollStations.Model;
using TurnpikeGate.Core.TollStations.Repository;


namespace TurnpikeGate.Core.TollStations.Service
{
    public class TollBoothService : ITollBoothService
    {
        private readonly ITollBoothRepository _tollBoothRepository;

        public TollBoothService(ITollBoothRepository tollBoothRepository)
        {
            _tollBoothRepository = tollBoothRepository;
        }

        public void Delete(string id)
        {
            _tollBoothRepository.Delete(ObjectId.Parse(id));

        }

        public List<TollBooth> GetAll()
        {
            return _tollBoothRepository.GetAll();
        }

        public TollBooth GetById(ObjectId id)
        {
            return _tollBoothRepository.GetById(id);
        }

        public void Insert(TollBooth tollBoothId)
        {
            _tollBoothRepository.Insert(tollBoothId);
        }

        public void Update(TollBooth entity)
        {
            _tollBoothRepository.Update(entity);
        }
    }
}
