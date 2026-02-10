namespace A2SSDCoursework
{
    partial class EmployeeSalesReport
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
            this.EmployeeSales_rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Controls_pnl = new System.Windows.Forms.Panel();
            this.GenerateReport_btn = new System.Windows.Forms.Button();
            this.Employees_cb = new System.Windows.Forms.ComboBox();
            this.Employee_lbl = new System.Windows.Forms.Label();
            this.Statuses_cb = new System.Windows.Forms.ComboBox();
            this.Status_lbl = new System.Windows.Forms.Label();
            this.Controls_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeSales_rv
            // 
            this.EmployeeSales_rv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EmployeeSales_rv.LocalReport.ReportEmbeddedResource = "A2SSDCoursework.EmployeeSalesReport.rdlc";
            this.EmployeeSales_rv.Location = new System.Drawing.Point(0, 76);
            this.EmployeeSales_rv.Name = "EmployeeSales_rv";
            this.EmployeeSales_rv.ServerReport.BearerToken = null;
            this.EmployeeSales_rv.Size = new System.Drawing.Size(1051, 567);
            this.EmployeeSales_rv.TabIndex = 2;
            // 
            // Controls_pnl
            // 
            this.Controls_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls_pnl.Controls.Add(this.GenerateReport_btn);
            this.Controls_pnl.Controls.Add(this.Employees_cb);
            this.Controls_pnl.Controls.Add(this.Employee_lbl);
            this.Controls_pnl.Controls.Add(this.Statuses_cb);
            this.Controls_pnl.Controls.Add(this.Status_lbl);
            this.Controls_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls_pnl.Location = new System.Drawing.Point(0, 0);
            this.Controls_pnl.Name = "Controls_pnl";
            this.Controls_pnl.Size = new System.Drawing.Size(1051, 76);
            this.Controls_pnl.TabIndex = 5;
            // 
            // GenerateReport_btn
            // 
            this.GenerateReport_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.GenerateReport_btn.FlatAppearance.BorderSize = 0;
            this.GenerateReport_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateReport_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateReport_btn.ForeColor = System.Drawing.Color.White;
            this.GenerateReport_btn.Location = new System.Drawing.Point(870, 16);
            this.GenerateReport_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateReport_btn.Name = "GenerateReport_btn";
            this.GenerateReport_btn.Size = new System.Drawing.Size(160, 44);
            this.GenerateReport_btn.TabIndex = 37;
            this.GenerateReport_btn.Text = "Generate";
            this.GenerateReport_btn.UseVisualStyleBackColor = false;
            this.GenerateReport_btn.Click += new System.EventHandler(this.GenerateReport_btn_Click);
            // 
            // Employees_cb
            // 
            this.Employees_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees_cb.FormattingEnabled = true;
            this.Employees_cb.Location = new System.Drawing.Point(14, 35);
            this.Employees_cb.Name = "Employees_cb";
            this.Employees_cb.Size = new System.Drawing.Size(311, 33);
            this.Employees_cb.TabIndex = 5;
            // 
            // Employee_lbl
            // 
            this.Employee_lbl.AutoSize = true;
            this.Employee_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_lbl.Location = new System.Drawing.Point(9, 3);
            this.Employee_lbl.Name = "Employee_lbl";
            this.Employee_lbl.Size = new System.Drawing.Size(122, 29);
            this.Employee_lbl.TabIndex = 4;
            this.Employee_lbl.Text = "Employee";
            // 
            // Statuses_cb
            // 
            this.Statuses_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuses_cb.FormattingEnabled = true;
            this.Statuses_cb.Location = new System.Drawing.Point(355, 35);
            this.Statuses_cb.Name = "Statuses_cb";
            this.Statuses_cb.Size = new System.Drawing.Size(187, 33);
            this.Statuses_cb.TabIndex = 3;
            // 
            // Status_lbl
            // 
            this.Status_lbl.AutoSize = true;
            this.Status_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_lbl.Location = new System.Drawing.Point(350, 3);
            this.Status_lbl.Name = "Status_lbl";
            this.Status_lbl.Size = new System.Drawing.Size(79, 29);
            this.Status_lbl.TabIndex = 2;
            this.Status_lbl.Text = "Status";
            // 
            // EmployeeSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Controls_pnl);
            this.Controls.Add(this.EmployeeSales_rv);
            this.Name = "EmployeeSalesReport";
            this.Size = new System.Drawing.Size(1051, 643);
            this.Load += new System.EventHandler(this.EmployeeSalesReport_Load);
            this.Controls_pnl.ResumeLayout(false);
            this.Controls_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer EmployeeSales_rv;
        private System.Windows.Forms.Panel Controls_pnl;
        private System.Windows.Forms.Button GenerateReport_btn;
        private System.Windows.Forms.ComboBox Employees_cb;
        private System.Windows.Forms.Label Employee_lbl;
        private System.Windows.Forms.ComboBox Statuses_cb;
        private System.Windows.Forms.Label Status_lbl;
    }
}
