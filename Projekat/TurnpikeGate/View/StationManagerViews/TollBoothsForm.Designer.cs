
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
            this.btnChange = new System.Windows.Forms.Button();
            this.stationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ramp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trafficLight = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvTollBooths.Location = new System.Drawing.Point(41, 58);
            this.dgvTollBooths.Name = "dgvTollBooths";
            this.dgvTollBooths.RowTemplate.Height = 25;
            this.dgvTollBooths.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTollBooths.Size = new System.Drawing.Size(1019, 347);
            this.dgvTollBooths.TabIndex = 0;
            // 
            // btnChange
            // 
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatAppearance.BorderSize = 2;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChange.Location = new System.Drawing.Point(839, 434);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(221, 73);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "IZMENI STANJE UREDJAJA";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // stationName
            // 
            this.stationName.HeaderText = "Naziv Stanice";
            this.stationName.Name = "stationName";
            // 
            // type
            // 
            this.type.HeaderText = "Tip";
            this.type.Name = "type";
            // 
            // ramp
            // 
            this.ramp.HeaderText = "Rampa";
            this.ramp.Name = "ramp";
            // 
            // camera
            // 
            this.camera.HeaderText = "Kamera";
            this.camera.Name = "camera";
            // 
            // trafficLight
            // 
            this.trafficLight.HeaderText = "Semafor";
            this.trafficLight.Name = "trafficLight";
            // 
            // TollBoothsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.dgvTollBooths);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TollBoothsForm";
            this.Text = "TollBoothsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTollBooths)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvTollBooths;
        private Button btnChange;
        private DataGridViewTextBoxColumn stationName;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn ramp;
        private DataGridViewTextBoxColumn camera;
        private DataGridViewTextBoxColumn trafficLight;
    }
}