namespace Hotel.RoomControls
{
    partial class UC_RoomUnitBooked
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
            this.pBRoomStatus = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBCleanStatus = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBRoomStatus)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCleanStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lBRoomID
            // 
            this.lBRoomID.AutoSize = true;
            this.lBRoomID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBRoomID.ForeColor = System.Drawing.Color.White;
            this.lBRoomID.Location = new System.Drawing.Point(9, 24);
            this.lBRoomID.Name = "lBRoomID";
            this.lBRoomID.Size = new System.Drawing.Size(51, 20);
            this.lBRoomID.TabIndex = 0;
            this.lBRoomID.Text = "label1";
            this.lBRoomID.Click += new System.EventHandler(this.UC_RoomUnitBooked_Click);
            // 
            // lBRoomTypeID
            // 
            this.lBRoomTypeID.AutoSize = true;
            this.lBRoomTypeID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBRoomTypeID.ForeColor = System.Drawing.Color.White;
            this.lBRoomTypeID.Location = new System.Drawing.Point(9, 58);
            this.lBRoomTypeID.Name = "lBRoomTypeID";
            this.lBRoomTypeID.Size = new System.Drawing.Size(51, 20);
            this.lBRoomTypeID.TabIndex = 1;
            this.lBRoomTypeID.Text = "label2";
            this.lBRoomTypeID.Click += new System.EventHandler(this.UC_RoomUnitBooked_Click);
            // 
            // pBRoomStatus
            // 
            this.pBRoomStatus.ImageRotate = 0F;
            this.pBRoomStatus.Location = new System.Drawing.Point(115, 13);
            this.pBRoomStatus.Name = "pBRoomStatus";
            this.pBRoomStatus.Size = new System.Drawing.Size(100, 100);
            this.pBRoomStatus.TabIndex = 8;
            this.pBRoomStatus.TabStop = false;
            this.pBRoomStatus.Click += new System.EventHandler(this.UC_RoomUnitBooked_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(68)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.pBCleanStatus);
            this.panel1.Controls.Add(this.lBRoomID);
            this.panel1.Controls.Add(this.lBRoomTypeID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 130);
            this.panel1.TabIndex = 7;
            this.panel1.Click += new System.EventHandler(this.UC_RoomUnitBooked_Click);
            // 
            // pBCleanStatus
            // 
            this.pBCleanStatus.Image = global::Hotel.Properties.Resources.CleanIcon;
            this.pBCleanStatus.ImageRotate = 0F;
            this.pBCleanStatus.Location = new System.Drawing.Point(14, 84);
            this.pBCleanStatus.Name = "pBCleanStatus";
            this.pBCleanStatus.Size = new System.Drawing.Size(28, 28);
            this.pBCleanStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBCleanStatus.TabIndex = 7;
            this.pBCleanStatus.TabStop = false;
            this.pBCleanStatus.Click += new System.EventHandler(this.UC_RoomUnitBooked_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_RoomUnitBooked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pBRoomStatus);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_RoomUnitBooked";
            this.Click += new System.EventHandler(this.UC_RoomUnitBooked_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pBRoomStatus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCleanStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lBRoomID;
        private System.Windows.Forms.Label lBRoomTypeID;
        private Guna.UI2.WinForms.Guna2PictureBox pBRoomStatus;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pBCleanStatus;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
