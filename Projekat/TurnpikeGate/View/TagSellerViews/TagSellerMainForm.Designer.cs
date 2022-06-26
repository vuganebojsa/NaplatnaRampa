namespace TurnpikeGate.View.TagSellerViews
{
    partial class TagSellerMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagSellerMainForm));
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTags = new System.Windows.Forms.Button();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlView = new System.Windows.Forms.Panel();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.SystemColors.Control;
            this.pnlControls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlControls.BackgroundImage")));
            this.pnlControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlControls.Controls.Add(this.btnLogout);
            this.pnlControls.Controls.Add(this.btnTags);
            this.pnlControls.Controls.Add(this.lbRole);
            this.pnlControls.Controls.Add(this.lbName);
            this.pnlControls.Controls.Add(this.pictureBox1);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(201, 675);
            this.pnlControls.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(0, 619);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(201, 56);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "ODJAVA";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTags
            // 
            this.btnTags.BackColor = System.Drawing.Color.Transparent;
            this.btnTags.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTags.FlatAppearance.BorderSize = 0;
            this.btnTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTags.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTags.Location = new System.Drawing.Point(2, 302);
            this.btnTags.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTags.Name = "btnTags";
            this.btnTags.Size = new System.Drawing.Size(206, 56);
            this.btnTags.TabIndex = 4;
            this.btnTags.Text = "TAGOVI";
            this.btnTags.UseVisualStyleBackColor = false;
            this.btnTags.Click += new System.EventHandler(this.btnTags_Click);
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.BackColor = System.Drawing.Color.Transparent;
            this.lbRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRole.Location = new System.Drawing.Point(40, 220);
            this.lbRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(59, 23);
            this.lbRole.TabIndex = 2;
            this.lbRole.Text = "label2";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(40, 182);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(40, 23);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "ime";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(40, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlView
            // 
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(201, 0);
            this.pnlView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1069, 675);
            this.pnlView.TabIndex = 1;
            // 
            // TagSellerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 675);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.pnlControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "TagSellerMainForm";
            this.Text = "TagSellerMainForm";
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlControls;
        private Panel pnlView;
        private Button btnLogout;
        private Button btnTags;
        private Label lbRole;
        private Label lbName;
        private PictureBox pictureBox1;
    }
}