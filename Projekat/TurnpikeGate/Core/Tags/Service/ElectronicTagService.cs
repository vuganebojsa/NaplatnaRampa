using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Tags.Model;
using TurnpikeGate.Core.Tags.Repository;

namespace TurnpikeGate.Core.Tags.Service
{
    internal class ElectronicTagService : IElectronicTagService
    {
        private IElectronicTagRepository electronicTagRepository;

        public ElectronicTagService(IElectronicTagRepository electronicTagRepository)
        {
            this.electronicTagRepository = electronicTagRepository;
        }
        public void Delete(string id)
        {
            electronicTagRepository.Delete(ObjectId.Parse(id));
        }

        public List<ElectronicTag> GetAll()
        {
            return electronicTagRepository.GetAll();
        }

        public ElectronicTag GetById(ObjectId id)
        {
            return electronicTagRepository.GetById(id);
        }

        public void Insert(ElectronicTag entity)
        {
            electronicTagRepository.Insert(entity);
        }

        public void Update(ElectronicTag entity)
        {
            electronicTagRepository.Update(entity);
        }
    }
}
