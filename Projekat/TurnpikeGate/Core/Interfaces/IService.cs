using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Interfaces
{
    internal interface IService<TEntity>
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(ObjectId id);
        List<TEntity> GetAll();
        TEntity GetById(ObjectId id);
    }
}
