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
    public partial class AddService : Form
    {
        function fn = new function();
        string query;
        public AddService()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtName.Text != "" && txtPrice.Text != "")
            {
                string id = txtID.Text;
                string name = txtName.Text;
                Int64 price = Convert.ToInt64(txtPrice.Text);
                query = "INSERT INTO DICHVU (MADV, TENDV, GIADV) VALUES ('" + id + "', '" + name + "', " + price + ")";
                fn.setData(query, "Thêm Dịch Vụ Thành Công!");
                this.Close();
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void btEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
