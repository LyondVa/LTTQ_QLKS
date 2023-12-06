using Hotel.All_user_control;
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
    public partial class Dashboard : Form
    {
        int position;
        public Dashboard(int x)
        {
            InitializeComponent();
            position = x;
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            //uC_Addroom1.Visible = false;
            uC_CustomerRes1.Visible = false;
            uC_CustomerDetail1.Visible = false;
            uC_Employee1.Visible= false;
            uC_User1.Visible = false;
            btAddroom.PerformClick();
            Position();
        }

        private void Position()
        {
            if(position == 2)
            {
                btEmploy.Visible= false;
                btUser.Visible = false;
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_RoomManagement1.Show();
            uC_RoomManagement1.BringToFront();
        }

        
        private void uC_Addroom1_Load(object sender, EventArgs e)
        {

        }

        private void btCustomerReg_Click(object sender, EventArgs e)
        {
            uC_CustomerRes1.Visible = true;
            uC_CustomerRes1.BringToFront();
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

        private void uC_CustomerDetail1_Load(object sender, EventArgs e)
        {

        }

        private void btEmploy_Click(object sender, EventArgs e)
        {
            
            uC_Employee21.Visible = true;
            uC_Employee21.BringToFront();
        }

        private void uC_Employee1_Load(object sender, EventArgs e)
        {

        }

        private void btEmploy_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            uC_User1.Visible = true;
            uC_User1.BringToFront();
        }
    }
}
