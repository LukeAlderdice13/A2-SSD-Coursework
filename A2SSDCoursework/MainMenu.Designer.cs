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
            this.NavBar = new System.Windows.Forms.Panel();
            this.MenuOptions_pnl = new System.Windows.Forms.Panel();
            this.MainDisplay_pnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.DimGray;
            this.NavBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1200, 40);
            this.NavBar.TabIndex = 7;
            this.NavBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseDown);
            this.NavBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseMove);
            this.NavBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseUp);
            // 
            // MenuOptions_pnl
            // 
            this.MenuOptions_pnl.BackColor = System.Drawing.Color.DarkGray;
            this.MenuOptions_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuOptions_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuOptions_pnl.Location = new System.Drawing.Point(0, 40);
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
            this.MainDisplay_pnl.Name = "MainDisplay_pnl";
            this.MainDisplay_pnl.Size = new System.Drawing.Size(950, 700);
            this.MainDisplay_pnl.TabIndex = 9;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 740);
            this.Controls.Add(this.MainDisplay_pnl);
            this.Controls.Add(this.MenuOptions_pnl);
            this.Controls.Add(this.NavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel NavBar;
        public System.Windows.Forms.Panel MenuOptions_pnl;
        public System.Windows.Forms.Panel MainDisplay_pnl;
    }
}