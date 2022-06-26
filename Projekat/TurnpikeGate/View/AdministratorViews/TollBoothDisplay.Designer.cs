
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollStationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rampId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trafficLightId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cameraId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooths)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooths
            // 
            this.dgvBooths.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.tollStationId,
            this.rampId,
            this.trafficLightId,
            this.cameraId});
            this.dgvBooths.Location = new System.Drawing.Point(20, 16);
            this.dgvBooths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBooths.Name = "dgvBooths";
            this.dgvBooths.RowHeadersWidth = 51;
            this.dgvBooths.RowTemplate.Height = 29;
            this.dgvBooths.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooths.Size = new System.Drawing.Size(897, 392);
            this.dgvBooths.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(414, 434);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 58);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "DODAJ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(605, 434);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 58);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "IZMENI";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(766, 434);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 58);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "OBRISI";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // type
            // 
            this.type.HeaderText = "Tip naplate";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // tollStationId
            // 
            this.tollStationId.HeaderText = "Stanica";
            this.tollStationId.MinimumWidth = 6;
            this.tollStationId.Name = "tollStationId";
            this.tollStationId.ReadOnly = true;
            // 
            // rampId
            // 
            this.rampId.HeaderText = "Rampa";
            this.rampId.MinimumWidth = 6;
            this.rampId.Name = "rampId";
            this.rampId.ReadOnly = true;
            // 
            // trafficLightId
            // 
            this.trafficLightId.HeaderText = "Semafor";
            this.trafficLightId.MinimumWidth = 6;
            this.trafficLightId.Name = "trafficLightId";
            this.trafficLightId.ReadOnly = true;
            // 
            // cameraId
            // 
            this.cameraId.HeaderText = "Kamera";
            this.cameraId.MinimumWidth = 6;
            this.cameraId.Name = "cameraId";
            this.cameraId.ReadOnly = true;
            // 
            // TollBoothDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 527);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvBooths);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TollBoothDisplay";
            this.Text = "TollBoothDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooths)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvBooths;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn tollStationId;
        private DataGridViewTextBoxColumn rampId;
        private DataGridViewTextBoxColumn trafficLightId;
        private DataGridViewTextBoxColumn cameraId;
    }
}