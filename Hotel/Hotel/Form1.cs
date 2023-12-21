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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select TENTK, MATKHAU, MANV " +
                    "from TAIKHOAN where TENTK = '" + txbUsername.Text + "' and MATKHAU = '" + txbPassword.Text + "'";
            DataSet ds = fn.getData(query);
            string query1 = "select CHUCVU " +
                            "from NHANVIEN, TAIKHOAN " +
                            "where NHANVIEN.MANV = TAIKHOAN.MANV " +
                            "and TENTK = '" + txbUsername.Text + "' and MATKHAU = '" + txbPassword.Text + "'";
            DataSet ds1 = fn.getData(query1);
            int position = 0;
            if (ds.Tables[0].Rows.Count !=0 || (txbUsername.Text=="admin"&&txbPassword.Text =="admin"))
            {
                labelError.Visible = false;
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    if (ds1.Tables[0].Rows[0]["CHUCVU"].ToString() == "Quản lý")
                    {
                        position = 1;
                    }
                }
                if (txbUsername.Text == "admin" && txbPassword.Text == "admin")
                    position = 1;
                Home dash = new Home(position);
                this.Hide();
                dash.Show();
                Global.globalEmID = ds.Tables[0].Rows[0]["MANV"].ToString();
            }
            else
            {
                labelError.Visible = true;
                txbPassword.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
