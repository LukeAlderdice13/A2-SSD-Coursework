namespace A2SSDCoursework
{
    partial class ViewVehicle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewVehicle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VehicleInfo_lbl = new System.Windows.Forms.Label();
            this.Make_lbl = new System.Windows.Forms.Label();
            this.YearMade_lbl = new System.Windows.Forms.Label();
            this.Model_lbl = new System.Windows.Forms.Label();
            this.Colour_lbl = new System.Windows.Forms.Label();
            this.EngineSize_lbl = new System.Windows.Forms.Label();
            this.Plate_lbl = new System.Windows.Forms.Label();
            this.Vin_lbl = new System.Windows.Forms.Label();
            this.FuelType_lbl = new System.Windows.Forms.Label();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.DatePurchased_lbl = new System.Windows.Forms.Label();
            this.minSellPrice_lbl = new System.Windows.Forms.Label();
            this.ReturnArrow_pb = new System.Windows.Forms.PictureBox();
            this.ReturnArrow_il = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.ActionsTitle_lbl = new System.Windows.Forms.Label();
            this.Actions_pnl = new System.Windows.Forms.Panel();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Sell_btn = new System.Windows.Forms.Button();
            this.RecordService_btn = new System.Windows.Forms.Button();
            this.Vehicle_pnl = new System.Windows.Forms.Panel();
            this.ServiceHistory_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnArrow_pb)).BeginInit();
            this.Actions_pnl.SuspendLayout();
            this.Vehicle_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 5);
            this.panel1.TabIndex = 3;
            // 
            // VehicleInfo_lbl
            // 
            this.VehicleInfo_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleInfo_lbl.Location = new System.Drawing.Point(0, 0);
            this.VehicleInfo_lbl.Name = "VehicleInfo_lbl";
            this.VehicleInfo_lbl.Size = new System.Drawing.Size(1050, 76);
            this.VehicleInfo_lbl.TabIndex = 2;
            this.VehicleInfo_lbl.Text = "Vehicle Info";
            this.VehicleInfo_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VehicleInfo_lbl.Click += new System.EventHandler(this.VehicleInfo_lbl_Click);
            // 
            // Make_lbl
            // 
            this.Make_lbl.AutoSize = true;
            this.Make_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Make_lbl.Location = new System.Drawing.Point(5, 81);
            this.Make_lbl.Name = "Make_lbl";
            this.Make_lbl.Size = new System.Drawing.Size(101, 41);
            this.Make_lbl.TabIndex = 5;
            this.Make_lbl.Text = "Make:";
            // 
            // YearMade_lbl
            // 
            this.YearMade_lbl.AutoSize = true;
            this.YearMade_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearMade_lbl.Location = new System.Drawing.Point(5, 165);
            this.YearMade_lbl.Name = "YearMade_lbl";
            this.YearMade_lbl.Size = new System.Drawing.Size(170, 41);
            this.YearMade_lbl.TabIndex = 6;
            this.YearMade_lbl.Text = "Year Made:";
            // 
            // Model_lbl
            // 
            this.Model_lbl.AutoSize = true;
            this.Model_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Model_lbl.Location = new System.Drawing.Point(5, 123);
            this.Model_lbl.Name = "Model_lbl";
            this.Model_lbl.Size = new System.Drawing.Size(113, 41);
            this.Model_lbl.TabIndex = 4;
            this.Model_lbl.Text = "Model:";
            // 
            // Colour_lbl
            // 
            this.Colour_lbl.AutoSize = true;
            this.Colour_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colour_lbl.Location = new System.Drawing.Point(5, 207);
            this.Colour_lbl.Name = "Colour_lbl";
            this.Colour_lbl.Size = new System.Drawing.Size(125, 41);
            this.Colour_lbl.TabIndex = 7;
            this.Colour_lbl.Text = "Colour:";
            // 
            // EngineSize_lbl
            // 
            this.EngineSize_lbl.AutoSize = true;
            this.EngineSize_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineSize_lbl.Location = new System.Drawing.Point(5, 249);
            this.EngineSize_lbl.Name = "EngineSize_lbl";
            this.EngineSize_lbl.Size = new System.Drawing.Size(183, 41);
            this.EngineSize_lbl.TabIndex = 8;
            this.EngineSize_lbl.Text = "Engine Size:";
            // 
            // Plate_lbl
            // 
            this.Plate_lbl.AutoSize = true;
            this.Plate_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plate_lbl.Location = new System.Drawing.Point(9, 206);
            this.Plate_lbl.Name = "Plate_lbl";
            this.Plate_lbl.Size = new System.Drawing.Size(215, 41);
            this.Plate_lbl.TabIndex = 9;
            this.Plate_lbl.Text = "Plate Number:";
            // 
            // Vin_lbl
            // 
            this.Vin_lbl.AutoSize = true;
            this.Vin_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vin_lbl.Location = new System.Drawing.Point(426, 81);
            this.Vin_lbl.Name = "Vin_lbl";
            this.Vin_lbl.Size = new System.Drawing.Size(75, 41);
            this.Vin_lbl.TabIndex = 10;
            this.Vin_lbl.Text = "Vin:";
            // 
            // FuelType_lbl
            // 
            this.FuelType_lbl.AutoSize = true;
            this.FuelType_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelType_lbl.Location = new System.Drawing.Point(426, 123);
            this.FuelType_lbl.Name = "FuelType_lbl";
            this.FuelType_lbl.Size = new System.Drawing.Size(159, 41);
            this.FuelType_lbl.TabIndex = 11;
            this.FuelType_lbl.Text = "Fuel Type:";
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_lbl.Location = new System.Drawing.Point(426, 165);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(95, 41);
            this.Price_lbl.TabIndex = 12;
            this.Price_lbl.Text = "Price:";
            // 
            // DatePurchased_lbl
            // 
            this.DatePurchased_lbl.AutoSize = true;
            this.DatePurchased_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePurchased_lbl.Location = new System.Drawing.Point(426, 248);
            this.DatePurchased_lbl.Name = "DatePurchased_lbl";
            this.DatePurchased_lbl.Size = new System.Drawing.Size(238, 41);
            this.DatePurchased_lbl.TabIndex = 13;
            this.DatePurchased_lbl.Text = "Date Purchased:";
            // 
            // minSellPrice_lbl
            // 
            this.minSellPrice_lbl.AutoSize = true;
            this.minSellPrice_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minSellPrice_lbl.Location = new System.Drawing.Point(426, 207);
            this.minSellPrice_lbl.Name = "minSellPrice_lbl";
            this.minSellPrice_lbl.Size = new System.Drawing.Size(217, 41);
            this.minSellPrice_lbl.TabIndex = 14;
            this.minSellPrice_lbl.Text = "Min Sell Price:";
            // 
            // ReturnArrow_pb
            // 
            this.ReturnArrow_pb.Image = ((System.Drawing.Image)(resources.GetObject("ReturnArrow_pb.Image")));
            this.ReturnArrow_pb.Location = new System.Drawing.Point(16, 12);
            this.ReturnArrow_pb.Name = "ReturnArrow_pb";
            this.ReturnArrow_pb.Size = new System.Drawing.Size(68, 50);
            this.ReturnArrow_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReturnArrow_pb.TabIndex = 15;
            this.ReturnArrow_pb.TabStop = false;
            this.ReturnArrow_pb.Click += new System.EventHandler(this.ReturnArrow_pb_Click);
            this.ReturnArrow_pb.MouseEnter += new System.EventHandler(this.ReturnArrow_pb_MouseEnter);
            this.ReturnArrow_pb.MouseLeave += new System.EventHandler(this.ReturnArrow_pb_MouseLeave);
            // 
            // ReturnArrow_il
            // 
            this.ReturnArrow_il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ReturnArrow_il.ImageStream")));
            this.ReturnArrow_il.TransparentColor = System.Drawing.Color.Transparent;
            this.ReturnArrow_il.Images.SetKeyName(0, "BackArrow.png");
            this.ReturnArrow_il.Images.SetKeyName(1, "BackArrow_Highlighted.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(418, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 5);
            this.panel2.TabIndex = 41;
            // 
            // ActionsTitle_lbl
            // 
            this.ActionsTitle_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionsTitle_lbl.Location = new System.Drawing.Point(31, -18);
            this.ActionsTitle_lbl.Name = "ActionsTitle_lbl";
            this.ActionsTitle_lbl.Size = new System.Drawing.Size(983, 76);
            this.ActionsTitle_lbl.TabIndex = 40;
            this.ActionsTitle_lbl.Text = "Actions";
            this.ActionsTitle_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Actions_pnl
            // 
            this.Actions_pnl.Controls.Add(this.Delete_btn);
            this.Actions_pnl.Controls.Add(this.Sell_btn);
            this.Actions_pnl.Controls.Add(this.RecordService_btn);
            this.Actions_pnl.Controls.Add(this.panel2);
            this.Actions_pnl.Controls.Add(this.ActionsTitle_lbl);
            this.Actions_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Actions_pnl.Location = new System.Drawing.Point(0, 341);
            this.Actions_pnl.Name = "Actions_pnl";
            this.Actions_pnl.Size = new System.Drawing.Size(1051, 280);
            this.Actions_pnl.TabIndex = 42;
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.Firebrick;
            this.Delete_btn.FlatAppearance.BorderSize = 0;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.White;
            this.Delete_btn.Location = new System.Drawing.Point(330, 170);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(363, 44);
            this.Delete_btn.TabIndex = 74;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            // 
            // Sell_btn
            // 
            this.Sell_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.Sell_btn.FlatAppearance.BorderSize = 0;
            this.Sell_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sell_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sell_btn.ForeColor = System.Drawing.Color.White;
            this.Sell_btn.Location = new System.Drawing.Point(330, 120);
            this.Sell_btn.Name = "Sell_btn";
            this.Sell_btn.Size = new System.Drawing.Size(363, 44);
            this.Sell_btn.TabIndex = 73;
            this.Sell_btn.Text = "Sell";
            this.Sell_btn.UseVisualStyleBackColor = false;
            // 
            // RecordService_btn
            // 
            this.RecordService_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.RecordService_btn.FlatAppearance.BorderSize = 0;
            this.RecordService_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecordService_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordService_btn.ForeColor = System.Drawing.Color.White;
            this.RecordService_btn.Location = new System.Drawing.Point(330, 70);
            this.RecordService_btn.Name = "RecordService_btn";
            this.RecordService_btn.Size = new System.Drawing.Size(363, 44);
            this.RecordService_btn.TabIndex = 72;
            this.RecordService_btn.Text = "Record Service";
            this.RecordService_btn.UseVisualStyleBackColor = false;
            this.RecordService_btn.Click += new System.EventHandler(this.RecordService_btn_Click);
            // 
            // Vehicle_pnl
            // 
            this.Vehicle_pnl.AutoScroll = true;
            this.Vehicle_pnl.Controls.Add(this.ServiceHistory_btn);
            this.Vehicle_pnl.Controls.Add(this.Actions_pnl);
            this.Vehicle_pnl.Controls.Add(this.Plate_lbl);
            this.Vehicle_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Vehicle_pnl.Location = new System.Drawing.Point(0, 79);
            this.Vehicle_pnl.Name = "Vehicle_pnl";
            this.Vehicle_pnl.Size = new System.Drawing.Size(1051, 621);
            this.Vehicle_pnl.TabIndex = 43;
            // 
            // ServiceHistory_btn
            // 
            this.ServiceHistory_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.ServiceHistory_btn.FlatAppearance.BorderSize = 0;
            this.ServiceHistory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServiceHistory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceHistory_btn.ForeColor = System.Drawing.Color.White;
            this.ServiceHistory_btn.Location = new System.Drawing.Point(330, 273);
            this.ServiceHistory_btn.Name = "ServiceHistory_btn";
            this.ServiceHistory_btn.Size = new System.Drawing.Size(363, 44);
            this.ServiceHistory_btn.TabIndex = 75;
            this.ServiceHistory_btn.Text = "View Service History";
            this.ServiceHistory_btn.UseVisualStyleBackColor = false;
            this.ServiceHistory_btn.Click += new System.EventHandler(this.ServiceHistory_btn_Click);
            // 
            // ViewVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.ReturnArrow_pb);
            this.Controls.Add(this.minSellPrice_lbl);
            this.Controls.Add(this.DatePurchased_lbl);
            this.Controls.Add(this.Price_lbl);
            this.Controls.Add(this.FuelType_lbl);
            this.Controls.Add(this.Vin_lbl);
            this.Controls.Add(this.EngineSize_lbl);
            this.Controls.Add(this.Colour_lbl);
            this.Controls.Add(this.YearMade_lbl);
            this.Controls.Add(this.Make_lbl);
            this.Controls.Add(this.Model_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VehicleInfo_lbl);
            this.Controls.Add(this.Vehicle_pnl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewVehicle";
            this.Size = new System.Drawing.Size(1051, 700);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnArrow_pb)).EndInit();
            this.Actions_pnl.ResumeLayout(false);
            this.Vehicle_pnl.ResumeLayout(false);
            this.Vehicle_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VehicleInfo_lbl;
        private System.Windows.Forms.Label Make_lbl;
        private System.Windows.Forms.Label YearMade_lbl;
        private System.Windows.Forms.Label Model_lbl;
        private System.Windows.Forms.Label Colour_lbl;
        private System.Windows.Forms.Label EngineSize_lbl;
        private System.Windows.Forms.Label Plate_lbl;
        private System.Windows.Forms.Label Vin_lbl;
        private System.Windows.Forms.Label FuelType_lbl;
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.Label DatePurchased_lbl;
        private System.Windows.Forms.Label minSellPrice_lbl;
        private System.Windows.Forms.PictureBox ReturnArrow_pb;
        private System.Windows.Forms.ImageList ReturnArrow_il;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ActionsTitle_lbl;
        private System.Windows.Forms.Panel Actions_pnl;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Sell_btn;
        private System.Windows.Forms.Button RecordService_btn;
        private System.Windows.Forms.Panel Vehicle_pnl;
        private System.Windows.Forms.Button ServiceHistory_btn;
    }
}
