
namespace TurnpikeGate.View.AdministratorViews
{
    partial class AdministratorForm
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
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnTollBooths = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnPriceList = new System.Windows.Forms.Button();
            this.btnTollStation = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pnlView = new System.Windows.Forms.Panel();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.SystemColors.Control;
            this.pnlControls.Controls.Add(this.btnLogOut);
            this.pnlControls.Controls.Add(this.btnTollBooths);
            this.pnlControls.Controls.Add(this.btnUsers);
            this.pnlControls.Controls.Add(this.btnPriceList);
            this.pnlControls.Controls.Add(this.btnTollStation);
            this.pnlControls.Controls.Add(this.lblName);
            this.pnlControls.Controls.Add(this.lblRole);
            this.pnlControls.Controls.Add(this.pbUser);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(250, 853);
            this.pnlControls.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Location = new System.Drawing.Point(0, 783);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(250, 70);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Odjava";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnTollBooths
            // 
            this.btnTollBooths.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTollBooths.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTollBooths.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTollBooths.Location = new System.Drawing.Point(0, 369);
            this.btnTollBooths.Name = "btnTollBooths";
            this.btnTollBooths.Size = new System.Drawing.Size(250, 70);
            this.btnTollBooths.TabIndex = 6;
            this.btnTollBooths.Text = "Naplatna mesta";
            this.btnTollBooths.UseVisualStyleBackColor = true;
            this.btnTollBooths.Click += new System.EventHandler(this.btnTollBooths_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Location = new System.Drawing.Point(0, 438);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(250, 70);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "Korisnici";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnPriceList
            // 
            this.btnPriceList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriceList.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPriceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceList.Location = new System.Drawing.Point(0, 507);
            this.btnPriceList.Name = "btnPriceList";
            this.btnPriceList.Size = new System.Drawing.Size(250, 70);
            this.btnPriceList.TabIndex = 3;
            this.btnPriceList.Text = "Cenovnici";
            this.btnPriceList.UseVisualStyleBackColor = true;
            this.btnPriceList.Click += new System.EventHandler(this.btnPriceList_Click);
            // 
            // btnTollStation
            // 
            this.btnTollStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTollStation.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTollStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTollStation.Location = new System.Drawing.Point(0, 300);
            this.btnTollStation.Name = "btnTollStation";
            this.btnTollStation.Size = new System.Drawing.Size(250, 70);
            this.btnTollStation.TabIndex = 2;
            this.btnTollStation.Text = "Naplatne stanice";
            this.btnTollStation.UseVisualStyleBackColor = true;
            this.btnTollStation.Click += new System.EventHandler(this.btnTollStation_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 215);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ime";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblRole.Location = new System.Drawing.Point(50, 245);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(49, 20);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Uloga";
            // 
            // pbUser
            // 
            this.pbUser.Image = global::TurnpikeGate.Properties.Resources._219986;
            this.pbUser.Location = new System.Drawing.Point(50, 50);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(150, 150);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 0;
            this.pbUser.TabStop = false;
            // 
            // pnlView
            // 
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(250, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1292, 853);
            this.pnlView.TabIndex = 1;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 853);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.pnlControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdministratorForm";
            this.Text = "AdministratorForm";
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlControls;
        private Button btnLogOut;
        private Button btnTollBooths;
        private Button btnUsers;
        private Button btnPriceList;
        private Button btnTollStation;
        private Label lblName;
        private Label lblRole;
        private PictureBox pbUser;
        private Panel pnlView;
    }
}