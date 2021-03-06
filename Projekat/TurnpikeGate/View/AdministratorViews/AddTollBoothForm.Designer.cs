
namespace TurnpikeGate.View.AdministratorViews
{
    partial class AddTollBoothForm
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
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.cbTrafficLights = new System.Windows.Forms.ComboBox();
            this.cbRamps = new System.Windows.Forms.ComboBox();
            this.cbStations = new System.Windows.Forms.ComboBox();
            this.cbCameras = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTypes
            // 
            this.cbTypes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Location = new System.Drawing.Point(211, 94);
            this.cbTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(200, 33);
            this.cbTypes.TabIndex = 0;
            // 
            // cbTrafficLights
            // 
            this.cbTrafficLights.AutoCompleteCustomSource.AddRange(new string[] {
            "ISPRAVNO",
            "NEISPRAVNO"});
            this.cbTrafficLights.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTrafficLights.FormattingEnabled = true;
            this.cbTrafficLights.Items.AddRange(new object[] {
            "ISPRAVNO",
            "NEISPRAVNO"});
            this.cbTrafficLights.Location = new System.Drawing.Point(211, 218);
            this.cbTrafficLights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTrafficLights.Name = "cbTrafficLights";
            this.cbTrafficLights.Size = new System.Drawing.Size(200, 33);
            this.cbTrafficLights.TabIndex = 1;
            // 
            // cbRamps
            // 
            this.cbRamps.AutoCompleteCustomSource.AddRange(new string[] {
            "ISPRAVNO",
            "NEISPRAVNO"});
            this.cbRamps.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRamps.FormattingEnabled = true;
            this.cbRamps.Items.AddRange(new object[] {
            "ISPRAVNO",
            "NEISPRAVNO"});
            this.cbRamps.Location = new System.Drawing.Point(211, 175);
            this.cbRamps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRamps.Name = "cbRamps";
            this.cbRamps.Size = new System.Drawing.Size(200, 33);
            this.cbRamps.TabIndex = 2;
            // 
            // cbStations
            // 
            this.cbStations.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStations.FormattingEnabled = true;
            this.cbStations.Location = new System.Drawing.Point(211, 136);
            this.cbStations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStations.Name = "cbStations";
            this.cbStations.Size = new System.Drawing.Size(200, 33);
            this.cbStations.TabIndex = 3;
            // 
            // cbCameras
            // 
            this.cbCameras.AutoCompleteCustomSource.AddRange(new string[] {
            "ISPRAVNO",
            "NEISPRAVNO"});
            this.cbCameras.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCameras.FormattingEnabled = true;
            this.cbCameras.Items.AddRange(new object[] {
            "ISPRAVNO",
            "NEISPRAVNO"});
            this.cbCameras.Location = new System.Drawing.Point(211, 262);
            this.cbCameras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCameras.Name = "cbCameras";
            this.cbCameras.Size = new System.Drawing.Size(200, 33);
            this.cbCameras.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(119, 330);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 47);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "DODAJ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tip naplate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stanica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(63, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rampa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(61, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Semafor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(61, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kamera";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(258, 330);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 47);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "NAZAD";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(155, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "TIP NAPLATE";
            // 
            // AddTollBoothForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 436);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbCameras);
            this.Controls.Add(this.cbStations);
            this.Controls.Add(this.cbRamps);
            this.Controls.Add(this.cbTrafficLights);
            this.Controls.Add(this.cbTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddTollBoothForm";
            this.Text = "AddTollBoothForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbTypes;
        private ComboBox cbTrafficLights;
        private ComboBox cbRamps;
        private ComboBox cbStations;
        private ComboBox cbCameras;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnBack;
        private Label label6;
    }
}