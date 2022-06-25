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

namespace TurnpikeGate.View.AdministratorViews
{
    public partial class AdministratorForm : Form
    {
        private ILoginService _loginService;

        public AdministratorForm(ILoginService loginService)
        {
            _loginService = loginService;
            InitializeComponent();
        }

        public void LoadForm(object Form)
        {
            if (this.pnlView.Controls.Count > 0)
                this.pnlView.Controls.RemoveAt(0);
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlView.Controls.Add(form);
            this.pnlView.Tag = form;
            form.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            _loginService.Logout(this);
        }

        private void btnTollBooths_Click(object sender, EventArgs e)
        {
            LoadForm(new TollBoothDisplay());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadForm(new UsersDisplayForm());
        }

        private void btnPriceList_Click(object sender, EventArgs e)
        {
            LoadForm(new PriceListsDisplayForm());
        }

        private void btnTollStation_Click(object sender, EventArgs e)
        {
            LoadForm(new TollStationForm());
        }
    }
}
