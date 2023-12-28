using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
namespace Hotel.SmallForm
{
    public partial class receipt : Form
    {
        string query;
        function fn;
        private Bitmap memoryImage;
        private Size s;
        public receipt(string ten, string mahd, string ngayxuat, double tien)
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(430, 590);
            label6.Text = mahd;
            label2.Text = ngayxuat;
            label1.Text = ten;
            label3.Text = tien.ToString();
            label4.Text = (tien * 0.10).ToString();
            label5.Text = (tien *1.1).ToString();
            query = "select TENDV as MOTA, cast(GIADV as decimal) as 'DONGIA', CAST((dbo.TONGTIENDICHVU(MAHD, DICHVU.MADV) / GIADV) AS DECIMAL) AS SOLUONG, cast(dbo.TONGTIENDICHVU(MAHD, DICHVU.MADV) as decimal) as 'THANHTIEN'\r\nfrom DICHVU, CTDV\r\nwhere DICHVU.MADV = CTDV.MADV\r\nand MAHD = 'HD00001'\r\nUNION\r\nSELECT (N'Phòng ' + PHONG.MAPHG) as MOTA, CAST(GIADEM AS DECIMAL), '1' as SOLUONG, CAST(TIENDATPHG AS DECIMAL) as THANHTIEN\r\nFROM PHONG, LOAIPHONG, CTPHG\r\nWHERE PHONG.MALOAIPHG = LOAIPHONG.MALOAIPHG AND CTPHG.MAPHG = PHONG.MAPHG\r\nAND MAHD = 'HD00001'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            PaperSize customPaperSize = new PaperSize("CustomSize", 1500, 1000); // Đặt kích thước tùy chỉnh theo ý bạn
            printDocument1.DefaultPageSettings.PaperSize = customPaperSize;
            printDocument1.DefaultPageSettings.Landscape = true;
            try
            {
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.Refresh();
                    CaptureDataGridView(guna2DataGridView1);
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("In hóa đơn", 0, 0);
                    printDocument1.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void CaptureDataGridView(DataGridView dataGridView)
        {
            Graphics myGraphics = this.CreateGraphics();

            int resolution = 117;
            int xOffset = -233;
            int yOffset = 26;
            Size s = new Size(dataGridView.DisplayRectangle.Width + 400, dataGridView.DisplayRectangle.Height + 165);

            System.Drawing.Point locationOnForm = dataGridView.Location;
            System.Drawing.Point locationOnScreen = dataGridView.PointToScreen(locationOnForm);
            System.Drawing.Point locationOnClient = this.PointToClient(locationOnScreen);

            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            memoryImage.SetResolution(resolution, resolution);

            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(locationOnClient.X - xOffset, locationOnClient.Y - yOffset, 0, 0, s);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
