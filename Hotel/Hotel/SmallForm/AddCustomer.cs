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
    public partial class AddCustomer : Form
    {
        function fn = new function();
        string query;
        public AddCustomer()
        {
            InitializeComponent();
            txtBirth.Value = DateTime.Now;
        }

        private void btEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbID.Text != "" && tbName.Text != "" && tbNationality.Text != "" && tbCCCD.Text != "" && txtBirth.Text != "" && cbGender.Text != "" && tbPhone.Text != "" && tbAddress.Text != "" && tbEmail.Text != "")
            {
                string id = tbID.Text;
                string name = tbName.Text;
                string nationality = tbNationality.Text;
                string cccd = tbCCCD.Text;
                string dob = txtBirth.Text;
                string gender = cbGender.Text;
                string phone = tbPhone.Text;
                string address = tbAddress.Text;
                string email = tbEmail.Text;
                query = "INSERT INTO KHACHHANG (MAKH, KHOTEN, QUOCTICH, KCCCD, KNGSINH, KGIOITINH, KSDT, KDIACHI, KEMAIL) VALUES " +
                        "('" + id + "', N'" + name + "', N'" + nationality + "', '" + cccd + "', '" + dob + "', N'" + gender + "', '" + phone + "', N'" + address + "', N'" + email + "')";
                fn.setData(query, "Thêm Khách Hàng Thành Công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }
    }
}
