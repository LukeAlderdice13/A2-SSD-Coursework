namespace A2SSDCoursework
{
    partial class ServiceHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceHistory));
            this.ReturnArrow_il = new System.Windows.Forms.ImageList(this.components);
            this.ServiceHistory_lbl = new System.Windows.Forms.Label();
            this.ReturnArrow_pb = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CustomerInfo_pnl = new System.Windows.Forms.Panel();
            this.Underline_pnl = new System.Windows.Forms.Panel();
            this.Sold_lbl = new System.Windows.Forms.Label();
            this.Cost_lbl = new System.Windows.Forms.Label();
            this.Type_lbl = new System.Windows.Forms.Label();
            this.Employee_lbl = new System.Windows.Forms.Label();
            this.Date_lbl = new System.Windows.Forms.Label();
            this.NoServices_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnArrow_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnArrow_il
            // 
            this.ReturnArrow_il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ReturnArrow_il.ImageStream")));
            this.ReturnArrow_il.TransparentColor = System.Drawing.Color.Transparent;
            this.ReturnArrow_il.Images.SetKeyName(0, "BackArrow.png");
            this.ReturnArrow_il.Images.SetKeyName(1, "BackArrow_Highlighted.png");
            // 
            // ServiceHistory_lbl
            // 
            this.ServiceHistory_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceHistory_lbl.Location = new System.Drawing.Point(0, 0);
            this.ServiceHistory_lbl.Name = "ServiceHistory_lbl";
            this.ServiceHistory_lbl.Size = new System.Drawing.Size(1051, 76);
            this.ServiceHistory_lbl.TabIndex = 76;
            this.ServiceHistory_lbl.Text = "Service History";
            this.ServiceHistory_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReturnArrow_pb
            // 
            this.ReturnArrow_pb.Image = ((System.Drawing.Image)(resources.GetObject("ReturnArrow_pb.Image")));
            this.ReturnArrow_pb.Location = new System.Drawing.Point(16, 12);
            this.ReturnArrow_pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReturnArrow_pb.Name = "ReturnArrow_pb";
            this.ReturnArrow_pb.Size = new System.Drawing.Size(68, 50);
            this.ReturnArrow_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReturnArrow_pb.TabIndex = 78;
            this.ReturnArrow_pb.TabStop = false;
            this.ReturnArrow_pb.Click += new System.EventHandler(this.ReturnArrow_pb_Click);
            this.ReturnArrow_pb.MouseEnter += new System.EventHandler(this.ReturnArrow_pb_MouseEnter);
            this.ReturnArrow_pb.MouseLeave += new System.EventHandler(this.ReturnArrow_pb_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 5);
            this.panel2.TabIndex = 77;
            // 
            // CustomerInfo_pnl
            // 
            this.CustomerInfo_pnl.AutoScroll = true;
            this.CustomerInfo_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CustomerInfo_pnl.Location = new System.Drawing.Point(0, 132);
            this.CustomerInfo_pnl.Name = "CustomerInfo_pnl";
            this.CustomerInfo_pnl.Size = new System.Drawing.Size(1051, 568);
            this.CustomerInfo_pnl.TabIndex = 79;
            // 
            // Underline_pnl
            // 
            this.Underline_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Underline_pnl.Location = new System.Drawing.Point(0, 131);
            this.Underline_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.Underline_pnl.Name = "Underline_pnl";
            this.Underline_pnl.Size = new System.Drawing.Size(1051, 3);
            this.Underline_pnl.TabIndex = 78;
            // 
            // Sold_lbl
            // 
            this.Sold_lbl.AutoSize = true;
            this.Sold_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sold_lbl.Location = new System.Drawing.Point(570, 93);
            this.Sold_lbl.Name = "Sold_lbl";
            this.Sold_lbl.Size = new System.Drawing.Size(93, 36);
            this.Sold_lbl.TabIndex = 85;
            this.Sold_lbl.Text = "Sold?";
            // 
            // Cost_lbl
            // 
            this.Cost_lbl.AutoSize = true;
            this.Cost_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost_lbl.Location = new System.Drawing.Point(720, 93);
            this.Cost_lbl.Name = "Cost_lbl";
            this.Cost_lbl.Size = new System.Drawing.Size(76, 36);
            this.Cost_lbl.TabIndex = 84;
            this.Cost_lbl.Text = "Cost";
            // 
            // Type_lbl
            // 
            this.Type_lbl.AutoSize = true;
            this.Type_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_lbl.Location = new System.Drawing.Point(405, 93);
            this.Type_lbl.Name = "Type_lbl";
            this.Type_lbl.Size = new System.Drawing.Size(81, 36);
            this.Type_lbl.TabIndex = 83;
            this.Type_lbl.Text = "Type";
            // 
            // Employee_lbl
            // 
            this.Employee_lbl.AutoSize = true;
            this.Employee_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_lbl.Location = new System.Drawing.Point(160, 93);
            this.Employee_lbl.Name = "Employee_lbl";
            this.Employee_lbl.Size = new System.Drawing.Size(146, 36);
            this.Employee_lbl.TabIndex = 81;
            this.Employee_lbl.Text = "Employee";
            // 
            // Date_lbl
            // 
            this.Date_lbl.AutoSize = true;
            this.Date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_lbl.Location = new System.Drawing.Point(3, 93);
            this.Date_lbl.Name = "Date_lbl";
            this.Date_lbl.Size = new System.Drawing.Size(76, 36);
            this.Date_lbl.TabIndex = 80;
            this.Date_lbl.Text = "Date";
            // 
            // NoServices_lbl
            // 
            this.NoServices_lbl.AutoSize = true;
            this.NoServices_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoServices_lbl.ForeColor = System.Drawing.Color.Red;
            this.NoServices_lbl.Location = new System.Drawing.Point(403, 85);
            this.NoServices_lbl.Name = "NoServices_lbl";
            this.NoServices_lbl.Size = new System.Drawing.Size(247, 46);
            this.NoServices_lbl.TabIndex = 86;
            this.NoServices_lbl.Text = "No Services";
            this.NoServices_lbl.Visible = false;
            // 
            // ServiceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.NoServices_lbl);
            this.Controls.Add(this.Sold_lbl);
            this.Controls.Add(this.Cost_lbl);
            this.Controls.Add(this.Type_lbl);
            this.Controls.Add(this.Employee_lbl);
            this.Controls.Add(this.Date_lbl);
            this.Controls.Add(this.Underline_pnl);
            this.Controls.Add(this.ReturnArrow_pb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CustomerInfo_pnl);
            this.Controls.Add(this.ServiceHistory_lbl);
            this.Name = "ServiceHistory";
            this.Size = new System.Drawing.Size(1051, 700);
            this.Load += new System.EventHandler(this.ServiceHistory_Load);
            this.VisibleChanged += new System.EventHandler(this.ServiceHistory_VisibleChanged);
            this.Enter += new System.EventHandler(this.ServiceHistory_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnArrow_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ReturnArrow_il;
        private System.Windows.Forms.Label ServiceHistory_lbl;
        private System.Windows.Forms.PictureBox ReturnArrow_pb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel CustomerInfo_pnl;
        private System.Windows.Forms.Panel Underline_pnl;
        private System.Windows.Forms.Label Sold_lbl;
        private System.Windows.Forms.Label Cost_lbl;
        private System.Windows.Forms.Label Type_lbl;
        private System.Windows.Forms.Label Employee_lbl;
        private System.Windows.Forms.Label Date_lbl;
        private System.Windows.Forms.Label NoServices_lbl;
    }
}
