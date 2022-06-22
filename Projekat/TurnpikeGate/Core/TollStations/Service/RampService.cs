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

        public List<Ramp> GetAll()
        {
            return _rampRepository.GetAll();
        }

        public void Insert(Ramp ramp)
        {
            _rampRepository.Insert(ramp);
        }

    }
}
