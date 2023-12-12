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
            this.lBStatus = new System.Windows.Forms.Label();
            this.lBRoomTypeID = new System.Windows.Forms.Label();
            this.lBRoomID = new System.Windows.Forms.Label();
            this.cBRoomID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cBRoomTypeID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cBRoomStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cBCleanStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bTExit
            // 
            this.bTExit.Location = new System.Drawing.Point(246, 162);
            this.bTExit.Name = "bTExit";
            this.bTExit.Size = new System.Drawing.Size(75, 23);
            this.bTExit.TabIndex = 44;
            this.bTExit.Text = "Thoát";
            this.bTExit.UseVisualStyleBackColor = true;
            this.bTExit.Click += new System.EventHandler(this.bTExit_Click);
            // 
            // bTUpdate
            // 
            this.bTUpdate.Location = new System.Drawing.Point(165, 162);
            this.bTUpdate.Name = "bTUpdate";
            this.bTUpdate.Size = new System.Drawing.Size(75, 23);
            this.bTUpdate.TabIndex = 43;
            this.bTUpdate.Text = "Cập nhật";
            this.bTUpdate.UseVisualStyleBackColor = true;
            this.bTUpdate.Click += new System.EventHandler(this.bTUpdate_Click);
            // 
            // lBStatus
            // 
            this.lBStatus.AutoSize = true;
            this.lBStatus.Location = new System.Drawing.Point(12, 87);
            this.lBStatus.Name = "lBStatus";
            this.lBStatus.Size = new System.Drawing.Size(67, 16);
            this.lBStatus.TabIndex = 36;
            this.lBStatus.Text = "Trạng thái";
            // 
            // lBRoomTypeID
            // 
            this.lBRoomTypeID.AutoSize = true;
            this.lBRoomTypeID.Location = new System.Drawing.Point(183, 18);
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
            this.cBRoomID.BackColor = System.Drawing.Color.Transparent;
            this.cBRoomID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBRoomID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBRoomID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBRoomID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cBRoomID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cBRoomID.ItemHeight = 30;
            this.cBRoomID.Location = new System.Drawing.Point(15, 37);
            this.cBRoomID.Name = "cBRoomID";
            this.cBRoomID.Size = new System.Drawing.Size(136, 36);
            this.cBRoomID.TabIndex = 45;
            // 
            // cBRoomTypeID
            // 
            this.cBRoomTypeID.BackColor = System.Drawing.Color.Transparent;
            this.cBRoomTypeID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBRoomTypeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBRoomTypeID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBRoomTypeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBRoomTypeID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cBRoomTypeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cBRoomTypeID.ItemHeight = 30;
            this.cBRoomTypeID.Location = new System.Drawing.Point(186, 37);
            this.cBRoomTypeID.Name = "cBRoomTypeID";
            this.cBRoomTypeID.Size = new System.Drawing.Size(136, 36);
            this.cBRoomTypeID.StartIndex = 0;
            this.cBRoomTypeID.TabIndex = 48;
            // 
            // cBRoomStatus
            // 
            this.cBRoomStatus.BackColor = System.Drawing.Color.Transparent;
            this.cBRoomStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBRoomStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBRoomStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBRoomStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cBRoomStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cBRoomStatus.ItemHeight = 30;
            this.cBRoomStatus.Items.AddRange(new object[] {
            "Trống",
            "Bảo trì"});
            this.cBRoomStatus.Location = new System.Drawing.Point(15, 106);
            this.cBRoomStatus.Name = "cBRoomStatus";
            this.cBRoomStatus.Size = new System.Drawing.Size(136, 36);
            this.cBRoomStatus.StartIndex = 0;
            this.cBRoomStatus.TabIndex = 49;
            // 
            // cBCleanStatus
            // 
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
            this.cBCleanStatus.Location = new System.Drawing.Point(186, 106);
            this.cBCleanStatus.Name = "cBCleanStatus";
            this.cBCleanStatus.Size = new System.Drawing.Size(135, 36);
            this.cBCleanStatus.StartIndex = 0;
            this.cBCleanStatus.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Dọn dẹp";
            // 
            // F_UpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 192);
            this.ControlBox = false;
            this.Controls.Add(this.cBCleanStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBRoomStatus);
            this.Controls.Add(this.cBRoomTypeID);
            this.Controls.Add(this.cBRoomID);
            this.Controls.Add(this.bTExit);
            this.Controls.Add(this.bTUpdate);
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
        private System.Windows.Forms.Label lBStatus;
        private System.Windows.Forms.Label lBRoomTypeID;
        private System.Windows.Forms.Label lBRoomID;
        private Guna.UI2.WinForms.Guna2ComboBox cBRoomID;
        private Guna.UI2.WinForms.Guna2ComboBox cBRoomTypeID;
        private Guna.UI2.WinForms.Guna2ComboBox cBRoomStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cBCleanStatus;
        private System.Windows.Forms.Label label1;
    }
}