
namespace TurnpikeGate.View.AdministratorViews
{
    partial class PriceListsDisplayForm
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
            this.dgvPriceList = new System.Windows.Forms.DataGridView();
            this.vehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShow = new System.Windows.Forms.Button();
            this.cbPriceList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPriceList
            // 
            this.dgvPriceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPriceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPriceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleType,
            this.total,
            this.currency,
            this.departure,
            this.destination});
            this.dgvPriceList.Location = new System.Drawing.Point(54, 110);
            this.dgvPriceList.Name = "dgvPriceList";
            this.dgvPriceList.RowHeadersWidth = 51;
            this.dgvPriceList.RowTemplate.Height = 29;
            this.dgvPriceList.Size = new System.Drawing.Size(977, 359);
            this.dgvPriceList.TabIndex = 0;
            // 
            // vehicleType
            // 
            this.vehicleType.HeaderText = "Tip vozila";
            this.vehicleType.MinimumWidth = 6;
            this.vehicleType.Name = "vehicleType";
            this.vehicleType.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Cena";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // currency
            // 
            this.currency.HeaderText = "Valuta";
            this.currency.MinimumWidth = 6;
            this.currency.Name = "currency";
            this.currency.ReadOnly = true;
            // 
            // departure
            // 
            this.departure.HeaderText = "Pocetna stanica";
            this.departure.MinimumWidth = 6;
            this.departure.Name = "departure";
            this.departure.ReadOnly = true;
            // 
            // destination
            // 
            this.destination.HeaderText = "Krajnja stanica";
            this.destination.MinimumWidth = 6;
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SteelBlue;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(524, 501);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(218, 61);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "PRIKAZI CENE";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cbPriceList
            // 
            this.cbPriceList.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPriceList.FormattingEnabled = true;
            this.cbPriceList.Location = new System.Drawing.Point(304, 513);
            this.cbPriceList.Name = "cbPriceList";
            this.cbPriceList.Size = new System.Drawing.Size(178, 39);
            this.cbPriceList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(441, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "CENOVNIK";
            // 
            // PriceListsDisplayForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPriceList);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgvPriceList);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PriceListsDisplayForm";
            this.Text = "PriceListsDisplayForm";
            this.Load += new System.EventHandler(this.PriceListsDisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvPriceList;
        private Button btnShow;
        private ComboBox cbPriceList;
        private DataGridViewTextBoxColumn vehicleType;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn currency;
        private DataGridViewTextBoxColumn departure;
        private DataGridViewTextBoxColumn destination;
        private Label label1;
    }
}