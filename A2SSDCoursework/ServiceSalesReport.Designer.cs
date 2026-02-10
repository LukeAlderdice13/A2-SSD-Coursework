namespace A2SSDCoursework
{
    partial class ServiceSalesReport
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
            this.ServiceSales_rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Controls_pnl = new System.Windows.Forms.Panel();
            this.GenerateReport_btn = new System.Windows.Forms.Button();
            this.Employees_cb = new System.Windows.Forms.ComboBox();
            this.Employee_lbl = new System.Windows.Forms.Label();
            this.Makes_cb = new System.Windows.Forms.ComboBox();
            this.Make_lbl = new System.Windows.Forms.Label();
            this.Vehicles_cb = new System.Windows.Forms.ComboBox();
            this.Vehicle_lbl = new System.Windows.Forms.Label();
            this.Controls_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServiceSales_rv
            // 
            this.ServiceSales_rv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ServiceSales_rv.LocalReport.ReportEmbeddedResource = "A2SSDCoursework.ServiceSalesReport.rdlc";
            this.ServiceSales_rv.Location = new System.Drawing.Point(0, 76);
            this.ServiceSales_rv.Name = "ServiceSales_rv";
            this.ServiceSales_rv.ServerReport.BearerToken = null;
            this.ServiceSales_rv.Size = new System.Drawing.Size(1051, 567);
            this.ServiceSales_rv.TabIndex = 3;
            this.ServiceSales_rv.Load += new System.EventHandler(this.ServiceSales_rv_Load);
            // 
            // Controls_pnl
            // 
            this.Controls_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls_pnl.Controls.Add(this.GenerateReport_btn);
            this.Controls_pnl.Controls.Add(this.Employees_cb);
            this.Controls_pnl.Controls.Add(this.Employee_lbl);
            this.Controls_pnl.Controls.Add(this.Makes_cb);
            this.Controls_pnl.Controls.Add(this.Make_lbl);
            this.Controls_pnl.Controls.Add(this.Vehicles_cb);
            this.Controls_pnl.Controls.Add(this.Vehicle_lbl);
            this.Controls_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls_pnl.Location = new System.Drawing.Point(0, 0);
            this.Controls_pnl.Name = "Controls_pnl";
            this.Controls_pnl.Size = new System.Drawing.Size(1051, 76);
            this.Controls_pnl.TabIndex = 4;
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
            this.Employees_cb.Location = new System.Drawing.Point(530, 35);
            this.Employees_cb.Name = "Employees_cb";
            this.Employees_cb.Size = new System.Drawing.Size(311, 33);
            this.Employees_cb.TabIndex = 5;
            // 
            // Employee_lbl
            // 
            this.Employee_lbl.AutoSize = true;
            this.Employee_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_lbl.Location = new System.Drawing.Point(525, 3);
            this.Employee_lbl.Name = "Employee_lbl";
            this.Employee_lbl.Size = new System.Drawing.Size(122, 29);
            this.Employee_lbl.TabIndex = 4;
            this.Employee_lbl.Text = "Employee";
            // 
            // Makes_cb
            // 
            this.Makes_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Makes_cb.FormattingEnabled = true;
            this.Makes_cb.Location = new System.Drawing.Point(317, 35);
            this.Makes_cb.Name = "Makes_cb";
            this.Makes_cb.Size = new System.Drawing.Size(187, 33);
            this.Makes_cb.TabIndex = 3;
            // 
            // Make_lbl
            // 
            this.Make_lbl.AutoSize = true;
            this.Make_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Make_lbl.Location = new System.Drawing.Point(312, 3);
            this.Make_lbl.Name = "Make_lbl";
            this.Make_lbl.Size = new System.Drawing.Size(72, 29);
            this.Make_lbl.TabIndex = 2;
            this.Make_lbl.Text = "Make";
            // 
            // Vehicles_cb
            // 
            this.Vehicles_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehicles_cb.FormattingEnabled = true;
            this.Vehicles_cb.Location = new System.Drawing.Point(22, 36);
            this.Vehicles_cb.Name = "Vehicles_cb";
            this.Vehicles_cb.Size = new System.Drawing.Size(272, 33);
            this.Vehicles_cb.TabIndex = 1;
            // 
            // Vehicle_lbl
            // 
            this.Vehicle_lbl.AutoSize = true;
            this.Vehicle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehicle_lbl.Location = new System.Drawing.Point(17, 4);
            this.Vehicle_lbl.Name = "Vehicle_lbl";
            this.Vehicle_lbl.Size = new System.Drawing.Size(93, 29);
            this.Vehicle_lbl.TabIndex = 0;
            this.Vehicle_lbl.Text = "Vehicle";
            // 
            // ServiceSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Controls_pnl);
            this.Controls.Add(this.ServiceSales_rv);
            this.Name = "ServiceSalesReport";
            this.Size = new System.Drawing.Size(1051, 643);
            this.Controls_pnl.ResumeLayout(false);
            this.Controls_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ServiceSales_rv;
        private System.Windows.Forms.Panel Controls_pnl;
        private System.Windows.Forms.Label Vehicle_lbl;
        private System.Windows.Forms.ComboBox Vehicles_cb;
        private System.Windows.Forms.ComboBox Makes_cb;
        private System.Windows.Forms.Label Make_lbl;
        private System.Windows.Forms.ComboBox Employees_cb;
        private System.Windows.Forms.Label Employee_lbl;
        private System.Windows.Forms.Button GenerateReport_btn;
    }
}
