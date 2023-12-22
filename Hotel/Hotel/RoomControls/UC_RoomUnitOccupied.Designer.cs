namespace Hotel.RoomControls
{
    partial class UC_RoomUnitOccupied
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
            this.pBClean = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pBRoomStatus = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCleanStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRoomStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lBRoomID
            // 
            this.lBRoomID.AutoSize = true;
            this.lBRoomID.Location = new System.Drawing.Point(14, 26);
            this.lBRoomID.Name = "lBRoomID";
            this.lBRoomID.Size = new System.Drawing.Size(51, 20);
            this.lBRoomID.TabIndex = 0;
            this.lBRoomID.Text = "label1";
            this.lBRoomID.Click += new System.EventHandler(this.UC_RoomUnitOccupied_Click);
            // 
            // lBRoomTypeID
            // 
            this.lBRoomTypeID.AutoSize = true;
            this.lBRoomTypeID.Location = new System.Drawing.Point(14, 69);
            this.lBRoomTypeID.Name = "lBRoomTypeID";
            this.lBRoomTypeID.Size = new System.Drawing.Size(51, 20);
            this.lBRoomTypeID.TabIndex = 1;
            this.lBRoomTypeID.Text = "label2";
            this.lBRoomTypeID.Click += new System.EventHandler(this.UC_RoomUnitOccupied_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pBCleanStatus);
            this.panel1.Controls.Add(this.pBClean);
            this.panel1.Controls.Add(this.lBRoomID);
            this.panel1.Controls.Add(this.lBRoomTypeID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 162);
            this.panel1.TabIndex = 9;
            this.panel1.Click += new System.EventHandler(this.UC_RoomUnitOccupied_Click);
            // 
            // pBCleanStatus
            // 
            this.pBCleanStatus.ImageRotate = 0F;
            this.pBCleanStatus.Location = new System.Drawing.Point(46, 124);
            this.pBCleanStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBCleanStatus.Name = "pBCleanStatus";
            this.pBCleanStatus.Size = new System.Drawing.Size(32, 35);
            this.pBCleanStatus.TabIndex = 8;
            this.pBCleanStatus.TabStop = false;
            this.pBCleanStatus.Click += new System.EventHandler(this.UC_RoomUnitOccupied_Click);
            // 
            // pBClean
            // 
            this.pBClean.Image = global::Hotel.Properties.Resources.Clean;
            this.pBClean.ImageRotate = 0F;
            this.pBClean.Location = new System.Drawing.Point(3, 124);
            this.pBClean.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBClean.Name = "pBClean";
            this.pBClean.Size = new System.Drawing.Size(32, 35);
            this.pBClean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBClean.TabIndex = 7;
            this.pBClean.TabStop = false;
            this.pBClean.Click += new System.EventHandler(this.UC_RoomUnitOccupied_Click);
            // 
            // pBRoomStatus
            // 
            this.pBRoomStatus.ImageRotate = 0F;
            this.pBRoomStatus.Location = new System.Drawing.Point(141, 26);
            this.pBRoomStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBRoomStatus.Name = "pBRoomStatus";
            this.pBRoomStatus.Size = new System.Drawing.Size(112, 125);
            this.pBRoomStatus.TabIndex = 10;
            this.pBRoomStatus.TabStop = false;
            this.pBRoomStatus.Click += new System.EventHandler(this.UC_RoomUnitOccupied_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_RoomUnitOccupied
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.pBRoomStatus);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "UC_RoomUnitOccupied";
            this.Click += new System.EventHandler(this.UC_RoomUnitOccupied_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCleanStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRoomStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lBRoomID;
        private System.Windows.Forms.Label lBRoomTypeID;
        private Guna.UI2.WinForms.Guna2PictureBox pBRoomStatus;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pBCleanStatus;
        private Guna.UI2.WinForms.Guna2PictureBox pBClean;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
