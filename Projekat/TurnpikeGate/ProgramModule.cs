using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using TurnpikeGate.Core.TollStations.Repository;
using TurnpikeGate.Core.TollStations.Service;

namespace TurnpikeGate
{
    public class ProgramModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TollStationRepository>().As<ITollStationRepository>();
            builder.RegisterType<TollStationService>().As<ITollStationService>();
            builder.RegisterType<TollStationService>().AsSelf();


        }
    }
}
