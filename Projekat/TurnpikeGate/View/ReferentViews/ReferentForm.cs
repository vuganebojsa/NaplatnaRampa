using Autofac;
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

namespace TurnpikeGate.View.ReferentViews
{
    public partial class ReferentForm : Form
    {
        private ILoginService _loginService;

        public ReferentForm(ILoginService loginService)
        {
            _loginService = loginService;
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loginService.Logout(this);
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

        private void btnReportMalfunction_Click(object sender, EventArgs e)
        {
            LoadForm(new ReportMalfunctionForm());
        }
    }
}
