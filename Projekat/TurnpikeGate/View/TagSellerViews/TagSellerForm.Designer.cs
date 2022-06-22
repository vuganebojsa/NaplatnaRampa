namespace TurnpikeGate.View.TagSellerViews
{
    partial class TagSellerForm
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.btnAddFunds = new System.Windows.Forms.Button();
            this.chbAddFounds = new System.Windows.Forms.CheckBox();
            this.chbRegisterTag = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbID.Location = new System.Drawing.Point(131, 106);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(222, 35);
            this.tbID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(108, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dopuna Sredstava";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Taga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kolicina";
            // 
            // tbAmount
            // 
            this.tbAmount.Enabled = false;
            this.tbAmount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAmount.Location = new System.Drawing.Point(131, 169);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(222, 35);
            this.tbAmount.TabIndex = 4;
            // 
            // btnAddFunds
            // 
            this.btnAddFunds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFunds.Enabled = false;
            this.btnAddFunds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFunds.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddFunds.Location = new System.Drawing.Point(108, 297);
            this.btnAddFunds.Name = "btnAddFunds";
            this.btnAddFunds.Size = new System.Drawing.Size(257, 91);
            this.btnAddFunds.TabIndex = 8;
            this.btnAddFunds.Text = "Dodaj sredstva";
            this.btnAddFunds.UseVisualStyleBackColor = true;
            this.btnAddFunds.Click += new System.EventHandler(this.btnAddFunds_Click);
            // 
            // chbAddFounds
            // 
            this.chbAddFounds.AutoSize = true;
            this.chbAddFounds.Location = new System.Drawing.Point(88, 50);
            this.chbAddFounds.Name = "chbAddFounds";
            this.chbAddFounds.Size = new System.Drawing.Size(15, 14);
            this.chbAddFounds.TabIndex = 9;
            this.chbAddFounds.UseVisualStyleBackColor = true;
            this.chbAddFounds.CheckedChanged += new System.EventHandler(this.cbAddFounds_CheckedChanged);
            // 
            // chbRegisterTag
            // 
            this.chbRegisterTag.AutoSize = true;
            this.chbRegisterTag.Location = new System.Drawing.Point(112, 47);
            this.chbRegisterTag.Name = "chbRegisterTag";
            this.chbRegisterTag.Size = new System.Drawing.Size(15, 14);
            this.chbRegisterTag.TabIndex = 10;
            this.chbRegisterTag.UseVisualStyleBackColor = true;
            this.chbRegisterTag.CheckedChanged += new System.EventHandler(this.cbRegisterTag_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(140, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 40);
            this.label4.TabIndex = 11;
            this.label4.Text = "Izdavanje Taga";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbCurrency);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.cbType);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.chbRegisterTag);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(432, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 571);
            this.panel1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(71, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 30);
            this.label8.TabIndex = 17;
            this.label8.Text = "Valuta";
            // 
            // cbCurrency
            // 
            this.cbCurrency.Enabled = false;
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(76, 327);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(67, 23);
            this.cbCurrency.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(83, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(71, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Prezime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(76, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ime";
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Enabled = false;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Location = new System.Drawing.Point(151, 297);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(257, 91);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Izdavanje";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cbType
            // 
            this.cbType.Enabled = false;
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(169, 221);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(222, 38);
            this.cbType.TabIndex = 13;
            // 
            // tbLastName
            // 
            this.tbLastName.Enabled = false;
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLastName.Location = new System.Drawing.Point(169, 167);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(222, 35);
            this.tbLastName.TabIndex = 13;
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(169, 107);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(222, 35);
            this.tbName.TabIndex = 14;
            // 
            // TagSellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(902, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chbAddFounds);
            this.Controls.Add(this.btnAddFunds);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TagSellerForm";
            this.Text = "TagSellerForm";
            this.Load += new System.EventHandler(this.TagSellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbID;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbAmount;
        private Button btnAddFunds;
        private CheckBox chbAddFounds;
        private CheckBox chbRegisterTag;
        private Label label4;
        private Panel panel1;
        private TextBox tbLastName;
        private TextBox tbName;
        private ComboBox cbType;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnRegister;
        private Label label8;
        private ComboBox cbCurrency;
    }
}