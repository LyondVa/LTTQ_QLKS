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
        public EditUserName(string x1, string x2, string x3, string x4, string x5)
        {
            InitializeComponent();
            tbId.Text = x1;
            tbName.Text = x2;
            tbUsername.Text = x3;
            tbPass.Text = x4;
            if (x5 == "1")
            {
                cbPosition.SelectedIndex = 0;
            }
            else
            {
                cbPosition.SelectedIndex = 1;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.OK) 
            {
                query = "delete from employee where eid = " + tbId.Text + "";
                fn.setData(query, "Thông Tin Nhân Viên Đã Được Xóa!");
                this.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = "update employee set username = '" + tbUsername.Text + "', pass = '"+tbPass.Text+"', position = "+int.Parse(cbPosition.Text)+" where eid = "+int.Parse(tbId.Text);
            fn.setData(query, "Sửa Thông Tin Nhân Viên Thành Công!");
            this.Close();
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
