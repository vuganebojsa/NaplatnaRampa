using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using TurnpikeGate.Core;
using TurnpikeGate.Core.Locations.Repository;
using TurnpikeGate.Core.Locations.Service;
using TurnpikeGate.Core.Prices.Repository;
using TurnpikeGate.Core.Prices.Service;
using TurnpikeGate.Core.Tags.Repository;
using TurnpikeGate.Core.Tags.Service;
using TurnpikeGate.Core.TollStations.Repository;
using TurnpikeGate.Core.TollStations.Service;
using TurnpikeGate.Core.Turnpike.Repository;
using TurnpikeGate.Core.Turnpike.Service;

namespace TurnpikeGate
{
    public class ProgramModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TollStationRepository>().As<ITollStationRepository>();
            builder.RegisterType<TollStationService>().As<ITollStationService>();
            builder.RegisterType<TollStationService>().AsSelf();

            builder.RegisterType<LocationRepository>().As<ILocationRepository>();
            builder.RegisterType<LocationService>().As<ILocationService>();
            builder.RegisterType<Location>().AsSelf();

            builder.RegisterType<PriceListEntryRepository>().As<IPriceListEntryRepository>();
            builder.RegisterType<PriceListEntryService>().As<IPriceListEntryService>();
            builder.RegisterType<PriceListEntryService>().AsSelf();

            builder.RegisterType<PhysicalTollPaymentRepository>().As<IPhysicalTollPaymentRepository>();
            builder.RegisterType<PhysicalTollPaymentService>().As<IPhysicalTollPaymentService>();
            builder.RegisterType<PhysicalTollPaymentService>().AsSelf();

            builder.RegisterType<ElectronicTagRepository>().As<IElectronicTagRepository>();
            builder.RegisterType<ElectronicTagService>().As<IElectronicTagService>();
            builder.RegisterType<ElectronicTagService>().AsSelf();


        }
    }
}
