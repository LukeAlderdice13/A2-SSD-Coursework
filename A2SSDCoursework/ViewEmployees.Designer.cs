namespace A2SSDCoursework
{
    partial class ViewEmployees
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Employees_lbl = new System.Windows.Forms.Label();
            this.Employees_pnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 5);
            this.panel1.TabIndex = 3;
            // 
            // Employees_lbl
            // 
            this.Employees_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees_lbl.Location = new System.Drawing.Point(0, 0);
            this.Employees_lbl.Name = "Employees_lbl";
            this.Employees_lbl.Size = new System.Drawing.Size(950, 76);
            this.Employees_lbl.TabIndex = 2;
            this.Employees_lbl.Text = "Employees";
            this.Employees_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Employees_pnl
            // 
            this.Employees_pnl.AutoScroll = true;
            this.Employees_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Employees_pnl.Location = new System.Drawing.Point(0, 79);
            this.Employees_pnl.Name = "Employees_pnl";
            this.Employees_pnl.Size = new System.Drawing.Size(950, 621);
            this.Employees_pnl.TabIndex = 4;
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Employees_pnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Employees_lbl);
            this.Name = "ViewEmployees";
            this.Size = new System.Drawing.Size(950, 700);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Employees_lbl;
        private System.Windows.Forms.Panel Employees_pnl;
    }
}
