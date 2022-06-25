
namespace TurnpikeGate.View.ManagerViews
{
    partial class IncomeReportForm
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
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeRSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timesVisited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIncomeRsd = new System.Windows.Forms.Label();
            this.lblIncomeEur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPeriod
            // 
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Location = new System.Drawing.Point(534, 773);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(261, 28);
            this.cbPeriod.TabIndex = 6;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(832, 770);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(178, 33);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "PRIKAZI PRIHODE";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.station,
            this.incomeRSD,
            this.incomeEUR,
            this.timesVisited});
            this.dgvReport.Location = new System.Drawing.Point(33, 23);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 29;
            this.dgvReport.Size = new System.Drawing.Size(1233, 729);
            this.dgvReport.TabIndex = 4;
            // 
            // station
            // 
            this.station.HeaderText = "Naziv stanice";
            this.station.MinimumWidth = 6;
            this.station.Name = "station";
            this.station.ReadOnly = true;
            // 
            // incomeRSD
            // 
            this.incomeRSD.HeaderText = "Prihodi (RSD)";
            this.incomeRSD.MinimumWidth = 6;
            this.incomeRSD.Name = "incomeRSD";
            this.incomeRSD.ReadOnly = true;
            // 
            // incomeEUR
            // 
            this.incomeEUR.HeaderText = "Prihodi (EUR)";
            this.incomeEUR.MinimumWidth = 6;
            this.incomeEUR.Name = "incomeEUR";
            this.incomeEUR.ReadOnly = true;
            // 
            // timesVisited
            // 
            this.timesVisited.HeaderText = "Posecenost";
            this.timesVisited.MinimumWidth = 6;
            this.timesVisited.Name = "timesVisited";
            this.timesVisited.ReadOnly = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1043, 770);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(178, 33);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "STAMPAJ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 776);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "UKUPNI PRIHODI:";
            // 
            // lblIncomeRsd
            // 
            this.lblIncomeRsd.AutoSize = true;
            this.lblIncomeRsd.Location = new System.Drawing.Point(212, 776);
            this.lblIncomeRsd.Name = "lblIncomeRsd";
            this.lblIncomeRsd.Size = new System.Drawing.Size(47, 20);
            this.lblIncomeRsd.TabIndex = 9;
            this.lblIncomeRsd.Text = "(RSD)";
            // 
            // lblIncomeEur
            // 
            this.lblIncomeEur.AutoSize = true;
            this.lblIncomeEur.Location = new System.Drawing.Point(212, 802);
            this.lblIncomeEur.Name = "lblIncomeEur";
            this.lblIncomeEur.Size = new System.Drawing.Size(46, 20);
            this.lblIncomeEur.TabIndex = 10;
            this.lblIncomeEur.Text = "(EUR)";
            // 
            // IncomeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 840);
            this.Controls.Add(this.lblIncomeEur);
            this.Controls.Add(this.lblIncomeRsd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbPeriod);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgvReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IncomeReportForm";
            this.Text = "IncomeReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbPeriod;
        private Button btnShow;
        private DataGridView dgvReport;
        private Button btnPrint;
        private Label label1;
        private Label lblIncomeRsd;
        private Label lblIncomeEur;
        private DataGridViewTextBoxColumn station;
        private DataGridViewTextBoxColumn incomeRSD;
        private DataGridViewTextBoxColumn incomeEUR;
        private DataGridViewTextBoxColumn timesVisited;
    }
}