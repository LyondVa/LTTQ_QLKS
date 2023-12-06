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
        string query;
        public UC_Employee2()
        {
            InitializeComponent();
            setEmployee(guna2DataGridView1);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void setEmployee(DataGridView dgv)
        {
            query = "SELECT eid as 'Mã Nhân Viên', ename as 'Tên Nhân Viên', gender as 'Giới Tính', mobile as 'Số Điện Thoại', emailid as'Email', chucVu as 'Chức Vụ' FROM employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT eid as 'Mã Nhân Viên', ename as 'Tên Nhân Viên', gender as 'Giới Tính', mobile as 'Số Điện Thoại', emailid as'Email', chucVu as 'Chức Vụ' from employee where ename like '" + tbSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn.ToExcel(guna2DataGridView1, saveFileDialog1.FileName);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
        private void removeSelectedRow()
        {
            

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
