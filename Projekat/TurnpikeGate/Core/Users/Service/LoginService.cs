using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Interfaces;
using TurnpikeGate.Core.Users.Model;
using TurnpikeGate.Core.Users.Repository;
using TurnpikeGate.View;
using TurnpikeGate.View.AdministratorViews;
using TurnpikeGate.View.MainViews;
using TurnpikeGate.View.ReferentViews;
using TurnpikeGate.View.StationManagerViews;
using TurnpikeGate.View.TagSellerViews;

namespace TurnpikeGate.Core.Users.Service
{
    public class LoginService : ILoginService
    {
        private ICredentialsRepository _credentialsRepository;
        private LoginForm _loginForm;

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

        public void RedirectUser(LoginForm loginForm)
        {
            _loginForm = loginForm;

            switch (Globals.LoggedUser.Type)
            {
                case UserType.ADMINISTRATOR:
                    AdministratorForm adminForm = new AdministratorForm(this);
                    adminForm.Show();
                    break;
                case UserType.MAIN_MANAGER:
                    ManagerForm managerForm = new ManagerForm(this);
                    managerForm.Show();
                    break;
                case UserType.STATION_MANAGER:
                    StationManagerForm stationManagerForm = new StationManagerForm(this);
                    stationManagerForm.Show();
                    break;
                case UserType.REFERENT:
                    ReferentForm referentForm = new ReferentForm(this);
                    referentForm.Show();
                    break;
                case UserType.TAG_SELLER:
                    TagSellerMainForm sellerMainForm = new TagSellerMainForm(this);
                    sellerMainForm.Show();
                    break;
                default:
                    throw new LoggedUserException("Tip ulogovanog korisnika ne odgovara predefinisanim tipovima.");
            }
        }

        public void Logout(Form form)
        {
            var Result = MessageBox.Show("Da li ste sigurni da zelite da se odjavite sa sistema?", "Odjava?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                Globals.LoggedUser = null;
                form.Close();

                _loginForm.Show();
            }
        }
    }
}
