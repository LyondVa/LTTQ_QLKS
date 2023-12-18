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
            this.lBRoomID = new System.Windows.Forms.Label();
            this.lBRoomTypeID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBRoomStatus = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pBCleanStatus = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBRoomStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCleanStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lBRoomID
            // 
            this.lBRoomID.AutoSize = true;
            this.lBRoomID.Location = new System.Drawing.Point(12, 21);
            this.lBRoomID.Name = "lBRoomID";
            this.lBRoomID.Size = new System.Drawing.Size(44, 16);
            this.lBRoomID.TabIndex = 0;
            this.lBRoomID.Text = "label1";
            this.lBRoomID.Click += new System.EventHandler(this.UC_RoomUnitAvailable_Click);
            // 
            // lBRoomTypeID
            // 
            this.lBRoomTypeID.AutoSize = true;
            this.lBRoomTypeID.Location = new System.Drawing.Point(12, 55);
            this.lBRoomTypeID.Name = "lBRoomTypeID";
            this.lBRoomTypeID.Size = new System.Drawing.Size(44, 16);
            this.lBRoomTypeID.TabIndex = 1;
            this.lBRoomTypeID.Text = "label2";
            this.lBRoomTypeID.Click += new System.EventHandler(this.UC_RoomUnitAvailable_Click);
            // 
            // panel1
            // 
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
            // pBRoomStatus
            // 
            this.pBRoomStatus.ImageRotate = 0F;
            this.pBRoomStatus.Location = new System.Drawing.Point(107, 21);
            this.pBRoomStatus.Name = "pBRoomStatus";
            this.pBRoomStatus.Size = new System.Drawing.Size(100, 100);
            this.pBRoomStatus.TabIndex = 6;
            this.pBRoomStatus.TabStop = false;
            this.pBRoomStatus.Click += new System.EventHandler(this.UC_RoomUnitAvailable_Click);
            // 
            // pBCleanStatus
            // 
            this.pBCleanStatus.ImageRotate = 0F;
            this.pBCleanStatus.Location = new System.Drawing.Point(15, 99);
            this.pBCleanStatus.Name = "pBCleanStatus";
            this.pBCleanStatus.Size = new System.Drawing.Size(28, 28);
            this.pBCleanStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBCleanStatus.TabIndex = 8;
            this.pBCleanStatus.TabStop = false;
            this.pBCleanStatus.Click += new System.EventHandler(this.UC_RoomUnitAvailable_Click);
            // 
            // UC_RoomUnitAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.pBRoomStatus);
            this.Controls.Add(this.panel1);
            this.Name = "UC_RoomUnitAvailable";
            this.Click += new System.EventHandler(this.UC_RoomUnitAvailable_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBRoomStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCleanStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lBRoomID;
        private System.Windows.Forms.Label lBRoomTypeID;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pBCleanStatus;
        private Guna.UI2.WinForms.Guna2PictureBox pBRoomStatus;
    }
}
