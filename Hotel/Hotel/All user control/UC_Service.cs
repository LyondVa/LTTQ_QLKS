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
    public partial class UC_Service : UserControl
    {
        function fn = new function();
        string query;
        public UC_Service()
        {
            InitializeComponent();
            setService(dgvServiceInfo);
            AddDeleteColumn();
        }
        private void AddDeleteColumn()
        {
            DataGridViewImageColumn dGVImgCol = new DataGridViewImageColumn();
            dGVImgCol.Name = "REMOVE";
            dGVImgCol.HeaderText = "Xóa";
            dGVImgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dGVImgCol.Image = Resources.CrossMark;
            dGVImgCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGVImgCol.Width = 50;
            dgvServiceInfo.Columns.Insert(dgvServiceInfo.ColumnCount, dGVImgCol);
            dgvServiceInfo.Columns["REMOVE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }
        private void setService(DataGridView dgv)
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
            background br = new background();
            br.Show();
            addService.ShowDialog();
            setService(dgvServiceInfo);
            br.Hide();
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

        private void dgvServiceInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            if(e.ColumnIndex == dgvServiceInfo.Columns["REMOVE"].Index)
            {

            }
            DataGridViewRow selectedRow = dgvServiceInfo.Rows[e.RowIndex];
            string id = selectedRow.Cells["Mã Dịch Vụ"].Value.ToString();
            string name = selectedRow.Cells["Tên Dịch Vụ"].Value.ToString();
            Int64 p = Convert.ToInt64(selectedRow.Cells["Giá"].Value);
            string price = p.ToString();
            EditService es = new EditService(id, name, price);
            background br = new background();
            br.Show();
            es.ShowDialog();
            es.Focus();

            setService(dgvServiceInfo);
            br.Hide();
        }

        private void bTUpdate_Click(object sender, EventArgs e)
        {
            EditService es = new EditService();
            background br = new background();
            br.Show();
            es.ShowDialog();
            es.Focus();
            br.Hide();
        }
    }
}
