namespace A2SSDCoursework
{
    partial class IndividualSalesReport
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
            this.EmployeeReport_rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Controls_pnl = new System.Windows.Forms.Panel();
            this.GenerateReport_btn = new System.Windows.Forms.Button();
            this.SalesType_cb = new System.Windows.Forms.ComboBox();
            this.SaleType_lbl = new System.Windows.Forms.Label();
            this.Controls_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeReport_rv
            // 
            this.EmployeeReport_rv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EmployeeReport_rv.LocalReport.ReportEmbeddedResource = "A2SSDCoursework.IndividualEmployeeReport.rdlc";
            this.EmployeeReport_rv.Location = new System.Drawing.Point(0, 75);
            this.EmployeeReport_rv.Name = "EmployeeReport_rv";
            this.EmployeeReport_rv.ServerReport.BearerToken = null;
            this.EmployeeReport_rv.Size = new System.Drawing.Size(1051, 625);
            this.EmployeeReport_rv.TabIndex = 0;
            this.EmployeeReport_rv.Tag = "Employee Sales Info";
            this.EmployeeReport_rv.Load += new System.EventHandler(this.EmployeeReport_rv_Load);
            // 
            // Controls_pnl
            // 
            this.Controls_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls_pnl.Controls.Add(this.GenerateReport_btn);
            this.Controls_pnl.Controls.Add(this.SalesType_cb);
            this.Controls_pnl.Controls.Add(this.SaleType_lbl);
            this.Controls_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls_pnl.Location = new System.Drawing.Point(0, 0);
            this.Controls_pnl.Name = "Controls_pnl";
            this.Controls_pnl.Size = new System.Drawing.Size(1051, 75);
            this.Controls_pnl.TabIndex = 6;
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
            // SalesType_cb
            // 
            this.SalesType_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesType_cb.FormattingEnabled = true;
            this.SalesType_cb.Items.AddRange(new object[] {
            "All",
            "Vehicle Sale",
            "Service"});
            this.SalesType_cb.Location = new System.Drawing.Point(14, 35);
            this.SalesType_cb.Name = "SalesType_cb";
            this.SalesType_cb.Size = new System.Drawing.Size(311, 33);
            this.SalesType_cb.TabIndex = 5;
            // 
            // SaleType_lbl
            // 
            this.SaleType_lbl.AutoSize = true;
            this.SaleType_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleType_lbl.Location = new System.Drawing.Point(9, 3);
            this.SaleType_lbl.Name = "SaleType_lbl";
            this.SaleType_lbl.Size = new System.Drawing.Size(135, 29);
            this.SaleType_lbl.TabIndex = 4;
            this.SaleType_lbl.Text = "Sales Type";
            // 
            // IndividualSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Controls_pnl);
            this.Controls.Add(this.EmployeeReport_rv);
            this.Name = "IndividualSalesReport";
            this.Size = new System.Drawing.Size(1051, 700);
            this.Tag = "Employee Sales Info";
            this.Controls_pnl.ResumeLayout(false);
            this.Controls_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer EmployeeReport_rv;
        private System.Windows.Forms.Panel Controls_pnl;
        private System.Windows.Forms.Button GenerateReport_btn;
        private System.Windows.Forms.ComboBox SalesType_cb;
        private System.Windows.Forms.Label SaleType_lbl;
    }
}
