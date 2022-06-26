
namespace TurnpikeGate.View.MainViews
{
    partial class BusiestStationReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusiestStationReportForm));
            this.btnPrint = new System.Windows.Forms.Button();
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblTickets = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIncomeEur = new System.Windows.Forms.Label();
            this.lblIncomeRsd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(821, 724);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(178, 33);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "STAMPAJ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cbPeriod
            // 
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Location = new System.Drawing.Point(312, 727);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(261, 28);
            this.cbPeriod.TabIndex = 15;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(610, 724);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(178, 33);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "PRIKAZI STANICU";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Location = new System.Drawing.Point(456, 396);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(0, 20);
            this.lblTickets.TabIndex = 32;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(456, 311);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(0, 20);
            this.lblPlace.TabIndex = 31;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(456, 222);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "PRODATO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "MESTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "NAZIV:";
            // 
            // lblIncomeEur
            // 
            this.lblIncomeEur.AutoSize = true;
            this.lblIncomeEur.Location = new System.Drawing.Point(456, 517);
            this.lblIncomeEur.Name = "lblIncomeEur";
            this.lblIncomeEur.Size = new System.Drawing.Size(46, 20);
            this.lblIncomeEur.TabIndex = 26;
            this.lblIncomeEur.Text = "(EUR)";
            // 
            // lblIncomeRsd
            // 
            this.lblIncomeRsd.AutoSize = true;
            this.lblIncomeRsd.Location = new System.Drawing.Point(456, 491);
            this.lblIncomeRsd.Name = "lblIncomeRsd";
            this.lblIncomeRsd.Size = new System.Drawing.Size(47, 20);
            this.lblIncomeRsd.TabIndex = 25;
            this.lblIncomeRsd.Text = "(RSD)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "UKUPNI PRIHODI:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(821, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // BusiestStationReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 840);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIncomeEur);
            this.Controls.Add(this.lblIncomeRsd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbPeriod);
            this.Controls.Add(this.btnShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusiestStationReportForm";
            this.Text = "BusiestStationReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPrint;
        private ComboBox cbPeriod;
        private Button btnShow;
        private Label lblTickets;
        private Label lblPlace;
        private Label lblName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblIncomeEur;
        private Label lblIncomeRsd;
        private Label label1;
        private PictureBox pictureBox1;
    }
}