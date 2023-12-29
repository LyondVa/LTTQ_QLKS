using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Hotel.SmallForm
{
    public partial class F_Receipt : Form
    {
        function fn = new function();
        DataSet ds = new DataSet();
        string query, reservationID;
        double taxRate = 0.1;
        public F_Receipt(string reservationID)
        {
            InitializeComponent();
            this.reservationID = reservationID;
            SetBillingInfo();
            SetBillTotal();
            SetDataGridView();
            printDocument1.PrintPage += PrintDocument1_PrintPage;
        }

        private void SetDataGridView()
        {
            query = "select TENDV as MOTA, cast(GIADV as decimal) as 'DONGIA', CAST((dbo.TONGTIENDICHVU(MAHD, DICHVU.MADV) / GIADV) AS DECIMAL) AS SOLUONG, cast(dbo.TONGTIENDICHVU(MAHD, DICHVU.MADV) as decimal) as 'THANHTIEN' " +
                    "from DICHVU, CTDV " +
                    "where DICHVU.MADV = CTDV.MADV " +
                    "and MAHD = '" + reservationID + "' " +
                    "UNION " +
                    "SELECT (N'Phòng ' + PHONG.MAPHG) as MOTA, CAST(GIADEM AS DECIMAL), '1' as SOLUONG, CAST(TIENDATPHG AS DECIMAL) as THANHTIEN " +
                    "FROM PHONG, LOAIPHONG, CTPHG " +
                    "WHERE PHONG.MALOAIPHG = LOAIPHONG.MALOAIPHG AND CTPHG.MAPHG = PHONG.MAPHG " +
                    "AND MAHD = '" + reservationID + "'";
            ds = fn.getData(query);
            dgvBillingInfo.DataSource = ds.Tables[0];

            dgvBillingInfo.Columns["MOTA"].HeaderText = "Mô Tả";
            dgvBillingInfo.Columns["DONGIA"].HeaderText = "Đơn Giá (đ)";
            dgvBillingInfo.Columns["DONGIA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvBillingInfo.Columns["SOLUONG"].HeaderText = "SL";
            dgvBillingInfo.Columns["SOLUONG"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvBillingInfo.Columns["THANHTIEN"].HeaderText = "Thành Tiền (đ)";
            dgvBillingInfo.Columns["THANHTIEN"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;


        }
        private void SetBillingInfo()
        {
            query = "select KHOTEN " +
                    "from KHACHHANG, HOADON " +
                    "where KHACHHANG.MAKH = HOADON.MAKH " +
                    "and MAHD = '" + reservationID + "'";
            ds = fn.getData(query);
            lbReservationID.Text = reservationID;
            lbCustomerName.Text = ds.Tables[0].Rows[0]["KHOTEN"].ToString();
            lbReceiptDate.Text = DateTime.Now.Date.ToString();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btPrint_Click(object sender, EventArgs e)
        {
            Print();
        }
        private void SetBillTotal()
        {
            query = "select cast(TONGTIEN as decimal) as 'TONGTIEN' " +
                    "from HOADON " +
                    "where MAHD = '" + reservationID + "'";
            ds = fn.getData(query);
            lbBillTotal.Text = ds.Tables[0].Rows[0]["TONGTIEN"].ToString();
            lbTax.Text = taxRate.ToString();
            lbAfterTaxTotal.Text = (Double.Parse(lbBillTotal.Text) * taxRate).ToString();
        }
        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(pnBackground.Width, pnBackground.Height);
            pnBackground.DrawToBitmap(bmp, RestoreBounds);
            float scale = Math.Min(e.MarginBounds.Width / bmp.Width, e.MarginBounds.Height / bmp.Height);
            Rectangle imageBounds = new Rectangle(
                (int)(e.MarginBounds.Width / 2 - bmp.Width * scale / 2),
                (int)(e.MarginBounds.Height / 2 - bmp.Height * scale / 2),
                (int)(bmp.Width * scale),
                (int)(bmp.Height * scale));
            e.Graphics.DrawImage(bmp, imageBounds);
        }

        private void Print()
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            printDocument1.Dispose();
            printDialog1.Dispose();
        }
    }
}
