using Guna.UI2.WinForms;
using Hotel.SmallForm;
using iText.Layout.Element;
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
    public partial class UC_CustomerInfo : UserControl
    {
        function fn = new function();
        string query;
        public UC_CustomerInfo()
        {
            InitializeComponent();
            setCustomerInfo(dgvCustomerInfo);
        }
        public void setCustomerInfo(DataGridView dgv)
        {
            query = "SELECT MAKH as 'Mã Khách Hàng', KHOTEN as 'Họ Tên', QUOCTICH as 'Quốc Tịch', KCCCD as 'CCCD', KGIOITINH as 'Giới Tính', KNGSINH as 'Ngày Sinh', KSDT as 'Số Điện Thoại', KDIACHI as 'Địa Chỉ', KEMAIL as 'Email' " +
                    "FROM KHACHHANG " +
                    "ORDER BY MAKH ASC";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn.ToExcel(dgvCustomerInfo, saveFileDialog1.FileName);
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT MAKH as 'Mã Khách Hàng', KHOTEN as 'Họ Tên', QUOCTICH as 'Quốc Tịch', KCCCD as 'CCCD', KGIOITINH as 'Giới Tính', KNGSINH as 'Ngày Sinh', KSDT as 'Số Điện Thoại', KDIACHI as 'Địa Chỉ', KEMAIL as 'Email' " +
                    "FROM KHACHHANG " +
                    "WHERE KHOTEN like '%" + tbSearch.Text + "%' " +
                    "ORDER BY MAKH ASC";
            DataSet ds = fn.getData(query);
            dgvCustomerInfo.DataSource = ds.Tables[0];
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
            setCustomerInfo(dgvCustomerInfo);
        }

        private void dgvCustomerInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvCustomerInfo.Rows[e.RowIndex];
            string id = selectedRow.Cells[0].Value.ToString();
            string name = selectedRow.Cells[1].Value.ToString();
            string nationality = selectedRow.Cells[2].Value.ToString();
            string cccd = selectedRow.Cells[3].Value.ToString();
            string gender = selectedRow.Cells[4].Value.ToString();
            string dob = selectedRow.Cells[5].Value.ToString();
            string phone = selectedRow.Cells[6].Value.ToString();
            string address = selectedRow.Cells[7].Value.ToString();
            string email = selectedRow.Cells[8].Value.ToString();
            EditCustomer ec = new EditCustomer(id, name, nationality, cccd, gender, dob, phone, address, email);
            ec.ShowDialog();
            ec.Focus();
            setCustomerInfo(dgvCustomerInfo);
        }

        private void lBSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
