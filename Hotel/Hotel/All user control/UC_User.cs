using Hotel.SmallForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel.All_user_control
{
    public partial class UC_User : UserControl
    {
        function fn = new function();
        string query;
        public UC_User()
        {
            InitializeComponent();
            setEmployee(guna2DataGridView1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn.ToExcel(guna2DataGridView1, saveFileDialog1.FileName);
            }
        }
        public void setEmployee(DataGridView dgv)
        {
            query = "select NHANVIEN.MANV as 'Mã Nhân Viên', NHOTEN as 'Tên Nhân Viên', TENTK as 'Username', MATKHAU as 'Password', CHUCVU as 'Chức Vụ' " +
                    "from NHANVIEN, TAIKHOAN" +
                    "where NHANVIEN.MANV = TAIKHOAN.MANV";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = guna2DataGridView1.Rows[e.RowIndex];

            // Lấy dữ liệu từ hàng được chọn (ví dụ: cột đầu tiên)
            string x1 = selectedRow.Cells[0].Value.ToString();
            string x2 = selectedRow.Cells[1].Value.ToString();
            string x3 = selectedRow.Cells[2].Value.ToString();
            string x4 = selectedRow.Cells[3].Value.ToString();
            string x5 = selectedRow.Cells[4].Value.ToString();
           
            EditUserName edun = new EditUserName(x1,x2,x3,x4,x5);

            edun.ShowDialog();
            edun.Focus();
            setEmployee(guna2DataGridView1);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select NHANVIEN.MANV as 'Mã Nhân Viên', NHOTEN as 'Tên Nhân Viên', TENTK as 'Username', MATKHAU as 'Password', CHUCVU as 'Chức Vụ' " +
                    "from NHANVIEN, TAIKHOAN" +
                    "where NHANVIEN.MANV = TAIKHOAN.MANV" + 
                    "and '" + tbSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_User_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            ae.ShowDialog();
            setEmployee(guna2DataGridView1);
        }
    }
}
