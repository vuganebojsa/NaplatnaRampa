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

namespace TurnpikeGate.View.UserViews
{
    public partial class ChangePasswordForm : Form
    {

        private ICredentialsService _credentialsService;

        public ChangePasswordForm()
        {
            InitializeComponent();
            _credentialsService = Globals.Container.Resolve<CredentialsService>();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                _credentialsService.ChangeInitialPassword(tbPassword.Text, tbRepeatedPass.Text);
                MessageBox.Show("Sifra uspesno promenjena. Nalog aktiviran :)");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
