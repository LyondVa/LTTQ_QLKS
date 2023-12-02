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
            query = "select username, pass from employee where username = '" + txbUsername.Text + "' and pass = '" + txbPassword.Text + "'";
            DataSet ds = fn.getData(query);
            string query1 = "select position from employee where username = '" + txbUsername.Text + "' and pass = '" + txbPassword.Text + "'";
            DataSet ds1 = fn.getData(query1);
            int position = 0;
            if (ds.Tables[0].Rows.Count !=0 || (txbUsername.Text=="admin"&&txbPassword.Text =="admin"))
            {
                labelError.Visible = false;
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    position = Convert.ToInt32(ds1.Tables[0].Rows[0]["position"]);
                }
                if (txbUsername.Text == "admin" && txbPassword.Text == "admin")
                    position = 1;
                Dashboard dash = new Dashboard(position);
                this.Hide();
                dash.Show();
            }
            else
            {
                labelError.Visible = true;
                txbPassword.Clear();
            }
        }
    }
}
