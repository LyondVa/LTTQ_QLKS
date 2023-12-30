using Guna.UI2.WinForms;
using Hotel.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.SmallForm
{
    public partial class ChangePassword : Form
    {
        function fn = new function();
        string query;
        string pass;
        string pass1;
        string pass2;
        string pass3;
        string manv;
        public ChangePassword(string x, string man)
        {
            InitializeComponent();

            guna2TextBox1.UseSystemPasswordChar = true;
            guna2TextBox2.UseSystemPasswordChar = true;
            pass = x;
            guna2TextBox3.UseSystemPasswordChar = true;
            manv = man;
            guna2TextBox3.IconRight = Resources.OpenEye;
            guna2TextBox2.IconRight = Resources.OpenEye;
            guna2TextBox1.IconRight = Resources.OpenEye;

        }
        int txtPassFlag = 0;
        private void guna2TextBox1_IconRightClick(object sender, EventArgs e)
        {
            if (txtPassFlag == 0)
            {

                guna2TextBox1.IconRight = Resources.ClosedEye;
                guna2TextBox1.UseSystemPasswordChar = false;
                txtPassFlag = 1;
            }
            else
            {
                guna2TextBox1.IconRight = Resources.OpenEye;
                guna2TextBox1.UseSystemPasswordChar = true;

                txtPassFlag = 0;
            }
        }

        private void guna2TextBox2_IconRightClick(object sender, EventArgs e)
        {
            if (txtPassFlag == 0)
            {

                guna2TextBox2.IconRight = Resources.ClosedEye;
                guna2TextBox2.UseSystemPasswordChar = false;
                txtPassFlag = 1;
            }
            else
            {
                guna2TextBox2.IconRight = Resources.OpenEye;
                guna2TextBox2.UseSystemPasswordChar = true;

                txtPassFlag = 0;
            }
        }

        private void guna2TextBox3_IconRightClick(object sender, EventArgs e)
        {
            if (txtPassFlag == 0)
            {

                guna2TextBox3.IconRight = Resources.ClosedEye;
                guna2TextBox3.UseSystemPasswordChar = false;
                txtPassFlag = 1;
            }
            else
            {
                guna2TextBox3.IconRight = Resources.OpenEye;
                guna2TextBox3.UseSystemPasswordChar = true;

                txtPassFlag = 0;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            pass2 = guna2TextBox2.Text;
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            pass3 = guna2TextBox3.Text;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            pass1 = guna2TextBox1.Text; 
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(pass3 != pass2)
            {
                MessageBox.Show("Mật Khẩu Mới Không Khớp");
            }
            else if(pass1 == pass2)
            {
                MessageBox.Show("Mật Khẩu Mới Không Được Trùng Mật Khẩu Cũ");
            }
            else if(pass1 != pass)
            {
                MessageBox.Show("Mật Khẩu Hiện Tại Không Đúng");
            }
            else
            {
                query = "UPDATE TAIKHOAN SET MATKHAU = '" + pass + "' WHERE MANV = '" + manv + "'";
                fn.setData(query,"Đổi Mật Khẩu Thành Công");
                this.Close();
            }
        }
    }
}
