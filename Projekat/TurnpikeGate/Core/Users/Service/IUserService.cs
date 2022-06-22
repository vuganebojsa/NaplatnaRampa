using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Interfaces;
using TurnpikeGate.Core.Users.Model;
using TurnpikeGate.Core.Users.Repository;

namespace TurnpikeGate.Core.Users.Service
{
    public interface IUserService
    {
        public List<User> GetAll();

    }
}
