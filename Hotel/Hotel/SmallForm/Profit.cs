using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.SmallForm
{
    public partial class Profit : Form
    {
        string query;
        function fn = new function();
        DataSet ds = new DataSet();
        private Bitmap memoryImage;
        private Size s;
        public Profit()
        {
            InitializeComponent();
            RefreshData();
            SetDGV();
        }

        public void RefreshData()
        {
            query = "EXEC DBO.CHITIETDOANHTHUTUNGTHANG @NAM = " + Convert.ToInt16(cbYear.Text) + "";
            ds = fn.getData(query);
        }

        private void SetDGV()
        {
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView1.Columns["THANG"].HeaderText = "Tháng";
            guna2DataGridView1.Columns["PHONG"].HeaderText = "Tiền Phòng";
            guna2DataGridView1.Columns["DICHVU"].HeaderText = "Tiền Dịch Vụ";
            guna2DataGridView1.Columns["LUONG"].HeaderText = "Tiền Lương";
            guna2DataGridView1.Columns["DOANHTHU"].HeaderText = "Doanh Thu";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            pnDGV.AutoSize = true;
            guna2DataGridView1.AutoSize = true;
            guna2DataGridView1.ScrollBars = ScrollBars.None;

            Bitmap bmp = new Bitmap(pnDGV.Width, pnDGV.Height);
            pnDGV.DrawToBitmap(bmp, RestoreBounds);
            float scale = Math.Min(e.MarginBounds.Width / bmp.Width, e.MarginBounds.Height / bmp.Height);
            Rectangle imageBounds = new Rectangle((int)(e.MarginBounds.Width / 2 - bmp.Width * scale / 2),
                (int)(e.MarginBounds.Height / 2 - bmp.Height * scale / 2),
                (int)(bmp.Width * scale),
                (int)(bmp.Height * scale));
            e.Graphics.DrawImage(bmp, imageBounds);

            pnDGV.AutoSize = false;
            guna2DataGridView1.AutoSize = false;
            guna2DataGridView1.ScrollBars = ScrollBars.Vertical;
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn.ToExcel(guna2DataGridView1, saveFileDialog1.FileName);
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
