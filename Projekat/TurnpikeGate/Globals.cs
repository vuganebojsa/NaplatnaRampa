using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace TurnpikeGate
{
    public static class Globals
    {
        public static IContainer Container;

        public static void Load()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule<ProgramModule>();
            Container = containerBuilder.Build();
        }
    }
}
