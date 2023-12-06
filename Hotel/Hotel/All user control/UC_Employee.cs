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

namespace Hotel.All_user_control
{
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        string query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text!="" && txtMobile.Text!="" && txtEmail.Text!=""&& cbGender.Text != "" && txtUsername.Text !="" && txtPassword.Text !="" && txtPosition.Text !="")
            {
                string name = txtName.Text;
                Int64 mobile = Convert.ToInt64(txtMobile.Text);
                string email = txtEmail.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string gender = cbGender.Text;
                int position;
                if (txtPosition.Text == "Quản Lý")
                    position = 1;
                else
                    position = 2;
                query = "insert into employee (ename, mobile, gender, emailid, username, pass, position) values ('" + name + "'," + mobile + ",'" + gender + "','" + email + "','" + username + "','" + password + "','"+position + "')";
                fn.setData(query, "Đăng Ký Nhân Viên Thành Công!!");
                clearAll();
                getMaxID();
            }
        }
        public void clearAll()
        {
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtMobile.Clear();
            txtName.Clear();
            cbGender.SelectedIndex = -1;
        }
        private void UC_Employee_Load(object sender, EventArgs e)
        {
            
        }
        public void getMaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                lbToSet.Text = (num+1).ToString();
            }
        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabEmployee.SelectedIndex == 1)
            {
                setEmployee(guna2DataGridView1);
            }
            else if (tabEmployee.SelectedIndex == 2)
            {
                setEmployee(guna2DataGridView2);
            }
        }
        public void setEmployee(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    query = "delete from employee where eid = " + txtID.Text + "";
                    fn.setData(query, "Thông Tin Nhân Viên Đã Được Xóa!");
                    tabEmployee_SelectedIndexChanged(this, null);
                }
            }
        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một ô hay một hàng
            if (e.RowIndex > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.Rows[e.RowIndex];

                // Lấy dữ liệu từ hàng được chọn (ví dụ: cột đầu tiên)
                string x1 = selectedRow.Cells[1].Value.ToString();
                string x2 = selectedRow.Cells[2].Value.ToString();
                string x3 = selectedRow.Cells[3].Value.ToString();
                string x4 = selectedRow.Cells[4].Value.ToString();
                string x5 = selectedRow.Cells[5].Value.ToString();
                string x6 = selectedRow.Cells[6].Value.ToString();
                string x7 = selectedRow.Cells[7].Value.ToString();

                // Hiển thị form mới và chuyển dữ liệu nếu cần
                EmployeeInformation form = new EmployeeInformation(x1, x2, x3, x4, x5, x6, x7);
                
                form.Show();

            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn.ToExcel(guna2DataGridView1, saveFileDialog1.FileName);
            }
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
