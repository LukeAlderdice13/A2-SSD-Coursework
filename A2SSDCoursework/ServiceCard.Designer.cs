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
            ((System.ComponentModel.ISupportInitialize)(this.Delete_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_pb)).BeginInit();
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
            this.Sold_lbl.Text = "Sold?";
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
            // ServiceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Edit_pb);
            this.Controls.Add(this.Delete_pb);
            this.Controls.Add(this.ServiceType_lbl);
            this.Controls.Add(this.Sold_lbl);
            this.Controls.Add(this.Cost_lbl);
            this.Controls.Add(this.Employee_lbl);
            this.Controls.Add(this.Date_lbl);
            this.Name = "ServiceCard";
            this.Size = new System.Drawing.Size(1051, 90);
            this.MouseEnter += new System.EventHandler(this.ServiceCard_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ServiceCard_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.Delete_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_pb)).EndInit();
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
    }
}
