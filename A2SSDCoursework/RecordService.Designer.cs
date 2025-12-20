namespace A2SSDCoursework
{
    partial class RecordService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordService));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VehicleInfo_lbl = new System.Windows.Forms.Label();
            this.ReturnArrow_pb = new System.Windows.Forms.PictureBox();
            this.ReturnArrow_il = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnArrow_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(1, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 5);
            this.panel1.TabIndex = 5;
            // 
            // VehicleInfo_lbl
            // 
            this.VehicleInfo_lbl.Font = new System.Drawing.Font("Adobe Hebrew", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleInfo_lbl.Location = new System.Drawing.Point(0, 0);
            this.VehicleInfo_lbl.Name = "VehicleInfo_lbl";
            this.VehicleInfo_lbl.Size = new System.Drawing.Size(1050, 76);
            this.VehicleInfo_lbl.TabIndex = 4;
            this.VehicleInfo_lbl.Text = "Vehicle Info";
            this.VehicleInfo_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReturnArrow_pb
            // 
            this.ReturnArrow_pb.Image = ((System.Drawing.Image)(resources.GetObject("ReturnArrow_pb.Image")));
            this.ReturnArrow_pb.Location = new System.Drawing.Point(16, 12);
            this.ReturnArrow_pb.Name = "ReturnArrow_pb";
            this.ReturnArrow_pb.Size = new System.Drawing.Size(68, 50);
            this.ReturnArrow_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReturnArrow_pb.TabIndex = 16;
            this.ReturnArrow_pb.TabStop = false;
            // 
            // ReturnArrow_il
            // 
            this.ReturnArrow_il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ReturnArrow_il.ImageStream")));
            this.ReturnArrow_il.TransparentColor = System.Drawing.Color.Transparent;
            this.ReturnArrow_il.Images.SetKeyName(0, "BackArrow.png");
            this.ReturnArrow_il.Images.SetKeyName(1, "BackArrow_Highlighted.png");
            // 
            // RecordService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReturnArrow_pb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VehicleInfo_lbl);
            this.Name = "RecordService";
            this.Size = new System.Drawing.Size(1051, 700);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnArrow_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VehicleInfo_lbl;
        private System.Windows.Forms.PictureBox ReturnArrow_pb;
        private System.Windows.Forms.ImageList ReturnArrow_il;
    }
}
