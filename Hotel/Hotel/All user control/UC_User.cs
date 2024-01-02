using Hotel.Properties;
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
        DataSet ds;
        public UC_User()
        {
            InitializeComponent();
            setEmployee();
            EventHub.EmployeeUpdated += setEmployee;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn.ToExcel(guna2DataGridView1, saveFileDialog1.FileName);
            }
        }
        public void setEmployee()
        {
            query = "select NHANVIEN.MANV as 'Mã Nhân Viên', NHOTEN as 'Họ Tên', TENTK as 'Username', MATKHAU as 'Password', CHUCVU as 'Chức Vụ' " +
                    "from NHANVIEN, TAIKHOAN " +
                    "where NHANVIEN.MANV = TAIKHOAN.MANV and NHANVIEN.HOATDONG = 1" +
                    "order by NHANVIEN.MANV ASC";
            ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select NHANVIEN.MANV as 'Mã Nhân Viên', NHOTEN as 'Họ Tên', TENTK as 'Username', MATKHAU as 'Password', CHUCVU as 'Chức Vụ' " +
                    "from NHANVIEN, TAIKHOAN " +
                    "where NHANVIEN.MANV = TAIKHOAN.MANV and NHOTEN like N'%" + tbSearch.Text.Trim() + "%' and NHANVIEN.HOATDONG = 1" +
                    "order by NHANVIEN.MANV asc";
            ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            background br = new background();
            br.Show();
            ae.ShowDialog();
            setEmployee();
            br.Hide();
            EventHub.OnEmployeeUpdated();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow selectedRow = guna2DataGridView1.Rows[e.RowIndex];
                string id = selectedRow.Cells[0].Value.ToString();
                query = "SELECT NHANVIEN.MANV, NHOTEN, NCCCD, NGIOITINH, NNGSINH, NSDT, NDIACHI, NEMAIL, TENTK, MATKHAU, CHUCVU, LUONG" +
                        " FROM NHANVIEN, TAIKHOAN WHERE NHANVIEN.MANV = '" + id + "' AND TAIKHOAN.MANV = '" + id + "'";
                DataSet ds = fn.getData(query);
                DataGridView dgv = new DataGridView();
                dgv = guna2DataGridView2;
                dgv.DataSource = ds.Tables[0];
                string name = dgv.Rows[0].Cells["NHOTEN"].Value.ToString();
                string cccd = dgv.Rows[0].Cells["NCCCD"].Value.ToString();
                string gender = dgv.Rows[0].Cells["NGIOITINH"].Value.ToString();
                string dob = dgv.Rows[0].Cells["NNGSINH"].Value.ToString();
                string mobile = dgv.Rows[0].Cells["NSDT"].Value.ToString();
                string address = dgv.Rows[0].Cells["NDIACHI"].Value.ToString();
                string email = dgv.Rows[0].Cells["NEMAIL"].Value.ToString();
                string username = dgv.Rows[0].Cells["TENTK"].Value.ToString();
                string password = dgv.Rows[0].Cells["MATKHAU"].Value.ToString();
                string position = dgv.Rows[0].Cells["CHUCVU"].Value.ToString();
                Int64 sal = Convert.ToInt64(dgv.Rows[0].Cells[11].Value);
                string salary = sal.ToString();
                EditUserName edun = new EditUserName(id, name, cccd, gender, dob, mobile, address, email, username, password, position, salary);
                background br = new background();
                br.Show();
                edun.ShowDialog();
                edun.Focus();
                setEmployee();
                br.Hide();
            }
        }
        private void DeactivateEmployee(object sender, DataGridViewCellEventArgs e)
        {

            DialogResult dr = MessageBox.Show("Xác nhận xóa nhân viên?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string employeeID = ds.Tables[0].Rows[e.RowIndex]["Mã Nhân Viên"].ToString();
                query = "update NHANVIEN set HOATDONG = 0 where MANV = '" + employeeID + "'; " +
                        "update TAIKHOAN set HOATDONG = 0 where MANV = '" + employeeID + "'";
                fn.setDataNoMsg(query);
                EventHub.OnEmployeeUpdated();
            }
        }
        private void bTUpdate_Click(object sender, EventArgs e)
        {
            EditUserName edun = new EditUserName();
            background br = new background();
            br.Show();
            edun.ShowDialog();
            edun.Focus();
            setEmployee();
            br.Hide();
        }
    }
}
