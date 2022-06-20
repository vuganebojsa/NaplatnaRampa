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

namespace TurnpikeGate.View
{
    public partial class LoginForm : Form
    {
        private ILoginService _loginService;

        public LoginForm()
        {
            InitializeComponent();
            _loginService = Globals.Container.Resolve<ILoginService>();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _loginService.Login(tbUsername.Text, tbPassword.Text);
        }
    }
}
