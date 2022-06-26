
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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeRSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timesVisited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIncomeRsd = new System.Windows.Forms.Label();
            this.lblIncomeEur = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPeriod
            // 
            this.cbPeriod.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Location = new System.Drawing.Point(534, 773);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(261, 39);
            this.cbPeriod.TabIndex = 6;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 767);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "UKUPNI PRIHODI:";
            // 
            // lblIncomeRsd
            // 
            this.lblIncomeRsd.AutoSize = true;
            this.lblIncomeRsd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncomeRsd.Location = new System.Drawing.Point(272, 767);
            this.lblIncomeRsd.Name = "lblIncomeRsd";
            this.lblIncomeRsd.Size = new System.Drawing.Size(72, 32);
            this.lblIncomeRsd.TabIndex = 9;
            this.lblIncomeRsd.Text = "(RSD)";
            // 
            // lblIncomeEur
            // 
            this.lblIncomeEur.AutoSize = true;
            this.lblIncomeEur.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncomeEur.Location = new System.Drawing.Point(272, 799);
            this.lblIncomeEur.Name = "lblIncomeEur";
            this.lblIncomeEur.Size = new System.Drawing.Size(70, 32);
            this.lblIncomeEur.TabIndex = 10;
            this.lblIncomeEur.Text = "(EUR)";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1055, 773);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(178, 39);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "STAMPAJ";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShow.Location = new System.Drawing.Point(846, 773);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(178, 39);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "PRIKAZI";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // IncomeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 840);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblIncomeEur);
            this.Controls.Add(this.lblIncomeRsd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPeriod);
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
        private DataGridView dgvReport;
        private Label label1;
        private Label lblIncomeRsd;
        private Label lblIncomeEur;
        private DataGridViewTextBoxColumn station;
        private DataGridViewTextBoxColumn incomeRSD;
        private DataGridViewTextBoxColumn incomeEUR;
        private DataGridViewTextBoxColumn timesVisited;
        private Button btnPrint;
        private Button btnShow;
    }
}