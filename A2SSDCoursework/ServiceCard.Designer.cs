namespace A2SSDCoursework
{
    partial class ServiceCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceCard));
            this.Date_lbl = new System.Windows.Forms.Label();
            this.Employee_lbl = new System.Windows.Forms.Label();
            this.Cost_lbl = new System.Windows.Forms.Label();
            this.Sold_lbl = new System.Windows.Forms.Label();
            this.ServiceType_lbl = new System.Windows.Forms.Label();
            this.Delete_pb = new System.Windows.Forms.PictureBox();
            this.Edit_pb = new System.Windows.Forms.PictureBox();
            this.Bin_il = new System.Windows.Forms.ImageList(this.components);
            this.Edit_il = new System.Windows.Forms.ImageList(this.components);
            this.BottomLine_pnl = new System.Windows.Forms.Panel();
            this.Edit_pnl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cost_nud = new System.Windows.Forms.NumericUpDown();
            this.Type_tbx = new System.Windows.Forms.TextBox();
            this.Employees_cb = new System.Windows.Forms.ComboBox();
            this.Tick_pb = new System.Windows.Forms.PictureBox();
            this.X_pb = new System.Windows.Forms.PictureBox();
            this.Tick_il = new System.Windows.Forms.ImageList(this.components);
            this.X_il = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Delete_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_pb)).BeginInit();
            this.Edit_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cost_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // Date_lbl
            // 
            this.Date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_lbl.Location = new System.Drawing.Point(3, 0);
            this.Date_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Date_lbl.Name = "Date_lbl";
            this.Date_lbl.Size = new System.Drawing.Size(139, 90);
            this.Date_lbl.TabIndex = 0;
            this.Date_lbl.Text = "Date";
            this.Date_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Employee_lbl
            // 
            this.Employee_lbl.AutoEllipsis = true;
            this.Employee_lbl.AutoSize = true;
            this.Employee_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_lbl.Location = new System.Drawing.Point(160, 31);
            this.Employee_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Employee_lbl.MaximumSize = new System.Drawing.Size(226, 60);
            this.Employee_lbl.Name = "Employee_lbl";
            this.Employee_lbl.Size = new System.Drawing.Size(122, 29);
            this.Employee_lbl.TabIndex = 1;
            this.Employee_lbl.Text = "Employee";
            this.Employee_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Employee_lbl.Click += new System.EventHandler(this.Employee_lbl_Click);
            this.Employee_lbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Employee_lbl_MouseClick);
            this.Employee_lbl.MouseEnter += new System.EventHandler(this.Employee_lbl_MouseEnter);
            this.Employee_lbl.MouseLeave += new System.EventHandler(this.Employee_lbl_MouseLeave);
            // 
            // Cost_lbl
            // 
            this.Cost_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost_lbl.Location = new System.Drawing.Point(720, 0);
            this.Cost_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Cost_lbl.Name = "Cost_lbl";
            this.Cost_lbl.Size = new System.Drawing.Size(124, 90);
            this.Cost_lbl.TabIndex = 4;
            this.Cost_lbl.Text = "Cost";
            this.Cost_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sold_lbl
            // 
            this.Sold_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sold_lbl.Location = new System.Drawing.Point(570, 0);
            this.Sold_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Sold_lbl.Name = "Sold_lbl";
            this.Sold_lbl.Size = new System.Drawing.Size(112, 90);
            this.Sold_lbl.TabIndex = 5;
            this.Sold_lbl.Text = "No";
            this.Sold_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServiceType_lbl
            // 
            this.ServiceType_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceType_lbl.Location = new System.Drawing.Point(405, 0);
            this.ServiceType_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.ServiceType_lbl.Name = "ServiceType_lbl";
            this.ServiceType_lbl.Size = new System.Drawing.Size(165, 90);
            this.ServiceType_lbl.TabIndex = 3;
            this.ServiceType_lbl.Text = "Repair";
            this.ServiceType_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Delete_pb
            // 
            this.Delete_pb.Image = ((System.Drawing.Image)(resources.GetObject("Delete_pb.Image")));
            this.Delete_pb.Location = new System.Drawing.Point(830, 3);
            this.Delete_pb.Name = "Delete_pb";
            this.Delete_pb.Size = new System.Drawing.Size(74, 84);
            this.Delete_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Delete_pb.TabIndex = 6;
            this.Delete_pb.TabStop = false;
            this.Delete_pb.Click += new System.EventHandler(this.Delete_pb_Click);
            this.Delete_pb.MouseEnter += new System.EventHandler(this.Delete_pb_MouseEnter);
            this.Delete_pb.MouseLeave += new System.EventHandler(this.Delete_pb_MouseLeave);
            // 
            // Edit_pb
            // 
            this.Edit_pb.Image = ((System.Drawing.Image)(resources.GetObject("Edit_pb.Image")));
            this.Edit_pb.Location = new System.Drawing.Point(919, 3);
            this.Edit_pb.Name = "Edit_pb";
            this.Edit_pb.Size = new System.Drawing.Size(99, 84);
            this.Edit_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Edit_pb.TabIndex = 7;
            this.Edit_pb.TabStop = false;
            this.Edit_pb.Click += new System.EventHandler(this.Edit_pb_Click);
            this.Edit_pb.MouseEnter += new System.EventHandler(this.Edit_pb_MouseEnter);
            this.Edit_pb.MouseLeave += new System.EventHandler(this.Edit_pb_MouseLeave);
            // 
            // Bin_il
            // 
            this.Bin_il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Bin_il.ImageStream")));
            this.Bin_il.TransparentColor = System.Drawing.Color.Transparent;
            this.Bin_il.Images.SetKeyName(0, "Bin Unselected.png");
            this.Bin_il.Images.SetKeyName(1, "Bin Selected.png");
            // 
            // Edit_il
            // 
            this.Edit_il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Edit_il.ImageStream")));
            this.Edit_il.TransparentColor = System.Drawing.Color.Transparent;
            this.Edit_il.Images.SetKeyName(0, "Edit Unselected.png");
            this.Edit_il.Images.SetKeyName(1, "Edit Selected.png");
            // 
            // BottomLine_pnl
            // 
            this.BottomLine_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BottomLine_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomLine_pnl.Location = new System.Drawing.Point(0, 90);
            this.BottomLine_pnl.Name = "BottomLine_pnl";
            this.BottomLine_pnl.Size = new System.Drawing.Size(1051, 3);
            this.BottomLine_pnl.TabIndex = 8;
            // 
            // Edit_pnl
            // 
            this.Edit_pnl.Controls.Add(this.label3);
            this.Edit_pnl.Controls.Add(this.label2);
            this.Edit_pnl.Controls.Add(this.label1);
            this.Edit_pnl.Controls.Add(this.Cost_nud);
            this.Edit_pnl.Controls.Add(this.Type_tbx);
            this.Edit_pnl.Controls.Add(this.Employees_cb);
            this.Edit_pnl.Controls.Add(this.Tick_pb);
            this.Edit_pnl.Controls.Add(this.X_pb);
            this.Edit_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Edit_pnl.Location = new System.Drawing.Point(0, 0);
            this.Edit_pnl.Name = "Edit_pnl";
            this.Edit_pnl.Size = new System.Drawing.Size(1051, 90);
            this.Edit_pnl.TabIndex = 9;
            this.Edit_pnl.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(696, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.MaximumSize = new System.Drawing.Size(226, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cost";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.MaximumSize = new System.Drawing.Size(226, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.MaximumSize = new System.Drawing.Size(226, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cost_nud
            // 
            this.Cost_nud.DecimalPlaces = 2;
            this.Cost_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost_nud.Location = new System.Drawing.Point(701, 43);
            this.Cost_nud.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Cost_nud.Name = "Cost_nud";
            this.Cost_nud.Size = new System.Drawing.Size(123, 34);
            this.Cost_nud.TabIndex = 5;
            // 
            // Type_tbx
            // 
            this.Type_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_tbx.Location = new System.Drawing.Point(348, 43);
            this.Type_tbx.Name = "Type_tbx";
            this.Type_tbx.Size = new System.Drawing.Size(334, 34);
            this.Type_tbx.TabIndex = 4;
            // 
            // Employees_cb
            // 
            this.Employees_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Employees_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees_cb.FormattingEnabled = true;
            this.Employees_cb.Location = new System.Drawing.Point(8, 42);
            this.Employees_cb.Name = "Employees_cb";
            this.Employees_cb.Size = new System.Drawing.Size(316, 37);
            this.Employees_cb.TabIndex = 3;
            this.Employees_cb.SelectionChangeCommitted += new System.EventHandler(this.Employees_cb_SelectionChangeCommitted);
            // 
            // Tick_pb
            // 
            this.Tick_pb.Image = ((System.Drawing.Image)(resources.GetObject("Tick_pb.Image")));
            this.Tick_pb.Location = new System.Drawing.Point(833, 9);
            this.Tick_pb.Name = "Tick_pb";
            this.Tick_pb.Size = new System.Drawing.Size(97, 70);
            this.Tick_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tick_pb.TabIndex = 1;
            this.Tick_pb.TabStop = false;
            this.Tick_pb.Click += new System.EventHandler(this.Tick_pb_Click);
            this.Tick_pb.MouseEnter += new System.EventHandler(this.Tick_pb_MouseEnter);
            this.Tick_pb.MouseLeave += new System.EventHandler(this.Tick_pb_MouseLeave);
            // 
            // X_pb
            // 
            this.X_pb.Image = ((System.Drawing.Image)(resources.GetObject("X_pb.Image")));
            this.X_pb.Location = new System.Drawing.Point(939, 9);
            this.X_pb.Name = "X_pb";
            this.X_pb.Size = new System.Drawing.Size(79, 70);
            this.X_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.X_pb.TabIndex = 0;
            this.X_pb.TabStop = false;
            this.X_pb.Click += new System.EventHandler(this.X_pb_Click);
            this.X_pb.MouseEnter += new System.EventHandler(this.X_pb_MouseEnter);
            this.X_pb.MouseLeave += new System.EventHandler(this.X_pb_MouseLeave);
            // 
            // Tick_il
            // 
            this.Tick_il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Tick_il.ImageStream")));
            this.Tick_il.TransparentColor = System.Drawing.Color.Transparent;
            this.Tick_il.Images.SetKeyName(0, "Tick Unhighlighted.png");
            this.Tick_il.Images.SetKeyName(1, "Tick Highlighted.png");
            // 
            // X_il
            // 
            this.X_il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("X_il.ImageStream")));
            this.X_il.TransparentColor = System.Drawing.Color.Transparent;
            this.X_il.Images.SetKeyName(0, "x Unhighlighted.png");
            this.X_il.Images.SetKeyName(1, "x.png");
            // 
            // ServiceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Edit_pnl);
            this.Controls.Add(this.BottomLine_pnl);
            this.Controls.Add(this.Edit_pb);
            this.Controls.Add(this.Delete_pb);
            this.Controls.Add(this.ServiceType_lbl);
            this.Controls.Add(this.Sold_lbl);
            this.Controls.Add(this.Cost_lbl);
            this.Controls.Add(this.Employee_lbl);
            this.Controls.Add(this.Date_lbl);
            this.Name = "ServiceCard";
            this.Size = new System.Drawing.Size(1051, 93);
            this.MouseEnter += new System.EventHandler(this.ServiceCard_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ServiceCard_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.Delete_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_pb)).EndInit();
            this.Edit_pnl.ResumeLayout(false);
            this.Edit_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cost_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Date_lbl;
        private System.Windows.Forms.Label Employee_lbl;
        private System.Windows.Forms.Label Cost_lbl;
        private System.Windows.Forms.Label Sold_lbl;
        private System.Windows.Forms.Label ServiceType_lbl;
        private System.Windows.Forms.PictureBox Delete_pb;
        private System.Windows.Forms.PictureBox Edit_pb;
        private System.Windows.Forms.ImageList Bin_il;
        private System.Windows.Forms.ImageList Edit_il;
        private System.Windows.Forms.Panel BottomLine_pnl;
        private System.Windows.Forms.PictureBox Tick_pb;
        private System.Windows.Forms.PictureBox X_pb;
        private System.Windows.Forms.ImageList Tick_il;
        private System.Windows.Forms.ImageList X_il;
        private System.Windows.Forms.NumericUpDown Cost_nud;
        private System.Windows.Forms.TextBox Type_tbx;
        private System.Windows.Forms.ComboBox Employees_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel Edit_pnl;
    }
}
