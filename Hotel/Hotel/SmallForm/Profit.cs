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
        private Bitmap memoryImage;
        private Size s;
        public Profit()
        {
            InitializeComponent();
        }

        private void Profit_Load(object sender, EventArgs e)
        {
            timeStart.Value = new DateTime(2004, 1, 1);
            timeEnd.Value = DateTime.Now;
            timeStart.CustomFormat = "MM / yy";
            timeEnd.CustomFormat = "MM / yy";
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void setEmployee(DataGridView dgv)
        {
            query = "SELECT thang as N'Tháng', nam as N'Năm', tienPhong as N'Tiền Phòng', tienDichVu as N'Tiền Dịch Vụ', tienLuong as N'Đã Chi', tongNhap as N'Thu Vào', tienDoanhThu as N'Doanh Thu' FROM doanhthu WHERE thang >= 'Tháng " + timeStart.Value.Month + "' AND nam >= 'Năm " + timeStart.Value.Year + "' AND thang <= 'Tháng " + timeEnd.Value.Month + "' AND nam <= 'Năm " + timeEnd.Value.Year + "'";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void timeStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timeEnd_ValueChanged(object sender, EventArgs e)
        {
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            setEmployee(guna2DataGridView1);

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
