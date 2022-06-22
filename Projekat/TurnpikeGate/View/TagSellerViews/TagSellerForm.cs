using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurnpikeGate.Core.Prices.Model;
using Autofac;
using TurnpikeGate.Core.Tags.Service;
using TurnpikeGate.Core.Tags.Model;
using MongoDB.Bson;

namespace TurnpikeGate.View.TagSellerViews
{
    public partial class TagSellerForm : Form
    {
        private IElectronicTagService electronicTagService;
        public TagSellerForm()
        {
            electronicTagService = Globals.Container.Resolve<ElectronicTagService>();
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbAddFounds_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAddFounds.Checked)
            {
                this.BackColor = Color.LightBlue;
                panel1.BackColor = Color.LightGray;
                chbRegisterTag.Checked = false;
                tbAmount.Enabled = true;
                tbID.Enabled = true;
                btnAddFunds.Enabled = true;
            }
            else
            {
                tbAmount.Enabled = false;
                tbID.Enabled = false;
                btnAddFunds.Enabled = false;
                this.BackColor = Color.LightGray;

            }
        }

        private void cbRegisterTag_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRegisterTag.Checked)
            {
                chbAddFounds.Checked = false;
                this.BackColor = Color.LightGray;
                panel1.BackColor = Color.LightBlue;
                tbName.Enabled = true;
                tbLastName.Enabled = true;
                cbType.Enabled = true;
                btnRegister.Enabled = true;
                cbCurrency.Enabled = true;



            }
            else
            {
                panel1.BackColor = Color.LightGray;
                tbName.Enabled = false;
                tbLastName.Enabled = false;
                cbType.Enabled = false;
                btnRegister.Enabled = false;
                cbCurrency.Enabled = false;

            }

        }

        private void btnAddFunds_Click(object sender, EventArgs e)
        {
            try
            {
                ElectronicTag electronicTag = electronicTagService.GetById(ObjectId.Parse(tbID.Text));
                electronicTag.Amount.Total += int.Parse(tbAmount.Text);
                electronicTagService.Update(electronicTag);
                System.Windows.Forms.MessageBox.Show("Sredstva dodata!");
            }
            catch (NullReferenceException ex)
            {
                if (ex is NullReferenceException)
                {
                    System.Windows.Forms.MessageBox.Show(" Tag ne postoji!");
                }
                
            }
        }

        private void TagSellerForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            panel1.BackColor = Color.LightGray;
            chbAddFounds.Checked = true;
            chbRegisterTag.Checked = false;

            LoadComboBox();
        }

        private void LoadComboBox()
        {
            cbType.DataSource = (VehicleType[])Enum.GetValues(typeof(VehicleType));
            cbCurrency.DataSource = (Currency[])Enum.GetValues(typeof(Currency));

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ElectronicTag electronicTag = new ElectronicTag(tbName.Text, tbLastName.Text, (VehicleType)cbType.SelectedValue,(Currency)cbCurrency.SelectedValue);
            electronicTagService.Insert(electronicTag);
            DialogResult dialogResult = MessageBox.Show("Tag uspesno napravljen\nDa li zelite da odhah oplatite novac?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tbID.Text = electronicTag.ID.ToString();
                chbAddFounds.Checked = true;

            }
        }
    }
}
