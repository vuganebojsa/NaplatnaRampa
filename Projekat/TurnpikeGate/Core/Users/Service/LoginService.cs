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

        public void RedirectUser()
        {
            switch (Globals.LoggedUser.Type)
            {
                case UserType.ADMINISTRATOR:
                    Console.WriteLine("ADMIN");
                    break;
                case UserType.MAIN_MANAGER:
                    Console.WriteLine("MAIN");
                    break;
                case UserType.STATION_MANAGER:
                    Console.WriteLine("STATION");
                    break;
                case UserType.REFERENT:
                    Console.WriteLine("REFERENT");
                    break;
                case UserType.TAG_SELLER:
                    Console.WriteLine("TAG SELLER");
                    break;
                default:
                    throw new LoggedUserException("Tip ulogovanog korisnika ne odgovara predefinisanim tipovima.");
            }
        }
    }
}
