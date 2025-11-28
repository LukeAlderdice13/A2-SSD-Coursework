namespace A2SSDCoursework
{
    partial class Form1
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
            this.DohertyCars_lbl = new System.Windows.Forms.Label();
            this.LoginTitle_lbl = new System.Windows.Forms.Label();
            this.username_tbx = new System.Windows.Forms.TextBox();
            this.password_tbx = new System.Windows.Forms.TextBox();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.NavBar = new System.Windows.Forms.Panel();
            this.Login_btn = new System.Windows.Forms.Button();
            this.MainDisplay_pnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DohertyCars_lbl
            // 
            this.DohertyCars_lbl.AutoSize = true;
            this.DohertyCars_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DohertyCars_lbl.ForeColor = System.Drawing.Color.Black;
            this.DohertyCars_lbl.Location = new System.Drawing.Point(301, 41);
            this.DohertyCars_lbl.Name = "DohertyCars_lbl";
            this.DohertyCars_lbl.Size = new System.Drawing.Size(490, 100);
            this.DohertyCars_lbl.TabIndex = 0;
            this.DohertyCars_lbl.Text = "Doherty Cars";
            // 
            // LoginTitle_lbl
            // 
            this.LoginTitle_lbl.AutoSize = true;
            this.LoginTitle_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitle_lbl.Location = new System.Drawing.Point(454, 125);
            this.LoginTitle_lbl.Name = "LoginTitle_lbl";
            this.LoginTitle_lbl.Size = new System.Drawing.Size(178, 75);
            this.LoginTitle_lbl.TabIndex = 1;
            this.LoginTitle_lbl.Text = "Login";
            // 
            // username_tbx
            // 
            this.username_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tbx.Location = new System.Drawing.Point(323, 258);
            this.username_tbx.Name = "username_tbx";
            this.username_tbx.Size = new System.Drawing.Size(447, 53);
            this.username_tbx.TabIndex = 2;
            this.username_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_tbx_KeyDown);
            // 
            // password_tbx
            // 
            this.password_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tbx.Location = new System.Drawing.Point(323, 378);
            this.password_tbx.Name = "password_tbx";
            this.password_tbx.Size = new System.Drawing.Size(447, 53);
            this.password_tbx.TabIndex = 3;
            this.password_tbx.UseSystemPasswordChar = true;
            this.password_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_tbx_KeyDown);
            this.password_tbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_tbx_KeyPress);
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.Location = new System.Drawing.Point(446, 206);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(189, 50);
            this.Username_lbl.TabIndex = 4;
            this.Username_lbl.Text = "Username";
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lbl.Location = new System.Drawing.Point(454, 325);
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
            this.Login_btn.Font = new System.Drawing.Font("Adobe Hebrew", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.Location = new System.Drawing.Point(404, 454);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(289, 64);
            this.Login_btn.TabIndex = 7;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // MainDisplay_pnl
            // 
            this.MainDisplay_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MainDisplay_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainDisplay_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainDisplay_pnl.Location = new System.Drawing.Point(0, 40);
            this.MainDisplay_pnl.Name = "MainDisplay_pnl";
            this.MainDisplay_pnl.Size = new System.Drawing.Size(1100, 505);
            this.MainDisplay_pnl.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1100, 545);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.NavBar);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.password_tbx);
            this.Controls.Add(this.username_tbx);
            this.Controls.Add(this.LoginTitle_lbl);
            this.Controls.Add(this.DohertyCars_lbl);
            this.Controls.Add(this.MainDisplay_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1100, 545);
            this.MinimumSize = new System.Drawing.Size(1100, 545);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DohertyCars_lbl;
        private System.Windows.Forms.Label LoginTitle_lbl;
        private System.Windows.Forms.TextBox username_tbx;
        private System.Windows.Forms.TextBox password_tbx;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Button Login_btn;
        public System.Windows.Forms.Panel MainDisplay_pnl;
    }
}

