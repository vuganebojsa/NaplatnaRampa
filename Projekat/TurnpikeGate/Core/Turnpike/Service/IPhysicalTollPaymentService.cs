using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Interfaces;
using TurnpikeGate.Core.Prices.Model;
using TurnpikeGate.Core.Turnpike.Model;

namespace TurnpikeGate.Core.Turnpike.Service
{
    interface IPhysicalTollPaymentService : IService<PhysicalTollPayment>
    {
        double CalculateTollPrice(VehicleType selectedVehicleType, ObjectId roadSectionId, Currency currency, out ObjectId priceListEntryId);
        List<PhysicalTollPayment> GetUntilDate(DateTime untilDate);
    }
}
