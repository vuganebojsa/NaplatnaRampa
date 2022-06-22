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
using TurnpikeGate.Core.TollStations.Repository;
using TurnpikeGate.Core.TollStations.Service;
using TurnpikeGate.Core.Users.Repository;
using TurnpikeGate.Core.Users.Service;

namespace TurnpikeGate
{
    public class ProgramModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TollStationRepository>().As<ITollStationRepository>();
            builder.RegisterType<TollStationService>().As<ITollStationService>();
            builder.RegisterType<TollStationService>().AsSelf();

            builder.RegisterType<CredentialsRepository>().As<ICredentialsRepository>();
            builder.RegisterType<CredentialsService>().As<ICredentialsService>();
            builder.RegisterType<CredentialsService>().AsSelf();

            builder.RegisterType<TollBoothRepository>().As<ITollBoothRepository>();
            builder.RegisterType<TollBoothService>().As<ITollBoothService>();
            builder.RegisterType<TollBoothService>().AsSelf();

            builder.RegisterType<LocationRepository>().As<ILocationRepository>();
            builder.RegisterType<LocationService>().As<ILocationService>();
            builder.RegisterType<Location>().AsSelf();

            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<UserService>().AsSelf();

            builder.RegisterType<PriceListRepository>().As<IPriceListRepository>();
            builder.RegisterType<PriceListService>().As<IPriceListService>();
            builder.RegisterType<PriceListService>().AsSelf();

            builder.RegisterType<PriceListEntryRepository>().As<IPriceListEntryRepository>();
            builder.RegisterType<PriceListEntryService>().As<IPriceListEntryService>();
            builder.RegisterType<PriceListEntryService>().AsSelf();

            builder.RegisterType<RoadSectionRepository>().As<IRoadSectionRepository>();
            builder.RegisterType<RoadSectionService>().As<IRoadSectionService>();
            builder.RegisterType<RoadSectionService>().AsSelf();

            builder.RegisterType<AmountRepository>().As<IAmountRepository>();
            builder.RegisterType<AmountService>().As<IAmountService>();
            builder.RegisterType<AmountService>().AsSelf();

            builder.RegisterType<RampRepository>().As<IRampRepository>();
            builder.RegisterType<RampService>().As<IRampService>();
            builder.RegisterType<RampService>().AsSelf();

            builder.RegisterType<TraficLightRepository>().As<ITraficLightRepository>();
            builder.RegisterType<TrafficLightService>().As<ITrafficLightService>();
            builder.RegisterType<TrafficLightService>().AsSelf();

            builder.RegisterType<CameraRepository>().As<ICameraRepository>();
            builder.RegisterType<CameraService>().As<ICameraService>();
            builder.RegisterType<CameraService>().AsSelf();
        }
    }
}
