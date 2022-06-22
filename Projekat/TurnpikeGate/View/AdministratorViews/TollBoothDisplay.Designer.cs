
namespace TurnpikeGate.View.AdministratorViews
{
    partial class TollBoothDisplay
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
            this.dgvBooths = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollStationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rampId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semphoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cameraId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooths)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooths
            // 
            this.dgvBooths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.tollStationId,
            this.rampId,
            this.semphoreId,
            this.cameraId});
            this.dgvBooths.Location = new System.Drawing.Point(23, 22);
            this.dgvBooths.Name = "dgvBooths";
            this.dgvBooths.RowHeadersWidth = 51;
            this.dgvBooths.RowTemplate.Height = 29;
            this.dgvBooths.Size = new System.Drawing.Size(1029, 609);
            this.dgvBooths.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(461, 646);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "DODAJ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // type
            // 
            this.type.HeaderText = "Tip naplate";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 125;
            // 
            // tollStationId
            // 
            this.tollStationId.HeaderText = "Stanica";
            this.tollStationId.MinimumWidth = 6;
            this.tollStationId.Name = "tollStationId";
            this.tollStationId.ReadOnly = true;
            this.tollStationId.Width = 125;
            // 
            // rampId
            // 
            this.rampId.HeaderText = "Rampa";
            this.rampId.MinimumWidth = 6;
            this.rampId.Name = "rampId";
            this.rampId.ReadOnly = true;
            this.rampId.Width = 125;
            // 
            // semphoreId
            // 
            this.semphoreId.HeaderText = "Semafor";
            this.semphoreId.MinimumWidth = 6;
            this.semphoreId.Name = "semphoreId";
            this.semphoreId.ReadOnly = true;
            this.semphoreId.Width = 125;
            // 
            // cameraId
            // 
            this.cameraId.HeaderText = "Kamera";
            this.cameraId.MinimumWidth = 6;
            this.cameraId.Name = "cameraId";
            this.cameraId.ReadOnly = true;
            this.cameraId.Width = 125;
            // 
            // TollBoothDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvBooths);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TollBoothDisplay";
            this.Text = "TollBoothDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooths)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvBooths;
        private Button btnAdd;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn tollStationId;
        private DataGridViewTextBoxColumn rampId;
        private DataGridViewTextBoxColumn semphoreId;
        private DataGridViewTextBoxColumn cameraId;
    }
}