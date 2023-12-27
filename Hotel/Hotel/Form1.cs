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

        public Form1()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int position = 0;
            if (txbUsername.Text == "admin" && txbPassword.Text == "admin")
            {
                position = 1;
                Global.globalEmID = "admin";
                Global.globalEmName = "admin";
                Home dashboard = new Home(position, Global.globalEmName);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                query = "select TENTK, MATKHAU, TAIKHOAN.MANV, NHOTEN, CHUCVU " +
                        "from TAIKHOAN, NHANVIEN " +
                        "where TAIKHOAN.MANV = NHANVIEN.MANV " +
                        "and TENTK = '" + txbUsername.Text + "' and MATKHAU = '" + txbPassword.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    labelError.Visible = false;
                    if (ds.Tables[0].Rows[0]["CHUCVU"].ToString() == "Quản lý")
                    {
                        position = 1;
                    }
                    Global.globalEmName = ds.Tables[0].Rows[0]["NHOTEN"].ToString();
                    Global.globalEmID = ds.Tables[0].Rows[0]["MANV"].ToString();
                    Home dashboard = new Home(position, Global.globalEmName);
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
    }
}
