using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Data.Prices.Model;

namespace TurnpikeGate.Core.Data.Prices.Repository
{
    public class PriceListRepository : IPriceListRepository
    {
        private IMongoCollection<PriceList> _collection;

        public PriceListRepository()
        {
            _collection = DatabaseConnection.Database.GetCollection<PriceList>("PriceLists");
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(item => item.ID == id);
        }

        public List<PriceList> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public PriceList GetById(ObjectId id)
        {
            return _collection.Find(item => item.ID == id).FirstOrDefault();
        }

        public void Insert(PriceList entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(PriceList entity)
        {
            _collection.ReplaceOne(item => item.ID == entity.ID, entity);
        }
    }
}
