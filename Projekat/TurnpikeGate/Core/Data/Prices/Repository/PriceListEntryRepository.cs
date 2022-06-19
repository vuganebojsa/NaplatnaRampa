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
    public class PriceListEntryRepository : IPriceListEntryRepository
    {
        private IMongoCollection<PriceListEntry> _collection;

        public PriceListEntryRepository()
        {
            _collection = DatabaseConnection.Database.GetCollection<PriceListEntry>("PriceListEntries");
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(item => item.ID == id);
        }

        public List<PriceListEntry> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public PriceListEntry GetById(ObjectId id)
        {
            return _collection.Find(item => item.ID == id).FirstOrDefault();
        }

        public void Insert(PriceListEntry entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(PriceListEntry entity)
        {
            _collection.ReplaceOne(item => item.ID == entity.ID, entity);
        }
    }
}
