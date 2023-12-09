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
    public partial class EditUserName : Form
    {
        function fn = new function();
        string query;
        public EditUserName(string id, string name, string cccd, string gender, string dob, string mobile, string address, string email, string username, string password, string position, string salary)
        {
            InitializeComponent();
            tbId.Text = id;
            tbName.Text = name;
            tbCCCD.Text = cccd;
            cbGender.Text = gender;
            tpBirth.Text = dob;
            tbMobile.Text = mobile;
            tbAddress.Text = address;
            tbEmail.Text = email;
            tbUsername.Text = username;
            tbPassword.Text = password;
            cbPosition.Text = position;
            tbSalary.Text = salary;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
            {
                query = "DELETE FROM TAIKHOAN " +
                        "WHERE MANV = '" + tbId.Text + "'\n" +
                        "Delete from NHANVIEN " +
                        "where MANV = '" + tbId.Text + "'";
                fn.setData(query, "Thông Tin Nhân Viên Đã Được Xóa!");
                this.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (tbId.Text != "" && tbName.Text != "" && tbCCCD.Text != "" && cbGender.Text != "" && tpBirth.Text != "" && tbMobile.Text != "" && tbAddress.Text != "" && tbEmail.Text != "" && tbUsername.Text != "" && tbPassword.Text != "" && cbPosition.Text != "" && tbSalary.Text != "")
            {
                query = "UPDATE NHANVIEN " +
                        "SET NHOTEN = '" + tbName.Text + "', NCCCD = '" + tbCCCD.Text + "', NGIOITINH = '" + cbGender.Text +
                        "', NNGSINH = '" + tpBirth.Text + "', NSDT = '" + tbMobile.Text + "', NDIACHI = '" + tbAddress.Text +
                        "', NEMAIL = '" + tbEmail.Text + "', CHUCVU = '" + cbPosition.Text + "', LUONG = " + Convert.ToInt64(tbSalary.Text) +
                        " WHERE MANV = '" + tbId.Text + "'\n" +
                        "UPDATE TAIKHOAN " +
                        "SET TENTK = '" + tbUsername.Text + "', MATKHAU = '" + tbPassword.Text +
                        "' WHERE MANV = '" + tbId.Text + "'";
                fn.setData(query, "Sửa Thông Tin Nhân Viên Thành Công!");
                this.Close();
            }
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
