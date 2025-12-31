namespace A2SSDCoursework
{
    partial class RecordService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordService));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RecordService_lbl = new System.Windows.Forms.Label();
            this.ReturnArrow_pb = new System.Windows.Forms.PictureBox();
            this.ReturnArrow_il = new System.Windows.Forms.ImageList(this.components);
            this.Cost_lbl = new System.Windows.Forms.Label();
            this.Type_lbl = new System.Windows.Forms.Label();
            this.Employee_lbl = new System.Windows.Forms.Label();
            this.Cost_nud = new System.Windows.Forms.NumericUpDown();
            this.Type_tbx = new System.Windows.Forms.TextBox();
            this.Employees_cb = new System.Windows.Forms.ComboBox();
            this.Date_lbl = new System.Windows.Forms.Label();
            this.Date_dtp = new System.Windows.Forms.DateTimePicker();
            this.RecordService_btn = new System.Windows.Forms.Button();
            this.ViewEmployee_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnArrow_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(1, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 5);
            this.panel1.TabIndex = 5;
            // 
            // RecordService_lbl
            // 
            this.RecordService_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordService_lbl.Location = new System.Drawing.Point(0, 0);
            this.RecordService_lbl.Name = "RecordService_lbl";
            this.RecordService_lbl.Size = new System.Drawing.Size(1050, 76);
            this.RecordService_lbl.TabIndex = 4;
            this.RecordService_lbl.Text = "Record Service";
            this.RecordService_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReturnArrow_pb
            // 
            this.ReturnArrow_pb.Image = ((System.Drawing.Image)(resources.GetObject("ReturnArrow_pb.Image")));
            this.ReturnArrow_pb.Location = new System.Drawing.Point(16, 12);
            this.ReturnArrow_pb.Name = "ReturnArrow_pb";
            this.ReturnArrow_pb.Size = new System.Drawing.Size(68, 50);
            this.ReturnArrow_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReturnArrow_pb.TabIndex = 16;
            this.ReturnArrow_pb.TabStop = false;
            this.ReturnArrow_pb.Click += new System.EventHandler(this.ReturnArrow_pb_Click);
            this.ReturnArrow_pb.MouseEnter += new System.EventHandler(this.ReturnArrow_pb_MouseEnter);
            this.ReturnArrow_pb.MouseLeave += new System.EventHandler(this.ReturnArrow_pb_MouseLeave);
            // 
            // ReturnArrow_il
            // 
            this.ReturnArrow_il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ReturnArrow_il.ImageStream")));
            this.ReturnArrow_il.TransparentColor = System.Drawing.Color.Transparent;
            this.ReturnArrow_il.Images.SetKeyName(0, "BackArrow.png");
            this.ReturnArrow_il.Images.SetKeyName(1, "BackArrow_Highlighted.png");
            // 
            // Cost_lbl
            // 
            this.Cost_lbl.AutoEllipsis = true;
            this.Cost_lbl.AutoSize = true;
            this.Cost_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost_lbl.Location = new System.Drawing.Point(12, 186);
            this.Cost_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Cost_lbl.MaximumSize = new System.Drawing.Size(226, 60);
            this.Cost_lbl.Name = "Cost_lbl";
            this.Cost_lbl.Size = new System.Drawing.Size(62, 29);
            this.Cost_lbl.TabIndex = 22;
            this.Cost_lbl.Text = "Cost";
            this.Cost_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Type_lbl
            // 
            this.Type_lbl.AutoEllipsis = true;
            this.Type_lbl.AutoSize = true;
            this.Type_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_lbl.Location = new System.Drawing.Point(699, 104);
            this.Type_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Type_lbl.MaximumSize = new System.Drawing.Size(226, 60);
            this.Type_lbl.Name = "Type_lbl";
            this.Type_lbl.Size = new System.Drawing.Size(68, 29);
            this.Type_lbl.TabIndex = 21;
            this.Type_lbl.Text = "Type";
            this.Type_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Employee_lbl
            // 
            this.Employee_lbl.AutoEllipsis = true;
            this.Employee_lbl.AutoSize = true;
            this.Employee_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_lbl.Location = new System.Drawing.Point(336, 104);
            this.Employee_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Employee_lbl.MaximumSize = new System.Drawing.Size(226, 60);
            this.Employee_lbl.Name = "Employee_lbl";
            this.Employee_lbl.Size = new System.Drawing.Size(122, 29);
            this.Employee_lbl.TabIndex = 20;
            this.Employee_lbl.Text = "Employee";
            this.Employee_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cost_nud
            // 
            this.Cost_nud.DecimalPlaces = 2;
            this.Cost_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost_nud.Location = new System.Drawing.Point(17, 219);
            this.Cost_nud.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Cost_nud.Name = "Cost_nud";
            this.Cost_nud.Size = new System.Drawing.Size(297, 34);
            this.Cost_nud.TabIndex = 19;
            // 
            // Type_tbx
            // 
            this.Type_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_tbx.Location = new System.Drawing.Point(704, 137);
            this.Type_tbx.Name = "Type_tbx";
            this.Type_tbx.Size = new System.Drawing.Size(334, 34);
            this.Type_tbx.TabIndex = 18;
            this.Type_tbx.TextChanged += new System.EventHandler(this.Type_tbx_TextChanged);
            // 
            // Employees_cb
            // 
            this.Employees_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Employees_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees_cb.FormattingEnabled = true;
            this.Employees_cb.Location = new System.Drawing.Point(341, 136);
            this.Employees_cb.Name = "Employees_cb";
            this.Employees_cb.Size = new System.Drawing.Size(338, 37);
            this.Employees_cb.TabIndex = 17;
            this.Employees_cb.SelectedIndexChanged += new System.EventHandler(this.Employees_cb_SelectedIndexChanged);
            // 
            // Date_lbl
            // 
            this.Date_lbl.AutoEllipsis = true;
            this.Date_lbl.AutoSize = true;
            this.Date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_lbl.Location = new System.Drawing.Point(11, 104);
            this.Date_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Date_lbl.MaximumSize = new System.Drawing.Size(226, 60);
            this.Date_lbl.Name = "Date_lbl";
            this.Date_lbl.Size = new System.Drawing.Size(63, 29);
            this.Date_lbl.TabIndex = 23;
            this.Date_lbl.Text = "Date";
            this.Date_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Date_dtp
            // 
            this.Date_dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_dtp.Location = new System.Drawing.Point(16, 136);
            this.Date_dtp.Name = "Date_dtp";
            this.Date_dtp.Size = new System.Drawing.Size(298, 34);
            this.Date_dtp.TabIndex = 24;
            // 
            // RecordService_btn
            // 
            this.RecordService_btn.BackColor = System.Drawing.Color.Firebrick;
            this.RecordService_btn.FlatAppearance.BorderSize = 0;
            this.RecordService_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecordService_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordService_btn.ForeColor = System.Drawing.Color.White;
            this.RecordService_btn.Location = new System.Drawing.Point(341, 214);
            this.RecordService_btn.Name = "RecordService_btn";
            this.RecordService_btn.Size = new System.Drawing.Size(338, 44);
            this.RecordService_btn.TabIndex = 73;
            this.RecordService_btn.Text = "Record Service";
            this.RecordService_btn.UseVisualStyleBackColor = false;
            this.RecordService_btn.Click += new System.EventHandler(this.RecordService_btn_Click);
            // 
            // ViewEmployee_lbl
            // 
            this.ViewEmployee_lbl.AutoEllipsis = true;
            this.ViewEmployee_lbl.AutoSize = true;
            this.ViewEmployee_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEmployee_lbl.Location = new System.Drawing.Point(336, 176);
            this.ViewEmployee_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.ViewEmployee_lbl.MaximumSize = new System.Drawing.Size(226, 60);
            this.ViewEmployee_lbl.Name = "ViewEmployee_lbl";
            this.ViewEmployee_lbl.Size = new System.Drawing.Size(147, 25);
            this.ViewEmployee_lbl.TabIndex = 74;
            this.ViewEmployee_lbl.Text = "View Employee";
            this.ViewEmployee_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewEmployee_lbl.Click += new System.EventHandler(this.ViewEmployee_lbl_Click);
            this.ViewEmployee_lbl.MouseEnter += new System.EventHandler(this.ViewEmployee_lbl_MouseEnter);
            this.ViewEmployee_lbl.MouseLeave += new System.EventHandler(this.ViewEmployee_lbl_MouseLeave);
            // 
            // RecordService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ViewEmployee_lbl);
            this.Controls.Add(this.RecordService_btn);
            this.Controls.Add(this.Date_dtp);
            this.Controls.Add(this.Date_lbl);
            this.Controls.Add(this.Cost_lbl);
            this.Controls.Add(this.Type_lbl);
            this.Controls.Add(this.Employee_lbl);
            this.Controls.Add(this.Cost_nud);
            this.Controls.Add(this.Type_tbx);
            this.Controls.Add(this.Employees_cb);
            this.Controls.Add(this.ReturnArrow_pb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RecordService_lbl);
            this.Name = "RecordService";
            this.Size = new System.Drawing.Size(1051, 700);
            this.VisibleChanged += new System.EventHandler(this.RecordService_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnArrow_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RecordService_lbl;
        private System.Windows.Forms.PictureBox ReturnArrow_pb;
        private System.Windows.Forms.ImageList ReturnArrow_il;
        private System.Windows.Forms.Label Cost_lbl;
        private System.Windows.Forms.Label Type_lbl;
        private System.Windows.Forms.Label Employee_lbl;
        private System.Windows.Forms.NumericUpDown Cost_nud;
        private System.Windows.Forms.TextBox Type_tbx;
        private System.Windows.Forms.ComboBox Employees_cb;
        private System.Windows.Forms.Label Date_lbl;
        private System.Windows.Forms.DateTimePicker Date_dtp;
        private System.Windows.Forms.Button RecordService_btn;
        private System.Windows.Forms.Label ViewEmployee_lbl;
    }
}
