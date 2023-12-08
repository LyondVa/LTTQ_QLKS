using Microsoft.Office.Interop.Excel;
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
            if (txtName.Text != "" && txtMobile.Text != "" && txtEmail.Text != "" && cbGender.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtPosition.Text != "" && txtSalary.Text != "")
            {
                string id = txtID.Text;
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
                Int64 salary = Convert.ToInt64(txtSalary.Text);
                query = "insert into NHANVIEN (MANV, NHOTEN, NSDT, NGIOITINH, NEMAIL, POSITION, CHUCVU, LUONG) values ('" + id + "," + name + "'," + mobile + ",'" + gender + "','" + email + "','" + position + "','" + cv + "','" + salary + "')";
                fn.setData(query, "Thêm Nhân Viên Thành Công!");
                query = "insert into TAIKHOAN (MANV, TENTK, MATKHAU) values ('" + id + "','" + username + "','" + password + "')";
                fn.setData(query, "Thêm tài khoản thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

