namespace Hotel.RoomControls
{
    partial class F_UpdateRoom
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bTExit = new System.Windows.Forms.Button();
            this.bTUpdate = new System.Windows.Forms.Button();
            this.tBStatus = new System.Windows.Forms.TextBox();
            this.tBRoomType = new System.Windows.Forms.TextBox();
            this.lBStatus = new System.Windows.Forms.Label();
            this.lBRoomTypeID = new System.Windows.Forms.Label();
            this.lBRoomID = new System.Windows.Forms.Label();
            this.cBRoomID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bTExit
            // 
            this.bTExit.Location = new System.Drawing.Point(187, 142);
            this.bTExit.Name = "bTExit";
            this.bTExit.Size = new System.Drawing.Size(75, 23);
            this.bTExit.TabIndex = 44;
            this.bTExit.Text = "Thoát";
            this.bTExit.UseVisualStyleBackColor = true;
            this.bTExit.Click += new System.EventHandler(this.bTExit_Click);
            // 
            // bTUpdate
            // 
            this.bTUpdate.Location = new System.Drawing.Point(106, 142);
            this.bTUpdate.Name = "bTUpdate";
            this.bTUpdate.Size = new System.Drawing.Size(75, 23);
            this.bTUpdate.TabIndex = 43;
            this.bTUpdate.Text = "Cập nhật";
            this.bTUpdate.UseVisualStyleBackColor = true;
            this.bTUpdate.Click += new System.EventHandler(this.bTUpdate_Click);
            // 
            // tBStatus
            // 
            this.tBStatus.Location = new System.Drawing.Point(15, 92);
            this.tBStatus.Name = "tBStatus";
            this.tBStatus.Size = new System.Drawing.Size(100, 22);
            this.tBStatus.TabIndex = 42;
            // 
            // tBRoomType
            // 
            this.tBRoomType.BackColor = System.Drawing.SystemColors.Window;
            this.tBRoomType.Location = new System.Drawing.Point(162, 37);
            this.tBRoomType.Name = "tBRoomType";
            this.tBRoomType.Size = new System.Drawing.Size(100, 22);
            this.tBRoomType.TabIndex = 39;
            // 
            // lBStatus
            // 
            this.lBStatus.AutoSize = true;
            this.lBStatus.Location = new System.Drawing.Point(12, 73);
            this.lBStatus.Name = "lBStatus";
            this.lBStatus.Size = new System.Drawing.Size(67, 16);
            this.lBStatus.TabIndex = 36;
            this.lBStatus.Text = "Trạng thái";
            // 
            // lBRoomTypeID
            // 
            this.lBRoomTypeID.AutoSize = true;
            this.lBRoomTypeID.Location = new System.Drawing.Point(159, 18);
            this.lBRoomTypeID.Name = "lBRoomTypeID";
            this.lBRoomTypeID.Size = new System.Drawing.Size(92, 16);
            this.lBRoomTypeID.TabIndex = 32;
            this.lBRoomTypeID.Text = "Mã loại phòng";
            // 
            // lBRoomID
            // 
            this.lBRoomID.AutoSize = true;
            this.lBRoomID.Location = new System.Drawing.Point(12, 18);
            this.lBRoomID.Name = "lBRoomID";
            this.lBRoomID.Size = new System.Drawing.Size(67, 16);
            this.lBRoomID.TabIndex = 31;
            this.lBRoomID.Text = "Mã phòng";
            // 
            // cBRoomID
            // 
            this.cBRoomID.FormattingEnabled = true;
            this.cBRoomID.Location = new System.Drawing.Point(15, 37);
            this.cBRoomID.Name = "cBRoomID";
            this.cBRoomID.Size = new System.Drawing.Size(100, 24);
            this.cBRoomID.TabIndex = 45;
            // 
            // F_UpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.cBRoomID);
            this.Controls.Add(this.bTExit);
            this.Controls.Add(this.bTUpdate);
            this.Controls.Add(this.tBStatus);
            this.Controls.Add(this.tBRoomType);
            this.Controls.Add(this.lBStatus);
            this.Controls.Add(this.lBRoomTypeID);
            this.Controls.Add(this.lBRoomID);
            this.Name = "F_UpdateRoom";
            this.Text = "Cập nhật phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bTExit;
        private System.Windows.Forms.Button bTUpdate;
        private System.Windows.Forms.TextBox tBStatus;
        private System.Windows.Forms.TextBox tBRoomType;
        private System.Windows.Forms.Label lBStatus;
        private System.Windows.Forms.Label lBRoomTypeID;
        private System.Windows.Forms.Label lBRoomID;
        private System.Windows.Forms.ComboBox cBRoomID;
    }
}