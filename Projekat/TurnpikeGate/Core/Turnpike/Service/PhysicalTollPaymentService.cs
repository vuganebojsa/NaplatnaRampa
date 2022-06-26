using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using TurnpikeGate.Core.Prices.Model;
using TurnpikeGate.Core.Prices.Repository;
using TurnpikeGate.Core.Turnpike.Model;
using TurnpikeGate.Core.Turnpike.Repository;

namespace TurnpikeGate.Core.Turnpike.Service
{
    class PhysicalTollPaymentService : IPhysicalTollPaymentService
    {
        private readonly IPhysicalTollPaymentRepository _physicalTollPaymentRepository;
        private readonly IPriceListRepository _priceListRepository;
        private readonly IPriceListEntryRepository _priceListEntryRepository;

        public PhysicalTollPaymentService(IPhysicalTollPaymentRepository physicalTollPaymentRepository, 
                                          IPriceListEntryRepository priceListEntryRepository, IPriceListRepository priceListRepository)
        {
            _physicalTollPaymentRepository = physicalTollPaymentRepository;
            _priceListRepository = priceListRepository;
            _priceListEntryRepository = priceListEntryRepository;
        }

        public void Insert(PhysicalTollPayment tollPayment)
        {
            _physicalTollPaymentRepository.Insert(tollPayment);
        }
        public void Delete(string id)
        {
            _physicalTollPaymentRepository.Delete(ObjectId.Parse(id));

        }
        public void Update(PhysicalTollPayment entity)
        {
            _physicalTollPaymentRepository.Update(entity);
        }

        public List<PhysicalTollPayment> GetAll()
        {
            return _physicalTollPaymentRepository.GetAll();
        }

        public PhysicalTollPayment GetById(ObjectId id)
        {
            return _physicalTollPaymentRepository.GetById(id);
        }

        public double CalculateTollPrice(VehicleType selectedVehicleType, ObjectId roadSectionId, Currency currency, out ObjectId priceListEntryId)
        {
            PriceList activePriceList = _priceListRepository.GetActive();
            PriceListEntry priceListEntry = _priceListEntryRepository.GetByParameters(activePriceList.PriceListEntries, selectedVehicleType, roadSectionId, currency);
            priceListEntryId = priceListEntry.ID;
            return priceListEntry.Amount.Total;
        }
        
        public List<PhysicalTollPayment> GetUntilDate(DateTime untilDate)
        {
            return _physicalTollPaymentRepository.GetUntilDate(untilDate);
        }

        public double CalculateVelocity(PhysicalTollPayment currentTollPayment, double mileage)
        {
            return (mileage / (currentTollPayment.ExitTime - currentTollPayment.EntranceTime).TotalMinutes)*60;
        }

        public List<PhysicalTollPayment> GetPending()
        {
            return _physicalTollPaymentRepository.GetPending();
        }
    }
}
