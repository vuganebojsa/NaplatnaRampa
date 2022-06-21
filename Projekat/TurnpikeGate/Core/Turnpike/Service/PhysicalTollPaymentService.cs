using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using TurnpikeGate.Core.Prices.Model;
using TurnpikeGate.Core.Turnpike.Model;
using TurnpikeGate.Core.Turnpike.Repository;

namespace TurnpikeGate.Core.Turnpike.Service
{
    class PhysicalTollPaymentService:IPhysicalTollPaymentService
    {
        private readonly IPhysicalTollPaymentRepository _physicalTollPaymentRepository;

        public PhysicalTollPaymentService(IPhysicalTollPaymentRepository physicalTollPaymentRepository)
        {
            _physicalTollPaymentRepository = physicalTollPaymentRepository;
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
    }
}
