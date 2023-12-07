using System;
using System.Collections;
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
    public partial class AddEmployee : Form
    {
        function fn = new function();
        string query;
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobile.Text != "" && txtEmail.Text != "" && cbGender.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtPosition.Text != "")
            {
                string name = txtName.Text;
                Int64 mobile = Convert.ToInt64(txtMobile.Text);
                string email = txtEmail.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string gender = cbGender.Text;
                int position;
                string cv = txtPosition.Text;
                if (txtPosition.Text == "Quản Lý")
                    position = 1;
                else
                    position = 2;
                query = "insert into employee (ename, mobile, gender, emailid, username, pass, position, chucVu) values ('" + name + "'," + mobile + ",'" + gender + "','" + email + "','" + username + "','" + password + "','" + position + "','" + cv + "')";
                fn.setData(query, "Thêm Nhân Viên Thành Công!");
                this.Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

