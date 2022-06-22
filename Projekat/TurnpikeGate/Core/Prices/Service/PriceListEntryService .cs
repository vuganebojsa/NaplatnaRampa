using MongoDB.Bson;
using TurnpikeGate.Core.Prices.Model;
using TurnpikeGate.Core.Prices.Repository;

namespace TurnpikeGate.Core.Prices.Service
{
    public class PriceListEntryService : IPriceListEntryService
    {
        private readonly IPriceListEntryRepository _priceListEntryRepository;

        public PriceListEntryService(IPriceListEntryRepository priceListEntryRepository)
        {
            _priceListEntryRepository = priceListEntryRepository;
        }

        public void Insert(PriceListEntry tollStation)
        {
            _priceListEntryRepository.Insert(tollStation);
        }
        public void Delete(string id)
        {
            _priceListEntryRepository.Delete(ObjectId.Parse(id));

        }
        public void Update(PriceListEntry entity)
        {
            _priceListEntryRepository.Update(entity);
        }

        public List<PriceListEntry> GetAll()
        {
            return _priceListEntryRepository.GetAll();
        }

        public PriceListEntry GetById(ObjectId id)
        {
            return _priceListEntryRepository.GetById(id);
        }

    }
}
