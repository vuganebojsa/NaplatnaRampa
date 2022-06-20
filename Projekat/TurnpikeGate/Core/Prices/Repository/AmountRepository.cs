using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Prices.Model;
using TurnpikeGate.Core.Prices;

namespace TurnpikeGate.Core.Prices.Repository
{
    public class AmountRepository : IAmountRepository
    {
        private IMongoCollection<Amount> _collection;

        public AmountRepository()
        {
            _collection = DatabaseConnection.Database.GetCollection<Amount>("Amounts");
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(item => item.ID == id);
        }

        public List<Amount> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public Amount GetById(ObjectId id)
        {
            return _collection.Find(item => item.ID == id).FirstOrDefault();
        }

        public void Insert(Amount entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(Amount entity)
        {
            _collection.ReplaceOne(item => item.ID == entity.ID, entity);
        }
    }
}
