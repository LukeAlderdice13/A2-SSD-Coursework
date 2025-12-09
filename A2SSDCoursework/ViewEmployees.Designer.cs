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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployees));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Employees_lbl = new System.Windows.Forms.Label();
            this.Employees_pnl = new System.Windows.Forms.Panel();
            this.Search_pnl = new System.Windows.Forms.Panel();
            this.Gender_cb = new System.Windows.Forms.ComboBox();
            this.MaxSalary_nud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_tbx = new System.Windows.Forms.TextBox();
            this.ResetSearch_lbl = new System.Windows.Forms.Label();
            this.MinSalary_nud = new System.Windows.Forms.NumericUpDown();
            this.SearchIcon_pb = new System.Windows.Forms.PictureBox();
            this.MinSalary_lbl = new System.Windows.Forms.Label();
            this.Role_lbl = new System.Windows.Forms.Label();
            this.Role_cb = new System.Windows.Forms.ComboBox();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Gender_lbl = new System.Windows.Forms.Label();
            this.Search_lbl = new System.Windows.Forms.Label();
            this.SearchIcon_il = new System.Windows.Forms.ImageList(this.components);
            this.Search_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSalary_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinSalary_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 4);
            this.panel1.TabIndex = 3;
            // 
            // Employees_lbl
            // 
            this.Employees_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees_lbl.Location = new System.Drawing.Point(0, 0);
            this.Employees_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Employees_lbl.Name = "Employees_lbl";
            this.Employees_lbl.Size = new System.Drawing.Size(788, 62);
            this.Employees_lbl.TabIndex = 2;
            this.Employees_lbl.Text = "Employees";
            this.Employees_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Employees_pnl
            // 
            this.Employees_pnl.AutoScroll = true;
            this.Employees_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Employees_pnl.Location = new System.Drawing.Point(0, 64);
            this.Employees_pnl.Margin = new System.Windows.Forms.Padding(2);
            this.Employees_pnl.Name = "Employees_pnl";
            this.Employees_pnl.Size = new System.Drawing.Size(544, 505);
            this.Employees_pnl.TabIndex = 4;
            // 
            // Search_pnl
            // 
            this.Search_pnl.AutoScroll = true;
            this.Search_pnl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Search_pnl.Controls.Add(this.MaxSalary_nud);
            this.Search_pnl.Controls.Add(this.Gender_cb);
            this.Search_pnl.Controls.Add(this.label1);
            this.Search_pnl.Controls.Add(this.Name_tbx);
            this.Search_pnl.Controls.Add(this.ResetSearch_lbl);
            this.Search_pnl.Controls.Add(this.MinSalary_nud);
            this.Search_pnl.Controls.Add(this.SearchIcon_pb);
            this.Search_pnl.Controls.Add(this.MinSalary_lbl);
            this.Search_pnl.Controls.Add(this.Role_lbl);
            this.Search_pnl.Controls.Add(this.Role_cb);
            this.Search_pnl.Controls.Add(this.Name_lbl);
            this.Search_pnl.Controls.Add(this.Gender_lbl);
            this.Search_pnl.Controls.Add(this.Search_lbl);
            this.Search_pnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_pnl.Location = new System.Drawing.Point(535, 64);
            this.Search_pnl.Margin = new System.Windows.Forms.Padding(2);
            this.Search_pnl.Name = "Search_pnl";
            this.Search_pnl.Size = new System.Drawing.Size(253, 505);
            this.Search_pnl.TabIndex = 12;
            // 
            // Gender_cb
            // 
            this.Gender_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_cb.FormattingEnabled = true;
            this.Gender_cb.Items.AddRange(new object[] {
            "Any Gender",
            "Male",
            "Female"});
            this.Gender_cb.Location = new System.Drawing.Point(16, 116);
            this.Gender_cb.Margin = new System.Windows.Forms.Padding(2);
            this.Gender_cb.Name = "Gender_cb";
            this.Gender_cb.Size = new System.Drawing.Size(228, 28);
            this.Gender_cb.TabIndex = 18;
            // 
            // MaxSalary_nud
            // 
            this.MaxSalary_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxSalary_nud.Location = new System.Drawing.Point(17, 234);
            this.MaxSalary_nud.Margin = new System.Windows.Forms.Padding(2);
            this.MaxSalary_nud.Name = "MaxSalary_nud";
            this.MaxSalary_nud.Size = new System.Drawing.Size(227, 26);
            this.MaxSalary_nud.TabIndex = 16;
            this.MaxSalary_nud.ValueChanged += new System.EventHandler(this.MaxSalary_nud_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Max Salary";
            // 
            // Name_tbx
            // 
            this.Name_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_tbx.Location = new System.Drawing.Point(16, 60);
            this.Name_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.Name_tbx.Name = "Name_tbx";
            this.Name_tbx.Size = new System.Drawing.Size(228, 26);
            this.Name_tbx.TabIndex = 15;
            // 
            // ResetSearch_lbl
            // 
            this.ResetSearch_lbl.AutoSize = true;
            this.ResetSearch_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetSearch_lbl.ForeColor = System.Drawing.Color.Red;
            this.ResetSearch_lbl.Location = new System.Drawing.Point(41, 429);
            this.ResetSearch_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResetSearch_lbl.Name = "ResetSearch_lbl";
            this.ResetSearch_lbl.Size = new System.Drawing.Size(181, 31);
            this.ResetSearch_lbl.TabIndex = 14;
            this.ResetSearch_lbl.Text = "Reset Filters";
            this.ResetSearch_lbl.Click += new System.EventHandler(this.ResetSearch_lbl_Click);
            this.ResetSearch_lbl.MouseEnter += new System.EventHandler(this.ResetSearch_lbl_MouseEnter);
            this.ResetSearch_lbl.MouseLeave += new System.EventHandler(this.ResetSearch_lbl_MouseLeave);
            // 
            // MinSalary_nud
            // 
            this.MinSalary_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinSalary_nud.Location = new System.Drawing.Point(17, 292);
            this.MinSalary_nud.Margin = new System.Windows.Forms.Padding(2);
            this.MinSalary_nud.Name = "MinSalary_nud";
            this.MinSalary_nud.Size = new System.Drawing.Size(227, 26);
            this.MinSalary_nud.TabIndex = 0;
            this.MinSalary_nud.ValueChanged += new System.EventHandler(this.MinSalary_nud_ValueChanged);
            // 
            // SearchIcon_pb
            // 
            this.SearchIcon_pb.Image = ((System.Drawing.Image)(resources.GetObject("SearchIcon_pb.Image")));
            this.SearchIcon_pb.Location = new System.Drawing.Point(93, 350);
            this.SearchIcon_pb.Margin = new System.Windows.Forms.Padding(2);
            this.SearchIcon_pb.Name = "SearchIcon_pb";
            this.SearchIcon_pb.Size = new System.Drawing.Size(68, 65);
            this.SearchIcon_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchIcon_pb.TabIndex = 0;
            this.SearchIcon_pb.TabStop = false;
            this.SearchIcon_pb.Click += new System.EventHandler(this.SearchIcon_pb_Click);
            this.SearchIcon_pb.MouseEnter += new System.EventHandler(this.SearchIcon_pb_MouseEnter);
            this.SearchIcon_pb.MouseLeave += new System.EventHandler(this.SearchIcon_pb_MouseLeave);
            // 
            // MinSalary_lbl
            // 
            this.MinSalary_lbl.AutoSize = true;
            this.MinSalary_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinSalary_lbl.Location = new System.Drawing.Point(16, 270);
            this.MinSalary_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinSalary_lbl.Name = "MinSalary_lbl";
            this.MinSalary_lbl.Size = new System.Drawing.Size(82, 20);
            this.MinSalary_lbl.TabIndex = 13;
            this.MinSalary_lbl.Text = "Min Salary";
            // 
            // Role_lbl
            // 
            this.Role_lbl.AutoSize = true;
            this.Role_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_lbl.Location = new System.Drawing.Point(14, 152);
            this.Role_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Role_lbl.Name = "Role_lbl";
            this.Role_lbl.Size = new System.Drawing.Size(42, 20);
            this.Role_lbl.TabIndex = 10;
            this.Role_lbl.Text = "Role";
            // 
            // Role_cb
            // 
            this.Role_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Role_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_cb.FormattingEnabled = true;
            this.Role_cb.Location = new System.Drawing.Point(16, 175);
            this.Role_cb.Margin = new System.Windows.Forms.Padding(2);
            this.Role_cb.Name = "Role_cb";
            this.Role_cb.Size = new System.Drawing.Size(228, 28);
            this.Role_cb.TabIndex = 9;
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(14, 37);
            this.Name_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(51, 20);
            this.Name_lbl.TabIndex = 4;
            this.Name_lbl.Text = "Name";
            // 
            // Gender_lbl
            // 
            this.Gender_lbl.AutoSize = true;
            this.Gender_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_lbl.Location = new System.Drawing.Point(14, 94);
            this.Gender_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Gender_lbl.Name = "Gender_lbl";
            this.Gender_lbl.Size = new System.Drawing.Size(63, 20);
            this.Gender_lbl.TabIndex = 3;
            this.Gender_lbl.Text = "Gender";
            // 
            // Search_lbl
            // 
            this.Search_lbl.AutoSize = true;
            this.Search_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_lbl.Location = new System.Drawing.Point(26, 2);
            this.Search_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Search_lbl.Name = "Search_lbl";
            this.Search_lbl.Size = new System.Drawing.Size(212, 26);
            this.Search_lbl.TabIndex = 0;
            this.Search_lbl.Text = "Search Employees";
            // 
            // SearchIcon_il
            // 
            this.SearchIcon_il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SearchIcon_il.ImageStream")));
            this.SearchIcon_il.TransparentColor = System.Drawing.Color.Transparent;
            this.SearchIcon_il.Images.SetKeyName(0, "Search_Icon_default.png");
            this.SearchIcon_il.Images.SetKeyName(1, "Search_Icon_highlighted.png");
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Employees_pnl);
            this.Controls.Add(this.Search_pnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Employees_lbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewEmployees";
            this.Size = new System.Drawing.Size(788, 569);
            this.Search_pnl.ResumeLayout(false);
            this.Search_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSalary_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinSalary_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Employees_lbl;
        private System.Windows.Forms.Panel Employees_pnl;
        private System.Windows.Forms.Panel Search_pnl;
        private System.Windows.Forms.Label ResetSearch_lbl;
        private System.Windows.Forms.NumericUpDown MinSalary_nud;
        private System.Windows.Forms.PictureBox SearchIcon_pb;
        private System.Windows.Forms.Label MinSalary_lbl;
        private System.Windows.Forms.Label Role_lbl;
        private System.Windows.Forms.ComboBox Role_cb;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label Gender_lbl;
        private System.Windows.Forms.Label Search_lbl;
        private System.Windows.Forms.TextBox Name_tbx;
        private System.Windows.Forms.NumericUpDown MaxSalary_nud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Gender_cb;
        private System.Windows.Forms.ImageList SearchIcon_il;
    }
}
