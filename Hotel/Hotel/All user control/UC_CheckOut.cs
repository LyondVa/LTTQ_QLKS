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
        string clientID, reservationID;
        public UC_CheckOut()
        {
            InitializeComponent();
            txtCheckOutDate.Value = DateTime.Now;
            EventHub.DatabaseUpdated += RefreshData;
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void RefreshData()
        {
            query = "select KHACHHANG.MAKH as 'Mã Khách Hàng', KHACHHANG.KHOTEN as 'Họ Tên', KHACHHANG.KSDT as 'SDT', KHACHHANG.QUOCTICH as 'Quốc Tịch', KHACHHANG.KGIOITINH as 'Giới Tính', KHACHHANG.KNGSINH as 'Ngày Sinh', KHACHHANG.KCCCD as 'CCCD', KHACHHANG.KDIACHI as 'Địa Chỉ', HOADON.MAHD as 'Mã Hóa Đơn', HOADON.NGNHANPHG as 'Ngày Nhận Phòng', PHONG.MAPHG as 'Mã Phòng', PHONG.MALOAIPHG as 'Mã Loại Phòng', CTPHG.TIENDATPHG as 'Tiền Đặt Phòng'" +
                    "from KHACHHANG " +
                    "inner join HOADON on KHACHHANG.MAKH = HOADON.MAKH " +
                    "inner join CTPHG on HOADON.MAHD = CTPHG.MAHD " +
                    "inner join PHONG on CTPHG.MAPHG = PHONG.MAPHG " +
                    "where KHACHHANG.STAYING = 1";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        private void UC_CheckOut_Load(object sender, EventArgs e)
        {
            query = "select KHACHHANG.MAKH as 'Mã Khách Hàng', KHACHHANG.KHOTEN as 'Họ Tên', KHACHHANG.KSDT as 'SDT', KHACHHANG.QUOCTICH as 'Quốc Tịch', KHACHHANG.KGIOITINH as 'Giới Tính', KHACHHANG.KNGSINH as 'Ngày Sinh', KHACHHANG.KCCCD as 'CCCD', KHACHHANG.KDIACHI as 'Địa Chỉ', HOADON.MAHD as 'Mã Hóa Đơn', HOADON.NGNHANPHG as 'Ngày Nhận Phòng', PHONG.MAPHG as 'Mã Phòng', PHONG.MALOAIPHG as 'Mã Loại Phòng', CTPHG.TIENDATPHG as 'Tiền Đặt Phòng'" +
                    "from KHACHHANG " +
                    "inner join HOADON on KHACHHANG.MAKH = HOADON.MAKH " +
                    "inner join CTPHG on HOADON.MAHD = CTPHG.MAHD " +
                    "inner join PHONG on CTPHG.MAPHG = PHONG.MAPHG " +
                    "where KHACHHANG.STAYING = 1 and NGTRPHGTHAT != null";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select KHACHHANG.MAKH as 'Mã Khách Hàng', KHACHHANG.KHOTEN as 'Họ Tên', KHACHHANG.KSDT as 'SDT', KHACHHANG.QUOCTICH as 'Quốc Tịch', KHACHHANG.KGIOITINH as 'Giới Tính', KHACHHANG.KNGSINH as 'Ngày Sinh', KHACHHANG.KCCCD as 'CCCD', KHACHHANG.KDIACHI as 'Địa Chỉ', HOADON.MAHD as 'Mã Hóa Đơn', HOADON.NGNHANPHG as 'Ngày Nhận Phòng', PHONG.MAPHG as 'Mã Phòng', PHONG.MALOAIPHG as 'Mã Loại Phòng', CTPHG.TIENDATPHG as 'Tiền Đặt Phòng'" +
                    "from KHACHHANG " +
                    "inner join HOADON on KHACHHANG.MAKH = HOADON.MAKH " +
                    "inner join CTPHG on HOADON.MAHD = CTPHG.MAHD " +
                    "inner join PHONG on CTPHG.MAPHG = PHONG.MAPHG " +
                    "where KHOTEN like '" + txtName.Text + "%' and KHACHHANG.STAYING = 1 and NGTRPHGTHAT != null";
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
                clientID = guna2DataGridView1.Rows[e.RowIndex].Cells["Mã khách hàng"].Value.ToString();
                reservationID = guna2DataGridView1.Rows[e.RowIndex].Cells["Mã hóa đơn"].Value.ToString();
            }
        }

        private void btCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn không?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    query = "update KHACHHANG " +
                            "set KHACHHANG.STAYING = 0" +
                            "where MAKH = '" + clientID + "'; " +
                            "update HOADON " +
                            "set NGTHANHTOAN = '" + txtCheckOutDate.Value.ToString(Global.dateFormat) + "'" +
                            ", NGTRPHGTHAT= '" + txtCheckOutDate.Value.ToString(Global.dateFormat) + "'" +
                            "where MAHD = '" + reservationID + "'";
                    fn.setData(query, "Thanh Toán Thành Công");
                    query = "select KHOTEN from KHACHHANG k join HOADON h on k.MAKH = h.MAKH where k.MAKH = '"+clientID+"'";
                    string x1 = fn.getData2(query);
                    query = "select MAHD from KHACHHANG k join HOADON h on k.MAKH = h.MAKH where k.MAKH = '" + clientID + "'";
                    string x2 = fn.getData2(query);
                    query = "select NGXUATHD from KHACHHANG k join HOADON h on k.MAKH = h.MAKH where k.MAKH = '" + clientID + "'";

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtRoom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
