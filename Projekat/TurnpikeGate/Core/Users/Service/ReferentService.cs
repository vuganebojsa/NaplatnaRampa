using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Users.Model;
using TurnpikeGate.Core.Users.Repository;

namespace TurnpikeGate.Core.Users.Service
{
    internal class ReferentService
    {
        IReferentRepository _referentRepository;

        public ReferentService(IReferentRepository referentRepository)
        { 
            _referentRepository = referentRepository;
        }

        public Referent GetById(ObjectId id)
        {
            return _referentRepository.GetById(id);
        }



    }
}
