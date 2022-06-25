using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurnpikeGate.Core.Users.Service;
using Autofac;
using TurnpikeGate.View.UserViews;

namespace TurnpikeGate.View
{
    public partial class LoginForm : Form
    {
        private ILoginService _loginService;

        public LoginForm()
        {
            InitializeComponent();
            _loginService = Globals.Container.Resolve<LoginService>();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Globals.LoggedUser != null)
                this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                _loginService.Login(tbUsername.Text, tbPassword.Text);
                if (!Globals.LoggedUser.IsActive)
                {
                    ChangePasswordForm changePasswordForm = new ChangePasswordForm();
                    changePasswordForm.ShowDialog();
                }

                tbPassword.Text = "";
                tbUsername.Text = "";

                this.Hide();
                _loginService.RedirectUser(this);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
