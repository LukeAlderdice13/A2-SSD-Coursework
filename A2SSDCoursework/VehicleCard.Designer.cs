namespace A2SSDCoursework
{
    partial class VehicleCard
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
            this.Make_lbl = new System.Windows.Forms.Label();
            this.Colour_lbl = new System.Windows.Forms.Label();
            this.Info_pnl = new System.Windows.Forms.Panel();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.FuelType_lbl = new System.Windows.Forms.Label();
            this.Plate_lbl = new System.Windows.Forms.Label();
            this.ViewVehicle_btn = new System.Windows.Forms.Button();
            this.EngineSize_lbl = new System.Windows.Forms.Label();
            this.Model_lbl = new System.Windows.Forms.Label();
            this.Info_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Make_lbl
            // 
            this.Make_lbl.AutoEllipsis = true;
            this.Make_lbl.BackColor = System.Drawing.Color.DarkGray;
            this.Make_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Make_lbl.ForeColor = System.Drawing.Color.Black;
            this.Make_lbl.Location = new System.Drawing.Point(3, 3);
            this.Make_lbl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Make_lbl.Name = "Make_lbl";
            this.Make_lbl.Size = new System.Drawing.Size(224, 34);
            this.Make_lbl.TabIndex = 4;
            this.Make_lbl.Text = "Test\r\n";
            this.Make_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Colour_lbl
            // 
            this.Colour_lbl.AutoEllipsis = true;
            this.Colour_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Colour_lbl.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colour_lbl.Location = new System.Drawing.Point(0, 0);
            this.Colour_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Colour_lbl.Name = "Colour_lbl";
            this.Colour_lbl.Size = new System.Drawing.Size(224, 35);
            this.Colour_lbl.TabIndex = 2;
            this.Colour_lbl.Text = "Colour: Red";
            this.Colour_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Info_pnl
            // 
            this.Info_pnl.BackColor = System.Drawing.Color.Silver;
            this.Info_pnl.Controls.Add(this.Price_lbl);
            this.Info_pnl.Controls.Add(this.FuelType_lbl);
            this.Info_pnl.Controls.Add(this.Plate_lbl);
            this.Info_pnl.Controls.Add(this.ViewVehicle_btn);
            this.Info_pnl.Controls.Add(this.EngineSize_lbl);
            this.Info_pnl.Controls.Add(this.Colour_lbl);
            this.Info_pnl.Location = new System.Drawing.Point(3, 78);
            this.Info_pnl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Info_pnl.Name = "Info_pnl";
            this.Info_pnl.Size = new System.Drawing.Size(224, 232);
            this.Info_pnl.TabIndex = 5;
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoEllipsis = true;
            this.Price_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Price_lbl.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_lbl.Location = new System.Drawing.Point(0, 140);
            this.Price_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(224, 35);
            this.Price_lbl.TabIndex = 7;
            this.Price_lbl.Text = "Price: £4999";
            this.Price_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FuelType_lbl
            // 
            this.FuelType_lbl.AutoEllipsis = true;
            this.FuelType_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.FuelType_lbl.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelType_lbl.Location = new System.Drawing.Point(0, 105);
            this.FuelType_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FuelType_lbl.Name = "FuelType_lbl";
            this.FuelType_lbl.Size = new System.Drawing.Size(224, 35);
            this.FuelType_lbl.TabIndex = 6;
            this.FuelType_lbl.Text = "Fuel Type: Unleaded";
            this.FuelType_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Plate_lbl
            // 
            this.Plate_lbl.AutoEllipsis = true;
            this.Plate_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Plate_lbl.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plate_lbl.Location = new System.Drawing.Point(0, 70);
            this.Plate_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Plate_lbl.Name = "Plate_lbl";
            this.Plate_lbl.Size = new System.Drawing.Size(224, 35);
            this.Plate_lbl.TabIndex = 5;
            this.Plate_lbl.Text = "Plate: 234 PSU3";
            this.Plate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewVehicle_btn
            // 
            this.ViewVehicle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ViewVehicle_btn.FlatAppearance.BorderSize = 0;
            this.ViewVehicle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewVehicle_btn.Font = new System.Drawing.Font("Adobe Hebrew", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewVehicle_btn.Location = new System.Drawing.Point(5, 181);
            this.ViewVehicle_btn.Name = "ViewVehicle_btn";
            this.ViewVehicle_btn.Size = new System.Drawing.Size(215, 47);
            this.ViewVehicle_btn.TabIndex = 4;
            this.ViewVehicle_btn.Text = "View Vehicle";
            this.ViewVehicle_btn.UseVisualStyleBackColor = false;
            this.ViewVehicle_btn.Click += new System.EventHandler(this.ViewVehicle_btn_Click);
            // 
            // EngineSize_lbl
            // 
            this.EngineSize_lbl.AutoEllipsis = true;
            this.EngineSize_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.EngineSize_lbl.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineSize_lbl.Location = new System.Drawing.Point(0, 35);
            this.EngineSize_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EngineSize_lbl.Name = "EngineSize_lbl";
            this.EngineSize_lbl.Size = new System.Drawing.Size(224, 35);
            this.EngineSize_lbl.TabIndex = 3;
            this.EngineSize_lbl.Text = "Engine Size: 1.23";
            this.EngineSize_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Model_lbl
            // 
            this.Model_lbl.AutoEllipsis = true;
            this.Model_lbl.BackColor = System.Drawing.Color.DarkGray;
            this.Model_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Model_lbl.ForeColor = System.Drawing.Color.Black;
            this.Model_lbl.Location = new System.Drawing.Point(3, 40);
            this.Model_lbl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Model_lbl.Name = "Model_lbl";
            this.Model_lbl.Size = new System.Drawing.Size(224, 34);
            this.Model_lbl.TabIndex = 6;
            this.Model_lbl.Text = "Test\r\n";
            this.Model_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VehicleCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.Model_lbl);
            this.Controls.Add(this.Make_lbl);
            this.Controls.Add(this.Info_pnl);
            this.Name = "VehicleCard";
            this.Size = new System.Drawing.Size(230, 314);
            this.Info_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Make_lbl;
        private System.Windows.Forms.Label Colour_lbl;
        private System.Windows.Forms.Panel Info_pnl;
        private System.Windows.Forms.Button ViewVehicle_btn;
        private System.Windows.Forms.Label EngineSize_lbl;
        private System.Windows.Forms.Label Plate_lbl;
        private System.Windows.Forms.Label FuelType_lbl;
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.Label Model_lbl;
    }
}
