namespace A2SSDCoursework
{
    partial class MainMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.NavBar = new System.Windows.Forms.Panel();
            this.HomeIcon_pb = new System.Windows.Forms.PictureBox();
            this.ReturnArrow_pb = new System.Windows.Forms.PictureBox();
            this.CurrentControl_lbl = new System.Windows.Forms.Label();
            this.MenuOptions_pnl = new System.Windows.Forms.Panel();
            this.MainDisplay_pnl = new System.Windows.Forms.Panel();
            this.ReturnArrow_il = new System.Windows.Forms.ImageList(this.components);
            this.HomeIcon_il = new System.Windows.Forms.ImageList(this.components);
            this.Icon_pb = new System.Windows.Forms.PictureBox();
            this.NavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnArrow_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.DimGray;
            this.NavBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NavBar.Controls.Add(this.Icon_pb);
            this.NavBar.Controls.Add(this.HomeIcon_pb);
            this.NavBar.Controls.Add(this.ReturnArrow_pb);
            this.NavBar.Controls.Add(this.CurrentControl_lbl);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1300, 40);
            this.NavBar.TabIndex = 7;
            this.NavBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseDown);
            this.NavBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseMove);
            this.NavBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseUp);
            // 
            // HomeIcon_pb
            // 
            this.HomeIcon_pb.Image = ((System.Drawing.Image)(resources.GetObject("HomeIcon_pb.Image")));
            this.HomeIcon_pb.Location = new System.Drawing.Point(2, -1);
            this.HomeIcon_pb.Name = "HomeIcon_pb";
            this.HomeIcon_pb.Size = new System.Drawing.Size(40, 40);
            this.HomeIcon_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeIcon_pb.TabIndex = 17;
            this.HomeIcon_pb.TabStop = false;
            this.HomeIcon_pb.Click += new System.EventHandler(this.HomeIcon_pb_Click);
            this.HomeIcon_pb.MouseEnter += new System.EventHandler(this.HomeIcon_pb_MouseEnter);
            this.HomeIcon_pb.MouseLeave += new System.EventHandler(this.HomeIcon_pb_MouseLeave);
            // 
            // ReturnArrow_pb
            // 
            this.ReturnArrow_pb.Image = ((System.Drawing.Image)(resources.GetObject("ReturnArrow_pb.Image")));
            this.ReturnArrow_pb.Location = new System.Drawing.Point(258, 1);
            this.ReturnArrow_pb.Name = "ReturnArrow_pb";
            this.ReturnArrow_pb.Size = new System.Drawing.Size(44, 35);
            this.ReturnArrow_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReturnArrow_pb.TabIndex = 16;
            this.ReturnArrow_pb.TabStop = false;
            this.ReturnArrow_pb.Visible = false;
            this.ReturnArrow_pb.Click += new System.EventHandler(this.ReturnArrow_pb_Click);
            this.ReturnArrow_pb.MouseEnter += new System.EventHandler(this.ReturnArrow_pb_MouseEnter);
            this.ReturnArrow_pb.MouseLeave += new System.EventHandler(this.ReturnArrow_pb_MouseLeave);
            // 
            // CurrentControl_lbl
            // 
            this.CurrentControl_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentControl_lbl.ForeColor = System.Drawing.Color.White;
            this.CurrentControl_lbl.Location = new System.Drawing.Point(959, 0);
            this.CurrentControl_lbl.Name = "CurrentControl_lbl";
            this.CurrentControl_lbl.Size = new System.Drawing.Size(340, 39);
            this.CurrentControl_lbl.TabIndex = 0;
            this.CurrentControl_lbl.Text = "Home";
            this.CurrentControl_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MenuOptions_pnl
            // 
            this.MenuOptions_pnl.BackColor = System.Drawing.Color.DarkGray;
            this.MenuOptions_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuOptions_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuOptions_pnl.Location = new System.Drawing.Point(0, 40);
            this.MenuOptions_pnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuOptions_pnl.Name = "MenuOptions_pnl";
            this.MenuOptions_pnl.Size = new System.Drawing.Size(250, 700);
            this.MenuOptions_pnl.TabIndex = 8;
            // 
            // MainDisplay_pnl
            // 
            this.MainDisplay_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MainDisplay_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainDisplay_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainDisplay_pnl.Location = new System.Drawing.Point(250, 40);
            this.MainDisplay_pnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainDisplay_pnl.Name = "MainDisplay_pnl";
            this.MainDisplay_pnl.Size = new System.Drawing.Size(1050, 700);
            this.MainDisplay_pnl.TabIndex = 9;
            // 
            // ReturnArrow_il
            // 
            this.ReturnArrow_il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ReturnArrow_il.ImageStream")));
            this.ReturnArrow_il.TransparentColor = System.Drawing.Color.Transparent;
            this.ReturnArrow_il.Images.SetKeyName(0, "BackArrow.png");
            this.ReturnArrow_il.Images.SetKeyName(1, "BackArrow_Selected.png");
            // 
            // HomeIcon_il
            // 
            this.HomeIcon_il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("HomeIcon_il.ImageStream")));
            this.HomeIcon_il.TransparentColor = System.Drawing.Color.Transparent;
            this.HomeIcon_il.Images.SetKeyName(0, "HomeIcon.png");
            this.HomeIcon_il.Images.SetKeyName(1, "HomeIconHighlighted.png");
            // 
            // Icon_pb
            // 
            this.Icon_pb.Image = ((System.Drawing.Image)(resources.GetObject("Icon_pb.Image")));
            this.Icon_pb.Location = new System.Drawing.Point(61, 2);
            this.Icon_pb.Name = "Icon_pb";
            this.Icon_pb.Size = new System.Drawing.Size(170, 40);
            this.Icon_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon_pb.TabIndex = 18;
            this.Icon_pb.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 740);
            this.Controls.Add(this.MainDisplay_pnl);
            this.Controls.Add(this.MenuOptions_pnl);
            this.Controls.Add(this.NavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.NavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnArrow_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel NavBar;
        public System.Windows.Forms.Panel MenuOptions_pnl;
        public System.Windows.Forms.Panel MainDisplay_pnl;
        private System.Windows.Forms.Label CurrentControl_lbl;
        private System.Windows.Forms.PictureBox ReturnArrow_pb;
        private System.Windows.Forms.ImageList ReturnArrow_il;
        private System.Windows.Forms.PictureBox HomeIcon_pb;
        private System.Windows.Forms.ImageList HomeIcon_il;
        private System.Windows.Forms.PictureBox Icon_pb;
    }
}