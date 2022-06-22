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
    public class TollBoothService : ITollBoothService
    {
        private readonly ITollBoothRepository _tollBoothRepository;

        public TollBoothService(ITollBoothRepository tollBoothRepository)
        {
            _tollBoothRepository = tollBoothRepository;
        }

        public List<TollBooth> GetAll()
        {
            return _tollBoothRepository.GetAll();
        }

        public void Insert(TollBooth tollBooth)
        {
            _tollBoothRepository.Insert(tollBooth);
        }

    }
}
