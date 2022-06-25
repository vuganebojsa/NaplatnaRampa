using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurnpikeGate.View.ReferentViews
{
    public partial class ReferentForm : Form
    {
        private LoginForm _loginForm;

        public ReferentForm(LoginForm loginform)
        {
            _loginForm = loginform;
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var Result = MessageBox.Show("Da li ste sigurni da zelite da se odjavite sa sistema?", "Odjava?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                Globals.LoggedUser = null;
                this.Close();

                LoginForm loginForm = new LoginForm();
                _loginForm.Show();
            }
            
        }

        private void btnTollPayment_Click(object sender, EventArgs e)
        {
            LoadForm(new ExitTicketIssuingForm());
        }

        private void LoadForm(object Form)
        {
            if (this.pnlView.Controls.Count > 0)
            {
                this.pnlView.Controls.RemoveAt(0);

            }
            Form selectedButton = Form as Form;
            selectedButton.TopLevel = false;
            selectedButton.Dock = DockStyle.Fill;
            this.pnlView.Controls.Add(selectedButton);
            this.pnlView.Tag = selectedButton;
            selectedButton.Show();

        }
    }
}
