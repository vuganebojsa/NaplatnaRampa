
namespace TurnpikeGate.View.ReferentViews
{
    partial class ReportMalfunctionForm
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
            this.lblCamera = new System.Windows.Forms.Label();
            this.btnReportCamera = new System.Windows.Forms.Button();
            this.btnReportTrafficLight = new System.Windows.Forms.Button();
            this.lblTrafficLight = new System.Windows.Forms.Label();
            this.btnRamp = new System.Windows.Forms.Button();
            this.lblRamp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Location = new System.Drawing.Point(426, 233);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(68, 20);
            this.lblCamera.TabIndex = 0;
            this.lblCamera.Text = "KAMERA";
            // 
            // btnReportCamera
            // 
            this.btnReportCamera.Location = new System.Drawing.Point(784, 229);
            this.btnReportCamera.Name = "btnReportCamera";
            this.btnReportCamera.Size = new System.Drawing.Size(94, 29);
            this.btnReportCamera.TabIndex = 1;
            this.btnReportCamera.Text = "PRIJAVI";
            this.btnReportCamera.UseVisualStyleBackColor = true;
            this.btnReportCamera.Click += new System.EventHandler(this.btnReportCamera_Click);
            // 
            // btnReportTrafficLight
            // 
            this.btnReportTrafficLight.Location = new System.Drawing.Point(784, 328);
            this.btnReportTrafficLight.Name = "btnReportTrafficLight";
            this.btnReportTrafficLight.Size = new System.Drawing.Size(94, 29);
            this.btnReportTrafficLight.TabIndex = 3;
            this.btnReportTrafficLight.Text = "PRIJAVI KVAR";
            this.btnReportTrafficLight.UseVisualStyleBackColor = true;
            this.btnReportTrafficLight.Click += new System.EventHandler(this.btnReportTrafficLight_Click);
            // 
            // lblTrafficLight
            // 
            this.lblTrafficLight.AutoSize = true;
            this.lblTrafficLight.Location = new System.Drawing.Point(426, 332);
            this.lblTrafficLight.Name = "lblTrafficLight";
            this.lblTrafficLight.Size = new System.Drawing.Size(75, 20);
            this.lblTrafficLight.TabIndex = 2;
            this.lblTrafficLight.Text = "SEMAFOR";
            // 
            // btnRamp
            // 
            this.btnRamp.Location = new System.Drawing.Point(784, 429);
            this.btnRamp.Name = "btnRamp";
            this.btnRamp.Size = new System.Drawing.Size(94, 29);
            this.btnRamp.TabIndex = 5;
            this.btnRamp.Text = "PRIJAVI";
            this.btnRamp.UseVisualStyleBackColor = true;
            this.btnRamp.Click += new System.EventHandler(this.btnRamp_Click);
            // 
            // lblRamp
            // 
            this.lblRamp.AutoSize = true;
            this.lblRamp.Location = new System.Drawing.Point(426, 433);
            this.lblRamp.Name = "lblRamp";
            this.lblRamp.Size = new System.Drawing.Size(58, 20);
            this.lblRamp.TabIndex = 4;
            this.lblRamp.Text = "RAMPA";
            // 
            // ReportMalfunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 793);
            this.Controls.Add(this.btnRamp);
            this.Controls.Add(this.lblRamp);
            this.Controls.Add(this.btnReportTrafficLight);
            this.Controls.Add(this.lblTrafficLight);
            this.Controls.Add(this.btnReportCamera);
            this.Controls.Add(this.lblCamera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportMalfunctionForm";
            this.Text = "ReportMalfunctionForm";
            this.Load += new System.EventHandler(this.ReportMalfunctionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCamera;
        private Button btnReportCamera;
        private Button btnReportTrafficLight;
        private Label lblTrafficLight;
        private Button btnRamp;
        private Label lblRamp;
    }
}