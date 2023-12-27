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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_UpdateRoom));
            this.lBStatus = new System.Windows.Forms.Label();
            this.lBRoomTypeID = new System.Windows.Forms.Label();
            this.lBRoomID = new System.Windows.Forms.Label();
            this.cBRoomID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cBRoomTypeID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cBRoomStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cBCleanStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.bTUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.bTExit = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBStatus
            // 
            this.lBStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lBStatus.AutoSize = true;
            this.lBStatus.BackColor = System.Drawing.Color.Transparent;
            this.lBStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBStatus.ForeColor = System.Drawing.Color.White;
            this.lBStatus.Location = new System.Drawing.Point(22, 155);
            this.lBStatus.Name = "lBStatus";
            this.lBStatus.Size = new System.Drawing.Size(98, 28);
            this.lBStatus.TabIndex = 36;
            this.lBStatus.Text = "Trạng thái";
            // 
            // lBRoomTypeID
            // 
            this.lBRoomTypeID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lBRoomTypeID.AutoSize = true;
            this.lBRoomTypeID.BackColor = System.Drawing.Color.Transparent;
            this.lBRoomTypeID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBRoomTypeID.ForeColor = System.Drawing.Color.White;
            this.lBRoomTypeID.Location = new System.Drawing.Point(211, 81);
            this.lBRoomTypeID.Name = "lBRoomTypeID";
            this.lBRoomTypeID.Size = new System.Drawing.Size(140, 28);
            this.lBRoomTypeID.TabIndex = 32;
            this.lBRoomTypeID.Text = "Mã loại phòng";
            // 
            // lBRoomID
            // 
            this.lBRoomID.AutoSize = true;
            this.lBRoomID.BackColor = System.Drawing.Color.Transparent;
            this.lBRoomID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBRoomID.ForeColor = System.Drawing.Color.White;
            this.lBRoomID.Location = new System.Drawing.Point(22, 80);
            this.lBRoomID.Name = "lBRoomID";
            this.lBRoomID.Size = new System.Drawing.Size(103, 28);
            this.lBRoomID.TabIndex = 31;
            this.lBRoomID.Text = "Mã phòng";
            // 
            // cBRoomID
            // 
            this.cBRoomID.BackColor = System.Drawing.Color.Transparent;
            this.cBRoomID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBRoomID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBRoomID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBRoomID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cBRoomID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cBRoomID.ItemHeight = 30;
            this.cBRoomID.Location = new System.Drawing.Point(27, 110);
            this.cBRoomID.Name = "cBRoomID";
            this.cBRoomID.Size = new System.Drawing.Size(170, 36);
            this.cBRoomID.TabIndex = 45;
            this.cBRoomID.SelectedIndexChanged += new System.EventHandler(this.cBRoomID_SelectedIndexChanged);
            // 
            // cBRoomTypeID
            // 
            this.cBRoomTypeID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cBRoomTypeID.BackColor = System.Drawing.Color.Transparent;
            this.cBRoomTypeID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBRoomTypeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBRoomTypeID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBRoomTypeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBRoomTypeID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cBRoomTypeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cBRoomTypeID.ItemHeight = 30;
            this.cBRoomTypeID.Location = new System.Drawing.Point(217, 110);
            this.cBRoomTypeID.Name = "cBRoomTypeID";
            this.cBRoomTypeID.Size = new System.Drawing.Size(170, 36);
            this.cBRoomTypeID.TabIndex = 48;
            // 
            // cBRoomStatus
            // 
            this.cBRoomStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cBRoomStatus.BackColor = System.Drawing.Color.Transparent;
            this.cBRoomStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBRoomStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBRoomStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBRoomStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cBRoomStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cBRoomStatus.ItemHeight = 30;
            this.cBRoomStatus.Items.AddRange(new object[] {
            "Bình thường",
            "Bảo trì"});
            this.cBRoomStatus.Location = new System.Drawing.Point(27, 183);
            this.cBRoomStatus.Name = "cBRoomStatus";
            this.cBRoomStatus.Size = new System.Drawing.Size(170, 36);
            this.cBRoomStatus.StartIndex = 0;
            this.cBRoomStatus.TabIndex = 49;
            this.cBRoomStatus.Tag = "150,40";
            // 
            // cBCleanStatus
            // 
            this.cBCleanStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cBCleanStatus.BackColor = System.Drawing.Color.Transparent;
            this.cBCleanStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBCleanStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCleanStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBCleanStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBCleanStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cBCleanStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cBCleanStatus.ItemHeight = 30;
            this.cBCleanStatus.Items.AddRange(new object[] {
            "Đã dọn",
            "Chưa dọn"});
            this.cBCleanStatus.Location = new System.Drawing.Point(217, 183);
            this.cBCleanStatus.Name = "cBCleanStatus";
            this.cBCleanStatus.Size = new System.Drawing.Size(170, 36);
            this.cBCleanStatus.StartIndex = 0;
            this.cBCleanStatus.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 50;
            this.label1.Text = "Dọn dẹp";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // bTUpdate
            // 
            this.bTUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bTUpdate.BackColor = System.Drawing.Color.Transparent;
            this.bTUpdate.BorderRadius = 10;
            this.bTUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bTUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bTUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bTUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bTUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(124)))), ((int)(((byte)(78)))));
            this.bTUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTUpdate.ForeColor = System.Drawing.Color.White;
            this.bTUpdate.Location = new System.Drawing.Point(101, 248);
            this.bTUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bTUpdate.Name = "bTUpdate";
            this.bTUpdate.Size = new System.Drawing.Size(140, 36);
            this.bTUpdate.TabIndex = 52;
            this.bTUpdate.Tag = "150,40";
            this.bTUpdate.Text = "Cập Nhật";
            this.bTUpdate.Click += new System.EventHandler(this.bTUpdate_Click);
            // 
            // bTExit
            // 
            this.bTExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bTExit.BackColor = System.Drawing.Color.Transparent;
            this.bTExit.BorderRadius = 10;
            this.bTExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bTExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bTExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bTExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bTExit.FillColor = System.Drawing.Color.White;
            this.bTExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(124)))), ((int)(((byte)(78)))));
            this.bTExit.Location = new System.Drawing.Point(247, 248);
            this.bTExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bTExit.Name = "bTExit";
            this.bTExit.Size = new System.Drawing.Size(140, 36);
            this.bTExit.TabIndex = 53;
            this.bTExit.Text = "Thoát";
            this.bTExit.Click += new System.EventHandler(this.bTExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 41);
            this.label2.TabIndex = 54;
            this.label2.Text = "Cập Nhật Phòng";
            // 
            // F_UpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 304);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bTExit);
            this.Controls.Add(this.bTUpdate);
            this.Controls.Add(this.cBCleanStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBRoomStatus);
            this.Controls.Add(this.cBRoomTypeID);
            this.Controls.Add(this.cBRoomID);
            this.Controls.Add(this.lBStatus);
            this.Controls.Add(this.lBRoomTypeID);
            this.Controls.Add(this.lBRoomID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_UpdateRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lBStatus;
        private System.Windows.Forms.Label lBRoomTypeID;
        private System.Windows.Forms.Label lBRoomID;
        private Guna.UI2.WinForms.Guna2ComboBox cBRoomID;
        private Guna.UI2.WinForms.Guna2ComboBox cBRoomTypeID;
        private Guna.UI2.WinForms.Guna2ComboBox cBRoomStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cBCleanStatus;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button bTUpdate;
        private Guna.UI2.WinForms.Guna2Button bTExit;
        private System.Windows.Forms.Label label2;
    }
}