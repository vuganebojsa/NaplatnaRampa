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
    public class LoginService : ILoginService
    {
        private ICredentialsRepository _credentialsRepository;

        public LoginService(ICredentialsRepository credentialsRepository)
        {
            _credentialsRepository = credentialsRepository;
        }

        public void Login(string username, string password)
        {
            if (username == "" || password == "")
                throw new EmptyFieldsException();

            Credentials foundUser = _credentialsRepository.FindCredentials(username, password);
            if (foundUser == null)
                throw new BadCredentialsException();

            Globals.LoggedUser = foundUser;
        }
    }
}
