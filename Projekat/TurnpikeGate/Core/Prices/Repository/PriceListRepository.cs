using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Prices.Model;

namespace TurnpikeGate.Core.Prices.Repository
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

        public PriceList GetActive()
        {
            return _collection.Find(a => a.ActivationDate <= DateTime.Now).SortByDescending((a) => a.ActivationDate).FirstOrDefault();
        }

        public List<PriceList> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public PriceList GetByDate(DateTime selectedDate)
        {
            return _collection.Find(item => item.ActivationDate == selectedDate).FirstOrDefault();
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
