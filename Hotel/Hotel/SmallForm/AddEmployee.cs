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
            txtBirth.Value = DateTime.Now;
            this.Size = new System.Drawing.Size(950, 604);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if ( txtName.Text != "" && txtCCCD.Text != "" && cbGender.Text != "" && txtBirth.Text != "" && txtMobile.Text != "" && txtAddress.Text != "" && txtEmail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtPosition.Text != "" && txtSalary.Text != "")
            {
                string name = txtName.Text;
                string cccd = txtCCCD.Text;
                string gender = cbGender.Text;
                string dob = txtBirth.Value.ToString(Global.dateFormat);
                string mobile = txtMobile.Text;
                string address = txtAddress.Text;
                string email = txtEmail.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string position = txtPosition.Text;
                Int64 salary = Convert.ToInt64(txtSalary.Text);
                query = "insert into NHANVIEN ( NHOTEN, NCCCD, NGIOITINH, NNGSINH, NSDT, NDIACHI, NEMAIL, CHUCVU, LUONG) values "
                      + "(N'" + name + "','" + cccd + "',N'" + gender + "','" + dob + "','" + mobile + "',N'" + address + "',N'" + email + "',N'" + position + "'," + salary + ")";
                fn.setData(query, "Thêm Nhân Viên Thành Công!");
                query = "declare @id nvarchar(10); select @id = MANV from NHANVIEN where NCCCD = '"+cccd+"'; insert into TAIKHOAN (MANV, TENTK, MATKHAU) values (@id,'" + username + "','" + password + "')";
                fn.setData(query, "Thêm Tài Khoản Thành Công!");
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

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

