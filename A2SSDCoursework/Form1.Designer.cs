namespace A2SSDCoursework
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginTitle_lbl = new System.Windows.Forms.Label();
            this.username_tbx = new System.Windows.Forms.TextBox();
            this.password_tbx = new System.Windows.Forms.TextBox();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.NavBar = new System.Windows.Forms.Panel();
            this.Login_btn = new System.Windows.Forms.Button();
            this.MainDisplay_pnl = new System.Windows.Forms.Panel();
            this.Logo_pb = new System.Windows.Forms.PictureBox();
            this.MainDisplay_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTitle_lbl
            // 
            this.LoginTitle_lbl.AutoSize = true;
            this.LoginTitle_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitle_lbl.Location = new System.Drawing.Point(451, 257);
            this.LoginTitle_lbl.Name = "LoginTitle_lbl";
            this.LoginTitle_lbl.Size = new System.Drawing.Size(178, 75);
            this.LoginTitle_lbl.TabIndex = 1;
            this.LoginTitle_lbl.Text = "Login";
            // 
            // username_tbx
            // 
            this.username_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tbx.Location = new System.Drawing.Point(319, 390);
            this.username_tbx.Name = "username_tbx";
            this.username_tbx.Size = new System.Drawing.Size(450, 53);
            this.username_tbx.TabIndex = 2;
            this.username_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_tbx_KeyDown);
            // 
            // password_tbx
            // 
            this.password_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tbx.Location = new System.Drawing.Point(319, 510);
            this.password_tbx.Name = "password_tbx";
            this.password_tbx.Size = new System.Drawing.Size(450, 53);
            this.password_tbx.TabIndex = 3;
            this.password_tbx.UseSystemPasswordChar = true;
            this.password_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_tbx_KeyDown);
            this.password_tbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_tbx_KeyPress);
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.Location = new System.Drawing.Point(443, 338);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(189, 50);
            this.Username_lbl.TabIndex = 4;
            this.Username_lbl.Text = "Username";
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lbl.Location = new System.Drawing.Point(451, 457);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(178, 50);
            this.Password_lbl.TabIndex = 5;
            this.Password_lbl.Text = "Password";
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.DimGray;
            this.NavBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1100, 40);
            this.NavBar.TabIndex = 6;
            this.NavBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseDown);
            this.NavBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseMove);
            this.NavBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseUp);
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Login_btn.FlatAppearance.BorderSize = 0;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Adobe Hebrew", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_btn.Location = new System.Drawing.Point(401, 586);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(290, 64);
            this.Login_btn.TabIndex = 7;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // MainDisplay_pnl
            // 
            this.MainDisplay_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MainDisplay_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainDisplay_pnl.Controls.Add(this.Login_btn);
            this.MainDisplay_pnl.Controls.Add(this.Logo_pb);
            this.MainDisplay_pnl.Controls.Add(this.username_tbx);
            this.MainDisplay_pnl.Controls.Add(this.Password_lbl);
            this.MainDisplay_pnl.Controls.Add(this.LoginTitle_lbl);
            this.MainDisplay_pnl.Controls.Add(this.Username_lbl);
            this.MainDisplay_pnl.Controls.Add(this.password_tbx);
            this.MainDisplay_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDisplay_pnl.Location = new System.Drawing.Point(0, 0);
            this.MainDisplay_pnl.Name = "MainDisplay_pnl";
            this.MainDisplay_pnl.Size = new System.Drawing.Size(1100, 670);
            this.MainDisplay_pnl.TabIndex = 10;
            // 
            // Logo_pb
            // 
            this.Logo_pb.Image = ((System.Drawing.Image)(resources.GetObject("Logo_pb.Image")));
            this.Logo_pb.Location = new System.Drawing.Point(203, 45);
            this.Logo_pb.Name = "Logo_pb";
            this.Logo_pb.Size = new System.Drawing.Size(671, 212);
            this.Logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_pb.TabIndex = 1;
            this.Logo_pb.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1100, 670);
            this.Controls.Add(this.NavBar);
            this.Controls.Add(this.MainDisplay_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1100, 670);
            this.MinimumSize = new System.Drawing.Size(1100, 670);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainDisplay_pnl.ResumeLayout(false);
            this.MainDisplay_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LoginTitle_lbl;
        private System.Windows.Forms.TextBox username_tbx;
        private System.Windows.Forms.TextBox password_tbx;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Button Login_btn;
        public System.Windows.Forms.Panel MainDisplay_pnl;
        private System.Windows.Forms.PictureBox Logo_pb;
    }
}

