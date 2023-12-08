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
        }

        private void txtSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtSearch.SelectedIndex == 0)
            {
                query = "select KHACHHANG.MAKH, KHACHHANG.KHOTEN, KHACHHANG.KSDT, KHACHHANG.QUOCTICH, KHACHHANG.KGIOTINH, KHACHHANG.KNGSINH, KHACHHANG.KCCCD, KHACHHANG.KDIACHI, KHACHHANG.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from KHACHHANG inner join rooms on KHACHHANG.roomid = rooms.roomid ";
                getRecord(query);
            }
            else if(txtSearch.SelectedIndex == 1)
            {
                query = "select KHACHHANG.MAKH, KHACHHANG.KHOTEN, KHACHHANG.KSDT, KHACHHANG.QUOCTICH, KHACHHANG.KGIOTINH, KHACHHANG.KNGSINH, KHACHHANG.KCCCD, KHACHHANG.KDIACHI, KHACHHANG.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from KHACHHANG inner join rooms on KHACHHANG.roomid = rooms.roomid where checkout is null";
                getRecord(query);
            }
            else if( txtSearch.SelectedIndex == 2)
            {
                query = "select KHACHHANG.MAKH, KHACHHANG.KHOTEN, KHACHHANG.KSDT, KHACHHANG.QUOCTICH, KHACHHANG.KGIOTINH, KHACHHANG.KNGSINH, KHACHHANG.KCCCD, KHACHHANG.KDIACHI, KHACHHANG.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from KHACHHANG inner join rooms on KHACHHANG.roomid = rooms.roomid where checkout is not null";
                getRecord(query);
            }
            /*query = "select KHACHHANG.MAKH, KHACHHANG.KHOTEN, KHACHHANG.KSDT, KHACHHANG.QUOCTICH, KHACHHANG.KGIOTINH, KHACHHANG.KNGSINH, KHACHHANG.KCCCD, KHACHHANG.KDIACHI, CTPHG.NGNHANPHG, PHONG.MAPHG, PHONG.MALOAIPHG, CTPHG.TIENDATPHONG " +
                    "from KHACHHANG " +
                    "inner join HOADON on KHACHHANG.MAKH = HOADON.MAKH " +
                    "inner join CTPHG on HOADON.MAHD = CTPHG.MAHD" +
                    "inner join PHONG on CTPHG.MAPHG = PHONG.MAPHG" +
                    "where CHECKEDOUT = 0";*/

        }
        private void getRecord (string query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn.ToExcel(guna2DataGridView1, saveFileDialog1.FileName);
            }
        }
    }
}
