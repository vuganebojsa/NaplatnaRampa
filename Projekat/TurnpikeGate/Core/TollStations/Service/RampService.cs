using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.TollStations.Model;
using TurnpikeGate.Core.TollStations.Repository;

namespace TurnpikeGate.Core.TollStations.Service
{
    public class RampService : IRampService
    {
        private readonly IRampRepository _rampRepository;

        public RampService(IRampRepository rampRepository)
        {
            _rampRepository = rampRepository;
        }

        public void Delete(string id)
        {
            _rampRepository.Delete(ObjectId.Parse(id));

        }

        public List<Ramp> GetAll()
        {
            return _rampRepository.GetAll();
        }

        public Ramp GetById(ObjectId id)
        {
            return _rampRepository.GetById(id);
        }

        public Ramp GetByTollBoothId(ObjectId tollBoothId)
        {
            return _rampRepository.GetTollBoothId(tollBoothId);
        }

        public void Insert(Ramp rampId)
        {
            _rampRepository.Insert(rampId);
        }


        public void Update(Ramp entity)
        {
            _rampRepository.Update(entity);
        }
    }
}
