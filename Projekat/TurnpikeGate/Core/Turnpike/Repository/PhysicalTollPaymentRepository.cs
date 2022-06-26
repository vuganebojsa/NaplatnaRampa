using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Turnpike.Model;

namespace TurnpikeGate.Core.Turnpike.Repository
{
    public class PhysicalTollPaymentRepository : IPhysicalTollPaymentRepository
    {
        private IMongoCollection<PhysicalTollPayment> _collection;

        public PhysicalTollPaymentRepository()
        {
            _collection = DatabaseConnection.Database.GetCollection<PhysicalTollPayment>("PhysicalTollPayments");
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(item => item.ID == id);
        }

        public List<PhysicalTollPayment> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public PhysicalTollPayment GetById(ObjectId id)
        {
            return _collection.Find(item => item.ID == id).FirstOrDefault();
        }

        public List<PhysicalTollPayment> GetPending()
        {
            return _collection.Find(item => item.PriceListEntryId == new ObjectId("000000000000000000000000")).ToList();
        }
        
        public List<PhysicalTollPayment> GetUntilDate(DateTime untilDate)
        {
            return _collection.Find(item => item.ExitTime < untilDate).ToList();
        }

        public void Insert(PhysicalTollPayment entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(PhysicalTollPayment entity)
        {
            _collection.ReplaceOne(item => item.ID == entity.ID, entity);
        }
    }
}
