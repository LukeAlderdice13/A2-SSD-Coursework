namespace A2SSDCoursework
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.Logo_pb = new System.Windows.Forms.PictureBox();
            this.VehicleServicing_lbl = new System.Windows.Forms.Label();
            this.OutOfStock_lbl = new System.Windows.Forms.Label();
            this.EmptyRoles_lbl = new System.Windows.Forms.Label();
            this.OutOfStock_lb = new System.Windows.Forms.ListBox();
            this.Roles_lb = new System.Windows.Forms.ListBox();
            this.Servicing_lb = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo_pb
            // 
            this.Logo_pb.Image = ((System.Drawing.Image)(resources.GetObject("Logo_pb.Image")));
            this.Logo_pb.Location = new System.Drawing.Point(129, 18);
            this.Logo_pb.Name = "Logo_pb";
            this.Logo_pb.Size = new System.Drawing.Size(768, 242);
            this.Logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_pb.TabIndex = 0;
            this.Logo_pb.TabStop = false;
            // 
            // VehicleServicing_lbl
            // 
            this.VehicleServicing_lbl.AutoSize = true;
            this.VehicleServicing_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleServicing_lbl.Location = new System.Drawing.Point(403, 339);
            this.VehicleServicing_lbl.Name = "VehicleServicing_lbl";
            this.VehicleServicing_lbl.Size = new System.Drawing.Size(219, 41);
            this.VehicleServicing_lbl.TabIndex = 96;
            this.VehicleServicing_lbl.Tag = "PrivateInfoLabel";
            this.VehicleServicing_lbl.Text = "Need Serviced:";
            this.VehicleServicing_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutOfStock_lbl
            // 
            this.OutOfStock_lbl.AutoSize = true;
            this.OutOfStock_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutOfStock_lbl.Location = new System.Drawing.Point(58, 339);
            this.OutOfStock_lbl.Name = "OutOfStock_lbl";
            this.OutOfStock_lbl.Size = new System.Drawing.Size(197, 41);
            this.OutOfStock_lbl.TabIndex = 97;
            this.OutOfStock_lbl.Tag = "PrivateInfoLabel";
            this.OutOfStock_lbl.Text = "Out of Stock:";
            this.OutOfStock_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmptyRoles_lbl
            // 
            this.EmptyRoles_lbl.AutoSize = true;
            this.EmptyRoles_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyRoles_lbl.Location = new System.Drawing.Point(772, 339);
            this.EmptyRoles_lbl.Name = "EmptyRoles_lbl";
            this.EmptyRoles_lbl.Size = new System.Drawing.Size(197, 41);
            this.EmptyRoles_lbl.TabIndex = 98;
            this.EmptyRoles_lbl.Tag = "PrivateInfoLabel";
            this.EmptyRoles_lbl.Text = "Empty Roles:";
            this.EmptyRoles_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OutOfStock_lb
            // 
            this.OutOfStock_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutOfStock_lb.FormattingEnabled = true;
            this.OutOfStock_lb.ItemHeight = 29;
            this.OutOfStock_lb.Location = new System.Drawing.Point(26, 383);
            this.OutOfStock_lb.Name = "OutOfStock_lb";
            this.OutOfStock_lb.Size = new System.Drawing.Size(277, 294);
            this.OutOfStock_lb.TabIndex = 116;
            this.OutOfStock_lb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OutOfStock_lb_MouseClick);
            // 
            // Roles_lb
            // 
            this.Roles_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roles_lb.FormattingEnabled = true;
            this.Roles_lb.ItemHeight = 29;
            this.Roles_lb.Location = new System.Drawing.Point(740, 383);
            this.Roles_lb.Name = "Roles_lb";
            this.Roles_lb.Size = new System.Drawing.Size(277, 294);
            this.Roles_lb.TabIndex = 117;
            this.Roles_lb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Roles_lb_MouseClick);
            // 
            // Servicing_lb
            // 
            this.Servicing_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Servicing_lb.FormattingEnabled = true;
            this.Servicing_lb.ItemHeight = 29;
            this.Servicing_lb.Location = new System.Drawing.Point(383, 383);
            this.Servicing_lb.Name = "Servicing_lb";
            this.Servicing_lb.Size = new System.Drawing.Size(277, 294);
            this.Servicing_lb.TabIndex = 118;
            this.Servicing_lb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Servicing_lb_MouseClick);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.Servicing_lb);
            this.Controls.Add(this.Roles_lb);
            this.Controls.Add(this.OutOfStock_lb);
            this.Controls.Add(this.EmptyRoles_lbl);
            this.Controls.Add(this.OutOfStock_lbl);
            this.Controls.Add(this.VehicleServicing_lbl);
            this.Controls.Add(this.Logo_pb);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1050, 700);
            this.Tag = "Home";
            this.EnabledChanged += new System.EventHandler(this.HomePage_EnabledChanged);
            this.VisibleChanged += new System.EventHandler(this.HomePage_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo_pb;
        private System.Windows.Forms.Label VehicleServicing_lbl;
        private System.Windows.Forms.Label OutOfStock_lbl;
        private System.Windows.Forms.Label EmptyRoles_lbl;
        private System.Windows.Forms.ListBox OutOfStock_lb;
        private System.Windows.Forms.ListBox Roles_lb;
        private System.Windows.Forms.ListBox Servicing_lb;
    }
}
