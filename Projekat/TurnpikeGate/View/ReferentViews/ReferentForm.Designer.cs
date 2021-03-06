namespace TurnpikeGate.View.ReferentViews
{
    partial class ReferentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReferentForm));
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnEntrance = new System.Windows.Forms.Button();
            this.btnReportMalfunction = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTollPayment = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pnlView = new System.Windows.Forms.Panel();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnEntrance);
            this.pnlControls.Controls.Add(this.btnReportMalfunction);
            this.pnlControls.Controls.Add(this.btnLogout);
            this.pnlControls.Controls.Add(this.btnTollPayment);
            this.pnlControls.Controls.Add(this.lblRole);
            this.pnlControls.Controls.Add(this.lblName);
            this.pnlControls.Controls.Add(this.pbUser);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(250, 853);
            this.pnlControls.TabIndex = 0;
            // 
            // btnEntrance
            // 
            this.btnEntrance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEntrance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrance.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEntrance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntrance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEntrance.Location = new System.Drawing.Point(0, 309);
            this.btnEntrance.Name = "btnEntrance";
            this.btnEntrance.Size = new System.Drawing.Size(250, 70);
            this.btnEntrance.TabIndex = 6;
            this.btnEntrance.Text = "IZDAVANJE TIKETA";
            this.btnEntrance.UseVisualStyleBackColor = false;
            this.btnEntrance.Click += new System.EventHandler(this.btnEntrance_Click);
            // 
            // btnReportMalfunction
            // 
            this.btnReportMalfunction.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReportMalfunction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportMalfunction.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnReportMalfunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportMalfunction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReportMalfunction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReportMalfunction.Location = new System.Drawing.Point(0, 443);
            this.btnReportMalfunction.Name = "btnReportMalfunction";
            this.btnReportMalfunction.Size = new System.Drawing.Size(250, 70);
            this.btnReportMalfunction.TabIndex = 5;
            this.btnReportMalfunction.Text = "PREGLED UREDJAJA";
            this.btnReportMalfunction.UseVisualStyleBackColor = false;
            this.btnReportMalfunction.Click += new System.EventHandler(this.btnReportMalfunction_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(0, 783);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 70);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "ODJAVA";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTollPayment
            // 
            this.btnTollPayment.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTollPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTollPayment.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTollPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTollPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTollPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTollPayment.Location = new System.Drawing.Point(0, 376);
            this.btnTollPayment.Name = "btnTollPayment";
            this.btnTollPayment.Size = new System.Drawing.Size(250, 70);
            this.btnTollPayment.TabIndex = 3;
            this.btnTollPayment.Text = "NAPLATA PUTARINE";
            this.btnTollPayment.UseVisualStyleBackColor = false;
            this.btnTollPayment.Click += new System.EventHandler(this.btnTollPayment_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRole.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRole.Location = new System.Drawing.Point(50, 245);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(57, 23);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Uloga";
            // 
            // lblName
            // 
            this.lblName.AccessibleDescription = "";
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(50, 215);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ime";
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(50, 50);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(150, 150);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 0;
            this.pbUser.TabStop = false;
            // 
            // pnlView
            // 
            this.pnlView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(250, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1292, 853);
            this.pnlView.TabIndex = 1;
            // 
            // ReferentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 853);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.pnlControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReferentForm";
            this.Text = "ReferentForm";
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlControls;
        private Button btnLogout;
        private Button btnTollPayment;
        private Label lblRole;
        private Label lblName;
        private PictureBox pbUser;
        private Panel pnlView;
        private Button btnReportMalfunction;
        private Button btnEntrance;
    }
}