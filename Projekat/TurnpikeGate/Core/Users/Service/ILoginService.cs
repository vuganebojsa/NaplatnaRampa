using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Users.Model;

namespace TurnpikeGate.Core.Users.Service
{
    public interface ILoginService
    {
        void Login(string username, string password);
        void RedirectUser();
    }
}
