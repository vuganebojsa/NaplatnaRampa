using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Users.Model;
using TurnpikeGate.View;

namespace TurnpikeGate.Core.Users.Service
{
    public interface ILoginService
    {
        void Login(string username, string password);
        void Logout(Form form);
        void RedirectUser(LoginForm loginForm);
    }
}
