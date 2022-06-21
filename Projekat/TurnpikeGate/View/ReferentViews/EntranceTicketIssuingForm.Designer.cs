
namespace TurnpikeGate.View.ReferentViews
{
    partial class EntranceTicketIssuingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntranceTicketIssuingForm));
            this.pbCar = new System.Windows.Forms.PictureBox();
            this.pbBus = new System.Windows.Forms.PictureBox();
            this.pbTruck = new System.Windows.Forms.PictureBox();
            this.pbMinivan = new System.Windows.Forms.PictureBox();
            this.pbMotorcycle = new System.Windows.Forms.PictureBox();
            this.pbCarWithTrailer = new System.Windows.Forms.PictureBox();
            this.btnIssue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPlates = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEntry = new System.Windows.Forms.TextBox();
            this.platesTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTruck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinivan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotorcycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarWithTrailer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCar
            // 
            this.pbCar.BackColor = System.Drawing.SystemColors.Control;
            this.pbCar.Image = ((System.Drawing.Image)(resources.GetObject("pbCar.Image")));
            this.pbCar.Location = new System.Drawing.Point(383, 220);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(185, 102);
            this.pbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar.TabIndex = 1;
            this.pbCar.TabStop = false;
            this.pbCar.Click += new System.EventHandler(this.pbCar_Click);
            // 
            // pbBus
            // 
            this.pbBus.Image = ((System.Drawing.Image)(resources.GetObject("pbBus.Image")));
            this.pbBus.Location = new System.Drawing.Point(589, 220);
            this.pbBus.Name = "pbBus";
            this.pbBus.Size = new System.Drawing.Size(191, 102);
            this.pbBus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBus.TabIndex = 2;
            this.pbBus.TabStop = false;
            this.pbBus.Click += new System.EventHandler(this.pbBus_Click);
            // 
            // pbTruck
            // 
            this.pbTruck.Image = ((System.Drawing.Image)(resources.GetObject("pbTruck.Image")));
            this.pbTruck.Location = new System.Drawing.Point(808, 220);
            this.pbTruck.Name = "pbTruck";
            this.pbTruck.Size = new System.Drawing.Size(194, 102);
            this.pbTruck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTruck.TabIndex = 3;
            this.pbTruck.TabStop = false;
            this.pbTruck.Click += new System.EventHandler(this.pbTruck_Click);
            // 
            // pbMinivan
            // 
            this.pbMinivan.Image = ((System.Drawing.Image)(resources.GetObject("pbMinivan.Image")));
            this.pbMinivan.Location = new System.Drawing.Point(589, 339);
            this.pbMinivan.Name = "pbMinivan";
            this.pbMinivan.Size = new System.Drawing.Size(191, 101);
            this.pbMinivan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinivan.TabIndex = 4;
            this.pbMinivan.TabStop = false;
            this.pbMinivan.Click += new System.EventHandler(this.pbMinivan_Click);
            // 
            // pbMotorcycle
            // 
            this.pbMotorcycle.Image = ((System.Drawing.Image)(resources.GetObject("pbMotorcycle.Image")));
            this.pbMotorcycle.Location = new System.Drawing.Point(383, 339);
            this.pbMotorcycle.Name = "pbMotorcycle";
            this.pbMotorcycle.Size = new System.Drawing.Size(185, 101);
            this.pbMotorcycle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMotorcycle.TabIndex = 5;
            this.pbMotorcycle.TabStop = false;
            this.pbMotorcycle.Click += new System.EventHandler(this.pbMotorcycle_Click);
            // 
            // pbCarWithTrailer
            // 
            this.pbCarWithTrailer.Image = ((System.Drawing.Image)(resources.GetObject("pbCarWithTrailer.Image")));
            this.pbCarWithTrailer.Location = new System.Drawing.Point(808, 339);
            this.pbCarWithTrailer.Name = "pbCarWithTrailer";
            this.pbCarWithTrailer.Size = new System.Drawing.Size(194, 101);
            this.pbCarWithTrailer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCarWithTrailer.TabIndex = 6;
            this.pbCarWithTrailer.TabStop = false;
            this.pbCarWithTrailer.Click += new System.EventHandler(this.pbCarWithTrailer_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssue.FlatAppearance.BorderSize = 3;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIssue.Location = new System.Drawing.Point(745, 569);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(257, 91);
            this.btnIssue.TabIndex = 7;
            this.btnIssue.Text = "IZDAJ TIKET";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(111, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tablice";
            // 
            // tbPlates
            // 
            this.tbPlates.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPlates.Location = new System.Drawing.Point(383, 126);
            this.tbPlates.Name = "tbPlates";
            this.tbPlates.Size = new System.Drawing.Size(397, 35);
            this.tbPlates.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(111, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "IZABERITE TIP VOZILA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(419, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 40);
            this.label3.TabIndex = 11;
            this.label3.Text = "IZDAVANJE TIKETA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(111, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "MESTO ULASKA";
            // 
            // tbEntry
            // 
            this.tbEntry.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEntry.Location = new System.Drawing.Point(383, 479);
            this.tbEntry.Name = "tbEntry";
            this.tbEntry.Size = new System.Drawing.Size(397, 35);
            this.tbEntry.TabIndex = 13;
            // 
            // platesTimer
            // 
            this.platesTimer.Tick += new System.EventHandler(this.platesTimer_Tick_1);
            // 
            // EntranceTicketIssuingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1076, 672);
            this.Controls.Add(this.tbEntry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPlates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.pbCarWithTrailer);
            this.Controls.Add(this.pbMotorcycle);
            this.Controls.Add(this.pbMinivan);
            this.Controls.Add(this.pbTruck);
            this.Controls.Add(this.pbBus);
            this.Controls.Add(this.pbCar);
            this.Name = "EntranceTicketIssuingForm";
            this.Text = "EntranceTicketIssuingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTruck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinivan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotorcycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarWithTrailer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbCar;
        private PictureBox pbBus;
        private PictureBox pbTruck;
        private PictureBox pbMinivan;
        private PictureBox pbMotorcycle;
        private PictureBox pbCarWithTrailer;
        private Button btnIssue;
        private Label label1;
        private TextBox tbPlates;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbEntry;
        private System.Windows.Forms.Timer platesTimer;
    }
}