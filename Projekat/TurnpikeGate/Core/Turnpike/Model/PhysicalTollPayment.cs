using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Turnpike.Model
{
    public class PhysicalTollPayment : TollPayment
    {
        [BsonElement("referentId")]
        public ObjectId ReferentId { get; set; }

        public PhysicalTollPayment(string registrationPlate, DateTime enteranceTime, DateTime exitTime, 
                                   ObjectId entranceStationId, ObjectId referentId, ObjectId priceListEntryId)
        { 
            ID = ObjectId.GenerateNewId();
            RegistrationPlate = registrationPlate;
            EntranceTime = enteranceTime;
            ExitTime = exitTime;
            EntranceStationId = entranceStationId;
            ReferentId = referentId;
            PriceListEntryId = priceListEntryId;

        }

    }
}
