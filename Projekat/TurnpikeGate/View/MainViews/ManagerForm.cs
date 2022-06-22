using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurnpikeGate.View.ManagerViews;

namespace TurnpikeGate.View.MainViews
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void btnFirstSurvey_Click(object sender, EventArgs e)
        {
            LoadForm(new TotalncomeForm());
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

        private void btnSecondSurvey_Click(object sender, EventArgs e)
        {
            LoadForm(new BussiestStationForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Da li ste sigurni?", "Odjava?", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                
            }
        }
    }
}
