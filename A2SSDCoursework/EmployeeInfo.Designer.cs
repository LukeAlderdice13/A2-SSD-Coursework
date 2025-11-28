namespace A2SSDCoursework
{
    partial class EmployeeCard
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
            this.EmployeeName_lbl = new System.Windows.Forms.Label();
            this.JoinDate_lbl = new System.Windows.Forms.Label();
            this.Salary_lbl = new System.Windows.Forms.Label();
            this.Info_pnl = new System.Windows.Forms.Panel();
            this.ViewEmployee_btn = new System.Windows.Forms.Button();
            this.EmploymentStatus_lbl = new System.Windows.Forms.Label();
            this.Info_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeName_lbl
            // 
            this.EmployeeName_lbl.AutoEllipsis = true;
            this.EmployeeName_lbl.BackColor = System.Drawing.Color.DarkGray;
            this.EmployeeName_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeName_lbl.ForeColor = System.Drawing.Color.Black;
            this.EmployeeName_lbl.Location = new System.Drawing.Point(3, 4);
            this.EmployeeName_lbl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.EmployeeName_lbl.Name = "EmployeeName_lbl";
            this.EmployeeName_lbl.Size = new System.Drawing.Size(224, 46);
            this.EmployeeName_lbl.TabIndex = 0;
            this.EmployeeName_lbl.Text = "Luke Alderdice";
            this.EmployeeName_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JoinDate_lbl
            // 
            this.JoinDate_lbl.AutoEllipsis = true;
            this.JoinDate_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.JoinDate_lbl.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinDate_lbl.Location = new System.Drawing.Point(0, 0);
            this.JoinDate_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.JoinDate_lbl.Name = "JoinDate_lbl";
            this.JoinDate_lbl.Size = new System.Drawing.Size(224, 35);
            this.JoinDate_lbl.TabIndex = 1;
            this.JoinDate_lbl.Text = "Joined: 12/3/2023";
            this.JoinDate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Salary_lbl
            // 
            this.Salary_lbl.AutoEllipsis = true;
            this.Salary_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Salary_lbl.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary_lbl.Location = new System.Drawing.Point(0, 35);
            this.Salary_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Salary_lbl.Name = "Salary_lbl";
            this.Salary_lbl.Size = new System.Drawing.Size(224, 35);
            this.Salary_lbl.TabIndex = 2;
            this.Salary_lbl.Text = "Salary: £10000";
            this.Salary_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Info_pnl
            // 
            this.Info_pnl.BackColor = System.Drawing.Color.Silver;
            this.Info_pnl.Controls.Add(this.ViewEmployee_btn);
            this.Info_pnl.Controls.Add(this.EmploymentStatus_lbl);
            this.Info_pnl.Controls.Add(this.Salary_lbl);
            this.Info_pnl.Controls.Add(this.JoinDate_lbl);
            this.Info_pnl.Location = new System.Drawing.Point(3, 48);
            this.Info_pnl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Info_pnl.Name = "Info_pnl";
            this.Info_pnl.Size = new System.Drawing.Size(224, 158);
            this.Info_pnl.TabIndex = 3;
            this.Info_pnl.Enter += new System.EventHandler(this.Info_pnl_Enter);
            // 
            // ViewEmployee_btn
            // 
            this.ViewEmployee_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ViewEmployee_btn.FlatAppearance.BorderSize = 0;
            this.ViewEmployee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewEmployee_btn.Font = new System.Drawing.Font("Adobe Hebrew", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEmployee_btn.Location = new System.Drawing.Point(5, 106);
            this.ViewEmployee_btn.Name = "ViewEmployee_btn";
            this.ViewEmployee_btn.Size = new System.Drawing.Size(215, 47);
            this.ViewEmployee_btn.TabIndex = 4;
            this.ViewEmployee_btn.Text = "View Employee";
            this.ViewEmployee_btn.UseVisualStyleBackColor = false;
            this.ViewEmployee_btn.Click += new System.EventHandler(this.ViewEmployee_btn_Click);
            // 
            // EmploymentStatus_lbl
            // 
            this.EmploymentStatus_lbl.AutoEllipsis = true;
            this.EmploymentStatus_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmploymentStatus_lbl.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmploymentStatus_lbl.Location = new System.Drawing.Point(0, 70);
            this.EmploymentStatus_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EmploymentStatus_lbl.Name = "EmploymentStatus_lbl";
            this.EmploymentStatus_lbl.Size = new System.Drawing.Size(224, 35);
            this.EmploymentStatus_lbl.TabIndex = 3;
            this.EmploymentStatus_lbl.Text = "Status: Full Time";
            this.EmploymentStatus_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmployeeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.EmployeeName_lbl);
            this.Controls.Add(this.Info_pnl);
            this.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Name = "EmployeeCard";
            this.Size = new System.Drawing.Size(230, 210);
            this.Leave += new System.EventHandler(this.EmployeeCard_Leave);
            this.MouseEnter += new System.EventHandler(this.EmployeeCard_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.EmployeeCard_MouseLeave);
            this.Info_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EmployeeName_lbl;
        private System.Windows.Forms.Label JoinDate_lbl;
        private System.Windows.Forms.Label Salary_lbl;
        private System.Windows.Forms.Panel Info_pnl;
        private System.Windows.Forms.Label EmploymentStatus_lbl;
        private System.Windows.Forms.Button ViewEmployee_btn;
    }
}
