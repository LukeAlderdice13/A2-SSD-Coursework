namespace A2SSDCoursework
{
    partial class MakeCard
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
            this.MakeName_lbl = new System.Windows.Forms.Label();
            this.MakeName_tbx = new System.Windows.Forms.TextBox();
            this.DeleteMake_btn = new System.Windows.Forms.Button();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.Info_pnl = new System.Windows.Forms.Panel();
            this.ConfirmEdit_btn = new System.Windows.Forms.Button();
            this.EditName_btn = new System.Windows.Forms.Button();
            this.Info_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MakeName_lbl
            // 
            this.MakeName_lbl.AutoEllipsis = true;
            this.MakeName_lbl.BackColor = System.Drawing.Color.DarkGray;
            this.MakeName_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeName_lbl.ForeColor = System.Drawing.Color.Black;
            this.MakeName_lbl.Location = new System.Drawing.Point(8, 6);
            this.MakeName_lbl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.MakeName_lbl.Name = "MakeName_lbl";
            this.MakeName_lbl.Size = new System.Drawing.Size(215, 46);
            this.MakeName_lbl.TabIndex = 1;
            this.MakeName_lbl.Text = "Luke Alderdice";
            this.MakeName_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MakeName_tbx
            // 
            this.MakeName_tbx.BackColor = System.Drawing.Color.DarkGray;
            this.MakeName_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeName_tbx.Location = new System.Drawing.Point(8, 6);
            this.MakeName_tbx.Name = "MakeName_tbx";
            this.MakeName_tbx.Size = new System.Drawing.Size(215, 45);
            this.MakeName_tbx.TabIndex = 2;
            this.MakeName_tbx.Visible = false;
            // 
            // DeleteMake_btn
            // 
            this.DeleteMake_btn.BackColor = System.Drawing.Color.Red;
            this.DeleteMake_btn.FlatAppearance.BorderSize = 0;
            this.DeleteMake_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteMake_btn.Font = new System.Drawing.Font("Adobe Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMake_btn.ForeColor = System.Drawing.Color.White;
            this.DeleteMake_btn.Location = new System.Drawing.Point(0, 104);
            this.DeleteMake_btn.Name = "DeleteMake_btn";
            this.DeleteMake_btn.Size = new System.Drawing.Size(215, 47);
            this.DeleteMake_btn.TabIndex = 5;
            this.DeleteMake_btn.Text = "Delete";
            this.DeleteMake_btn.UseVisualStyleBackColor = false;
            this.DeleteMake_btn.Click += new System.EventHandler(this.DeleteMake_btn_Click);
            // 
            // Reset_btn
            // 
            this.Reset_btn.BackColor = System.Drawing.Color.Red;
            this.Reset_btn.FlatAppearance.BorderSize = 0;
            this.Reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_btn.Font = new System.Drawing.Font("Adobe Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_btn.ForeColor = System.Drawing.Color.White;
            this.Reset_btn.Location = new System.Drawing.Point(0, 104);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(215, 47);
            this.Reset_btn.TabIndex = 6;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = false;
            this.Reset_btn.Visible = false;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // Info_pnl
            // 
            this.Info_pnl.BackColor = System.Drawing.Color.Silver;
            this.Info_pnl.Controls.Add(this.Reset_btn);
            this.Info_pnl.Controls.Add(this.ConfirmEdit_btn);
            this.Info_pnl.Controls.Add(this.EditName_btn);
            this.Info_pnl.Controls.Add(this.DeleteMake_btn);
            this.Info_pnl.Location = new System.Drawing.Point(8, 6);
            this.Info_pnl.Name = "Info_pnl";
            this.Info_pnl.Size = new System.Drawing.Size(215, 151);
            this.Info_pnl.TabIndex = 7;
            // 
            // ConfirmEdit_btn
            // 
            this.ConfirmEdit_btn.BackColor = System.Drawing.Color.Green;
            this.ConfirmEdit_btn.FlatAppearance.BorderSize = 0;
            this.ConfirmEdit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmEdit_btn.Font = new System.Drawing.Font("Adobe Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmEdit_btn.ForeColor = System.Drawing.Color.White;
            this.ConfirmEdit_btn.Location = new System.Drawing.Point(0, 51);
            this.ConfirmEdit_btn.Name = "ConfirmEdit_btn";
            this.ConfirmEdit_btn.Size = new System.Drawing.Size(215, 47);
            this.ConfirmEdit_btn.TabIndex = 9;
            this.ConfirmEdit_btn.Text = "Confirm Edit";
            this.ConfirmEdit_btn.UseVisualStyleBackColor = false;
            this.ConfirmEdit_btn.Visible = false;
            this.ConfirmEdit_btn.Click += new System.EventHandler(this.ConfirmEdit_btn_Click);
            // 
            // EditName_btn
            // 
            this.EditName_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.EditName_btn.FlatAppearance.BorderSize = 0;
            this.EditName_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditName_btn.Font = new System.Drawing.Font("Adobe Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditName_btn.ForeColor = System.Drawing.Color.White;
            this.EditName_btn.Location = new System.Drawing.Point(0, 51);
            this.EditName_btn.Name = "EditName_btn";
            this.EditName_btn.Size = new System.Drawing.Size(215, 47);
            this.EditName_btn.TabIndex = 8;
            this.EditName_btn.Text = "Edit";
            this.EditName_btn.UseVisualStyleBackColor = false;
            this.EditName_btn.Click += new System.EventHandler(this.EditName_btn_Click);
            // 
            // MakeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MakeName_tbx);
            this.Controls.Add(this.MakeName_lbl);
            this.Controls.Add(this.Info_pnl);
            this.Name = "MakeCard";
            this.Size = new System.Drawing.Size(230, 195);
            this.MouseEnter += new System.EventHandler(this.MakeCard_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MakeCard_MouseLeave);
            this.Info_pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MakeName_lbl;
        private System.Windows.Forms.TextBox MakeName_tbx;
        private System.Windows.Forms.Button DeleteMake_btn;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Panel Info_pnl;
        private System.Windows.Forms.Button ConfirmEdit_btn;
        private System.Windows.Forms.Button EditName_btn;
    }
}
