namespace A2SSDCoursework
{
    partial class CustomerCard
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
            this.CustomerName_lbl = new System.Windows.Forms.Label();
            this.MoneySpent_lbl = new System.Windows.Forms.Label();
            this.VehiclesBought_lbl = new System.Windows.Forms.Label();
            this.Info_pnl = new System.Windows.Forms.Panel();
            this.ViewCustomer_lbl = new System.Windows.Forms.Button();
            this.Info_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerName_lbl
            // 
            this.CustomerName_lbl.AutoEllipsis = true;
            this.CustomerName_lbl.BackColor = System.Drawing.Color.DarkGray;
            this.CustomerName_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName_lbl.ForeColor = System.Drawing.Color.Black;
            this.CustomerName_lbl.Location = new System.Drawing.Point(3, 4);
            this.CustomerName_lbl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.CustomerName_lbl.Name = "CustomerName_lbl";
            this.CustomerName_lbl.Size = new System.Drawing.Size(224, 46);
            this.CustomerName_lbl.TabIndex = 4;
            this.CustomerName_lbl.Text = "Luke Alderdice";
            this.CustomerName_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoneySpent_lbl
            // 
            this.MoneySpent_lbl.AutoEllipsis = true;
            this.MoneySpent_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoneySpent_lbl.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneySpent_lbl.Location = new System.Drawing.Point(0, 35);
            this.MoneySpent_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MoneySpent_lbl.Name = "MoneySpent_lbl";
            this.MoneySpent_lbl.Size = new System.Drawing.Size(224, 35);
            this.MoneySpent_lbl.TabIndex = 2;
            this.MoneySpent_lbl.Text = "Spent: £100000";
            this.MoneySpent_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VehiclesBought_lbl
            // 
            this.VehiclesBought_lbl.AutoEllipsis = true;
            this.VehiclesBought_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.VehiclesBought_lbl.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiclesBought_lbl.Location = new System.Drawing.Point(0, 0);
            this.VehiclesBought_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.VehiclesBought_lbl.Name = "VehiclesBought_lbl";
            this.VehiclesBought_lbl.Size = new System.Drawing.Size(224, 35);
            this.VehiclesBought_lbl.TabIndex = 1;
            this.VehiclesBought_lbl.Text = "Vehicles Bought:";
            this.VehiclesBought_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Info_pnl
            // 
            this.Info_pnl.BackColor = System.Drawing.Color.Silver;
            this.Info_pnl.Controls.Add(this.ViewCustomer_lbl);
            this.Info_pnl.Controls.Add(this.MoneySpent_lbl);
            this.Info_pnl.Controls.Add(this.VehiclesBought_lbl);
            this.Info_pnl.Location = new System.Drawing.Point(3, 48);
            this.Info_pnl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Info_pnl.Name = "Info_pnl";
            this.Info_pnl.Size = new System.Drawing.Size(224, 124);
            this.Info_pnl.TabIndex = 5;
            // 
            // ViewCustomer_lbl
            // 
            this.ViewCustomer_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ViewCustomer_lbl.FlatAppearance.BorderSize = 0;
            this.ViewCustomer_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewCustomer_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCustomer_lbl.Location = new System.Drawing.Point(5, 71);
            this.ViewCustomer_lbl.Name = "ViewCustomer_lbl";
            this.ViewCustomer_lbl.Size = new System.Drawing.Size(215, 47);
            this.ViewCustomer_lbl.TabIndex = 4;
            this.ViewCustomer_lbl.Text = "View Customer";
            this.ViewCustomer_lbl.UseVisualStyleBackColor = false;
            this.ViewCustomer_lbl.Click += new System.EventHandler(this.ViewCustomer_lbl_Click);
            // 
            // CustomerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomerName_lbl);
            this.Controls.Add(this.Info_pnl);
            this.Name = "CustomerCard";
            this.Size = new System.Drawing.Size(230, 176);
            this.Info_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CustomerName_lbl;
        private System.Windows.Forms.Label MoneySpent_lbl;
        private System.Windows.Forms.Label VehiclesBought_lbl;
        private System.Windows.Forms.Panel Info_pnl;
        private System.Windows.Forms.Button ViewCustomer_lbl;
    }
}
