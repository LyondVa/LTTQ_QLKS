namespace Hotel.RoomControls
{
    partial class UC_RoomUnitAvailable
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
            this.lBRoomID = new System.Windows.Forms.Label();
            this.lBRoomTypeID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBCleanStatus = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCleanStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lBRoomID
            // 
            this.lBRoomID.AutoSize = true;
            this.lBRoomID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBRoomID.ForeColor = System.Drawing.Color.White;
            this.lBRoomID.Location = new System.Drawing.Point(10, 21);
            this.lBRoomID.Name = "lBRoomID";
            this.lBRoomID.Size = new System.Drawing.Size(51, 20);
            this.lBRoomID.TabIndex = 0;
            this.lBRoomID.Text = "label1";
            this.lBRoomID.Click += new System.EventHandler(this.UC_RoomUnitAvailable_Click);
            // 
            // lBRoomTypeID
            // 
            this.lBRoomTypeID.AutoSize = true;
            this.lBRoomTypeID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBRoomTypeID.ForeColor = System.Drawing.Color.White;
            this.lBRoomTypeID.Location = new System.Drawing.Point(10, 55);
            this.lBRoomTypeID.Name = "lBRoomTypeID";
            this.lBRoomTypeID.Size = new System.Drawing.Size(51, 20);
            this.lBRoomTypeID.TabIndex = 1;
            this.lBRoomTypeID.Text = "label2";
            this.lBRoomTypeID.Click += new System.EventHandler(this.UC_RoomUnitAvailable_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.pBCleanStatus);
            this.panel1.Controls.Add(this.lBRoomID);
            this.panel1.Controls.Add(this.lBRoomTypeID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 130);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.UC_RoomUnitAvailable_Click);
            // 
            // pBCleanStatus
            // 
            this.pBCleanStatus.ImageRotate = 0F;
            this.pBCleanStatus.Location = new System.Drawing.Point(14, 84);
            this.pBCleanStatus.Name = "pBCleanStatus";
            this.pBCleanStatus.Size = new System.Drawing.Size(34, 30);
            this.pBCleanStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBCleanStatus.TabIndex = 8;
            this.pBCleanStatus.TabStop = false;
            this.pBCleanStatus.Click += new System.EventHandler(this.UC_RoomUnitAvailable_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 130);
            this.label1.TabIndex = 9;
            this.label1.Text = "Trống";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.UC_RoomUnitAvailable_Click);
            // 
            // UC_RoomUnitAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(243)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_RoomUnitAvailable";
            this.Click += new System.EventHandler(this.UC_RoomUnitAvailable_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCleanStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lBRoomID;
        private System.Windows.Forms.Label lBRoomTypeID;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pBCleanStatus;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
    }
}
