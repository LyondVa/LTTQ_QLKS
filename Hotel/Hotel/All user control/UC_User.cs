using Hotel.SmallForm;
using iText.Layout.Element;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            query = "select NHANVIEN.MANV as 'Mã Nhân Viên', NHOTEN as 'Họ Tên', TENTK as 'Username', MATKHAU as 'Password', CHUCVU as 'Chức Vụ' " +
                    "from NHANVIEN, TAIKHOAN " +
                    "where NHANVIEN.MANV = TAIKHOAN.MANV " +
                    "order by NHANVIEN.MANV ASC";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select NHANVIEN.MANV as 'Mã Nhân Viên', NHOTEN as 'Họ Tên', TENTK as 'Username', MATKHAU as 'Password', CHUCVU as 'Chức Vụ' " +
                    "from NHANVIEN, TAIKHOAN " +
                    "where NHANVIEN.MANV = TAIKHOAN.MANV and NHOTEN like N'" + tbSearch.Text.Trim() + "%' " +
                    "order by NHANVIEN.MANV asc";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            background br = new background();
            br.Show();
            ae.ShowDialog();
            setEmployee(guna2DataGridView1);
            br.Hide();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow selectedRow = guna2DataGridView1.Rows[e.RowIndex];
            string id = selectedRow.Cells[0].Value.ToString();
            query = "SELECT NHANVIEN.MANV, NHOTEN, NCCCD, NGIOITINH, NNGSINH, NSDT, NDIACHI, NEMAIL, TENTK, MATKHAU, CHUCVU, LUONG" +
                    " FROM NHANVIEN, TAIKHOAN WHERE NHANVIEN.MANV = '" + id + "' AND TAIKHOAN.MANV = '" + id + "'";
            DataSet ds = fn.getData(query);
            DataGridView dgv = new DataGridView();
            dgv = guna2DataGridView2;
            dgv.DataSource = ds.Tables[0];
            string name = dgv.Rows[0].Cells[1].Value.ToString();
            string cccd = dgv.Rows[0].Cells[2].Value.ToString();
            string gender = dgv.Rows[0].Cells[3].Value.ToString();
            string dob = dgv.Rows[0].Cells[4].Value.ToString();
            string mobile = dgv.Rows[0].Cells[5].Value.ToString();
            string address = dgv.Rows[0].Cells[6].Value.ToString();
            string email = dgv.Rows[0].Cells[7].Value.ToString();
            string username = dgv.Rows[0].Cells[8].Value.ToString();
            string password = dgv.Rows[0].Cells[9].Value.ToString();
            string position = dgv.Rows[0].Cells[10].Value.ToString();
            Int64 sal = Convert.ToInt64(dgv.Rows[0].Cells[11].Value);
            string salary = sal.ToString();
            EditUserName edun = new EditUserName(id, name, cccd, gender, dob, mobile, address, email, username, password, position, salary);
            background br = new background();
            br.Show();
            edun.ShowDialog();
            edun.Focus();
            setEmployee(guna2DataGridView1);
            br.Hide();
        }

        private void bTUpdate_Click(object sender, EventArgs e)
        {
            EditUserName edun = new EditUserName();
            background br = new background();
            br.Show();
            edun.ShowDialog();
            edun.Focus();
            setEmployee(guna2DataGridView1);
            br.Hide();
        }
    }
}
