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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitTicketIssuingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEntranceTime = new System.Windows.Forms.TextBox();
            this.tbEntranceStation = new System.Windows.Forms.TextBox();
            this.tbPlates = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbRSD = new System.Windows.Forms.RadioButton();
            this.rbEUR = new System.Windows.Forms.RadioButton();
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
            this.pbCarWithTrailer = new System.Windows.Forms.PictureBox();
            this.pbMotorcycle = new System.Windows.Forms.PictureBox();
            this.pbMinivan = new System.Windows.Forms.PictureBox();
            this.pbTruck = new System.Windows.Forms.PictureBox();
            this.pbBus = new System.Windows.Forms.PictureBox();
            this.pbCar = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.vehiclesTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarWithTrailer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotorcycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinivan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTruck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(158, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAPLATA PUTARINE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tablice vozila:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mesto ulaska:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vreme ulaska:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(22, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mesto izlaska:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbEntranceTime);
            this.groupBox1.Controls.Add(this.tbEntranceStation);
            this.groupBox1.Controls.Add(this.tbPlates);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(29, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(545, 210);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ulazni Tiket";
            // 
            // tbEntranceTime
            // 
            this.tbEntranceTime.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEntranceTime.Location = new System.Drawing.Point(181, 152);
            this.tbEntranceTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEntranceTime.Name = "tbEntranceTime";
            this.tbEntranceTime.Size = new System.Drawing.Size(331, 32);
            this.tbEntranceTime.TabIndex = 8;
            // 
            // tbEntranceStation
            // 
            this.tbEntranceStation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEntranceStation.Location = new System.Drawing.Point(181, 97);
            this.tbEntranceStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEntranceStation.Name = "tbEntranceStation";
            this.tbEntranceStation.Size = new System.Drawing.Size(331, 32);
            this.tbEntranceStation.TabIndex = 7;
            // 
            // tbPlates
            // 
            this.tbPlates.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPlates.Location = new System.Drawing.Point(181, 44);
            this.tbPlates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPlates.Name = "tbPlates";
            this.tbPlates.Size = new System.Drawing.Size(331, 32);
            this.tbPlates.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(22, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Vreme izlaska:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(70, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Za uplatu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(70, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Preuzet iznos:";
            // 
            // rbRSD
            // 
            this.rbRSD.AutoSize = true;
            this.rbRSD.Checked = true;
            this.rbRSD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbRSD.Location = new System.Drawing.Point(230, 141);
            this.rbRSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRSD.Name = "rbRSD";
            this.rbRSD.Size = new System.Drawing.Size(64, 29);
            this.rbRSD.TabIndex = 10;
            this.rbRSD.TabStop = true;
            this.rbRSD.Text = "RSD";
            this.rbRSD.UseVisualStyleBackColor = true;
            // 
            // rbEUR
            // 
            this.rbEUR.AutoSize = true;
            this.rbEUR.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEUR.Location = new System.Drawing.Point(314, 141);
            this.rbEUR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbEUR.Name = "rbEUR";
            this.rbEUR.Size = new System.Drawing.Size(64, 29);
            this.rbEUR.TabIndex = 11;
            this.rbEUR.Text = "EUR";
            this.rbEUR.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(75, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Valuta:";
            // 
            // tbExitStation
            // 
            this.tbExitStation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbExitStation.Location = new System.Drawing.Point(181, 46);
            this.tbExitStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbExitStation.Name = "tbExitStation";
            this.tbExitStation.Size = new System.Drawing.Size(331, 32);
            this.tbExitStation.TabIndex = 14;
            // 
            // tbExitTime
            // 
            this.tbExitTime.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbExitTime.Location = new System.Drawing.Point(181, 100);
            this.tbExitTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbExitTime.Name = "tbExitTime";
            this.tbExitTime.Size = new System.Drawing.Size(331, 32);
            this.tbExitTime.TabIndex = 15;
            // 
            // tbTollPrice
            // 
            this.tbTollPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTollPrice.Location = new System.Drawing.Point(229, 37);
            this.tbTollPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTollPrice.Name = "tbTollPrice";
            this.tbTollPrice.Size = new System.Drawing.Size(235, 32);
            this.tbTollPrice.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(75, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Kusur:";
            // 
            // tbSumReceived
            // 
            this.tbSumReceived.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSumReceived.Location = new System.Drawing.Point(229, 90);
            this.tbSumReceived.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSumReceived.Name = "tbSumReceived";
            this.tbSumReceived.Size = new System.Drawing.Size(235, 32);
            this.tbSumReceived.TabIndex = 18;
            this.tbSumReceived.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbReceivedSum_keyDown);
            // 
            // tbChange
            // 
            this.tbChange.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbChange.Location = new System.Drawing.Point(229, 192);
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
            this.groupBox2.Location = new System.Drawing.Point(29, 308);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(545, 166);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Za unos";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.Location = new System.Drawing.Point(178, 515);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(222, 62);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.Text = "STAMPAJ TIKET";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbTollPrice);
            this.groupBox3.Controls.Add(this.rbEUR);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.rbRSD);
            this.groupBox3.Controls.Add(this.tbSumReceived);
            this.groupBox3.Controls.Add(this.tbChange);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(606, 369);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(508, 242);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Uplata";
            // 
            // pbCarWithTrailer
            // 
            this.pbCarWithTrailer.Image = ((System.Drawing.Image)(resources.GetObject("pbCarWithTrailer.Image")));
            this.pbCarWithTrailer.Location = new System.Drawing.Point(927, 249);
            this.pbCarWithTrailer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCarWithTrailer.Name = "pbCarWithTrailer";
            this.pbCarWithTrailer.Size = new System.Drawing.Size(170, 76);
            this.pbCarWithTrailer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCarWithTrailer.TabIndex = 28;
            this.pbCarWithTrailer.TabStop = false;
            this.pbCarWithTrailer.Click += new System.EventHandler(this.pbCarWithTrailer_Click);
            // 
            // pbMotorcycle
            // 
            this.pbMotorcycle.Image = ((System.Drawing.Image)(resources.GetObject("pbMotorcycle.Image")));
            this.pbMotorcycle.Location = new System.Drawing.Point(927, 61);
            this.pbMotorcycle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMotorcycle.Name = "pbMotorcycle";
            this.pbMotorcycle.Size = new System.Drawing.Size(170, 84);
            this.pbMotorcycle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMotorcycle.TabIndex = 27;
            this.pbMotorcycle.TabStop = false;
            this.pbMotorcycle.Click += new System.EventHandler(this.pbMotorcycle_Click);
            // 
            // pbMinivan
            // 
            this.pbMinivan.Image = ((System.Drawing.Image)(resources.GetObject("pbMinivan.Image")));
            this.pbMinivan.Location = new System.Drawing.Point(735, 249);
            this.pbMinivan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMinivan.Name = "pbMinivan";
            this.pbMinivan.Size = new System.Drawing.Size(167, 76);
            this.pbMinivan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinivan.TabIndex = 26;
            this.pbMinivan.TabStop = false;
            this.pbMinivan.Click += new System.EventHandler(this.pbMinivan_Click);
            // 
            // pbTruck
            // 
            this.pbTruck.Image = ((System.Drawing.Image)(resources.GetObject("pbTruck.Image")));
            this.pbTruck.Location = new System.Drawing.Point(927, 160);
            this.pbTruck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbTruck.Name = "pbTruck";
            this.pbTruck.Size = new System.Drawing.Size(170, 76);
            this.pbTruck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTruck.TabIndex = 25;
            this.pbTruck.TabStop = false;
            this.pbTruck.Click += new System.EventHandler(this.pbTruck_Click);
            // 
            // pbBus
            // 
            this.pbBus.Image = ((System.Drawing.Image)(resources.GetObject("pbBus.Image")));
            this.pbBus.Location = new System.Drawing.Point(735, 160);
            this.pbBus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBus.Name = "pbBus";
            this.pbBus.Size = new System.Drawing.Size(167, 76);
            this.pbBus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBus.TabIndex = 24;
            this.pbBus.TabStop = false;
            this.pbBus.Click += new System.EventHandler(this.pbBus_Click);
            // 
            // pbCar
            // 
            this.pbCar.BackColor = System.Drawing.SystemColors.Control;
            this.pbCar.Image = ((System.Drawing.Image)(resources.GetObject("pbCar.Image")));
            this.pbCar.Location = new System.Drawing.Point(735, 61);
            this.pbCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(167, 85);
            this.pbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar.TabIndex = 23;
            this.pbCar.TabStop = false;
            this.pbCar.Click += new System.EventHandler(this.pbCar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(5, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "Tip vozila:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(606, 34);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(508, 315);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            // 
            // ExitTicketIssuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 630);
            this.Controls.Add(this.pbCarWithTrailer);
            this.Controls.Add(this.pbMotorcycle);
            this.Controls.Add(this.pbMinivan);
            this.Controls.Add(this.pbTruck);
            this.Controls.Add(this.pbBus);
            this.Controls.Add(this.pbCar);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExitTicketIssuingForm";
            this.Text = "ExitTicketIssuingForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarWithTrailer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotorcycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinivan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTruck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox tbPlates;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label7;
        private Label label8;
        private Label label9;
        private RadioButton rbRSD;
        private RadioButton rbEUR;
        private Label label10;
        private TextBox tbEntranceTime;
        private TextBox tbEntranceStation;
        private TextBox tbExitStation;
        private TextBox tbExitTime;
        private TextBox tbTollPrice;
        private Label label11;
        private TextBox tbSumReceived;
        private TextBox tbChange;
        private GroupBox groupBox2;
        private Button btnConfirm;
        private GroupBox groupBox3;
        private PictureBox pbCarWithTrailer;
        private PictureBox pbMotorcycle;
        private PictureBox pbMinivan;
        private PictureBox pbTruck;
        private PictureBox pbBus;
        private PictureBox pbCar;
        private Label label12;
        private GroupBox groupBox4;
        private System.Windows.Forms.Timer vehiclesTimer;
    }
}