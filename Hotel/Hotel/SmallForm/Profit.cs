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
        private Bitmap memoryImage;
        private Size s;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            s = this.ClientSize;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, -10, s);
        }
        string query;
        function fn = new function();
        public Profit()
        {

            InitializeComponent();
            printDocument1.DocumentName = "PrintScreenshot";
        }

        private void Profit_Load(object sender, EventArgs e)
        {
            timeStart.Value = new DateTime(2021, 1, 1);
            timeEnd.Value = new DateTime(2021, 4, 4);
            timeStart.CustomFormat = "MM / yy";
            timeEnd.CustomFormat = "MM / yy";
            setEmployee(guna2DataGridView1);

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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.Refresh();

                    CaptureScreen();
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("In hóa đơn", guna2DataGridView1.Width, guna2DataGridView1.Height);
                    printDocument1.Print();
                    printDialog1.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
            finally
            {
                printDialog1.Dispose();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, guna2DataGridView1.Location.X, guna2DataGridView1.Location.Y);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}