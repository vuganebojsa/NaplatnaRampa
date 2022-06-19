using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Data.Users.Model;

namespace TurnpikeGate.Core.Data.Users.Repository
{
    public class CredentialsRepository : ICredentialsRepository
    {
        private IMongoCollection<Credentials> _collection;

        public CredentialsRepository()
        {
            _collection = DatabaseConnection.Database.GetCollection<Credentials>("Credentials");
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(item => item.ID == id);
        }

        public List<Credentials> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public Credentials GetById(ObjectId id)
        {
            return _collection.Find(item => item.ID == id).FirstOrDefault();
        }

        public void Insert(Credentials entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(Credentials entity)
        {
            _collection.ReplaceOne(item => item.ID == entity.ID, entity);
        }
        
        
    }
}
