using Guna.UI2.WinForms;
using Hotel.Properties;
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
        DataSet ds;
        public UC_CustomerInfo()
        {
            InitializeComponent();
            setCustomerInfo();
            EventHub.CustomerUpdated += setCustomerInfo;
        }
        public void setCustomerInfo()
        {
            query = "SELECT MAKH as 'Mã Khách Hàng', KHOTEN as 'Họ Tên', QUOCTICH as 'Quốc Tịch', KCCCD as 'CCCD', KGIOITINH as 'Giới Tính', convert(DATE, KNGSINH) as 'Ngày Sinh', KSDT as 'Số Điện Thoại', KDIACHI as 'Địa Chỉ', KEMAIL as 'Email' " +
                    "FROM KHACHHANG " +
                    "where HOATDONG = 1 " +
                    "ORDER BY MAKH ASC";
            ds = fn.getData(query);
            dgvCustomerInfo.DataSource = ds.Tables[0];
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
            query = "SELECT MAKH as 'Mã Khách Hàng', KHOTEN as 'Họ Tên', QUOCTICH as 'Quốc Tịch', KCCCD as 'CCCD', KGIOITINH as 'Giới Tính', convert(DATE, KNGSINH) as 'Ngày Sinh', KSDT as 'Số Điện Thoại', KDIACHI as 'Địa Chỉ', KEMAIL as 'Email' " +
                    "FROM KHACHHANG " +
                    "WHERE KHOTEN like N'%" + tbSearch.Text.Trim() + "%' and HOATDONG = 1 " +
                    "ORDER BY MAKH ASC";
          ds = fn.getData(query);
            dgvCustomerInfo.DataSource = ds.Tables[0];
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            background br = new background();
            br.Show();
            addCustomer.ShowDialog();
            setCustomerInfo();
            br.Hide();
        }

        private void dgvCustomerInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow selectedRow = dgvCustomerInfo.Rows[e.RowIndex];
                string id = selectedRow.Cells["Mã Khách Hàng"].Value.ToString();
                string name = selectedRow.Cells["Họ Tên"].Value.ToString();
                string nationality = selectedRow.Cells["Quốc Tịch"].Value.ToString();
                string cccd = selectedRow.Cells["CCCD"].Value.ToString();
                string gender = selectedRow.Cells["Giới Tính"].Value.ToString();
                string dob = selectedRow.Cells["Ngày Sinh"].Value.ToString();
                string phone = selectedRow.Cells["Số Điện Thoại"].Value.ToString();
                string address = selectedRow.Cells["Địa Chỉ"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                EditCustomer ec = new EditCustomer(id, name, nationality, cccd, gender, dob, phone, address, email);
                background br = new background();
                br.Show();
                ec.ShowDialog();

                ec.Focus();
                setCustomerInfo();
                br.Hide();
            }
        }
        private void DeactivateCustomer(object sender, DataGridViewCellEventArgs e)
        {

            DialogResult dr = MessageBox.Show("Xác nhận xóa khách hàng?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string customerID = ds.Tables[0].Rows[e.RowIndex]["Mã Khách Hàng"].ToString();
                query = "update KHACHHANG set HOATDONG = 0 where MAKH = '" + customerID + "'";
                fn.setDataNoMsg(query);
                EventHub.OnCustomerUpdated();
            }
        }
    }
}
