using Hotel.SmallForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.All_user_control
{
    public partial class UC_CheckOut : UserControl
    {
        function fn = new function();
        string query;

        public UC_CheckOut()
        {
            InitializeComponent();
            txtCheckOutDate.Value = DateTime.Now;
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UC_CheckOut_Load(object sender, EventArgs e)
        {
            query = "select KHACHHANG.MAKH, KHACHHANG.KHOTEN, KHACHHANG.KSDT, KHACHHANG.QUOCTICH, KHACHHANG.KGIOITINH, KHACHHANG.KNGSINH, KHACHHANG.KCCCD, KHACHHANG.KDIACHI, CTPHG.NGNHANPHG, PHONG.MAPHG, PHONG.MALOAIPHG, CTPHG.TIENDATPHG " +
                    "from KHACHHANG " +
                    "inner join HOADON on KHACHHANG.MAKH = HOADON.MAKH " +
                    "inner join CTPHG on HOADON.MAHD = CTPHG.MAHD " +
                    "inner join PHONG on CTPHG.MAPHG = PHONG.MAPHG " +
                    "where KHACHHANG.STAYING = 1";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select KHACHHANG.MAKH, KHACHHANG.KHOTEN, KHACHHANG.KSDT, KHACHHANG.QUOCTICH, KHACHHANG.KGIOITINH, KHACHHANG.KNGSINH, KHACHHANG.KCCCD, KHACHHANG.KDIACHI, CTPHG.NGNHANPHG, PHONG.MAPHG, PHONG.MALOAIPHG, CTPHG.TIENDATPHG " +
                    "from KHACHHANG " +
                    "inner join HOADON on KHACHHANG.MAKH = HOADON.MAKH " +
                    "inner join CTPHG on HOADON.MAHD = CTPHG.MAHD " +
                    "inner join PHONG on CTPHG.MAPHG = PHONG.MAPHG " +
                    "where KHOTEN like '" + txtName.Text + "%' and KHACHHANG.STAYING = 1";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }
        string id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                id = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn không?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txtCheckOutDate.Text;
                    query = "update KHACHHANG " +
                            "set KHACHHANG.STAYING = 0" +
                            "where KHOTEN = '" + txtCName.Text + "'; " +
                            "update HOADON " +
                            "set NGTHANHTOAN = '" + cdate + "'" +
                            "where MAHD = ( " +
                                            "select top 1 MAHD " +
                                            "from HOADON, KHACHHANG " +
                                            "where HOADON.MAKH = KHACHHANG.MAKH " +
                                            "and HOADON.MAKH = '" + txtCName.Text + "'"+
                                            "order by HOADON.MAHD desc"+
                                            ")";
                    fn.setData(query, "Thanh Toán Thành Công");
                    receipt rc = new receipt();
                    rc.Show();
                    UC_CheckOut_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Không có khách hàng để lựa chọn", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txtCName.Clear();
            txtRoom.Clear();
            txtName.Clear();
            txtCheckOutDate.ResetText();
        }

        private void UC_CheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                fn.ToExcel(guna2DataGridView1, saveFileDialog1.FileName);
            }
        }

    }
}
