using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.SmallForm
{
    public partial class EmployeeInformation : Form
    {
        public EmployeeInformation(string x1, string x2, string x3, string x4, string x5, string x6, string x7)
        {
            InitializeComponent();
            CustomizeForm();
            name = x1;
            phoneNumber = x2;
            gender = x3;
            email = x4;
            username = x5;
            password = x6;
            position = x7;
        }
        string name, phoneNumber, gender, email,username,password, position;

        private void EmployeeInformation_Load(object sender, EventArgs e)
        {
            guna2TextBox1.Text = name;
            guna2TextBox2.Text = phoneNumber;
            guna2TextBox3.Text = gender;
            guna2TextBox4.Text = email;
            guna2TextBox5.Text = username;
            guna2TextBox6.Text = password;
            guna2TextBox7.Text = position;
        }
        private void CustomizeForm()
        {
            // Đặt FormBorderStyle thành None
            FormBorderStyle = FormBorderStyle.None;

            // Kích thước của các góc bo tròn
            int cornerRadius = 20;

            // Tạo hình chữ nhật với các góc bo tròn
            GraphicsPath path = GetRoundedRectangle(new Rectangle(0, 0, Width, Height), cornerRadius);

            // Đặt region cho form
            Region = new Region(path);
        }

        // Hàm tạo hình chữ nhật với các góc bo tròn
        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rect.Location, size);

            // Góc trên bên trái
            path.AddArc(arc, 180, 90);

            // Góc trên bên phải
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Góc dưới bên phải
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Góc dưới bên trái
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            // Đường đi đến góc trên bên trái để đóng hình chữ nhật
            path.CloseFigure();

            return path;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
