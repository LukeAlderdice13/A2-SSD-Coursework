namespace A2SSDCoursework
{
    partial class SoldVehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoldVehicles));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SoldVehicles_lbl = new System.Windows.Forms.Label();
            this.Vehicles_pnl = new System.Windows.Forms.Panel();
            this.Search_pnl = new System.Windows.Forms.Panel();
            this.ResetSearch_lbl = new System.Windows.Forms.Label();
            this.MaxPrice_nud = new System.Windows.Forms.NumericUpDown();
            this.SearchIcon_pb = new System.Windows.Forms.PictureBox();
            this.MaxPrice_lbl = new System.Windows.Forms.Label();
            this.Colour_cb = new System.Windows.Forms.ComboBox();
            this.FuelType_lbl = new System.Windows.Forms.Label();
            this.FuelType_cb = new System.Windows.Forms.ComboBox();
            this.Colour_lbl = new System.Windows.Forms.Label();
            this.Make_lbl = new System.Windows.Forms.Label();
            this.ModelName_lbl = new System.Windows.Forms.Label();
            this.Makes_cb = new System.Windows.Forms.ComboBox();
            this.ModelName_tbx = new System.Windows.Forms.TextBox();
            this.Search_lbl = new System.Windows.Forms.Label();
            this.SearchIcon_il = new System.Windows.Forms.ImageList(this.components);
            this.Search_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrice_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 5);
            this.panel1.TabIndex = 9;
            // 
            // SoldVehicles_lbl
            // 
            this.SoldVehicles_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldVehicles_lbl.Location = new System.Drawing.Point(0, 0);
            this.SoldVehicles_lbl.Name = "SoldVehicles_lbl";
            this.SoldVehicles_lbl.Size = new System.Drawing.Size(1050, 76);
            this.SoldVehicles_lbl.TabIndex = 8;
            this.SoldVehicles_lbl.Text = "Sold Vehicles";
            this.SoldVehicles_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Vehicles_pnl
            // 
            this.Vehicles_pnl.AutoScroll = true;
            this.Vehicles_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Vehicles_pnl.Location = new System.Drawing.Point(0, 79);
            this.Vehicles_pnl.Name = "Vehicles_pnl";
            this.Vehicles_pnl.Size = new System.Drawing.Size(725, 621);
            this.Vehicles_pnl.TabIndex = 10;
            // 
            // Search_pnl
            // 
            this.Search_pnl.AutoScroll = true;
            this.Search_pnl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Search_pnl.Controls.Add(this.ResetSearch_lbl);
            this.Search_pnl.Controls.Add(this.MaxPrice_nud);
            this.Search_pnl.Controls.Add(this.SearchIcon_pb);
            this.Search_pnl.Controls.Add(this.MaxPrice_lbl);
            this.Search_pnl.Controls.Add(this.Colour_cb);
            this.Search_pnl.Controls.Add(this.FuelType_lbl);
            this.Search_pnl.Controls.Add(this.FuelType_cb);
            this.Search_pnl.Controls.Add(this.Colour_lbl);
            this.Search_pnl.Controls.Add(this.Make_lbl);
            this.Search_pnl.Controls.Add(this.ModelName_lbl);
            this.Search_pnl.Controls.Add(this.Makes_cb);
            this.Search_pnl.Controls.Add(this.ModelName_tbx);
            this.Search_pnl.Controls.Add(this.Search_lbl);
            this.Search_pnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_pnl.Location = new System.Drawing.Point(713, 79);
            this.Search_pnl.Name = "Search_pnl";
            this.Search_pnl.Size = new System.Drawing.Size(337, 621);
            this.Search_pnl.TabIndex = 11;
            // 
            // ResetSearch_lbl
            // 
            this.ResetSearch_lbl.AutoSize = true;
            this.ResetSearch_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetSearch_lbl.ForeColor = System.Drawing.Color.Red;
            this.ResetSearch_lbl.Location = new System.Drawing.Point(60, 519);
            this.ResetSearch_lbl.Name = "ResetSearch_lbl";
            this.ResetSearch_lbl.Size = new System.Drawing.Size(221, 39);
            this.ResetSearch_lbl.TabIndex = 14;
            this.ResetSearch_lbl.Text = "Reset Filters";
            this.ResetSearch_lbl.Click += new System.EventHandler(this.ResetSearch_lbl_Click);
            // 
            // MaxPrice_nud
            // 
            this.MaxPrice_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxPrice_nud.Location = new System.Drawing.Point(21, 354);
            this.MaxPrice_nud.Name = "MaxPrice_nud";
            this.MaxPrice_nud.Size = new System.Drawing.Size(303, 30);
            this.MaxPrice_nud.TabIndex = 0;
            // 
            // SearchIcon_pb
            // 
            this.SearchIcon_pb.Image = ((System.Drawing.Image)(resources.GetObject("SearchIcon_pb.Image")));
            this.SearchIcon_pb.Location = new System.Drawing.Point(129, 422);
            this.SearchIcon_pb.Name = "SearchIcon_pb";
            this.SearchIcon_pb.Size = new System.Drawing.Size(90, 80);
            this.SearchIcon_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchIcon_pb.TabIndex = 0;
            this.SearchIcon_pb.TabStop = false;
            this.SearchIcon_pb.Click += new System.EventHandler(this.SearchIcon_pb_Click);
            this.SearchIcon_pb.MouseEnter += new System.EventHandler(this.SearchIcon_pb_MouseEnter);
            this.SearchIcon_pb.MouseLeave += new System.EventHandler(this.SearchIcon_pb_MouseLeave);
            // 
            // MaxPrice_lbl
            // 
            this.MaxPrice_lbl.AutoSize = true;
            this.MaxPrice_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxPrice_lbl.Location = new System.Drawing.Point(21, 326);
            this.MaxPrice_lbl.Name = "MaxPrice_lbl";
            this.MaxPrice_lbl.Size = new System.Drawing.Size(99, 25);
            this.MaxPrice_lbl.TabIndex = 13;
            this.MaxPrice_lbl.Text = "Max Price";
            // 
            // Colour_cb
            // 
            this.Colour_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Colour_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colour_cb.FormattingEnabled = true;
            this.Colour_cb.Location = new System.Drawing.Point(21, 212);
            this.Colour_cb.Name = "Colour_cb";
            this.Colour_cb.Size = new System.Drawing.Size(303, 33);
            this.Colour_cb.TabIndex = 11;
            // 
            // FuelType_lbl
            // 
            this.FuelType_lbl.AutoSize = true;
            this.FuelType_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelType_lbl.Location = new System.Drawing.Point(19, 255);
            this.FuelType_lbl.Name = "FuelType_lbl";
            this.FuelType_lbl.Size = new System.Drawing.Size(100, 25);
            this.FuelType_lbl.TabIndex = 10;
            this.FuelType_lbl.Text = "Fuel Type";
            // 
            // FuelType_cb
            // 
            this.FuelType_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FuelType_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelType_cb.FormattingEnabled = true;
            this.FuelType_cb.Location = new System.Drawing.Point(21, 283);
            this.FuelType_cb.Name = "FuelType_cb";
            this.FuelType_cb.Size = new System.Drawing.Size(303, 33);
            this.FuelType_cb.TabIndex = 9;
            // 
            // Colour_lbl
            // 
            this.Colour_lbl.AutoSize = true;
            this.Colour_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colour_lbl.Location = new System.Drawing.Point(21, 185);
            this.Colour_lbl.Name = "Colour_lbl";
            this.Colour_lbl.Size = new System.Drawing.Size(70, 25);
            this.Colour_lbl.TabIndex = 8;
            this.Colour_lbl.Text = "Colour";
            // 
            // Make_lbl
            // 
            this.Make_lbl.AutoSize = true;
            this.Make_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Make_lbl.Location = new System.Drawing.Point(19, 46);
            this.Make_lbl.Name = "Make_lbl";
            this.Make_lbl.Size = new System.Drawing.Size(61, 25);
            this.Make_lbl.TabIndex = 4;
            this.Make_lbl.Text = "Make";
            // 
            // ModelName_lbl
            // 
            this.ModelName_lbl.AutoSize = true;
            this.ModelName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelName_lbl.Location = new System.Drawing.Point(21, 116);
            this.ModelName_lbl.Name = "ModelName_lbl";
            this.ModelName_lbl.Size = new System.Drawing.Size(123, 25);
            this.ModelName_lbl.TabIndex = 3;
            this.ModelName_lbl.Text = "Model Name";
            // 
            // Makes_cb
            // 
            this.Makes_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Makes_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Makes_cb.FormattingEnabled = true;
            this.Makes_cb.Location = new System.Drawing.Point(21, 74);
            this.Makes_cb.Name = "Makes_cb";
            this.Makes_cb.Size = new System.Drawing.Size(303, 33);
            this.Makes_cb.TabIndex = 2;
            // 
            // ModelName_tbx
            // 
            this.ModelName_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelName_tbx.Location = new System.Drawing.Point(21, 144);
            this.ModelName_tbx.Name = "ModelName_tbx";
            this.ModelName_tbx.Size = new System.Drawing.Size(303, 30);
            this.ModelName_tbx.TabIndex = 1;
            // 
            // Search_lbl
            // 
            this.Search_lbl.AutoSize = true;
            this.Search_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_lbl.Location = new System.Drawing.Point(62, 4);
            this.Search_lbl.Name = "Search_lbl";
            this.Search_lbl.Size = new System.Drawing.Size(235, 32);
            this.Search_lbl.TabIndex = 0;
            this.Search_lbl.Text = "Search Vehicles";
            // 
            // SearchIcon_il
            // 
            this.SearchIcon_il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SearchIcon_il.ImageStream")));
            this.SearchIcon_il.TransparentColor = System.Drawing.Color.Transparent;
            this.SearchIcon_il.Images.SetKeyName(0, "Search_Icon_default.png");
            this.SearchIcon_il.Images.SetKeyName(1, "Search_Icon_highlighted.png");
            // 
            // SoldVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Vehicles_pnl);
            this.Controls.Add(this.Search_pnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SoldVehicles_lbl);
            this.Name = "SoldVehicles";
            this.Size = new System.Drawing.Size(1050, 700);
            this.Search_pnl.ResumeLayout(false);
            this.Search_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrice_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SoldVehicles_lbl;
        private System.Windows.Forms.Panel Vehicles_pnl;
        private System.Windows.Forms.Panel Search_pnl;
        private System.Windows.Forms.Label ResetSearch_lbl;
        private System.Windows.Forms.NumericUpDown MaxPrice_nud;
        private System.Windows.Forms.PictureBox SearchIcon_pb;
        private System.Windows.Forms.Label MaxPrice_lbl;
        private System.Windows.Forms.ComboBox Colour_cb;
        private System.Windows.Forms.Label FuelType_lbl;
        private System.Windows.Forms.ComboBox FuelType_cb;
        private System.Windows.Forms.Label Colour_lbl;
        private System.Windows.Forms.Label Make_lbl;
        private System.Windows.Forms.Label ModelName_lbl;
        private System.Windows.Forms.ComboBox Makes_cb;
        private System.Windows.Forms.TextBox ModelName_tbx;
        private System.Windows.Forms.Label Search_lbl;
        private System.Windows.Forms.ImageList SearchIcon_il;
    }
}
