﻿namespace Hotel
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btEmploy = new Guna.UI2.WinForms.Guna2Button();
            this.btCustomerDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btCustomerReg = new Guna.UI2.WinForms.Guna2Button();
            this.btAddroom = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_CustomerInfo1 = new Hotel.All_user_control.UC_CustomerInfo();
            this.uC_Service1 = new Hotel.All_user_control.UC_Service();
            this.uC_RoomManagement1 = new Hotel.All_user_control.UC_RoomManagement();
            this.uC_Employee1 = new Hotel.All_user_control.UC_Employee();
            this.uC_CustomerDetail1 = new Hotel.All_user_control.UC_CustomerDetail();
            this.uC_CheckOut1 = new Hotel.All_user_control.UC_CheckOut();
            this.uC_Employee21 = new Hotel.All_user_control.UC_Employee2();
            this.uC_User1 = new Hotel.All_user_control.UC_User();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btUser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btService = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinisize = new Guna.UI2.WinForms.Guna2Button();
            this.btExit = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btEmploy
            // 
            this.btEmploy.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btEmploy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btEmploy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btEmploy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btEmploy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btEmploy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEmploy.FillColor = System.Drawing.Color.SlateBlue;
            this.btEmploy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmploy.ForeColor = System.Drawing.Color.White;
            this.btEmploy.Location = new System.Drawing.Point(0, 462);
            this.btEmploy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEmploy.Name = "btEmploy";
            this.btEmploy.Size = new System.Drawing.Size(328, 93);
            this.btEmploy.TabIndex = 4;
            this.btEmploy.Text = "Thông Tin Nhân Viên";
            this.btEmploy.EnabledChanged += new System.EventHandler(this.btEmploy_EnabledChanged);
            this.btEmploy.Click += new System.EventHandler(this.btEmploy_Click);
            // 
            // btCustomerDetail
            // 
            this.btCustomerDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btCustomerDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCustomerDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCustomerDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCustomerDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCustomerDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCustomerDetail.FillColor = System.Drawing.Color.SlateBlue;
            this.btCustomerDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCustomerDetail.ForeColor = System.Drawing.Color.White;
            this.btCustomerDetail.Location = new System.Drawing.Point(0, 276);
            this.btCustomerDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCustomerDetail.Name = "btCustomerDetail";
            this.btCustomerDetail.Size = new System.Drawing.Size(328, 93);
            this.btCustomerDetail.TabIndex = 3;
            this.btCustomerDetail.Text = "Chi Tiết Khách Hàng";
            this.btCustomerDetail.Click += new System.EventHandler(this.btCustomerDetail_Click);
            // 
            // btCheckOut
            // 
            this.btCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCheckOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCheckOut.FillColor = System.Drawing.Color.SlateBlue;
            this.btCheckOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckOut.ForeColor = System.Drawing.Color.White;
            this.btCheckOut.Location = new System.Drawing.Point(0, 369);
            this.btCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(328, 93);
            this.btCheckOut.TabIndex = 2;
            this.btCheckOut.Text = "Thanh Toán";
            this.btCheckOut.Click += new System.EventHandler(this.btCheckOut_Click);
            // 
            // btCustomerReg
            // 
            this.btCustomerReg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btCustomerReg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCustomerReg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCustomerReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCustomerReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCustomerReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCustomerReg.FillColor = System.Drawing.Color.SlateBlue;
            this.btCustomerReg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btCustomerReg.ForeColor = System.Drawing.Color.White;
            this.btCustomerReg.Location = new System.Drawing.Point(0, 183);
            this.btCustomerReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCustomerReg.Name = "btCustomerReg";
            this.btCustomerReg.Size = new System.Drawing.Size(328, 93);
            this.btCustomerReg.TabIndex = 1;
            this.btCustomerReg.Text = "Thông Tin Khách Hàng";
            this.btCustomerReg.Click += new System.EventHandler(this.btCustomerReg_Click);
            // 
            // btAddroom
            // 
            this.btAddroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btAddroom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btAddroom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAddroom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAddroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAddroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAddroom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAddroom.FillColor = System.Drawing.Color.SlateBlue;
            this.btAddroom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddroom.ForeColor = System.Drawing.Color.White;
            this.btAddroom.Location = new System.Drawing.Point(0, 90);
            this.btAddroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddroom.Name = "btAddroom";
            this.btAddroom.Size = new System.Drawing.Size(328, 93);
            this.btAddroom.TabIndex = 0;
            this.btAddroom.Text = "Danh sách phòng";
            this.btAddroom.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.uC_CustomerInfo1);
            this.panel2.Controls.Add(this.uC_Service1);
            this.panel2.Controls.Add(this.uC_RoomManagement1);
            this.panel2.Controls.Add(this.uC_Employee1);
            this.panel2.Controls.Add(this.uC_CustomerDetail1);
            this.panel2.Controls.Add(this.uC_CheckOut1);
            this.panel2.Controls.Add(this.uC_Employee21);
            this.panel2.Controls.Add(this.uC_User1);
            this.panel2.Location = new System.Drawing.Point(294, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1436, 805);
            this.panel2.TabIndex = 3;
            // 
            // uC_CustomerInfo1
            // 
            this.uC_CustomerInfo1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerInfo1.Location = new System.Drawing.Point(-1, -4);
            this.uC_CustomerInfo1.Name = "uC_CustomerInfo1";
            this.uC_CustomerInfo1.Size = new System.Drawing.Size(1673, 682);
            this.uC_CustomerInfo1.TabIndex = 8;
            // 
            // uC_Service1
            // 
            this.uC_Service1.BackColor = System.Drawing.Color.White;
            this.uC_Service1.Location = new System.Drawing.Point(25, -4);
            this.uC_Service1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Service1.Name = "uC_Service1";
            this.uC_Service1.Size = new System.Drawing.Size(1673, 682);
            this.uC_Service1.TabIndex = 7;
            // 
            // uC_RoomManagement1
            // 
            this.uC_RoomManagement1.BackColor = System.Drawing.Color.White;
            this.uC_RoomManagement1.Location = new System.Drawing.Point(26, 1);
            this.uC_RoomManagement1.Name = "uC_RoomManagement1";
            this.uC_RoomManagement1.Size = new System.Drawing.Size(1313, 682);
            this.uC_RoomManagement1.TabIndex = 5;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.Color.White;
            this.uC_Employee1.ForeColor = System.Drawing.Color.Black;
            this.uC_Employee1.Location = new System.Drawing.Point(26, -2);
            this.uC_Employee1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1315, 599);
            this.uC_Employee1.TabIndex = 4;
            this.uC_Employee1.Load += new System.EventHandler(this.uC_Employee1_Load);
            // 
            // uC_CustomerDetail1
            // 
            this.uC_CustomerDetail1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerDetail1.Location = new System.Drawing.Point(3, -2);
            this.uC_CustomerDetail1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_CustomerDetail1.Name = "uC_CustomerDetail1";
            this.uC_CustomerDetail1.Size = new System.Drawing.Size(1624, 679);
            this.uC_CustomerDetail1.TabIndex = 3;
            this.uC_CustomerDetail1.Load += new System.EventHandler(this.uC_CustomerDetail1_Load);
            // 
            // uC_CheckOut1
            // 
            this.uC_CheckOut1.BackColor = System.Drawing.Color.White;
            this.uC_CheckOut1.Location = new System.Drawing.Point(-4, 2);
            this.uC_CheckOut1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_CheckOut1.Name = "uC_CheckOut1";
            this.uC_CheckOut1.Size = new System.Drawing.Size(1314, 679);
            this.uC_CheckOut1.TabIndex = 2;
            // 
            // uC_Employee21
            // 
            this.uC_Employee21.BackColor = System.Drawing.Color.White;
            this.uC_Employee21.Location = new System.Drawing.Point(-28, 2);
            this.uC_Employee21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Employee21.Name = "uC_Employee21";
            this.uC_Employee21.Size = new System.Drawing.Size(1478, 853);
            this.uC_Employee21.TabIndex = 6;
            // 
            // uC_User1
            // 
            this.uC_User1.BackColor = System.Drawing.Color.White;
            this.uC_User1.Location = new System.Drawing.Point(-1, -1);
            this.uC_User1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_User1.Name = "uC_User1";
            this.uC_User1.Size = new System.Drawing.Size(1478, 853);
            this.uC_User1.TabIndex = 5;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this;
            // 
            // btUser
            // 
            this.btUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUser.FillColor = System.Drawing.Color.SlateBlue;
            this.btUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUser.ForeColor = System.Drawing.Color.White;
            this.btUser.Location = new System.Drawing.Point(0, 555);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(328, 90);
            this.btUser.TabIndex = 5;
            this.btUser.Text = "Quản Lý Nhân Viên";
            this.btUser.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 30;
            this.guna2Elipse7.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btService);
            this.panel1.Controls.Add(this.btUser);
            this.panel1.Controls.Add(this.btEmploy);
            this.panel1.Controls.Add(this.btCheckOut);
            this.panel1.Controls.Add(this.btCustomerDetail);
            this.panel1.Controls.Add(this.btCustomerReg);
            this.panel1.Controls.Add(this.btAddroom);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Location = new System.Drawing.Point(1, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 835);
            this.panel1.TabIndex = 6;
            // 
            // btService
            // 
            this.btService.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btService.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btService.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btService.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btService.FillColor = System.Drawing.Color.SlateBlue;
            this.btService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btService.ForeColor = System.Drawing.Color.White;
            this.btService.Location = new System.Drawing.Point(0, 745);
            this.btService.Name = "btService";
            this.btService.Size = new System.Drawing.Size(328, 90);
            this.btService.TabIndex = 8;
            this.btService.Text = "Dịch Vụ";
            this.btService.Click += new System.EventHandler(this.btService_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button2.FillColor = System.Drawing.Color.SlateBlue;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(0, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(328, 90);
            this.guna2Button2.TabIndex = 7;
            this.guna2Button2.Text = "Trang Chủ";
            // 
            // btnMinisize
            // 
            this.btnMinisize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinisize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinisize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinisize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinisize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnMinisize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinisize.ForeColor = System.Drawing.Color.Wheat;
            this.btnMinisize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinisize.Image")));
            this.btnMinisize.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMinisize.Location = new System.Drawing.Point(1640, 1);
            this.btnMinisize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(44, 36);
            this.btnMinisize.TabIndex = 1;
            // 
            // btExit
            // 
            this.btExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btExit.ForeColor = System.Drawing.Color.Wheat;
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.ImageSize = new System.Drawing.Size(40, 40);
            this.btExit.Location = new System.Drawing.Point(1686, 1);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(44, 36);
            this.btExit.TabIndex = 0;
            this.btExit.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1726, 1011);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnMinisize);
            this.Controls.Add(this.btExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboardcs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btExit;
        private Guna.UI2.WinForms.Guna2Button btnMinisize;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btAddroom;
        private Guna.UI2.WinForms.Guna2Button btEmploy;
        private Guna.UI2.WinForms.Guna2Button btCustomerDetail;
        private Guna.UI2.WinForms.Guna2Button btCheckOut;
        private Guna.UI2.WinForms.Guna2Button btCustomerReg;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_user_control.UC_CheckOut uC_CheckOut1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_user_control.UC_CustomerDetail uC_CustomerDetail1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_user_control.UC_Employee uC_Employee1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Guna.UI2.WinForms.Guna2Button btUser;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private All_user_control.UC_User uC_User1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private All_user_control.UC_Employee2 uC_Employee21;
        private All_user_control.UC_RoomManagement uC_RoomManagement1;
        private Guna.UI2.WinForms.Guna2Button btService;
        private All_user_control.UC_Service uC_Service1;
        private All_user_control.UC_CustomerInfo uC_CustomerInfo1;
    }
}