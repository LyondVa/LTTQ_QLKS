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
    public partial class UC_CustomerDetail : UserControl
    {
        function fn = new function();
        string query;
        public UC_CustomerDetail()
        {
            InitializeComponent();
            setCDetail(guna2DataGridView1);
            EventHub.DatabaseUpdated += RefreshWithSearch;
        }
        private void RefreshWithSearch()
        {
            if (txtSearch.SelectedIndex == 0)
            {
                query = "select KHACHHANG.MAKH as 'Mã Khách Hàng', KHACHHANG.KHOTEN as 'Họ Tên',  PHONG.MAPHG as 'Mã Phòng', HOADON.NGNHANPHG as 'Ngày Nhận Phòng', cast(CTPHG.TIENDATPHG as decimal) as 'Tiền Đặt Phòng' " +
                    "from KHACHHANG " +
                    "left join HOADON on KHACHHANG.MAKH = HOADON.MAKH " +
                    "left join CTPHG on HOADON.MAHD = CTPHG.MAHD " +
                    "left join PHONG on CTPHG.MAPHG = PHONG.MAPHG " +
                    "order by KHACHHANG.MAKH ASC";
                getRecord(query);
            }
            else if (txtSearch.SelectedIndex == 1)
            {
                query = "select KHACHHANG.MAKH as 'Mã Khách Hàng', KHACHHANG.KHOTEN as 'Họ Tên',  PHONG.MAPHG as 'Mã Phòng', HOADON.NGNHANPHG as 'Ngày Nhận Phòng', cast(CTPHG.TIENDATPHG as decimal) as 'Tiền Đặt Phòng' " +
                    "from KHACHHANG " +
                    "inner join HOADON on KHACHHANG.MAKH = HOADON.MAKH " +
                    "inner join CTPHG on HOADON.MAHD = CTPHG.MAHD " +
                    "inner join PHONG on CTPHG.MAPHG = PHONG.MAPHG " +
                    "where KHACHHANG.STAYING = 1 " +
                    "order by KHACHHANG.MAKH ASC";
                getRecord(query);
            }
            else if (txtSearch.SelectedIndex == 2)
            {
                query = "select KHACHHANG.MAKH as 'Mã Khách Hàng', KHACHHANG.KHOTEN as 'Họ Tên',  PHONG.MAPHG as 'Mã Phòng', HOADON.NGNHANPHG as 'Ngày Nhận Phòng', cast(CTPHG.TIENDATPHG as decimal) as 'Tiền Đặt Phòng' " +
                    "from KHACHHANG " +
                    "inner join HOADON on KHACHHANG.MAKH = HOADON.MAKH " +
                    "inner join CTPHG on HOADON.MAHD = CTPHG.MAHD " +
                    "inner join PHONG on CTPHG.MAPHG = PHONG.MAPHG " +
                    "where KHACHHANG.STAYING = 0" +
                    "order by KHACHHANG.MAKH ASC";
                getRecord(query);
            }
        }
        private void txtSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshWithSearch();
        }
        private void getRecord(string query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void setCDetail(DataGridView dgv)
        {
            txtSearch.SelectedIndex = 0;
            query = query = "select KHACHHANG.MAKH as 'Mã Khách Hàng', KHACHHANG.KHOTEN as 'Họ Tên',  PHONG.MAPHG as 'Mã Phòng', HOADON.NGNHANPHG as 'Ngày Nhận Phòng', cast(CTPHG.TIENDATPHG as decimal) as 'Tiền Đặt Phòng' " +
                    "from KHACHHANG " +
                    "left join HOADON on KHACHHANG.MAKH = HOADON.MAKH " +
                    "left join CTPHG on HOADON.MAHD = CTPHG.MAHD " +
                    "left join PHONG on CTPHG.MAPHG = PHONG.MAPHG " +
                    "order by KHACHHANG.MAKH ASC";
            getRecord(query);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn.ToExcel(guna2DataGridView1, saveFileDialog1.FileName);
            }
        }

        private void tbNameSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.SelectedIndex == 0)
            {
                query = "select KHACHHANG.MAKH as 'Mã Khách Hàng', KHACHHANG.KHOTEN as 'Họ Tên',  PHONG.MAPHG as 'Mã Phòng', HOADON.NGNHANPHG as 'Ngày Nhận Phòng', cast(CTPHG.TIENDATPHG as decimal) as 'Tiền Đặt Phòng' " +
                    "from KHACHHANG " +
                    "left join HOADON on KHACHHANG.MAKH = HOADON.MAKH " +
                    "left join CTPHG on HOADON.MAHD = CTPHG.MAHD " +
                    "left join PHONG on CTPHG.MAPHG = PHONG.MAPHG " +
                    "where KHACHHANG.KHOTEN like N'%" + tbNameSearch.Text.Trim() + "%' " +
                    "order by KHACHHANG.MAKH ASC";
                getRecord(query);
            }
            else if (txtSearch.SelectedIndex == 1)
            {
                query = "select KHACHHANG.MAKH as 'Mã Khách Hàng', KHACHHANG.KHOTEN as 'Họ Tên',  PHONG.MAPHG as 'Mã Phòng', HOADON.NGNHANPHG as 'Ngày Nhận Phòng', cast(CTPHG.TIENDATPHG as decimal) as 'Tiền Đặt Phòng' " +
                    "from KHACHHANG " +
                    "inner join HOADON on KHACHHANG.MAKH = HOADON.MAKH " +
                    "inner join CTPHG on HOADON.MAHD = CTPHG.MAHD " +
                    "inner join PHONG on CTPHG.MAPHG = PHONG.MAPHG " +
                    "where KHACHHANG.STAYING = 1 and KHACHHANG.KHOTEN like N'%" + tbNameSearch.Text.Trim() + "%' " +
                    "order by KHACHHANG.MAKH ASC";
                getRecord(query);
            }
            else if (txtSearch.SelectedIndex == 2)
            {
                query = "select KHACHHANG.MAKH as 'Mã Khách Hàng', KHACHHANG.KHOTEN as 'Họ Tên',  PHONG.MAPHG as 'Mã Phòng', HOADON.NGNHANPHG as 'Ngày Nhận Phòng', cast(CTPHG.TIENDATPHG as decimal) as 'Tiền Đặt Phòng' " +
                    "from KHACHHANG " +
                    "inner join HOADON on KHACHHANG.MAKH = HOADON.MAKH " +
                    "inner join CTPHG on HOADON.MAHD = CTPHG.MAHD " +
                    "inner join PHONG on CTPHG.MAPHG = PHONG.MAPHG " +
                    "where KHACHHANG.STAYING = 0 and KHACHHANG.KHOTEN like N'%" + tbNameSearch.Text.Trim() + "%' " +
                    "order by KHACHHANG.MAKH ASC";
                getRecord(query);
            }
        }
    }
}
