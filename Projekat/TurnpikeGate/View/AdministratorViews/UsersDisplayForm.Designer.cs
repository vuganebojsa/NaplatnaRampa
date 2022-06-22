
namespace TurnpikeGate.View.AdministratorViews
{
    partial class UsersDisplayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.lastName,
            this.JMBG,
            this.email,
            this.phoneNumber,
            this.salary});
            this.dgvUsers.Location = new System.Drawing.Point(45, 45);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 29;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1215, 750);
            this.dgvUsers.TabIndex = 0;
            // 
            // name
            // 
            this.name.FillWeight = 110F;
            this.name.HeaderText = "Ime";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lastName
            // 
            this.lastName.FillWeight = 110F;
            this.lastName.HeaderText = "Prezime";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // JMBG
            // 
            this.JMBG.FillWeight = 110F;
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.MinimumWidth = 6;
            this.JMBG.Name = "JMBG";
            this.JMBG.ReadOnly = true;
            // 
            // email
            // 
            this.email.FillWeight = 110F;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // phoneNumber
            // 
            this.phoneNumber.FillWeight = 110F;
            this.phoneNumber.HeaderText = "Broj telefona";
            this.phoneNumber.MinimumWidth = 6;
            this.phoneNumber.Name = "phoneNumber";
            // 
            // salary
            // 
            this.salary.FillWeight = 110F;
            this.salary.HeaderText = "Plata";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            // 
            // UsersDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 840);
            this.Controls.Add(this.dgvUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersDisplayForm";
            this.Text = "UsersDisplayForm";
            this.Load += new System.EventHandler(this.UsersDisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn JMBG;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn phoneNumber;
        private DataGridViewTextBoxColumn salary;
    }
}