namespace TurnpikeGate.View.ReferentViews
{
    partial class ExitTicketIssuingForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEntranceTime = new System.Windows.Forms.TextBox();
            this.tbEntranceStation = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbPlates = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.tbExitStation = new System.Windows.Forms.TextBox();
            this.tbExitTime = new System.Windows.Forms.TextBox();
            this.tbTollPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSumReceived = new System.Windows.Forms.TextBox();
            this.tbChange = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRaiseRamp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAPLATA PUTARINE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tablice vozila:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tip vozila:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(38, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mesto ulaska:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(38, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vreme ulaska:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(38, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mesto izlaska:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbEntranceTime);
            this.groupBox1.Controls.Add(this.tbEntranceStation);
            this.groupBox1.Controls.Add(this.tbType);
            this.groupBox1.Controls.Add(this.tbPlates);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(29, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(582, 267);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ulazni Tiket";
            // 
            // tbEntranceTime
            // 
            this.tbEntranceTime.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEntranceTime.Location = new System.Drawing.Point(197, 206);
            this.tbEntranceTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEntranceTime.Name = "tbEntranceTime";
            this.tbEntranceTime.Size = new System.Drawing.Size(316, 32);
            this.tbEntranceTime.TabIndex = 8;
            // 
            // tbEntranceStation
            // 
            this.tbEntranceStation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEntranceStation.Location = new System.Drawing.Point(197, 151);
            this.tbEntranceStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEntranceStation.Name = "tbEntranceStation";
            this.tbEntranceStation.Size = new System.Drawing.Size(316, 32);
            this.tbEntranceStation.TabIndex = 7;
            // 
            // tbType
            // 
            this.tbType.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbType.Location = new System.Drawing.Point(197, 97);
            this.tbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(316, 32);
            this.tbType.TabIndex = 6;
            // 
            // tbPlates
            // 
            this.tbPlates.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPlates.Location = new System.Drawing.Point(197, 44);
            this.tbPlates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPlates.Name = "tbPlates";
            this.tbPlates.Size = new System.Drawing.Size(316, 32);
            this.tbPlates.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(38, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Vreme izlaska:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(688, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Za uplatu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(688, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Preuzet iznos:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(848, 263);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 29);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "RSD";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(932, 263);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 29);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "EUR";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(693, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Valuta:";
            // 
            // tbExitStation
            // 
            this.tbExitStation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbExitStation.Location = new System.Drawing.Point(197, 47);
            this.tbExitStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbExitStation.Name = "tbExitStation";
            this.tbExitStation.Size = new System.Drawing.Size(316, 32);
            this.tbExitStation.TabIndex = 14;
            // 
            // tbExitTime
            // 
            this.tbExitTime.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbExitTime.Location = new System.Drawing.Point(197, 100);
            this.tbExitTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbExitTime.Name = "tbExitTime";
            this.tbExitTime.Size = new System.Drawing.Size(316, 32);
            this.tbExitTime.TabIndex = 15;
            // 
            // tbTollPrice
            // 
            this.tbTollPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTollPrice.Location = new System.Drawing.Point(847, 159);
            this.tbTollPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTollPrice.Name = "tbTollPrice";
            this.tbTollPrice.Size = new System.Drawing.Size(235, 32);
            this.tbTollPrice.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(693, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Kusur:";
            // 
            // tbSumReceived
            // 
            this.tbSumReceived.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSumReceived.Location = new System.Drawing.Point(847, 212);
            this.tbSumReceived.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSumReceived.Name = "tbSumReceived";
            this.tbSumReceived.Size = new System.Drawing.Size(235, 32);
            this.tbSumReceived.TabIndex = 18;
            // 
            // tbChange
            // 
            this.tbChange.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbChange.Location = new System.Drawing.Point(847, 314);
            this.tbChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbChange.Name = "tbChange";
            this.tbChange.Size = new System.Drawing.Size(235, 32);
            this.tbChange.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbExitTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbExitStation);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(29, 407);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(582, 171);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Za unos";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.Location = new System.Drawing.Point(646, 458);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(222, 62);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.Text = "STAMPAJ TIKET";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(646, 118);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(464, 267);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Uplata";
            // 
            // btnRaiseRamp
            // 
            this.btnRaiseRamp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRaiseRamp.Location = new System.Drawing.Point(888, 458);
            this.btnRaiseRamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRaiseRamp.Name = "btnRaiseRamp";
            this.btnRaiseRamp.Size = new System.Drawing.Size(222, 62);
            this.btnRaiseRamp.TabIndex = 23;
            this.btnRaiseRamp.Text = "PODIGNI RAMPU";
            this.btnRaiseRamp.UseVisualStyleBackColor = true;
            this.btnRaiseRamp.Click += new System.EventHandler(this.btnRaiseRamp_Click);
            // 
            // ExitTicketIssuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 630);
            this.Controls.Add(this.btnRaiseRamp);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbSumReceived);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.tbTollPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExitTicketIssuingForm";
            this.Text = "ExitTicketIssuingForm";
            this.Load += new System.EventHandler(this.ExitTicketIssuingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox tbPlates;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label7;
        private Label label8;
        private Label label9;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label10;
        private TextBox tbEntranceTime;
        private TextBox tbEntranceStation;
        private TextBox tbType;
        private TextBox tbExitStation;
        private TextBox tbExitTime;
        private TextBox tbTollPrice;
        private Label label11;
        private TextBox tbSumReceived;
        private TextBox tbChange;
        private GroupBox groupBox2;
        private Button btnConfirm;
        private GroupBox groupBox3;
        private Button btnRaiseRamp;
    }
}