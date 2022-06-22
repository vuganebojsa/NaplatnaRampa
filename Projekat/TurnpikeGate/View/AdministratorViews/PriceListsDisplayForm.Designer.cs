
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
            this.btnShow = new System.Windows.Forms.Button();
            this.cbPriceList = new System.Windows.Forms.ComboBox();
            this.vehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPriceList
            // 
            this.dgvPriceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPriceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleType,
            this.total,
            this.currency,
            this.departure,
            this.destination});
            this.dgvPriceList.Location = new System.Drawing.Point(30, 23);
            this.dgvPriceList.Name = "dgvPriceList";
            this.dgvPriceList.RowHeadersWidth = 51;
            this.dgvPriceList.RowTemplate.Height = 29;
            this.dgvPriceList.Size = new System.Drawing.Size(1019, 548);
            this.dgvPriceList.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(547, 612);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(154, 33);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "PRIKAZI CENE";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cbPriceList
            // 
            this.cbPriceList.FormattingEnabled = true;
            this.cbPriceList.Location = new System.Drawing.Point(317, 615);
            this.cbPriceList.Name = "cbPriceList";
            this.cbPriceList.Size = new System.Drawing.Size(178, 28);
            this.cbPriceList.TabIndex = 3;
            // 
            // vehicleType
            // 
            this.vehicleType.HeaderText = "Tip vozila";
            this.vehicleType.MinimumWidth = 6;
            this.vehicleType.Name = "vehicleType";
            this.vehicleType.ReadOnly = true;
            this.vehicleType.Width = 125;
            // 
            // total
            // 
            this.total.HeaderText = "Cena";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 125;
            // 
            // currency
            // 
            this.currency.HeaderText = "Valuta";
            this.currency.MinimumWidth = 6;
            this.currency.Name = "currency";
            this.currency.ReadOnly = true;
            this.currency.Width = 125;
            // 
            // departure
            // 
            this.departure.HeaderText = "Pocetna stanica";
            this.departure.MinimumWidth = 6;
            this.departure.Name = "departure";
            this.departure.ReadOnly = true;
            this.departure.Width = 125;
            // 
            // destination
            // 
            this.destination.HeaderText = "Krajnja stanica";
            this.destination.MinimumWidth = 6;
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            this.destination.Width = 125;
            // 
            // PriceListsDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.cbPriceList);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgvPriceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PriceListsDisplayForm";
            this.Text = "PriceListsDisplayForm";
            this.Load += new System.EventHandler(this.PriceListsDisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceList)).EndInit();
            this.ResumeLayout(false);

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
    }
}