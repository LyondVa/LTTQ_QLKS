using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.SmallForm
{
    public partial class EditCustomer : Form
    {
        function fn = new function();
        string query;
        public EditCustomer(string id, string name, string nationality, string cccd, string gender, string dob, string phone, string address, string email)
        {
            InitializeComponent();
            tbID.Text = id;
            tbName.Text = name;
            tbNationality.Text = nationality;
            tbCCCD.Text = cccd;
            cbGender.Text = gender;
            txtBirth.Text = dob;
            tbPhone.Text = phone;
            tbAddress.Text = address;
            tbEmail.Text = email;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (tbID.Text != "" && tbName.Text != "" && tbNationality.Text != "" && tbCCCD.Text != "" && txtBirth.Text != "" && cbGender.Text != "" && tbPhone.Text != "" && tbAddress.Text != "" && tbEmail.Text != "")
            {
                query = "UPDATE KHACHHANG " +
                        "SET KHOTEN = N'" + tbName.Text + "', QUOCTICH = N'" + tbNationality.Text +
                        "', KCCCD = '" + tbCCCD.Text + "', KNGSINH = '" + txtBirth.Text + "', KGIOITINH = N'" + cbGender.Text +
                        "', KSDT = '" + tbPhone.Text + "', KDIACHI = N'" + tbAddress.Text + "', KEMAIL = N'" + tbEmail.Text + "' " +
                        "WHERE MAKH = '" + tbID.Text + "'";
                fn.setData(query, "Sửa Thông Tin Khách Hàng Thành Công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "DELETE FROM KHACHHANG " +
                        "WHERE MAKH = '" + tbID.Text + "'";
                fn.setData(query, "Thông Tin Khách Hàng Đã Được Xóa!");
                this.Close();
            }
        }

        private void btEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
