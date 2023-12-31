using Hotel.SmallForm;
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

namespace Hotel.All_user_control
{
    public partial class UC_Employee2 : UserControl
    {
        function fn = new function();
        string manv;
        string query;
        DataSet ds;
        public UC_Employee2()
        {
            InitializeComponent();
            setEmployee();
            manv = Global.globalEmID;
            EventHub.EmployeeUpdated += setEmployee;

        }
        string pass;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow selectedRow = guna2DataGridView1.Rows[e.RowIndex];
                string id = selectedRow.Cells[0].Value.ToString();
                if (id == manv)
                {
                    query = "SELECT MATKHAU" +
                            " FROM TAIKHOAN WHERE MANV = '" + id + "'";
                    pass = fn.getData2(query);
                    ChangePassword cp = new ChangePassword(pass,manv);
                    background br = new background();
                    br.Show();
                    cp.ShowDialog();
                    br.Hide();
                }
            }
        }
        public void setEmployee()
        {
            query = "SELECT MANV as 'Mã Nhân Viên', NHOTEN as 'Họ Tên', NCCCD as 'CCCD', NGIOITINH as 'Giới Tính', CONVERT(DATE, NNGSINH) as 'Ngày Sinh', NSDT as 'SDT', NDIACHI as 'Địa Chỉ', NEMAIL as'Email', CHUCVU as 'Chức Vụ', cast(LUONG as decimal) as 'Lương' " +
                    "FROM NHANVIEN " +
                    "WHERE HOATDONG = 1" +
                    "ORDER BY MANV ASC";
            ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT MANV as 'Mã Nhân Viên', NHOTEN as 'Họ Tên', NCCCD as 'CCCD', NGIOITINH as 'Giới Tính', CONVERT(DATE, NNGSINH) as 'Ngày Sinh', NSDT as 'SDT', NDIACHI as 'Địa Chỉ', NEMAIL as'Email', CHUCVU as 'Chức Vụ', cast(LUONG as decimal) as 'Lương' " +
                    "from NHANVIEN " +
                    "where NHOTEN like N'" + tbSearch.Text + "%' and HOATDONG = 1" +
                    "ORDER BY MANV ASC";
            ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn.ToExcel(guna2DataGridView1, saveFileDialog1.FileName);
            }
        }
        private void UC_Employee2_Load(object sender, EventArgs e)
        {
            setEmployee();
        }
    }
}
