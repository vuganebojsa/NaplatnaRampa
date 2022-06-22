using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Interfaces;
using TurnpikeGate.Core.Users.Model;
using TurnpikeGate.Core.Users.Repository;
using TurnpikeGate.View.AdministratorViews;
using TurnpikeGate.View.MainViews;
using TurnpikeGate.View.ReferentViews;
using TurnpikeGate.View.TagSellerViews;

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
                    AdministratorForm adminForm = new AdministratorForm();
                    adminForm.Show();
                    break;
                case UserType.MAIN_MANAGER:
                    ManagerForm managerForm = new ManagerForm();
                    managerForm.Show();
                    break;
                case UserType.STATION_MANAGER:
                    Console.WriteLine("STATION");
                    break;
                case UserType.REFERENT:
                    ReferentForm referentForm = new ReferentForm();
                    referentForm.Show();
                    break;
                case UserType.TAG_SELLER:
                    TagSellerMainForm sellerMainForm = new TagSellerMainForm();
                    sellerMainForm.Show();
                    break;
                default:
                    throw new LoggedUserException("Tip ulogovanog korisnika ne odgovara predefinisanim tipovima.");
            }
        }
    }
}
