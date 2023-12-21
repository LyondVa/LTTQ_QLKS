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
    public partial class UC_Service : UserControl
    {
        function fn = new function();
        string query;
        public UC_Service()
        {
            InitializeComponent();
            setService(dgvServiceInfo);
        }
        public void setService(DataGridView dgv)
        {
            query = "SELECT MADV as 'Mã Dịch Vụ', TENDV as 'Tên Dịch Vụ', cast(GIADV as decimal) as 'Giá'" +
                    "FROM DICHVU " +
                    "ORDER BY MADV ASC";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn.ToExcel(dgvServiceInfo, saveFileDialog1.FileName);
            }
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            addService.ShowDialog();
            setService(dgvServiceInfo);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT MADV as 'Mã Dịch Vụ', TENDV as 'Tên Dịch Vụ', cast(GIADV as decimal) as 'Giá' " +
                    "FROM DICHVU " +
                    "WHERE TENDV like N'%" + tbSearch.Text + "%' " +
                    "ORDER BY MADV ASC";
            DataSet ds = fn.getData(query);
            dgvServiceInfo.DataSource = ds.Tables[0];
        }

        private void dgvServiceInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvServiceInfo.Rows[e.RowIndex];
            string id = selectedRow.Cells[0].Value.ToString();
            string name = selectedRow.Cells[1].Value.ToString();
            Int64 p = Convert.ToInt64(selectedRow.Cells[2].Value);
            string price = p.ToString();
            EditService es = new EditService(id, name, price);
            es.ShowDialog();
            es.Focus();
            setService(dgvServiceInfo);
        }
    }
}
