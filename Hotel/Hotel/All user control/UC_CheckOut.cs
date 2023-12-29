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
        string clientID, reservationID, id;
        public UC_CheckOut()
        {
            InitializeComponent();
            txtCheckOutDate.Value = DateTime.Now;
            EventHub.DatabaseUpdated += RefreshData;
            EventHub.ServicesUpdated += RefreshData;
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void RefreshData()
        {
            query = "select HOADON.MAHD as 'Mã Hóa Đơn', KHACHHANG.MAKH as 'Mã Khách Hàng', KHACHHANG.KHOTEN as 'Họ Tên', HOADON.NGNHANPHG as 'Ngày Nhận Phòng', HOADON.NGTRPHG as 'Ngày trả phòng', cast(HOADON.TONGTIEN as decimal) as 'Tổng tiền' " +
                    "from KHACHHANG " +
                    "inner join HOADON on KHACHHANG.MAKH = HOADON.MAKH " +
                    "where KHACHHANG.STAYING = 1 and NGTRPHGTHAT is null";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        private void UC_CheckOut_Load(object sender, EventArgs e)
        {
            query = "select HOADON.MAHD as 'Mã Hóa Đơn', KHACHHANG.MAKH as 'Mã Khách Hàng', KHACHHANG.KHOTEN as 'Họ Tên', HOADON.NGNHANPHG as 'Ngày Nhận Phòng', HOADON.NGTRPHG as 'Ngày trả phòng', cast(HOADON.TONGTIEN as decimal) as 'Tổng tiền' " +
                    "from KHACHHANG " +
                    "inner join HOADON on KHACHHANG.MAKH = HOADON.MAKH " +
                    "where KHACHHANG.STAYING = 1 and NGTRPHGTHAT is null";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select HOADON.MAHD as 'Mã Hóa Đơn', KHACHHANG.MAKH as 'Mã Khách Hàng', KHACHHANG.KHOTEN as 'Họ Tên', HOADON.NGNHANPHG as 'Ngày Nhận Phòng', HOADON.NGTRPHG as 'Ngày trả phòng', cast(HOADON.TONGTIEN as decimal) as 'Tổng tiền' " +
                    "from KHACHHANG " +
                    "inner join HOADON on KHACHHANG.MAKH = HOADON.MAKH " +
                    "where KHOTEN like N'" + txtName.Text + "%' and KHACHHANG.STAYING = 1 and NGTRPHGTHAT is null";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

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
                            "set NGTHANHTOAN = '" + txtCheckOutDate.Value.ToString(Global.dateFormat) + "', " +
                            "NGTRPHGTHAT= '" + txtCheckOutDate.Value.ToString(Global.dateFormat) + "', " +
                            "NGXUATHD = '" + txtCheckOutDate.Value.ToString(Global.dateFormat) + "' " +
                            "where MAHD = '" + reservationID + "'" +
                            "update PHONG " +
                            "set DONDEP = N'Chưa dọn' " +
                            "from PHONG, CTPHG " +
                            "where PHONG.MAPHG = CTPHG.MAPHG " +
                            "and MAHD = '" + reservationID + "'";
                    fn.setData(query, "Thanh Toán Thành Công");
                    //query = "select KHOTEN from KHACHHANG k join HOADON h on k.MAKH = h.MAKH where k.MAKH = '"+clientID+"'";
                    //string x1 = fn.getData2(query);
                    //query = "select NGXUATHD from KHACHHANG k join HOADON h on k.MAKH = h.MAKH where k.MAKH = '" + clientID + "'";
                    //string x3 = fn.getData2(query); 
                    //query = query = "select TONGTIEN from HOADON where MAHD = '" + reservationID + "'";
                    //string x4 = fn.getData2(query);

                    //receipt rc = new receipt(x1,reservationID,x3,double.Parse(x4));

                    F_Receipt rc = new F_Receipt(reservationID);

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
            txtReservationID.Clear();
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
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                id = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Họ tên"].Value.ToString();
                txtReservationID.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Mã hóa đơn"].Value.ToString();
                clientID = guna2DataGridView1.Rows[e.RowIndex].Cells["Mã khách hàng"].Value.ToString();
                reservationID = guna2DataGridView1.Rows[e.RowIndex].Cells["Mã hóa đơn"].Value.ToString();
            }
        }
    }
}
