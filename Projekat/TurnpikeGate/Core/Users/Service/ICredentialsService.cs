using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Interfaces;
using TurnpikeGate.Core.Users.Model;

namespace TurnpikeGate.Core.Users.Service
{
    public interface ICredentialsService : IService<Credentials>
    {
        public void ChangeInitialPassword(String newPassword, String repeatedNewPassword);
    }
}
