﻿using System;
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
        Bitmap memoryImage;
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

        }

        private void CaptureDataGridView(DataGridView dataGridView)
        {
            Graphics myGraphics = this.CreateGraphics();

            // Đặt độ phân giải thấp (ví dụ: 300 pixels/inch)
            int resolution = 50;

            // Chú ý rằng bạn có thể cần điều chỉnh giá trị 20 và 50 này tùy thuộc vào vị trí cụ thể của DataGridView trên Form
            int xOffset = 0;
            int yOffset = 0;

            // Sử dụng kích thước của phần hiển thị thực sự của DataGridView
            Size s = new Size(dataGridView.DisplayRectangle.Width , dataGridView.DisplayRectangle.Height );

            System.Drawing.Point locationOnForm = dataGridView.Location;
            System.Drawing.Point locationOnScreen = dataGridView.PointToScreen(locationOnForm);
            System.Drawing.Point locationOnClient = this.PointToClient(locationOnScreen);

            // Đặt kích thước và độ phân giải của hình chụp
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            memoryImage.SetResolution(resolution, resolution);

            Graphics memoryGraphics = Graphics.FromImage(memoryImage);

            // Chú ý rằng bạn sử dụng Location của DataGridView trên Form
            memoryGraphics.CopyFromScreen(300 , 0, 0, 0, s);
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
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


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
