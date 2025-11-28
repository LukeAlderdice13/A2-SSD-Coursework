namespace A2SSDCoursework
{
    partial class AddMake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMake));
            this.AddButton_pb = new System.Windows.Forms.PictureBox();
            this.AddButtonHover_pb = new System.Windows.Forms.PictureBox();
            this.MakeName_tbx = new System.Windows.Forms.TextBox();
            this.Info_pnl = new System.Windows.Forms.Panel();
            this.AddMake_btn = new System.Windows.Forms.Button();
            this.Escape_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddButton_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddButtonHover_pb)).BeginInit();
            this.Info_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton_pb
            // 
            this.AddButton_pb.Image = ((System.Drawing.Image)(resources.GetObject("AddButton_pb.Image")));
            this.AddButton_pb.Location = new System.Drawing.Point(22, 2);
            this.AddButton_pb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton_pb.Name = "AddButton_pb";
            this.AddButton_pb.Size = new System.Drawing.Size(131, 130);
            this.AddButton_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddButton_pb.TabIndex = 0;
            this.AddButton_pb.TabStop = false;
            this.AddButton_pb.Click += new System.EventHandler(this.AddButton_pb_Click);
            this.AddButton_pb.MouseEnter += new System.EventHandler(this.AddButton_pb_MouseEnter);
            this.AddButton_pb.MouseHover += new System.EventHandler(this.AddButton_pb_MouseHover);
            // 
            // AddButtonHover_pb
            // 
            this.AddButtonHover_pb.Image = ((System.Drawing.Image)(resources.GetObject("AddButtonHover_pb.Image")));
            this.AddButtonHover_pb.Location = new System.Drawing.Point(22, 2);
            this.AddButtonHover_pb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButtonHover_pb.Name = "AddButtonHover_pb";
            this.AddButtonHover_pb.Size = new System.Drawing.Size(131, 130);
            this.AddButtonHover_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddButtonHover_pb.TabIndex = 1;
            this.AddButtonHover_pb.TabStop = false;
            this.AddButtonHover_pb.Visible = false;
            this.AddButtonHover_pb.Click += new System.EventHandler(this.AddButtonHover_pb_Click);
            this.AddButtonHover_pb.MouseLeave += new System.EventHandler(this.AddButtonHover_pb_MouseLeave);
            // 
            // MakeName_tbx
            // 
            this.MakeName_tbx.BackColor = System.Drawing.Color.DarkGray;
            this.MakeName_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeName_tbx.Location = new System.Drawing.Point(0, 0);
            this.MakeName_tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MakeName_tbx.Name = "MakeName_tbx";
            this.MakeName_tbx.Size = new System.Drawing.Size(162, 37);
            this.MakeName_tbx.TabIndex = 10;
            this.MakeName_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MakeName_tbx_KeyDown);
            // 
            // Info_pnl
            // 
            this.Info_pnl.BackColor = System.Drawing.Color.Silver;
            this.Info_pnl.Controls.Add(this.MakeName_tbx);
            this.Info_pnl.Controls.Add(this.AddMake_btn);
            this.Info_pnl.Controls.Add(this.Escape_btn);
            this.Info_pnl.Location = new System.Drawing.Point(6, 5);
            this.Info_pnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Info_pnl.Name = "Info_pnl";
            this.Info_pnl.Size = new System.Drawing.Size(161, 123);
            this.Info_pnl.TabIndex = 13;
            this.Info_pnl.Visible = false;
            // 
            // AddMake_btn
            // 
            this.AddMake_btn.BackColor = System.Drawing.Color.Green;
            this.AddMake_btn.FlatAppearance.BorderSize = 0;
            this.AddMake_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMake_btn.Font = new System.Drawing.Font("Adobe Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMake_btn.ForeColor = System.Drawing.Color.White;
            this.AddMake_btn.Location = new System.Drawing.Point(0, 41);
            this.AddMake_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddMake_btn.Name = "AddMake_btn";
            this.AddMake_btn.Size = new System.Drawing.Size(161, 38);
            this.AddMake_btn.TabIndex = 8;
            this.AddMake_btn.Text = "Add";
            this.AddMake_btn.UseVisualStyleBackColor = false;
            this.AddMake_btn.Click += new System.EventHandler(this.AddMake_btn_Click);
            // 
            // Escape_btn
            // 
            this.Escape_btn.BackColor = System.Drawing.Color.Red;
            this.Escape_btn.FlatAppearance.BorderSize = 0;
            this.Escape_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Escape_btn.Font = new System.Drawing.Font("Adobe Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Escape_btn.ForeColor = System.Drawing.Color.White;
            this.Escape_btn.Location = new System.Drawing.Point(0, 84);
            this.Escape_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Escape_btn.Name = "Escape_btn";
            this.Escape_btn.Size = new System.Drawing.Size(161, 38);
            this.Escape_btn.TabIndex = 5;
            this.Escape_btn.Text = "Escape";
            this.Escape_btn.UseVisualStyleBackColor = false;
            this.Escape_btn.Click += new System.EventHandler(this.Escape_btn_Click);
            // 
            // AddMake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.Info_pnl);
            this.Controls.Add(this.AddButtonHover_pb);
            this.Controls.Add(this.AddButton_pb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddMake";
            this.Size = new System.Drawing.Size(172, 158);
            ((System.ComponentModel.ISupportInitialize)(this.AddButton_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddButtonHover_pb)).EndInit();
            this.Info_pnl.ResumeLayout(false);
            this.Info_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AddButton_pb;
        private System.Windows.Forms.PictureBox AddButtonHover_pb;
        private System.Windows.Forms.TextBox MakeName_tbx;
        private System.Windows.Forms.Panel Info_pnl;
        private System.Windows.Forms.Button AddMake_btn;
        private System.Windows.Forms.Button Escape_btn;
    }
}
