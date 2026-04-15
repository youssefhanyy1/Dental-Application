namespace Dental_Application
{
    partial class DayCellcs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDayNumber = new System.Windows.Forms.Label();
            this.flpEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDayNumber
            // 
            this.lblDayNumber.AutoSize = true;
            this.lblDayNumber.Font = new System.Drawing.Font("Matura MT Script Capitals", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayNumber.Location = new System.Drawing.Point(4, 3);
            this.lblDayNumber.Name = "lblDayNumber";
            this.lblDayNumber.Size = new System.Drawing.Size(29, 20);
            this.lblDayNumber.TabIndex = 0;
            this.lblDayNumber.Text = "00";
            this.lblDayNumber.Click += new System.EventHandler(this.lblDayNumber_Click);
            // 
            // flpEvents
            // 
            this.flpEvents.Location = new System.Drawing.Point(3, 22);
            this.flpEvents.Name = "flpEvents";
            this.flpEvents.Size = new System.Drawing.Size(149, 75);
            this.flpEvents.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.flpEvents);
            this.guna2Panel1.Controls.Add(this.lblDayNumber);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(155, 100);
            this.guna2Panel1.TabIndex = 4;
            // 
            // DayCellcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "DayCellcs";
            this.Size = new System.Drawing.Size(155, 100);
            this.Load += new System.EventHandler(this.DayCellcs_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDayNumber;
        private System.Windows.Forms.FlowLayoutPanel flpEvents;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
