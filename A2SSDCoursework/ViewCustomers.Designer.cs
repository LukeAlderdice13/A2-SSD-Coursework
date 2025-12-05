namespace A2SSDCoursework
{
    partial class ViewCustomers
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
            this.Customers_pnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Customers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Customers_pnl
            // 
            this.Customers_pnl.AutoScroll = true;
            this.Customers_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Customers_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Customers_pnl.Location = new System.Drawing.Point(0, 79);
            this.Customers_pnl.Name = "Customers_pnl";
            this.Customers_pnl.Size = new System.Drawing.Size(950, 621);
            this.Customers_pnl.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 5);
            this.panel1.TabIndex = 9;
            // 
            // Customers
            // 
            this.Customers.Font = new System.Drawing.Font("Adobe Hebrew", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers.Location = new System.Drawing.Point(0, 0);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(950, 76);
            this.Customers.TabIndex = 8;
            this.Customers.Text = "Customers";
            this.Customers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Customers_pnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Customers);
            this.Name = "ViewCustomers";
            this.Size = new System.Drawing.Size(950, 700);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Customers_pnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Customers;
    }
}
