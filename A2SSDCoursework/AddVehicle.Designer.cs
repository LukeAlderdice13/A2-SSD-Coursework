namespace A2SSDCoursework
{
    partial class AddVehicle
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
            this.Model_lbl = new System.Windows.Forms.Label();
            this.Model_tbx = new System.Windows.Forms.TextBox();
            this.YearMade_lbl = new System.Windows.Forms.Label();
            this.AddVehicle_btn = new System.Windows.Forms.Button();
            this.Colour_tbx = new System.Windows.Forms.TextBox();
            this.YearMade_tbx = new System.Windows.Forms.TextBox();
            this.Registration_tbx = new System.Windows.Forms.TextBox();
            this.Colour_lbl = new System.Windows.Forms.Label();
            this.Vin_tbx = new System.Windows.Forms.TextBox();
            this.Registration_lbl = new System.Windows.Forms.Label();
            this.Vin_lbl = new System.Windows.Forms.Label();
            this.Makes_cb = new System.Windows.Forms.ComboBox();
            this.Make_lbl = new System.Windows.Forms.Label();
            this.DatePurchased_dtp = new System.Windows.Forms.DateTimePicker();
            this.DatePurchased_lbl = new System.Windows.Forms.Label();
            this.EngineSize_nud = new System.Windows.Forms.NumericUpDown();
            this.EngineSize_lbl = new System.Windows.Forms.Label();
            this.FuelType_tbx = new System.Windows.Forms.TextBox();
            this.FuelType_lbl = new System.Windows.Forms.Label();
            this.Price_nud = new System.Windows.Forms.NumericUpDown();
            this.Price_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EngineSize_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // Model_lbl
            // 
            this.Model_lbl.AutoSize = true;
            this.Model_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Model_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.Model_lbl.Location = new System.Drawing.Point(3, 51);
            this.Model_lbl.Name = "Model_lbl";
            this.Model_lbl.Size = new System.Drawing.Size(113, 41);
            this.Model_lbl.TabIndex = 83;
            this.Model_lbl.Text = "Model:";
            this.Model_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Model_tbx
            // 
            this.Model_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Model_tbx.Location = new System.Drawing.Point(206, 55);
            this.Model_tbx.MaxLength = 50;
            this.Model_tbx.Name = "Model_tbx";
            this.Model_tbx.Size = new System.Drawing.Size(305, 34);
            this.Model_tbx.TabIndex = 88;
            this.Model_tbx.TextChanged += new System.EventHandler(this.Model_tbx_TextChanged);
            this.Model_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Model_tbx_KeyDown);
            // 
            // YearMade_lbl
            // 
            this.YearMade_lbl.AutoSize = true;
            this.YearMade_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearMade_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.YearMade_lbl.Location = new System.Drawing.Point(3, 92);
            this.YearMade_lbl.Name = "YearMade_lbl";
            this.YearMade_lbl.Size = new System.Drawing.Size(170, 41);
            this.YearMade_lbl.TabIndex = 84;
            this.YearMade_lbl.Text = "Year Made:";
            this.YearMade_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddVehicle_btn
            // 
            this.AddVehicle_btn.BackColor = System.Drawing.Color.Firebrick;
            this.AddVehicle_btn.FlatAppearance.BorderSize = 0;
            this.AddVehicle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddVehicle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVehicle_btn.ForeColor = System.Drawing.Color.White;
            this.AddVehicle_btn.Location = new System.Drawing.Point(349, 229);
            this.AddVehicle_btn.Name = "AddVehicle_btn";
            this.AddVehicle_btn.Size = new System.Drawing.Size(363, 51);
            this.AddVehicle_btn.TabIndex = 93;
            this.AddVehicle_btn.Text = "Add Vehicle";
            this.AddVehicle_btn.UseVisualStyleBackColor = false;
            this.AddVehicle_btn.Click += new System.EventHandler(this.AddVehicle_btn_Click);
            // 
            // Colour_tbx
            // 
            this.Colour_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colour_tbx.Location = new System.Drawing.Point(206, 137);
            this.Colour_tbx.MaxLength = 50;
            this.Colour_tbx.Name = "Colour_tbx";
            this.Colour_tbx.Size = new System.Drawing.Size(305, 34);
            this.Colour_tbx.TabIndex = 92;
            this.Colour_tbx.TextChanged += new System.EventHandler(this.Colour_tbx_TextChanged);
            this.Colour_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Colour_tbx_KeyDown);
            // 
            // YearMade_tbx
            // 
            this.YearMade_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearMade_tbx.Location = new System.Drawing.Point(206, 96);
            this.YearMade_tbx.MaxLength = 50;
            this.YearMade_tbx.Name = "YearMade_tbx";
            this.YearMade_tbx.Size = new System.Drawing.Size(305, 34);
            this.YearMade_tbx.TabIndex = 89;
            this.YearMade_tbx.TextChanged += new System.EventHandler(this.YearMade_tbx_TextChanged);
            this.YearMade_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.YearMade_tbx_KeyDown);
            this.YearMade_tbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearMade_tbx_KeyPress);
            // 
            // Registration_tbx
            // 
            this.Registration_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_tbx.Location = new System.Drawing.Point(785, 55);
            this.Registration_tbx.MaxLength = 50;
            this.Registration_tbx.Name = "Registration_tbx";
            this.Registration_tbx.Size = new System.Drawing.Size(255, 34);
            this.Registration_tbx.TabIndex = 91;
            this.Registration_tbx.TextChanged += new System.EventHandler(this.Registration_tbx_TextChanged);
            this.Registration_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Registration_tbx_KeyDown);
            // 
            // Colour_lbl
            // 
            this.Colour_lbl.AutoSize = true;
            this.Colour_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colour_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.Colour_lbl.Location = new System.Drawing.Point(3, 133);
            this.Colour_lbl.Name = "Colour_lbl";
            this.Colour_lbl.Size = new System.Drawing.Size(125, 41);
            this.Colour_lbl.TabIndex = 87;
            this.Colour_lbl.Text = "Colour:";
            this.Colour_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Vin_tbx
            // 
            this.Vin_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vin_tbx.Location = new System.Drawing.Point(785, 96);
            this.Vin_tbx.MaxLength = 50;
            this.Vin_tbx.Name = "Vin_tbx";
            this.Vin_tbx.Size = new System.Drawing.Size(255, 34);
            this.Vin_tbx.TabIndex = 90;
            this.Vin_tbx.TextChanged += new System.EventHandler(this.Vin_tbx_TextChanged);
            this.Vin_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Vin_tbx_KeyDown);
            // 
            // Registration_lbl
            // 
            this.Registration_lbl.AutoSize = true;
            this.Registration_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.Registration_lbl.Location = new System.Drawing.Point(514, 51);
            this.Registration_lbl.Name = "Registration_lbl";
            this.Registration_lbl.Size = new System.Drawing.Size(215, 41);
            this.Registration_lbl.TabIndex = 85;
            this.Registration_lbl.Text = "Plate Number:";
            this.Registration_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Vin_lbl
            // 
            this.Vin_lbl.AutoSize = true;
            this.Vin_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vin_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.Vin_lbl.Location = new System.Drawing.Point(515, 92);
            this.Vin_lbl.Name = "Vin_lbl";
            this.Vin_lbl.Size = new System.Drawing.Size(75, 41);
            this.Vin_lbl.TabIndex = 86;
            this.Vin_lbl.Text = "Vin:";
            this.Vin_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Makes_cb
            // 
            this.Makes_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Makes_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Makes_cb.FormattingEnabled = true;
            this.Makes_cb.Location = new System.Drawing.Point(206, 12);
            this.Makes_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Makes_cb.Name = "Makes_cb";
            this.Makes_cb.Size = new System.Drawing.Size(305, 37);
            this.Makes_cb.TabIndex = 95;
            // 
            // Make_lbl
            // 
            this.Make_lbl.AutoSize = true;
            this.Make_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Make_lbl.ForeColor = System.Drawing.Color.Black;
            this.Make_lbl.Location = new System.Drawing.Point(3, 10);
            this.Make_lbl.Name = "Make_lbl";
            this.Make_lbl.Size = new System.Drawing.Size(101, 41);
            this.Make_lbl.TabIndex = 94;
            this.Make_lbl.Text = "Make:";
            this.Make_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DatePurchased_dtp
            // 
            this.DatePurchased_dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePurchased_dtp.Location = new System.Drawing.Point(785, 14);
            this.DatePurchased_dtp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatePurchased_dtp.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DatePurchased_dtp.Name = "DatePurchased_dtp";
            this.DatePurchased_dtp.Size = new System.Drawing.Size(255, 34);
            this.DatePurchased_dtp.TabIndex = 97;
            // 
            // DatePurchased_lbl
            // 
            this.DatePurchased_lbl.AutoSize = true;
            this.DatePurchased_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePurchased_lbl.ForeColor = System.Drawing.Color.Black;
            this.DatePurchased_lbl.Location = new System.Drawing.Point(515, 12);
            this.DatePurchased_lbl.Name = "DatePurchased_lbl";
            this.DatePurchased_lbl.Size = new System.Drawing.Size(238, 41);
            this.DatePurchased_lbl.TabIndex = 96;
            this.DatePurchased_lbl.Text = "Date Purchased:";
            this.DatePurchased_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EngineSize_nud
            // 
            this.EngineSize_nud.DecimalPlaces = 2;
            this.EngineSize_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineSize_nud.Location = new System.Drawing.Point(206, 178);
            this.EngineSize_nud.Margin = new System.Windows.Forms.Padding(4);
            this.EngineSize_nud.Name = "EngineSize_nud";
            this.EngineSize_nud.Size = new System.Drawing.Size(305, 34);
            this.EngineSize_nud.TabIndex = 99;
            this.EngineSize_nud.ValueChanged += new System.EventHandler(this.EngineSize_nud_ValueChanged);
            // 
            // EngineSize_lbl
            // 
            this.EngineSize_lbl.AutoSize = true;
            this.EngineSize_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineSize_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.EngineSize_lbl.Location = new System.Drawing.Point(3, 173);
            this.EngineSize_lbl.Name = "EngineSize_lbl";
            this.EngineSize_lbl.Size = new System.Drawing.Size(183, 41);
            this.EngineSize_lbl.TabIndex = 98;
            this.EngineSize_lbl.Text = "Engine Size:";
            this.EngineSize_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FuelType_tbx
            // 
            this.FuelType_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelType_tbx.Location = new System.Drawing.Point(785, 137);
            this.FuelType_tbx.MaxLength = 50;
            this.FuelType_tbx.Name = "FuelType_tbx";
            this.FuelType_tbx.Size = new System.Drawing.Size(255, 34);
            this.FuelType_tbx.TabIndex = 101;
            this.FuelType_tbx.TextChanged += new System.EventHandler(this.FuelType_tbx_TextChanged);
            this.FuelType_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FuelType_tbx_KeyDown);
            // 
            // FuelType_lbl
            // 
            this.FuelType_lbl.AutoSize = true;
            this.FuelType_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelType_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.FuelType_lbl.Location = new System.Drawing.Point(515, 133);
            this.FuelType_lbl.Name = "FuelType_lbl";
            this.FuelType_lbl.Size = new System.Drawing.Size(159, 41);
            this.FuelType_lbl.TabIndex = 100;
            this.FuelType_lbl.Text = "Fuel Type:";
            this.FuelType_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Price_nud
            // 
            this.Price_nud.DecimalPlaces = 2;
            this.Price_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_nud.Location = new System.Drawing.Point(785, 178);
            this.Price_nud.Margin = new System.Windows.Forms.Padding(4);
            this.Price_nud.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.Price_nud.Name = "Price_nud";
            this.Price_nud.Size = new System.Drawing.Size(255, 34);
            this.Price_nud.TabIndex = 103;
            this.Price_nud.ValueChanged += new System.EventHandler(this.Price_nud_ValueChanged);
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.Price_lbl.Location = new System.Drawing.Point(515, 173);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(95, 41);
            this.Price_lbl.TabIndex = 102;
            this.Price_lbl.Text = "Price:";
            this.Price_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.EngineSize_nud);
            this.Controls.Add(this.Makes_cb);
            this.Controls.Add(this.Model_tbx);
            this.Controls.Add(this.Colour_tbx);
            this.Controls.Add(this.YearMade_tbx);
            this.Controls.Add(this.Price_nud);
            this.Controls.Add(this.Price_lbl);
            this.Controls.Add(this.FuelType_tbx);
            this.Controls.Add(this.FuelType_lbl);
            this.Controls.Add(this.EngineSize_lbl);
            this.Controls.Add(this.DatePurchased_dtp);
            this.Controls.Add(this.DatePurchased_lbl);
            this.Controls.Add(this.Make_lbl);
            this.Controls.Add(this.Model_lbl);
            this.Controls.Add(this.YearMade_lbl);
            this.Controls.Add(this.AddVehicle_btn);
            this.Controls.Add(this.Registration_tbx);
            this.Controls.Add(this.Colour_lbl);
            this.Controls.Add(this.Vin_tbx);
            this.Controls.Add(this.Registration_lbl);
            this.Controls.Add(this.Vin_lbl);
            this.Name = "AddVehicle";
            this.Size = new System.Drawing.Size(1051, 700);
            this.Tag = "Add Vehicles";
            this.Load += new System.EventHandler(this.AddVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EngineSize_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Model_lbl;
        private System.Windows.Forms.TextBox Model_tbx;
        private System.Windows.Forms.Label YearMade_lbl;
        private System.Windows.Forms.Button AddVehicle_btn;
        private System.Windows.Forms.TextBox Colour_tbx;
        private System.Windows.Forms.TextBox YearMade_tbx;
        private System.Windows.Forms.TextBox Registration_tbx;
        private System.Windows.Forms.Label Colour_lbl;
        private System.Windows.Forms.TextBox Vin_tbx;
        private System.Windows.Forms.Label Registration_lbl;
        private System.Windows.Forms.Label Vin_lbl;
        private System.Windows.Forms.ComboBox Makes_cb;
        private System.Windows.Forms.Label Make_lbl;
        private System.Windows.Forms.DateTimePicker DatePurchased_dtp;
        private System.Windows.Forms.Label DatePurchased_lbl;
        private System.Windows.Forms.NumericUpDown EngineSize_nud;
        private System.Windows.Forms.Label EngineSize_lbl;
        private System.Windows.Forms.TextBox FuelType_tbx;
        private System.Windows.Forms.Label FuelType_lbl;
        private System.Windows.Forms.NumericUpDown Price_nud;
        private System.Windows.Forms.Label Price_lbl;
    }
}
