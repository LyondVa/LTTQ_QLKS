using Hotel.Properties;
using Hotel.SmallForm;
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
    public partial class Form1 : Form
    {
        function fn = new function();
        string query;
        int txtPassFlag = 0;
        public Form1()
        {
            InitializeComponent();
            txbPassword.UseSystemPasswordChar = true;

            txbPassword.IconRight = Resources.OpenEye;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "admin" && txbPassword.Text == "admin")
            {
                Global.globalPermission = 1;
                Global.globalEmID = "admin";
                Global.globalEmName = "admin";
                Home dashboard = new Home(Global.globalPermission, Global.globalEmName);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                query = "select TENTK, MATKHAU, TAIKHOAN.MANV, NHOTEN, CHUCVU " +
                        "from TAIKHOAN, NHANVIEN " +
                        "where TAIKHOAN.MANV = NHANVIEN.MANV " +
                        "and TENTK = '" + txbUsername.Text + "' and MATKHAU = '" + txbPassword.Text + "' and TAIKHOAN.HOATDONG = 1";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    labelError.Visible = false;
                    if (ds.Tables[0].Rows[0]["CHUCVU"].ToString() == "Quản lý"|| ds.Tables[0].Rows[0]["CHUCVU"].ToString() =="Giám đốc")
                    {
                        Global.globalPermission = 1;
                    }
                    else
                    {
                        Global.globalPermission = 2;
                    }
                    Global.globalEmName = ds.Tables[0].Rows[0]["NHOTEN"].ToString();
                    Global.globalEmID = ds.Tables[0].Rows[0]["MANV"].ToString();
                    Home dashboard = new Home(Global.globalPermission, Global.globalEmName);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    labelError.Visible = true;
                    txbPassword.Clear();
                }
            }
        }

        private void txbPassword_IconRightClick(object sender, EventArgs e)
        {

            if (txtPassFlag == 0)
            {
                
                txbPassword.IconRight = Resources.ClosedEye;
                txbPassword.UseSystemPasswordChar = false;
                txtPassFlag = 1;
            }
            else
            {
                txbPassword.IconRight = Resources.OpenEye;
                txbPassword.UseSystemPasswordChar= true;

                txtPassFlag = 0;
            }
        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
