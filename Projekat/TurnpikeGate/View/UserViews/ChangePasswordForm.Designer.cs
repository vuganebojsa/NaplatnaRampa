namespace TurnpikeGate.View.UserViews
{
    partial class ChangePasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbRepeatedPass = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(115, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izmenite inicijalnu lozinku koju Vam je dodelio admin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(167, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izmenom inicijalne lozinke aktivirate nalog za dalje korisenje.";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(253, 202);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.PlaceholderText = "nova lozinka";
            this.tbPassword.Size = new System.Drawing.Size(314, 27);
            this.tbPassword.TabIndex = 2;
            // 
            // tbRepeatedPass
            // 
            this.tbRepeatedPass.Location = new System.Drawing.Point(253, 254);
            this.tbRepeatedPass.Name = "tbRepeatedPass";
            this.tbRepeatedPass.PasswordChar = '*';
            this.tbRepeatedPass.PlaceholderText = "ponovite novu lozinku";
            this.tbRepeatedPass.Size = new System.Drawing.Size(314, 27);
            this.tbRepeatedPass.TabIndex = 3;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(363, 317);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 29);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Potvrdi";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbRepeatedPass);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbPassword;
        private TextBox tbRepeatedPass;
        private Button btnConfirm;
    }
}