namespace A2SSDCoursework
{
    partial class SellVehicle
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
            this.Customers_cb = new System.Windows.Forms.ComboBox();
            this.Price_nud = new System.Windows.Forms.NumericUpDown();
            this.ViewCustomer_lbl = new System.Windows.Forms.Label();
            this.Customer_lbl = new System.Windows.Forms.Label();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.Date_dtp = new System.Windows.Forms.DateTimePicker();
            this.Date_lbl = new System.Windows.Forms.Label();
            this.Sell_btn = new System.Windows.Forms.Button();
            this.ViewEmployee_lbl = new System.Windows.Forms.Label();
            this.Employee_lbl = new System.Windows.Forms.Label();
            this.Employees_cb = new System.Windows.Forms.ComboBox();
            this.AddNewCustomer_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Price_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // Customers_cb
            // 
            this.Customers_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Customers_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers_cb.FormattingEnabled = true;
            this.Customers_cb.Location = new System.Drawing.Point(52, 47);
            this.Customers_cb.Name = "Customers_cb";
            this.Customers_cb.Size = new System.Drawing.Size(456, 39);
            this.Customers_cb.TabIndex = 0;
            this.Customers_cb.SelectedIndexChanged += new System.EventHandler(this.Customers_cb_SelectedIndexChanged);
            this.Customers_cb.VisibleChanged += new System.EventHandler(this.Customers_cb_VisibleChanged);
            // 
            // Price_nud
            // 
            this.Price_nud.DecimalPlaces = 2;
            this.Price_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_nud.Location = new System.Drawing.Point(52, 178);
            this.Price_nud.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Price_nud.Name = "Price_nud";
            this.Price_nud.Size = new System.Drawing.Size(456, 38);
            this.Price_nud.TabIndex = 1;
            this.Price_nud.ValueChanged += new System.EventHandler(this.Price_nud_ValueChanged);
            // 
            // ViewCustomer_lbl
            // 
            this.ViewCustomer_lbl.AutoEllipsis = true;
            this.ViewCustomer_lbl.AutoSize = true;
            this.ViewCustomer_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCustomer_lbl.Location = new System.Drawing.Point(48, 89);
            this.ViewCustomer_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.ViewCustomer_lbl.MaximumSize = new System.Drawing.Size(226, 60);
            this.ViewCustomer_lbl.Name = "ViewCustomer_lbl";
            this.ViewCustomer_lbl.Size = new System.Drawing.Size(145, 25);
            this.ViewCustomer_lbl.TabIndex = 75;
            this.ViewCustomer_lbl.Text = "View Customer";
            this.ViewCustomer_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewCustomer_lbl.Click += new System.EventHandler(this.ViewCustomer_lbl_Click);
            this.ViewCustomer_lbl.MouseEnter += new System.EventHandler(this.ViewCustomer_lbl_MouseEnter);
            this.ViewCustomer_lbl.MouseLeave += new System.EventHandler(this.ViewCustomer_lbl_MouseLeave);
            // 
            // Customer_lbl
            // 
            this.Customer_lbl.AutoEllipsis = true;
            this.Customer_lbl.AutoSize = true;
            this.Customer_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_lbl.Location = new System.Drawing.Point(47, 10);
            this.Customer_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Customer_lbl.MaximumSize = new System.Drawing.Size(226, 60);
            this.Customer_lbl.Name = "Customer_lbl";
            this.Customer_lbl.Size = new System.Drawing.Size(142, 36);
            this.Customer_lbl.TabIndex = 76;
            this.Customer_lbl.Text = "Customer";
            this.Customer_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoEllipsis = true;
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_lbl.Location = new System.Drawing.Point(47, 141);
            this.Price_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Price_lbl.MaximumSize = new System.Drawing.Size(226, 60);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(83, 36);
            this.Price_lbl.TabIndex = 77;
            this.Price_lbl.Text = "Price";
            this.Price_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Date_dtp
            // 
            this.Date_dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_dtp.Location = new System.Drawing.Point(566, 175);
            this.Date_dtp.Name = "Date_dtp";
            this.Date_dtp.Size = new System.Drawing.Size(445, 38);
            this.Date_dtp.TabIndex = 79;
            // 
            // Date_lbl
            // 
            this.Date_lbl.AutoEllipsis = true;
            this.Date_lbl.AutoSize = true;
            this.Date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_lbl.Location = new System.Drawing.Point(561, 138);
            this.Date_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Date_lbl.MaximumSize = new System.Drawing.Size(226, 60);
            this.Date_lbl.Name = "Date_lbl";
            this.Date_lbl.Size = new System.Drawing.Size(76, 36);
            this.Date_lbl.TabIndex = 78;
            this.Date_lbl.Text = "Date";
            this.Date_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sell_btn
            // 
            this.Sell_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.Sell_btn.FlatAppearance.BorderSize = 0;
            this.Sell_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sell_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sell_btn.ForeColor = System.Drawing.Color.White;
            this.Sell_btn.Location = new System.Drawing.Point(356, 258);
            this.Sell_btn.Name = "Sell_btn";
            this.Sell_btn.Size = new System.Drawing.Size(363, 52);
            this.Sell_btn.TabIndex = 80;
            this.Sell_btn.Text = "Sell";
            this.Sell_btn.UseVisualStyleBackColor = false;
            this.Sell_btn.Click += new System.EventHandler(this.Sell_btn_Click);
            // 
            // ViewEmployee_lbl
            // 
            this.ViewEmployee_lbl.AutoEllipsis = true;
            this.ViewEmployee_lbl.AutoSize = true;
            this.ViewEmployee_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEmployee_lbl.Location = new System.Drawing.Point(564, 89);
            this.ViewEmployee_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.ViewEmployee_lbl.MaximumSize = new System.Drawing.Size(226, 60);
            this.ViewEmployee_lbl.Name = "ViewEmployee_lbl";
            this.ViewEmployee_lbl.Size = new System.Drawing.Size(147, 25);
            this.ViewEmployee_lbl.TabIndex = 83;
            this.ViewEmployee_lbl.Text = "View Employee";
            this.ViewEmployee_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewEmployee_lbl.Click += new System.EventHandler(this.ViewEmployee_lbl_Click);
            this.ViewEmployee_lbl.MouseEnter += new System.EventHandler(this.ViewEmployee_lbl_MouseEnter);
            this.ViewEmployee_lbl.MouseLeave += new System.EventHandler(this.ViewEmployee_lbl_MouseLeave);
            // 
            // Employee_lbl
            // 
            this.Employee_lbl.AutoEllipsis = true;
            this.Employee_lbl.AutoSize = true;
            this.Employee_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_lbl.Location = new System.Drawing.Point(560, 10);
            this.Employee_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Employee_lbl.MaximumSize = new System.Drawing.Size(226, 60);
            this.Employee_lbl.Name = "Employee_lbl";
            this.Employee_lbl.Size = new System.Drawing.Size(146, 36);
            this.Employee_lbl.TabIndex = 82;
            this.Employee_lbl.Text = "Employee";
            this.Employee_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Employees_cb
            // 
            this.Employees_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Employees_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees_cb.FormattingEnabled = true;
            this.Employees_cb.Location = new System.Drawing.Point(566, 47);
            this.Employees_cb.Name = "Employees_cb";
            this.Employees_cb.Size = new System.Drawing.Size(445, 39);
            this.Employees_cb.TabIndex = 81;
            this.Employees_cb.SelectedIndexChanged += new System.EventHandler(this.Employees_cb_SelectedIndexChanged);
            // 
            // AddNewCustomer_lbl
            // 
            this.AddNewCustomer_lbl.AutoEllipsis = true;
            this.AddNewCustomer_lbl.AutoSize = true;
            this.AddNewCustomer_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewCustomer_lbl.Location = new System.Drawing.Point(329, 89);
            this.AddNewCustomer_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.AddNewCustomer_lbl.MaximumSize = new System.Drawing.Size(226, 60);
            this.AddNewCustomer_lbl.Name = "AddNewCustomer_lbl";
            this.AddNewCustomer_lbl.Size = new System.Drawing.Size(182, 25);
            this.AddNewCustomer_lbl.TabIndex = 84;
            this.AddNewCustomer_lbl.Text = "Add New Customer";
            this.AddNewCustomer_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewCustomer_lbl.Click += new System.EventHandler(this.AddNewCustomer_lbl_Click);
            this.AddNewCustomer_lbl.MouseEnter += new System.EventHandler(this.AddNewCustomer_lbl_MouseEnter);
            this.AddNewCustomer_lbl.MouseLeave += new System.EventHandler(this.AddNewCustomer_lbl_MouseLeave);
            // 
            // SellVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.Customers_cb);
            this.Controls.Add(this.AddNewCustomer_lbl);
            this.Controls.Add(this.ViewEmployee_lbl);
            this.Controls.Add(this.Employee_lbl);
            this.Controls.Add(this.Employees_cb);
            this.Controls.Add(this.Sell_btn);
            this.Controls.Add(this.Date_dtp);
            this.Controls.Add(this.Date_lbl);
            this.Controls.Add(this.Price_lbl);
            this.Controls.Add(this.Customer_lbl);
            this.Controls.Add(this.ViewCustomer_lbl);
            this.Controls.Add(this.Price_nud);
            this.Name = "SellVehicle";
            this.Size = new System.Drawing.Size(1051, 700);
            this.Tag = "Sell Vehicle";
            this.Load += new System.EventHandler(this.SellVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Price_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Customers_cb;
        private System.Windows.Forms.NumericUpDown Price_nud;
        private System.Windows.Forms.Label ViewCustomer_lbl;
        private System.Windows.Forms.Label Customer_lbl;
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.DateTimePicker Date_dtp;
        private System.Windows.Forms.Label Date_lbl;
        private System.Windows.Forms.Button Sell_btn;
        private System.Windows.Forms.Label ViewEmployee_lbl;
        private System.Windows.Forms.Label Employee_lbl;
        private System.Windows.Forms.ComboBox Employees_cb;
        private System.Windows.Forms.Label AddNewCustomer_lbl;
    }
}
