namespace TurnpikeGate.View.MainViews
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSecondSurvey = new System.Windows.Forms.Button();
            this.btnFirstSurvey = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pnlView = new System.Windows.Forms.Panel();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControls.Controls.Add(this.btnLogout);
            this.pnlControls.Controls.Add(this.btnSecondSurvey);
            this.pnlControls.Controls.Add(this.btnFirstSurvey);
            this.pnlControls.Controls.Add(this.lbName);
            this.pnlControls.Controls.Add(this.lbRole);
            this.pnlControls.Controls.Add(this.pbUser);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(250, 853);
            this.pnlControls.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(0, 781);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(248, 70);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "ODJAVA";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSecondSurvey
            // 
            this.btnSecondSurvey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecondSurvey.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSecondSurvey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondSurvey.Location = new System.Drawing.Point(0, 369);
            this.btnSecondSurvey.Name = "btnSecondSurvey";
            this.btnSecondSurvey.Size = new System.Drawing.Size(250, 70);
            this.btnSecondSurvey.TabIndex = 6;
            this.btnSecondSurvey.Text = "NAJOPTERECENIJA STANICA";
            this.btnSecondSurvey.UseVisualStyleBackColor = true;
            this.btnSecondSurvey.Click += new System.EventHandler(this.btnSecondSurvey_Click);
            // 
            // btnFirstSurvey
            // 
            this.btnFirstSurvey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstSurvey.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnFirstSurvey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstSurvey.Location = new System.Drawing.Point(0, 300);
            this.btnFirstSurvey.Name = "btnFirstSurvey";
            this.btnFirstSurvey.Size = new System.Drawing.Size(250, 70);
            this.btnFirstSurvey.TabIndex = 5;
            this.btnFirstSurvey.Text = "UKUPNI PRIHODI ZA ODREDJENI PERIOD";
            this.btnFirstSurvey.UseVisualStyleBackColor = true;
            this.btnFirstSurvey.Click += new System.EventHandler(this.btnFirstSurvey_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(50, 215);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(34, 20);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Ime";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbRole.Location = new System.Drawing.Point(50, 250);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(49, 20);
            this.lbRole.TabIndex = 2;
            this.lbRole.Text = "Uloga";
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
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(250, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1292, 853);
            this.pnlView.TabIndex = 1;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 853);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.pnlControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManagerForm";
            this.Text = "ManagerFormcs";
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlControls;
        private Panel pnlView;
        private PictureBox pbUser;
        private Label lbName;
        private Label lbRole;
        private Button btnLogout;
        private Button btnSecondSurvey;
        private Button btnFirstSurvey;
    }
}