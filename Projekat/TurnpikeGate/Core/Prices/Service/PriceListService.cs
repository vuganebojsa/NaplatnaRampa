using MongoDB.Bson;
using TurnpikeGate.Core.Prices.Model;
using TurnpikeGate.Core.Prices.Repository;

namespace TurnpikeGate.Core.Prices.Service
{
    public class PriceListService : IPriceListService
    {
        private readonly IPriceListRepository _priceListRepository;

        public PriceListService(IPriceListRepository priceListRepository)
        {
            _priceListRepository = priceListRepository;
        }

        public List<PriceList> GetAll()
        {
            return _priceListRepository.GetAll();
        }

        public PriceList GetByDate(DateTime selectedDate)
        {
            return _priceListRepository.GetByDate(selectedDate);
        }

        public PriceList GetById(ObjectId id)
        {
            return _priceListRepository.GetById(id);
        }

    }
}
