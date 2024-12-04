using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Hotel.SmallForm
{
    public partial class EditUserName : Form
    {
        internal function fn = new function();
        string query;
        bool cccdError = false, sdtError = false;
        DataSet ds = new DataSet();
        public EditUserName()
        {
            InitializeComponent();
        }
        public EditUserName(string id, string name, string cccd, string gender, string dob, string mobile, string address, string email, string username, string password, string position, string salary)
        {
            InitializeComponent();
            tbId.Text = id;
            tbName.Text = name;
            tbCCCD.Text = cccd;
            cbGender.Text = gender;
            dTPBirthdate.Text = dob;
            tbMobile.Text = mobile;
            tbAddress.Text = address;
            tbEmail.Text = email;
            tbUsername.Text = username;
            tbPassword.Text = password;
            cbPosition.Text = position;
            tbSalary.Text = salary;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
            {
                query = "update TAIKHOAN set HOATDONG = 0 " +
                        "WHERE MANV = '" + tbId.Text + "'\n" +
                        "update NHANVIEN set HOATDONG = 0 " +
                        "where MANV = '" + tbId.Text + "'";
                fn.setData(query, "Thông Tin Nhân Viên Đã Được Xóa!");
                this.Close();
                EventHub.OnEmployeeUpdated();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (tbId.Text != "" && tbName.Text != "" && tbCCCD.Text != "" && cbGender.Text != "" && dTPBirthdate.Text != "" && tbMobile.Text != "" && tbAddress.Text != "" && tbEmail.Text != "" && tbUsername.Text != "" && tbPassword.Text != "" && cbPosition.Text != "" && tbSalary.Text != "")
            {
                query = "UPDATE NHANVIEN " +
                        "SET NHOTEN = N'" + tbName.Text + "', NCCCD = '" + tbCCCD.Text + "', NGIOITINH = N'" + cbGender.Text +
                        "', NNGSINH = '" + dTPBirthdate.Value.ToString(Global.dateFormat) + "', NSDT = '" + tbMobile.Text + "', NDIACHI = N'" + tbAddress.Text +
                        "', NEMAIL = N'" + tbEmail.Text + "', CHUCVU = N'" + cbPosition.Text + "', LUONG = " + Convert.ToInt64(tbSalary.Text) +
                        " WHERE MANV = '" + tbId.Text + "'\n" +
                        "UPDATE TAIKHOAN " +
                        "SET MATKHAU = '" + tbPassword.Text +
                        "' WHERE MANV = '" + tbId.Text + "'";
                fn.setData(query, "Sửa Thông Tin Nhân Viên Thành Công!");
                this.Close();
                EventHub.OnEmployeeUpdated();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCCCD_TextChanged(object sender, EventArgs e)
        {
            query = "select NCCCD " +
                    "from NHANVIEN " +
                    "where NCCCD = '" + tbCCCD.Text + "' and MANV != '" + tbId.Text+"'";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cccdError = true;
                btUpdate.Enabled = false;
                errorProvider1.SetError(tbCCCD, "CCCD không được trùng");
            }
            else
            {
                cccdError = false;
                if (!sdtError)
                {
                    btUpdate.Enabled = true;
                }
                errorProvider1.SetError(tbCCCD, null);
            }
        }

        private void tbMobile_TextChanged(object sender, EventArgs e)
        {
            query = "select NSDT " +
                    "from NHANVIEN " +
                    "where NSDT = '" + tbMobile.Text + "'and MANV != '" + tbId.Text + "'";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                sdtError = true;
                btUpdate.Enabled = false;
                errorProvider1.SetError(tbMobile, "SDT không được trùng");
            }
            else
            {
                sdtError = false;
                if (!cccdError)
                {
                    btUpdate.Enabled = true;
                }
                errorProvider1.SetError(tbMobile, null);
            }
        }
        private void tbMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
