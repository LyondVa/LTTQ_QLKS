namespace Hotel.RoomControls
{
    partial class F_AddRoom
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
            this.bTAdd = new System.Windows.Forms.Button();
            this.tBStatus = new System.Windows.Forms.TextBox();
            this.tBRoomType = new System.Windows.Forms.TextBox();
            this.lBStatus = new System.Windows.Forms.Label();
            this.lBRoomTypeID = new System.Windows.Forms.Label();
            this.lBRoomID = new System.Windows.Forms.Label();
            this.lBFloor = new System.Windows.Forms.Label();
            this.cBFloor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cBRoomID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // bTExit
            // 
            this.bTExit.Location = new System.Drawing.Point(212, 176);
            this.bTExit.Name = "bTExit";
            this.bTExit.Size = new System.Drawing.Size(75, 23);
            this.bTExit.TabIndex = 29;
            this.bTExit.Text = "Thoát";
            this.bTExit.UseVisualStyleBackColor = true;
            this.bTExit.Click += new System.EventHandler(this.bTExit_Click);
            // 
            // bTAdd
            // 
            this.bTAdd.Location = new System.Drawing.Point(131, 176);
            this.bTAdd.Name = "bTAdd";
            this.bTAdd.Size = new System.Drawing.Size(75, 23);
            this.bTAdd.TabIndex = 28;
            this.bTAdd.Text = "Thêm";
            this.bTAdd.UseVisualStyleBackColor = true;
            this.bTAdd.Click += new System.EventHandler(this.bTAdd_Click);
            // 
            // tBStatus
            // 
            this.tBStatus.Location = new System.Drawing.Point(187, 124);
            this.tBStatus.Name = "tBStatus";
            this.tBStatus.Size = new System.Drawing.Size(100, 22);
            this.tBStatus.TabIndex = 27;
            // 
            // tBRoomType
            // 
            this.tBRoomType.Location = new System.Drawing.Point(15, 124);
            this.tBRoomType.Name = "tBRoomType";
            this.tBRoomType.Size = new System.Drawing.Size(100, 22);
            this.tBRoomType.TabIndex = 24;
            // 
            // lBStatus
            // 
            this.lBStatus.AutoSize = true;
            this.lBStatus.Location = new System.Drawing.Point(184, 105);
            this.lBStatus.Name = "lBStatus";
            this.lBStatus.Size = new System.Drawing.Size(67, 16);
            this.lBStatus.TabIndex = 21;
            this.lBStatus.Text = "Trạng thái";
            // 
            // lBRoomTypeID
            // 
            this.lBRoomTypeID.AutoSize = true;
            this.lBRoomTypeID.Location = new System.Drawing.Point(12, 105);
            this.lBRoomTypeID.Name = "lBRoomTypeID";
            this.lBRoomTypeID.Size = new System.Drawing.Size(92, 16);
            this.lBRoomTypeID.TabIndex = 17;
            this.lBRoomTypeID.Text = "Mã loại phòng";
            // 
            // lBRoomID
            // 
            this.lBRoomID.AutoSize = true;
            this.lBRoomID.Location = new System.Drawing.Point(184, 18);
            this.lBRoomID.Name = "lBRoomID";
            this.lBRoomID.Size = new System.Drawing.Size(67, 16);
            this.lBRoomID.TabIndex = 16;
            this.lBRoomID.Text = "Mã phòng";
            // 
            // lBFloor
            // 
            this.lBFloor.AutoSize = true;
            this.lBFloor.Location = new System.Drawing.Point(12, 18);
            this.lBFloor.Name = "lBFloor";
            this.lBFloor.Size = new System.Drawing.Size(39, 16);
            this.lBFloor.TabIndex = 30;
            this.lBFloor.Text = "Tầng";
            // 
            // cBFloor
            // 
            this.cBFloor.BackColor = System.Drawing.Color.Transparent;
            this.cBFloor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBFloor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBFloor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBFloor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cBFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cBFloor.ItemHeight = 30;
            this.cBFloor.Location = new System.Drawing.Point(15, 38);
            this.cBFloor.Name = "cBFloor";
            this.cBFloor.Size = new System.Drawing.Size(100, 36);
            this.cBFloor.TabIndex = 33;
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
            this.cBRoomID.Location = new System.Drawing.Point(187, 38);
            this.cBRoomID.Name = "cBRoomID";
            this.cBRoomID.Size = new System.Drawing.Size(100, 36);
            this.cBRoomID.TabIndex = 34;
            // 
            // F_AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 230);
            this.ControlBox = false;
            this.Controls.Add(this.cBRoomID);
            this.Controls.Add(this.cBFloor);
            this.Controls.Add(this.lBFloor);
            this.Controls.Add(this.bTExit);
            this.Controls.Add(this.bTAdd);
            this.Controls.Add(this.tBStatus);
            this.Controls.Add(this.tBRoomType);
            this.Controls.Add(this.lBStatus);
            this.Controls.Add(this.lBRoomTypeID);
            this.Controls.Add(this.lBRoomID);
            this.Name = "F_AddRoom";
            this.Text = "Thêm phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bTExit;
        private System.Windows.Forms.Button bTAdd;
        private System.Windows.Forms.TextBox tBStatus;
        private System.Windows.Forms.TextBox tBRoomType;
        private System.Windows.Forms.Label lBStatus;
        private System.Windows.Forms.Label lBRoomTypeID;
        private System.Windows.Forms.Label lBRoomID;
        private System.Windows.Forms.Label lBFloor;
        private Guna.UI2.WinForms.Guna2ComboBox cBFloor;
        private Guna.UI2.WinForms.Guna2ComboBox cBRoomID;
    }
}