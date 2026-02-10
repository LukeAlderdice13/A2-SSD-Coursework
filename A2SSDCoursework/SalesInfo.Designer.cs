namespace A2SSDCoursework
{
    partial class SalesInfo
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
            this.Reports_ms = new System.Windows.Forms.MenuStrip();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_pnl = new System.Windows.Forms.Panel();
            this.Reports_ms.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reports_ms
            // 
            this.Reports_ms.BackColor = System.Drawing.Color.Silver;
            this.Reports_ms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Reports_ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiclesToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.servicesToolStripMenuItem});
            this.Reports_ms.Location = new System.Drawing.Point(0, 0);
            this.Reports_ms.Name = "Reports_ms";
            this.Reports_ms.Size = new System.Drawing.Size(1051, 54);
            this.Reports_ms.TabIndex = 1;
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.Font = new System.Drawing.Font("Adobe Hebrew", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiclesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(159, 50);
            this.vehiclesToolStripMenuItem.Text = "Vehicles";
            this.vehiclesToolStripMenuItem.Click += new System.EventHandler(this.vehiclesToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Font = new System.Drawing.Font("Adobe Hebrew", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(197, 50);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Font = new System.Drawing.Font("Adobe Hebrew", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(158, 50);
            this.servicesToolStripMenuItem.Text = "Services";
            this.servicesToolStripMenuItem.Click += new System.EventHandler(this.servicesToolStripMenuItem_Click);
            // 
            // Report_pnl
            // 
            this.Report_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Report_pnl.Location = new System.Drawing.Point(0, 57);
            this.Report_pnl.Name = "Report_pnl";
            this.Report_pnl.Size = new System.Drawing.Size(1051, 643);
            this.Report_pnl.TabIndex = 2;
            // 
            // SalesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.Report_pnl);
            this.Controls.Add(this.Reports_ms);
            this.Name = "SalesInfo";
            this.Size = new System.Drawing.Size(1051, 700);
            this.Tag = "Sales Info";
            this.Load += new System.EventHandler(this.SalesInfo_Load);
            this.Reports_ms.ResumeLayout(false);
            this.Reports_ms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Reports_ms;
        private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.Panel Report_pnl;
    }
}
