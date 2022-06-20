using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Interfaces;

namespace TurnpikeGate.Core.Users.Service
{
    public class LoginService : ILoginService
    {
        public void Login(string username, string password)
        {
            if (username == "" || password == "")
                throw new EmptyFieldsException();
        }
    }
}
