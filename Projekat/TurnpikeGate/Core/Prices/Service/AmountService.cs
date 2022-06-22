using MongoDB.Bson;
using TurnpikeGate.Core.Prices.Model;
using TurnpikeGate.Core.Prices.Repository;

namespace TurnpikeGate.Core.Prices.Service
{
    public class AmountService : IAmountService
    {
        private readonly IAmountRepository _amountRepository;

        public AmountService(IAmountRepository amountRepository)
        {
            _amountRepository = amountRepository;
        }

        public List<Amount> GetAll()
        {
            return _amountRepository.GetAll();
        }

        public Amount GetById(ObjectId id)
        {
            return _amountRepository.GetById(id);
        }

    }
}
