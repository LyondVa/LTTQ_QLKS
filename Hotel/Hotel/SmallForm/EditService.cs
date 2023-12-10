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
    public partial class EditService : Form
    {
        function fn = new function();
        string query;
        public EditService(string id, string name, string price)
        {
            InitializeComponent();
            txtID.Text = id;
            txtName.Text = name;
            txtPrice.Text = price;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtName.Text != "" && txtPrice.Text != "")
            {
                query = "UPDATE DICHVU " +
                        "SET TENDV = '" + txtName.Text + "', GIADV = " + Convert.ToInt64(txtPrice.Text) + 
                        " WHERE MADV = '" + txtID.Text + "'";
                fn.setData(query, "Sửa Thông Tin Dịch Vụ Thành Công!");
                this.Close();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "DELETE FROM DICHVU " +
                        "WHERE MADV = '" + txtID.Text + "'";
                fn.setData(query, "Thông Tin Dịch Vụ Đã Được Xóa!");
                this.Close();
            }
        }

        private void btEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
