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

namespace TurnpikeGate.View.TagSellerViews
{
    public partial class TagSellerMainForm : Form
    {
        private readonly ILoginService _loginService;

        public TagSellerMainForm(ILoginService loginService)
        {
            _loginService = loginService;
            InitializeComponent();
            _loginService = loginService;
            InitName();
            
        }

        private void InitName()
        { 
            lbName.Text = Globals.LoggedUserInfo.Name + " " + Globals.LoggedUserInfo.LastName;
            lbRole.Text = "Pumpadzija";
        }


        private void btnTags_Click(object sender, EventArgs e)
        {
            
            TagSellerForm frm = new TagSellerForm();
            LoadForm(frm);

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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loginService.Logout(this);
        }
    }
}
