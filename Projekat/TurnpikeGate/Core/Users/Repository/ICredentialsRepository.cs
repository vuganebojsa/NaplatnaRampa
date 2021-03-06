using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Users.Model;
using TurnpikeGate.Core.Interfaces;

namespace TurnpikeGate.Core.Users.Repository
{
    public interface ICredentialsRepository : IRepository<Credentials>
    {
        public Credentials FindCredentials(string username, string password);
    }
}
