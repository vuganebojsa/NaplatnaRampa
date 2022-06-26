
namespace TurnpikeGate.View.StationManagerViews
{
    partial class TollBoothsForm
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
            this.dgvTollBooths = new System.Windows.Forms.DataGridView();
            this.stationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ramp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trafficLight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTollBooths)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTollBooths
            // 
            this.dgvTollBooths.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTollBooths.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTollBooths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTollBooths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stationName,
            this.type,
            this.ramp,
            this.camera,
            this.trafficLight});
            this.dgvTollBooths.Location = new System.Drawing.Point(32, 85);
            this.dgvTollBooths.Name = "dgvTollBooths";
            this.dgvTollBooths.RowHeadersWidth = 51;
            this.dgvTollBooths.RowTemplate.Height = 25;
            this.dgvTollBooths.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTollBooths.Size = new System.Drawing.Size(1019, 347);
            this.dgvTollBooths.TabIndex = 0;
            // 
            // stationName
            // 
            this.stationName.HeaderText = "Naziv Stanice";
            this.stationName.MinimumWidth = 6;
            this.stationName.Name = "stationName";
            // 
            // type
            // 
            this.type.HeaderText = "Tip";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            // 
            // ramp
            // 
            this.ramp.HeaderText = "Rampa";
            this.ramp.MinimumWidth = 6;
            this.ramp.Name = "ramp";
            // 
            // camera
            // 
            this.camera.HeaderText = "Kamera";
            this.camera.MinimumWidth = 6;
            this.camera.Name = "camera";
            // 
            // trafficLight
            // 
            this.trafficLight.HeaderText = "Semafor";
            this.trafficLight.MinimumWidth = 6;
            this.trafficLight.Name = "trafficLight";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.SteelBlue;
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatAppearance.BorderSize = 2;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(720, 452);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(331, 52);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "IZMENI STANJE UREDJAJA";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(365, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "STANJA NAPLATNIH MESTA";
            // 
            // TollBoothsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.dgvTollBooths);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TollBoothsForm";
            this.Text = "TollBoothsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTollBooths)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvTollBooths;
        private Button btnChange;
        private DataGridViewTextBoxColumn stationName;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn ramp;
        private DataGridViewTextBoxColumn camera;
        private DataGridViewTextBoxColumn trafficLight;
        private Label label1;
    }
}