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
            ((System.ComponentModel.ISupportInitialize)(this.Cost_nud)).BeginInit();
            this.SuspendLayout();
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
            this.Cost_lbl.Location = new System.Drawing.Point(7, 87);
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
            this.Type_lbl.Location = new System.Drawing.Point(694, 5);
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
            this.Employee_lbl.Location = new System.Drawing.Point(331, 5);
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
            this.Cost_nud.Location = new System.Drawing.Point(12, 120);
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
            this.Type_tbx.Location = new System.Drawing.Point(699, 38);
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
            this.Employees_cb.Location = new System.Drawing.Point(336, 37);
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
            this.Date_lbl.Location = new System.Drawing.Point(6, 5);
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
            this.Date_dtp.Location = new System.Drawing.Point(11, 37);
            this.Date_dtp.Name = "Date_dtp";
            this.Date_dtp.Size = new System.Drawing.Size(298, 34);
            this.Date_dtp.TabIndex = 24;
            // 
            // RecordService_btn
            // 
            this.RecordService_btn.BackColor = System.Drawing.Color.Firebrick;
            this.RecordService_btn.FlatAppearance.BorderSize = 0;
            this.RecordService_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecordService_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordService_btn.ForeColor = System.Drawing.Color.White;
            this.RecordService_btn.Location = new System.Drawing.Point(336, 115);
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
            this.ViewEmployee_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEmployee_lbl.Location = new System.Drawing.Point(331, 77);
            this.ViewEmployee_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.ViewEmployee_lbl.MaximumSize = new System.Drawing.Size(226, 60);
            this.ViewEmployee_lbl.Name = "ViewEmployee_lbl";
            this.ViewEmployee_lbl.Size = new System.Drawing.Size(133, 22);
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
            this.Name = "RecordService";
            this.Size = new System.Drawing.Size(1051, 700);
            this.Tag = "Record Service";
            this.VisibleChanged += new System.EventHandler(this.RecordService_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Cost_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
