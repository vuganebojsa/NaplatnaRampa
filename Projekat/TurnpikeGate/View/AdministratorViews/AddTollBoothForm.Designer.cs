
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTypes
            // 
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Location = new System.Drawing.Point(229, 52);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(151, 28);
            this.cbTypes.TabIndex = 0;
            // 
            // cbTrafficLights
            // 
            this.cbTrafficLights.FormattingEnabled = true;
            this.cbTrafficLights.Location = new System.Drawing.Point(229, 184);
            this.cbTrafficLights.Name = "cbTrafficLights";
            this.cbTrafficLights.Size = new System.Drawing.Size(151, 28);
            this.cbTrafficLights.TabIndex = 1;
            // 
            // cbRamps
            // 
            this.cbRamps.FormattingEnabled = true;
            this.cbRamps.Location = new System.Drawing.Point(229, 140);
            this.cbRamps.Name = "cbRamps";
            this.cbRamps.Size = new System.Drawing.Size(151, 28);
            this.cbRamps.TabIndex = 2;
            // 
            // cbStations
            // 
            this.cbStations.FormattingEnabled = true;
            this.cbStations.Location = new System.Drawing.Point(229, 95);
            this.cbStations.Name = "cbStations";
            this.cbStations.Size = new System.Drawing.Size(151, 28);
            this.cbStations.TabIndex = 3;
            // 
            // cbCameras
            // 
            this.cbCameras.FormattingEnabled = true;
            this.cbCameras.Location = new System.Drawing.Point(229, 227);
            this.cbCameras.Name = "cbCameras";
            this.cbCameras.Size = new System.Drawing.Size(151, 28);
            this.cbCameras.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tip naplate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stanica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rampa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Semafor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kamera";
            // 
            // AddTollBoothForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 354);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCameras);
            this.Controls.Add(this.cbStations);
            this.Controls.Add(this.cbRamps);
            this.Controls.Add(this.cbTrafficLights);
            this.Controls.Add(this.cbTypes);
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
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}