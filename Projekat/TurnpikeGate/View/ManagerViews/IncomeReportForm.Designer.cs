
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
            this.cbPeriod.Location = new System.Drawing.Point(467, 580);
            this.cbPeriod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(229, 33);
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
            this.dgvReport.Location = new System.Drawing.Point(29, 17);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 29;
            this.dgvReport.Size = new System.Drawing.Size(1079, 547);
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
            this.label1.Location = new System.Drawing.Point(43, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "UKUPNI PRIHODI:";
            // 
            // lblIncomeRsd
            // 
            this.lblIncomeRsd.AutoSize = true;
            this.lblIncomeRsd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncomeRsd.Location = new System.Drawing.Point(238, 575);
            this.lblIncomeRsd.Name = "lblIncomeRsd";
            this.lblIncomeRsd.Size = new System.Drawing.Size(58, 25);
            this.lblIncomeRsd.TabIndex = 9;
            this.lblIncomeRsd.Text = "(RSD)";
            // 
            // lblIncomeEur
            // 
            this.lblIncomeEur.AutoSize = true;
            this.lblIncomeEur.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncomeEur.Location = new System.Drawing.Point(238, 599);
            this.lblIncomeEur.Name = "lblIncomeEur";
            this.lblIncomeEur.Size = new System.Drawing.Size(58, 25);
            this.lblIncomeEur.TabIndex = 10;
            this.lblIncomeEur.Text = "(EUR)";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(917, 580);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(162, 39);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "STAMPAJ";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SteelBlue;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(740, 580);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(171, 39);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "PRIKAZI";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // IncomeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 630);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblIncomeEur);
            this.Controls.Add(this.lblIncomeRsd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPeriod);
            this.Controls.Add(this.dgvReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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