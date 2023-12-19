﻿using Hotel.All_user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Home : Form
    {
        int position;
        public Home(int x)
        {
            InitializeComponent();
            position = x;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            uC_CustomerInfo1.Visible = false;
            uC_CheckOut1.Visible = false;
            uC_CustomerDetail1.Visible = false;
            uC_User1.Visible = false;
            uC_RoomManagement1.Visible = false;
            uC_Chartt1.Visible = false;
            uC_Employee21.Visible = false;
            uC_Employee1.Visible = false;
            uC_Service1.Visible = false;
            uC_Employee1.Visible = false;
            uC_RoomGrid1.Visible = false;
            btHome.PerformClick();
            Position();

        }
        private void Position()
        {
            if (position == 2)
            {
                btEmploy.Visible = false;
                btUser.Visible = false;
            }
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
        }

        private void btService_Click(object sender, EventArgs e)
        {
            uC_Service1.Visible = true;
            uC_Service1.BringToFront();

        }

        private void btMoney_Click(object sender, EventArgs e)
        {
            uC_Chartt1.Visible = true;
            uC_Chartt1.BringToFront();

        }

        private void btEmploy_Click(object sender, EventArgs e)
        {
            uC_Employee21.Visible = true;
            uC_Employee21.BringToFront();

        }

        private void btCustomerReg_Click(object sender, EventArgs e)
        {
            uC_CustomerInfo1.Visible = true;
            uC_CustomerInfo1.BringToFront();

        }

        private void btAddroom_Click(object sender, EventArgs e)
        {
            uC_RoomManagement1.Visible = true;
            uC_RoomManagement1.BringToFront();

        }

        private void btCheckOut_Click(object sender, EventArgs e)
        {
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();

        }

        private void btCustomerDetail_Click(object sender, EventArgs e)
        {

            uC_CustomerDetail1.Visible = true;
            uC_CustomerDetail1.BringToFront();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        private void btUser_Click(object sender, EventArgs e)
        {
            uC_User1.Visible = true;
            uC_User1.BringToFront();
        }

        private void bTRoomGrid_Click(object sender, EventArgs e)
        {
            uC_RoomGrid1.Visible = true;
            uC_RoomGrid1.BringToFront();
        }
    }
}
