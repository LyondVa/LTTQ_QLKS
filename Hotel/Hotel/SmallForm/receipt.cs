using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public receipt()
        {
            InitializeComponent();
        }
        public void ExportToPdf(string outputPath)
        {
            using (PdfWriter writer = new PdfWriter(outputPath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);

                    // Thêm nội dung của Form1 vào tài liệu PDF
                    // Thêm các thành phần khác của Form1 nếu cần
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PDF Files|*.pdf";
            saveFileDialog1.Title = "Save PDF File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    using (PdfWriter writer = new PdfWriter(saveFileDialog1.FileName))
                    {
                        using (PdfDocument pdf = new PdfDocument(writer))
                        {
                            Document document = new Document(pdf);

                            // Tạo một trang PDF và vẽ Panel1 lên trang đó
                            Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height);
                            panel1.DrawToBitmap(bitmap, new Rectangle(0, 0, panel1.Width, panel1.Height));
                            iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(ImageToByteArray(bitmap)));
                            document.Add(image);

                            // Vẽ PictureBox và Label lên trang PDF
                            foreach (Control control in panel1.Controls)
                            {
                                if (control is PictureBox)
                                {
                                    // Debug statement
                                    Console.WriteLine("PictureBox found.");

                                    Bitmap picBoxBitmap = new Bitmap(control.Width, control.Height);
                                    control.DrawToBitmap(picBoxBitmap, new Rectangle(0, 0, control.Width, control.Height));
                                    byte[] picBoxBytes = ImageToByteArray(picBoxBitmap);

                                    // Debug statement
                                    Console.WriteLine($"PictureBox content size: {picBoxBytes.Length} bytes");

                                    iText.Layout.Element.Image picBoxImage = new iText.Layout.Element.Image(ImageDataFactory.Create(picBoxBytes));
                                    document.Add(picBoxImage);
                                }
                                else if (control is Label)
                                {
                                    // Debug statement
                                    Console.WriteLine("Label found.");

                                    Label label = control as Label;
                                    document.Add(new Paragraph(label.Text));
                                }
                            }
                        }
                    }

                    MessageBox.Show("PDF file saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private byte[] ImageToByteArray(Bitmap bitmap)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
