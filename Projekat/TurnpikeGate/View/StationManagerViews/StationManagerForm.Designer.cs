
namespace TurnpikeGate.View.StationManagerViews
{
    partial class StationManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationManagerForm));
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTollBooths = new System.Windows.Forms.Button();
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
            this.pnlControls.Controls.Add(this.btnTollBooths);
            this.pnlControls.Controls.Add(this.lbName);
            this.pnlControls.Controls.Add(this.lbRole);
            this.pnlControls.Controls.Add(this.pbUser);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(200, 640);
            this.pnlControls.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 586);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(198, 52);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "ODJAVA";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTollBooths
            // 
            this.btnTollBooths.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTollBooths.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTollBooths.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTollBooths.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTollBooths.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTollBooths.ForeColor = System.Drawing.Color.White;
            this.btnTollBooths.Location = new System.Drawing.Point(0, 271);
            this.btnTollBooths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTollBooths.Name = "btnTollBooths";
            this.btnTollBooths.Size = new System.Drawing.Size(200, 70);
            this.btnTollBooths.TabIndex = 6;
            this.btnTollBooths.Text = "NAPLATNA MESTA";
            this.btnTollBooths.UseVisualStyleBackColor = false;
            this.btnTollBooths.Click += new System.EventHandler(this.btnTollBooths_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(32, 169);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(31, 17);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Ime";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRole.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbRole.Location = new System.Drawing.Point(32, 196);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(44, 17);
            this.lbRole.TabIndex = 4;
            this.lbRole.Text = "Uloga";
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(32, 39);
            this.pbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(131, 112);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 1;
            this.pbUser.TabStop = false;
            // 
            // pnlView
            // 
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(200, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1149, 640);
            this.pnlView.TabIndex = 1;
            // 
            // StationManagerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1349, 640);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.pnlControls);
            this.Name = "StationManagerForm";
            this.Text = "StationManagerForm";
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
        private Button btnTollBooths;
        private Button btnLogout;
    }
}