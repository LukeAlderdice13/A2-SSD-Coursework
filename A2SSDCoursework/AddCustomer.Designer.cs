namespace A2SSDCoursework
{
    partial class AddCustomer
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
            this.FirstName_lbl = new System.Windows.Forms.Label();
            this.FirstName_tbx = new System.Windows.Forms.TextBox();
            this.Surname_lbl = new System.Windows.Forms.Label();
            this.AddCustomer_btn = new System.Windows.Forms.Button();
            this.TelephoneNo_tbx = new System.Windows.Forms.TextBox();
            this.Surname_tbx = new System.Windows.Forms.TextBox();
            this.Address_tbx = new System.Windows.Forms.TextBox();
            this.TelephoneNo_lbl = new System.Windows.Forms.Label();
            this.Email_tbx = new System.Windows.Forms.TextBox();
            this.Address_lbl = new System.Windows.Forms.Label();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstName_lbl
            // 
            this.FirstName_lbl.AutoSize = true;
            this.FirstName_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.FirstName_lbl.Location = new System.Drawing.Point(3, 3);
            this.FirstName_lbl.Name = "FirstName_lbl";
            this.FirstName_lbl.Size = new System.Drawing.Size(176, 41);
            this.FirstName_lbl.TabIndex = 72;
            this.FirstName_lbl.Text = "First Name:";
            this.FirstName_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstName_tbx
            // 
            this.FirstName_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_tbx.Location = new System.Drawing.Point(238, 7);
            this.FirstName_tbx.Name = "FirstName_tbx";
            this.FirstName_tbx.Size = new System.Drawing.Size(279, 34);
            this.FirstName_tbx.TabIndex = 77;
            this.FirstName_tbx.TextChanged += new System.EventHandler(this.FirstName_tbx_TextChanged);
            this.FirstName_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FirstName_tbx_KeyDown);
            // 
            // Surname_lbl
            // 
            this.Surname_lbl.AutoSize = true;
            this.Surname_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.Surname_lbl.Location = new System.Drawing.Point(3, 44);
            this.Surname_lbl.Name = "Surname_lbl";
            this.Surname_lbl.Size = new System.Drawing.Size(149, 41);
            this.Surname_lbl.TabIndex = 73;
            this.Surname_lbl.Text = "Surname:";
            this.Surname_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddCustomer_btn
            // 
            this.AddCustomer_btn.BackColor = System.Drawing.Color.Firebrick;
            this.AddCustomer_btn.FlatAppearance.BorderSize = 0;
            this.AddCustomer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomer_btn.ForeColor = System.Drawing.Color.White;
            this.AddCustomer_btn.Location = new System.Drawing.Point(347, 129);
            this.AddCustomer_btn.Name = "AddCustomer_btn";
            this.AddCustomer_btn.Size = new System.Drawing.Size(363, 44);
            this.AddCustomer_btn.TabIndex = 82;
            this.AddCustomer_btn.Text = "Add Customer";
            this.AddCustomer_btn.UseVisualStyleBackColor = false;
            this.AddCustomer_btn.Click += new System.EventHandler(this.AddCustomer_btn_Click);
            // 
            // TelephoneNo_tbx
            // 
            this.TelephoneNo_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelephoneNo_tbx.Location = new System.Drawing.Point(238, 89);
            this.TelephoneNo_tbx.Name = "TelephoneNo_tbx";
            this.TelephoneNo_tbx.Size = new System.Drawing.Size(279, 34);
            this.TelephoneNo_tbx.TabIndex = 81;
            this.TelephoneNo_tbx.TextChanged += new System.EventHandler(this.TelephoneNo_tbx_TextChanged);
            this.TelephoneNo_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelephoneNo_tbx_KeyDown);
            // 
            // Surname_tbx
            // 
            this.Surname_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname_tbx.Location = new System.Drawing.Point(238, 48);
            this.Surname_tbx.Name = "Surname_tbx";
            this.Surname_tbx.Size = new System.Drawing.Size(279, 34);
            this.Surname_tbx.TabIndex = 78;
            this.Surname_tbx.TextChanged += new System.EventHandler(this.Surname_tbx_TextChanged);
            this.Surname_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Surname_tbx_KeyDown);
            // 
            // Address_tbx
            // 
            this.Address_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_tbx.Location = new System.Drawing.Point(677, 7);
            this.Address_tbx.Name = "Address_tbx";
            this.Address_tbx.Size = new System.Drawing.Size(356, 34);
            this.Address_tbx.TabIndex = 80;
            this.Address_tbx.TextChanged += new System.EventHandler(this.Address_tbx_TextChanged);
            this.Address_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Address_tbx_KeyDown);
            // 
            // TelephoneNo_lbl
            // 
            this.TelephoneNo_lbl.AutoSize = true;
            this.TelephoneNo_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelephoneNo_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.TelephoneNo_lbl.Location = new System.Drawing.Point(3, 85);
            this.TelephoneNo_lbl.Name = "TelephoneNo_lbl";
            this.TelephoneNo_lbl.Size = new System.Drawing.Size(216, 41);
            this.TelephoneNo_lbl.TabIndex = 76;
            this.TelephoneNo_lbl.Text = "Telephone No:";
            this.TelephoneNo_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Email_tbx
            // 
            this.Email_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_tbx.Location = new System.Drawing.Point(677, 48);
            this.Email_tbx.Name = "Email_tbx";
            this.Email_tbx.Size = new System.Drawing.Size(356, 34);
            this.Email_tbx.TabIndex = 79;
            this.Email_tbx.TextChanged += new System.EventHandler(this.Email_tbx_TextChanged);
            this.Email_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Email_tbx_KeyDown);
            // 
            // Address_lbl
            // 
            this.Address_lbl.AutoSize = true;
            this.Address_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.Address_lbl.Location = new System.Drawing.Point(523, 3);
            this.Address_lbl.Name = "Address_lbl";
            this.Address_lbl.Size = new System.Drawing.Size(136, 41);
            this.Address_lbl.TabIndex = 74;
            this.Address_lbl.Text = "Address:";
            this.Address_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.Email_lbl.Location = new System.Drawing.Point(524, 44);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(106, 41);
            this.Email_lbl.TabIndex = 75;
            this.Email_lbl.Text = "Email:";
            this.Email_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.FirstName_lbl);
            this.Controls.Add(this.FirstName_tbx);
            this.Controls.Add(this.Surname_lbl);
            this.Controls.Add(this.AddCustomer_btn);
            this.Controls.Add(this.TelephoneNo_tbx);
            this.Controls.Add(this.Surname_tbx);
            this.Controls.Add(this.Address_tbx);
            this.Controls.Add(this.TelephoneNo_lbl);
            this.Controls.Add(this.Email_tbx);
            this.Controls.Add(this.Address_lbl);
            this.Controls.Add(this.Email_lbl);
            this.Name = "AddCustomer";
            this.Size = new System.Drawing.Size(1051, 700);
            this.Tag = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName_lbl;
        private System.Windows.Forms.TextBox FirstName_tbx;
        private System.Windows.Forms.Label Surname_lbl;
        private System.Windows.Forms.Button AddCustomer_btn;
        private System.Windows.Forms.TextBox TelephoneNo_tbx;
        private System.Windows.Forms.TextBox Surname_tbx;
        private System.Windows.Forms.TextBox Address_tbx;
        private System.Windows.Forms.Label TelephoneNo_lbl;
        private System.Windows.Forms.TextBox Email_tbx;
        private System.Windows.Forms.Label Address_lbl;
        private System.Windows.Forms.Label Email_lbl;
    }
}
