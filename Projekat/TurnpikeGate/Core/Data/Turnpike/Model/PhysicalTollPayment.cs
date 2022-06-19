using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Data.Turnpike.Model
{
    public class PhysicalTollPayment : TollPayment
    {
        public ObjectId ReferentId { get; set; }

        public PhysicalTollPayment(string registrationPlate, DateTime enteranceTime, DateTime exitTime, 
                                   ObjectId entranceStationId, ObjectId referentId)
        { 
            ID = ObjectId.GenerateNewId();
            RegistrationPlate = registrationPlate;
            EntranceTime = enteranceTime;
            ExitTime = exitTime;
            EntranceStationId = entranceStationId;
            ReferentId = referentId;

        }

    }
}
