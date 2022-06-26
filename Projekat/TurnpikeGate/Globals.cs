using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using MongoDB.Bson;
using TurnpikeGate.Core.Users.Model;

namespace TurnpikeGate
{
    public static class Globals
    {
        public static IContainer Container;
        public static Credentials LoggedUser;
        public static User LoggedUserInfo;
        public static void Load()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule<ProgramModule>();
            Container = containerBuilder.Build();
        }
    }
}