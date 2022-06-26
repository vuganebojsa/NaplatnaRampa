
namespace TurnpikeGate.View.ReferentViews
{
    partial class EntranceTicketIssuingForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPlates = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEntry = new System.Windows.Forms.TextBox();
            this.platesTimer = new System.Windows.Forms.Timer(this.components);
            this.tbSuccess = new System.Windows.Forms.TextBox();
            this.issuingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(209, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tablice";
            // 
            // tbPlates
            // 
            this.tbPlates.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPlates.Location = new System.Drawing.Point(481, 185);
            this.tbPlates.Name = "tbPlates";
            this.tbPlates.Size = new System.Drawing.Size(397, 42);
            this.tbPlates.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(517, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 50);
            this.label3.TabIndex = 11;
            this.label3.Text = "IZDAVANJE TIKETA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(209, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "MESTO ULASKA";
            // 
            // tbEntry
            // 
            this.tbEntry.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEntry.Location = new System.Drawing.Point(481, 268);
            this.tbEntry.Name = "tbEntry";
            this.tbEntry.Size = new System.Drawing.Size(397, 42);
            this.tbEntry.TabIndex = 13;
            // 
            // platesTimer
            // 
            this.platesTimer.Tick += new System.EventHandler(this.platesTimer_Tick_1);
            // 
            // tbSuccess
            // 
            this.tbSuccess.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSuccess.Location = new System.Drawing.Point(209, 452);
            this.tbSuccess.Name = "tbSuccess";
            this.tbSuccess.Size = new System.Drawing.Size(669, 42);
            this.tbSuccess.TabIndex = 14;
            // 
            // issuingTimer
            // 
            this.issuingTimer.Tick += new System.EventHandler(this.issuingTimer_Tick);
            // 
            // EntranceTicketIssuingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1076, 672);
            this.Controls.Add(this.tbSuccess);
            this.Controls.Add(this.tbEntry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPlates);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntranceTicketIssuingForm";
            this.Text = "EntranceTicketIssuingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox tbPlates;
        private Label label3;
        private Label label4;
        private TextBox tbEntry;
        private System.Windows.Forms.Timer platesTimer;
        private TextBox tbSuccess;
        private System.Windows.Forms.Timer issuingTimer;
    }
}