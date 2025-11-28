namespace A2SSDCoursework
{
    partial class AvailableVehicles
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
            this.Vehicles_pnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AvailableVehicles_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Vehicles_pnl
            // 
            this.Vehicles_pnl.AutoScroll = true;
            this.Vehicles_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Vehicles_pnl.Location = new System.Drawing.Point(0, 79);
            this.Vehicles_pnl.Name = "Vehicles_pnl";
            this.Vehicles_pnl.Size = new System.Drawing.Size(950, 621);
            this.Vehicles_pnl.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 5);
            this.panel1.TabIndex = 6;
            // 
            // AvailableVehicles_lbl
            // 
            this.AvailableVehicles_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableVehicles_lbl.Location = new System.Drawing.Point(0, 0);
            this.AvailableVehicles_lbl.Name = "AvailableVehicles_lbl";
            this.AvailableVehicles_lbl.Size = new System.Drawing.Size(950, 76);
            this.AvailableVehicles_lbl.TabIndex = 5;
            this.AvailableVehicles_lbl.Text = "Available Vehicles";
            this.AvailableVehicles_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvailableVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Vehicles_pnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AvailableVehicles_lbl);
            this.Name = "AvailableVehicles";
            this.Size = new System.Drawing.Size(950, 700);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Vehicles_pnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AvailableVehicles_lbl;
    }
}
