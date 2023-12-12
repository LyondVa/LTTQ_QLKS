using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
