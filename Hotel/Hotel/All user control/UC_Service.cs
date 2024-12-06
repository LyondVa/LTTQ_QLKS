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
        public function fn = new function();
        string query;
        DataSet ds;
        public UC_Service()
        {
            InitializeComponent();
            setService();
            EventHub.ServicesUpdated += setService;
            if(Global.globalPermission == 1)
            {
                btAdd.Visible = true;
            }
            else
            {
                btAdd.Visible = false;
            }
        }
        private void setService()
        {
            query = "SELECT MADV as 'Mã Dịch Vụ', TENDV as 'Tên Dịch Vụ', cast(GIADV as decimal) as 'Giá'" +
                    "FROM DICHVU " +
                    "WHERE HOATDONG = 1" +
                    "ORDER BY MADV ASC";
            ds = fn.getData(query);
            dgvServiceInfo.DataSource = ds.Tables[0];
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
            setService();
            br.Hide();
        }

        public void tbSearch_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT MADV as 'Mã Dịch Vụ', TENDV as 'Tên Dịch Vụ', cast(GIADV as decimal) as 'Giá' " +
                    "FROM DICHVU " +
                    "WHERE TENDV like N'%" + tbSearch.Text + "%' and HOATDONG = 1" +
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
            else
            {
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
                setService();
                br.Hide();
            }
        }

        public void DeactivateService(object sender, DataGridViewCellEventArgs e)
        {
            
            DialogResult dr = MessageBox.Show("Xác nhận xóa dịch vụ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                string serviceID = ds.Tables[0].Rows[e.RowIndex]["Mã Dịch Vụ"].ToString();
                query = "update DICHVU set HOATDONG = 0 where MADV = '" + serviceID + "'";
                fn.setDataNoMsg(query);
                EventHub.OnServicesUpdated();
            }
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
