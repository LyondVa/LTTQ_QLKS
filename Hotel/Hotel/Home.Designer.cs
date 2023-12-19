namespace Hotel
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bTRoomGrid = new Guna.UI2.WinForms.Guna2Button();
            this.btMoney = new Guna.UI2.WinForms.Guna2Button();
            this.btService = new Guna.UI2.WinForms.Guna2Button();
            this.btUser = new Guna.UI2.WinForms.Guna2Button();
            this.btEmploy = new Guna.UI2.WinForms.Guna2Button();
            this.btCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btCustomerDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btCustomerReg = new Guna.UI2.WinForms.Guna2Button();
            this.btAddroom = new Guna.UI2.WinForms.Guna2Button();
            this.btHome = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uC_CustomerInfo1 = new Hotel.All_user_control.UC_CustomerInfo();
            this.uC_CustomerDetail1 = new Hotel.All_user_control.UC_CustomerDetail();
            this.uC_Employee21 = new Hotel.All_user_control.UC_Employee2();
            this.uC_User1 = new Hotel.All_user_control.UC_User();
            this.uC_RoomManagement1 = new Hotel.All_user_control.UC_RoomManagement();
            this.uC_Chartt1 = new Hotel.All_user_control.UC_Chartt();
            this.uC_Service1 = new Hotel.All_user_control.UC_Service();
            this.uC_Employee1 = new Hotel.All_user_control.UC_Employee();
            this.uC_CheckOut1 = new Hotel.All_user_control.UC_CheckOut();
            this.label1 = new System.Windows.Forms.Label();
            this.uC_RoomGrid1 = new Hotel.RoomControls.UC_RoomGrid();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-6, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 690);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.bTRoomGrid);
            this.panel2.Controls.Add(this.btMoney);
            this.panel2.Controls.Add(this.btService);
            this.panel2.Controls.Add(this.btUser);
            this.panel2.Controls.Add(this.btEmploy);
            this.panel2.Controls.Add(this.btCheckOut);
            this.panel2.Controls.Add(this.btCustomerDetail);
            this.panel2.Controls.Add(this.btCustomerReg);
            this.panel2.Controls.Add(this.btAddroom);
            this.panel2.Controls.Add(this.btHome);
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 495);
            this.panel2.TabIndex = 7;
            // 
            // bTRoomGrid
            // 
            this.bTRoomGrid.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bTRoomGrid.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bTRoomGrid.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bTRoomGrid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bTRoomGrid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bTRoomGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.bTRoomGrid.FillColor = System.Drawing.Color.Transparent;
            this.bTRoomGrid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTRoomGrid.ForeColor = System.Drawing.Color.White;
            this.bTRoomGrid.Location = new System.Drawing.Point(0, 450);
            this.bTRoomGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bTRoomGrid.Name = "bTRoomGrid";
            this.bTRoomGrid.Size = new System.Drawing.Size(200, 50);
            this.bTRoomGrid.TabIndex = 9;
            this.bTRoomGrid.Text = "Sơ đồ phòng";
            this.bTRoomGrid.Click += new System.EventHandler(this.bTRoomGrid_Click);
            // 
            // btMoney
            // 
            this.btMoney.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btMoney.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btMoney.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btMoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btMoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMoney.FillColor = System.Drawing.Color.Transparent;
            this.btMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMoney.ForeColor = System.Drawing.Color.White;
            this.btMoney.Location = new System.Drawing.Point(0, 400);
            this.btMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btMoney.Name = "btMoney";
            this.btMoney.Size = new System.Drawing.Size(200, 50);
            this.btMoney.TabIndex = 8;
            this.btMoney.Text = "Doanh Thu";
            this.btMoney.Click += new System.EventHandler(this.btMoney_Click);
            // 
            // btService
            // 
            this.btService.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btService.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btService.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btService.FillColor = System.Drawing.Color.Transparent;
            this.btService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btService.ForeColor = System.Drawing.Color.White;
            this.btService.Location = new System.Drawing.Point(0, 350);
            this.btService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btService.Name = "btService";
            this.btService.Size = new System.Drawing.Size(200, 50);
            this.btService.TabIndex = 8;
            this.btService.Text = "Dịch Vụ";
            this.btService.Click += new System.EventHandler(this.btService_Click);
            // 
            // btUser
            // 
            this.btUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUser.FillColor = System.Drawing.Color.Transparent;
            this.btUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUser.ForeColor = System.Drawing.Color.White;
            this.btUser.Location = new System.Drawing.Point(0, 300);
            this.btUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(200, 50);
            this.btUser.TabIndex = 5;
            this.btUser.Text = "Quản Lý Nhân Viên";
            this.btUser.Click += new System.EventHandler(this.btUser_Click);
            // 
            // btEmploy
            // 
            this.btEmploy.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btEmploy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btEmploy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btEmploy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btEmploy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btEmploy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEmploy.FillColor = System.Drawing.Color.Transparent;
            this.btEmploy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmploy.ForeColor = System.Drawing.Color.White;
            this.btEmploy.Location = new System.Drawing.Point(0, 250);
            this.btEmploy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEmploy.Name = "btEmploy";
            this.btEmploy.Size = new System.Drawing.Size(200, 50);
            this.btEmploy.TabIndex = 4;
            this.btEmploy.Text = "Thông Tin Nhân Viên";
            this.btEmploy.Click += new System.EventHandler(this.btEmploy_Click);
            // 
            // btCheckOut
            // 
            this.btCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCheckOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCheckOut.FillColor = System.Drawing.Color.Transparent;
            this.btCheckOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckOut.ForeColor = System.Drawing.Color.White;
            this.btCheckOut.Location = new System.Drawing.Point(0, 200);
            this.btCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(200, 50);
            this.btCheckOut.TabIndex = 2;
            this.btCheckOut.Text = "Thanh Toán";
            this.btCheckOut.Click += new System.EventHandler(this.btCheckOut_Click);
            // 
            // btCustomerDetail
            // 
            this.btCustomerDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btCustomerDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCustomerDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCustomerDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCustomerDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCustomerDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCustomerDetail.FillColor = System.Drawing.Color.Transparent;
            this.btCustomerDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCustomerDetail.ForeColor = System.Drawing.Color.White;
            this.btCustomerDetail.Location = new System.Drawing.Point(0, 150);
            this.btCustomerDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCustomerDetail.Name = "btCustomerDetail";
            this.btCustomerDetail.Size = new System.Drawing.Size(200, 50);
            this.btCustomerDetail.TabIndex = 3;
            this.btCustomerDetail.Text = "Chi Tiết Khách Hàng";
            this.btCustomerDetail.Click += new System.EventHandler(this.btCustomerDetail_Click);
            // 
            // btCustomerReg
            // 
            this.btCustomerReg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btCustomerReg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCustomerReg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCustomerReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCustomerReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCustomerReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCustomerReg.FillColor = System.Drawing.Color.Transparent;
            this.btCustomerReg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btCustomerReg.ForeColor = System.Drawing.Color.White;
            this.btCustomerReg.Location = new System.Drawing.Point(0, 100);
            this.btCustomerReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCustomerReg.Name = "btCustomerReg";
            this.btCustomerReg.Size = new System.Drawing.Size(200, 50);
            this.btCustomerReg.TabIndex = 1;
            this.btCustomerReg.Text = "Thông Tin Khách Hàng";
            this.btCustomerReg.Click += new System.EventHandler(this.btCustomerReg_Click);
            // 
            // btAddroom
            // 
            this.btAddroom.BackColor = System.Drawing.Color.Transparent;
            this.btAddroom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btAddroom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAddroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAddroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAddroom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAddroom.FillColor = System.Drawing.Color.Transparent;
            this.btAddroom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddroom.ForeColor = System.Drawing.Color.White;
            this.btAddroom.Location = new System.Drawing.Point(0, 50);
            this.btAddroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddroom.Name = "btAddroom";
            this.btAddroom.Size = new System.Drawing.Size(200, 50);
            this.btAddroom.TabIndex = 0;
            this.btAddroom.Text = "Danh sách phòng";
            this.btAddroom.Click += new System.EventHandler(this.btAddroom_Click);
            // 
            // btHome
            // 
            this.btHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHome.FillColor = System.Drawing.Color.Transparent;
            this.btHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.Location = new System.Drawing.Point(0, 0);
            this.btHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(200, 50);
            this.btHome.TabIndex = 7;
            this.btHome.Text = "Trang Chủ";
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.uC_RoomGrid1);
            this.panel3.Controls.Add(this.uC_CustomerInfo1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.uC_CheckOut1);
            this.panel3.Controls.Add(this.uC_Employee1);
            this.panel3.Controls.Add(this.uC_Service1);
            this.panel3.Controls.Add(this.uC_Chartt1);
            this.panel3.Controls.Add(this.uC_RoomManagement1);
            this.panel3.Controls.Add(this.uC_User1);
            this.panel3.Controls.Add(this.uC_Employee21);
            this.panel3.Controls.Add(this.uC_CustomerDetail1);
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 690);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 690);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uC_CustomerInfo1
            // 
            this.uC_CustomerInfo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_CustomerInfo1.BackgroundImage")));
            this.uC_CustomerInfo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_CustomerInfo1.Location = new System.Drawing.Point(0, 0);
            this.uC_CustomerInfo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uC_CustomerInfo1.Name = "uC_CustomerInfo1";
            this.uC_CustomerInfo1.Size = new System.Drawing.Size(900, 690);
            this.uC_CustomerInfo1.TabIndex = 1;
            // 
            // uC_CustomerDetail1
            // 
            this.uC_CustomerDetail1.Location = new System.Drawing.Point(0, 0);
            this.uC_CustomerDetail1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_CustomerDetail1.Name = "uC_CustomerDetail1";
            this.uC_CustomerDetail1.Size = new System.Drawing.Size(900, 690);
            this.uC_CustomerDetail1.TabIndex = 2;
            // 
            // uC_Employee21
            // 
            this.uC_Employee21.Location = new System.Drawing.Point(0, 0);
            this.uC_Employee21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Employee21.Name = "uC_Employee21";
            this.uC_Employee21.Size = new System.Drawing.Size(900, 690);
            this.uC_Employee21.TabIndex = 3;
            // 
            // uC_User1
            // 
            this.uC_User1.Location = new System.Drawing.Point(0, 0);
            this.uC_User1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_User1.Name = "uC_User1";
            this.uC_User1.Size = new System.Drawing.Size(900, 690);
            this.uC_User1.TabIndex = 4;
            // 
            // uC_RoomManagement1
            // 
            this.uC_RoomManagement1.Location = new System.Drawing.Point(0, 0);
            this.uC_RoomManagement1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uC_RoomManagement1.Name = "uC_RoomManagement1";
            this.uC_RoomManagement1.Size = new System.Drawing.Size(900, 690);
            this.uC_RoomManagement1.TabIndex = 5;
            // 
            // uC_Chartt1
            // 
            this.uC_Chartt1.Location = new System.Drawing.Point(0, 0);
            this.uC_Chartt1.Name = "uC_Chartt1";
            this.uC_Chartt1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uC_Chartt1.Size = new System.Drawing.Size(900, 690);
            this.uC_Chartt1.TabIndex = 6;
            // 
            // uC_Service1
            // 
            this.uC_Service1.Location = new System.Drawing.Point(0, 0);
            this.uC_Service1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Service1.Name = "uC_Service1";
            this.uC_Service1.Size = new System.Drawing.Size(900, 690);
            this.uC_Service1.TabIndex = 7;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.ForeColor = System.Drawing.Color.Black;
            this.uC_Employee1.Location = new System.Drawing.Point(0, 0);
            this.uC_Employee1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(900, 690);
            this.uC_Employee1.TabIndex = 8;
            // 
            // uC_CheckOut1
            // 
            this.uC_CheckOut1.Location = new System.Drawing.Point(0, 0);
            this.uC_CheckOut1.Name = "uC_CheckOut1";
            this.uC_CheckOut1.Size = new System.Drawing.Size(900, 690);
            this.uC_CheckOut1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đăng xuất";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // uC_RoomGrid1
            // 
            this.uC_RoomGrid1.AutoScroll = true;
            this.uC_RoomGrid1.BackColor = System.Drawing.Color.White;
            this.uC_RoomGrid1.Location = new System.Drawing.Point(0, 0);
            this.uC_RoomGrid1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uC_RoomGrid1.Name = "uC_RoomGrid1";
            this.uC_RoomGrid1.Size = new System.Drawing.Size(900, 690);
            this.uC_RoomGrid1.TabIndex = 10;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1100, 690);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button bTRoomGrid;
        private Guna.UI2.WinForms.Guna2Button btMoney;
        private Guna.UI2.WinForms.Guna2Button btService;
        private Guna.UI2.WinForms.Guna2Button btUser;
        private Guna.UI2.WinForms.Guna2Button btEmploy;
        private Guna.UI2.WinForms.Guna2Button btCheckOut;
        private Guna.UI2.WinForms.Guna2Button btCustomerDetail;
        private Guna.UI2.WinForms.Guna2Button btCustomerReg;
        private Guna.UI2.WinForms.Guna2Button btAddroom;
        private Guna.UI2.WinForms.Guna2Button btHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private All_user_control.UC_User uC_User1;
        private All_user_control.UC_Employee2 uC_Employee21;
        private All_user_control.UC_CustomerDetail uC_CustomerDetail1;
        private All_user_control.UC_CustomerInfo uC_CustomerInfo1;
        private All_user_control.UC_Service uC_Service1;
        private All_user_control.UC_Chartt uC_Chartt1;
        private All_user_control.UC_RoomManagement uC_RoomManagement1;
        private All_user_control.UC_Employee uC_Employee1;
        private All_user_control.UC_CheckOut uC_CheckOut1;
        private System.Windows.Forms.Label label1;
        private RoomControls.UC_RoomGrid uC_RoomGrid1;
    }
}