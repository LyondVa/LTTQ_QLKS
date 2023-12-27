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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AddRoom));
            this.lBStatus = new System.Windows.Forms.Label();
            this.lBRoomTypeID = new System.Windows.Forms.Label();
            this.lBRoomID = new System.Windows.Forms.Label();
            this.lBFloor = new System.Windows.Forms.Label();
            this.cBFloor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cBRoomID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cBCleanStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBRoomStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cBRoomTypeID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBStatus
            // 
            this.lBStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lBStatus.AutoSize = true;
            this.lBStatus.BackColor = System.Drawing.Color.Transparent;
            this.lBStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBStatus.ForeColor = System.Drawing.Color.White;
            this.lBStatus.Location = new System.Drawing.Point(227, 167);
            this.lBStatus.Name = "lBStatus";
            this.lBStatus.Size = new System.Drawing.Size(98, 28);
            this.lBStatus.TabIndex = 21;
            this.lBStatus.Text = "Trạng thái";
            // 
            // lBRoomTypeID
            // 
            this.lBRoomTypeID.AutoSize = true;
            this.lBRoomTypeID.BackColor = System.Drawing.Color.Transparent;
            this.lBRoomTypeID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBRoomTypeID.ForeColor = System.Drawing.Color.White;
            this.lBRoomTypeID.Location = new System.Drawing.Point(27, 167);
            this.lBRoomTypeID.Name = "lBRoomTypeID";
            this.lBRoomTypeID.Size = new System.Drawing.Size(140, 28);
            this.lBRoomTypeID.TabIndex = 17;
            this.lBRoomTypeID.Text = "Mã loại phòng";
            // 
            // lBRoomID
            // 
            this.lBRoomID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lBRoomID.AutoSize = true;
            this.lBRoomID.BackColor = System.Drawing.Color.Transparent;
            this.lBRoomID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBRoomID.ForeColor = System.Drawing.Color.White;
            this.lBRoomID.Location = new System.Drawing.Point(227, 81);
            this.lBRoomID.Name = "lBRoomID";
            this.lBRoomID.Size = new System.Drawing.Size(103, 28);
            this.lBRoomID.TabIndex = 16;
            this.lBRoomID.Text = "Mã phòng";
            // 
            // lBFloor
            // 
            this.lBFloor.AutoSize = true;
            this.lBFloor.BackColor = System.Drawing.Color.Transparent;
            this.lBFloor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBFloor.ForeColor = System.Drawing.Color.White;
            this.lBFloor.Location = new System.Drawing.Point(27, 81);
            this.lBFloor.Name = "lBFloor";
            this.lBFloor.Size = new System.Drawing.Size(55, 28);
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
            this.cBFloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cBFloor.Location = new System.Drawing.Point(27, 110);
            this.cBFloor.Name = "cBFloor";
            this.cBFloor.Size = new System.Drawing.Size(170, 36);
            this.cBFloor.TabIndex = 33;
            this.cBFloor.SelectedIndexChanged += new System.EventHandler(this.cBFloor_SelectedItemChanged);
            // 
            // cBRoomID
            // 
            this.cBRoomID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cBRoomID.BackColor = System.Drawing.Color.Transparent;
            this.cBRoomID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBRoomID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBRoomID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBRoomID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cBRoomID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cBRoomID.ItemHeight = 30;
            this.cBRoomID.Location = new System.Drawing.Point(227, 110);
            this.cBRoomID.Name = "cBRoomID";
            this.cBRoomID.Size = new System.Drawing.Size(170, 36);
            this.cBRoomID.TabIndex = 34;
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
            this.cBCleanStatus.Location = new System.Drawing.Point(27, 278);
            this.cBCleanStatus.Name = "cBCleanStatus";
            this.cBCleanStatus.Size = new System.Drawing.Size(170, 36);
            this.cBCleanStatus.StartIndex = 0;
            this.cBCleanStatus.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 37;
            this.label1.Text = "Dọn dẹp";
            // 
            // cBRoomStatus
            // 
            this.cBRoomStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.cBRoomStatus.Location = new System.Drawing.Point(227, 197);
            this.cBRoomStatus.Name = "cBRoomStatus";
            this.cBRoomStatus.Size = new System.Drawing.Size(170, 36);
            this.cBRoomStatus.StartIndex = 0;
            this.cBRoomStatus.TabIndex = 39;
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
            this.cBRoomTypeID.Location = new System.Drawing.Point(27, 197);
            this.cBRoomTypeID.Name = "cBRoomTypeID";
            this.cBRoomTypeID.Size = new System.Drawing.Size(170, 36);
            this.cBRoomTypeID.TabIndex = 40;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(124)))), ((int)(((byte)(78)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(227, 251);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(170, 36);
            this.guna2Button1.TabIndex = 41;
            this.guna2Button1.Text = "Thêm";
            this.guna2Button1.Click += new System.EventHandler(this.bTAdd_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(124)))), ((int)(((byte)(78)))));
            this.guna2Button2.Location = new System.Drawing.Point(227, 307);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(170, 36);
            this.guna2Button2.TabIndex = 42;
            this.guna2Button2.Text = "Thoát";
            this.guna2Button2.Click += new System.EventHandler(this.bTExit_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 41);
            this.label7.TabIndex = 66;
            this.label7.Text = "Thêm Phòng";
            // 
            // F_AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(420, 360);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.cBRoomTypeID);
            this.Controls.Add(this.cBRoomStatus);
            this.Controls.Add(this.cBCleanStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBRoomID);
            this.Controls.Add(this.cBFloor);
            this.Controls.Add(this.lBFloor);
            this.Controls.Add(this.lBStatus);
            this.Controls.Add(this.lBRoomTypeID);
            this.Controls.Add(this.lBRoomID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_AddRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lBStatus;
        private System.Windows.Forms.Label lBRoomTypeID;
        private System.Windows.Forms.Label lBRoomID;
        private System.Windows.Forms.Label lBFloor;
        private Guna.UI2.WinForms.Guna2ComboBox cBFloor;
        private Guna.UI2.WinForms.Guna2ComboBox cBRoomID;
        private Guna.UI2.WinForms.Guna2ComboBox cBCleanStatus;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cBRoomStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cBRoomTypeID;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label7;
    }
}