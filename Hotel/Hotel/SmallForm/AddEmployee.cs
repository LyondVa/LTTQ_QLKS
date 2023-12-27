using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.SmallForm
{
    public partial class AddEmployee : Form
    {
        function fn = new function();
        string query;
        bool cccdError = false, sdtError = false, usernameError = false;
        DataSet ds = new DataSet();
        public AddEmployee()
        {
            InitializeComponent();
            txtBirth.Value = DateTime.Now;
            this.Size = new System.Drawing.Size(950, 604);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if ( txtName.Text != "" && txtCCCD.Text != "" && cbGender.Text != "" && txtBirth.Text != "" && txtMobile.Text != "" && txtAddress.Text != "" && txtEmail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtPosition.Text != "" && txtSalary.Text != "")
            {
                string name = txtName.Text;
                string cccd = txtCCCD.Text;
                string gender = cbGender.Text;
                string dob = txtBirth.Value.ToString(Global.dateFormat);
                string mobile = txtMobile.Text;
                string address = txtAddress.Text;
                string email = txtEmail.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string position = txtPosition.Text;
                Int64 salary = Convert.ToInt64(txtSalary.Text);
                query = "insert into NHANVIEN ( NHOTEN, NCCCD, NGIOITINH, NNGSINH, NSDT, NDIACHI, NEMAIL, CHUCVU, LUONG) values "
                      + "(N'" + name + "','" + cccd + "',N'" + gender + "','" + dob + "','" + mobile + "',N'" + address + "',N'" + email + "',N'" + position + "'," + salary + ")";
                fn.setData(query, "Thêm Nhân Viên Thành Công!");
                query = "declare @id nvarchar(10); select @id = MANV from NHANVIEN where NCCCD = '"+cccd+"'; insert into TAIKHOAN (MANV, TENTK, MATKHAU) values (@id,'" + username + "','" + password + "')";
                fn.setDataNoMsg(query);
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select TENTK " +
                    "from TAIKHOAN " +
                    "where TENTK = '" + txtUsername.Text + "'";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                usernameError = true;
                bTAdd.Enabled=false;
                errorProvider1.SetError(txtUsername, "Tên tài khoản không được trùng");
            }
            else
            {
                usernameError=false;
                if(!cccdError && !sdtError)
                {
                    bTAdd.Enabled = true;
                }
                errorProvider1.SetError(txtUsername, null);
            }
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            query = "select NCCCD " +
                    "from NHANVIEN " +
                    "where NCCCD = '" + txtCCCD.Text + "'";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cccdError = true;
                bTAdd.Enabled = false;
                errorProvider1.SetError(txtCCCD, "CCCD không được trùng");
            }
            else
            {
                cccdError = false;
                if (!usernameError && !sdtError)
                {
                    bTAdd.Enabled = true;
                }
                errorProvider1.SetError(txtCCCD, null);
            }
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            query = "select NSDT " +
                    "from NHANVIEN " +
                    "where NSDT = '" + txtMobile.Text + "'";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                sdtError = true;
                bTAdd.Enabled = false;
                errorProvider1.SetError(txtMobile, "SDT không được trùng");
            }
            else
            {
                sdtError = false;
                if (!usernameError && !cccdError)
                {
                    bTAdd.Enabled = true;
                }
                errorProvider1.SetError(txtMobile, null);
            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

