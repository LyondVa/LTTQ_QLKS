using Hotel.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Hotel.All_user_control
{
    public partial class F_AddService : Form
    {
        string query;
        DataSet dSS = new DataSet();
        DataSet dSA = new DataSet();
        function fn = new function();
        string roomID;
        string reservationID;
        public F_AddService(string roomID, string reservationID)
        {
            InitializeComponent();
            InitializeSerivce();
            this.reservationID = reservationID;
            this.roomID = roomID;
        }
        private void InitializeSerivce()
        {
            query = "select MADV, TENDV " +
                    "from DICHVU ";
            dSA = fn.getData(query);
            dSA.Tables[0].Columns.Add("SOLUONG", typeof(int));

            dGVServiceSelection.DataSource = dSA.Tables[0];
            dGVServiceSelection.Columns["MADV"].Visible = false;
            dGVServiceSelection.Columns["TENDV"].HeaderText = "Tên dịch vụ";
            dGVServiceSelection.Columns["TENDV"].ReadOnly = true;
            dGVServiceSelection.Columns["SOLUONG"].HeaderText = "Số lượng";
            SetQuantityColumnValue();

            DataGridViewImageColumn dGVICA = new DataGridViewImageColumn();
            dGVICA.Name = "ADD";
            dGVICA.HeaderText = "Thêm";
            dGVICA.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dGVICA.Image = Resources.PlusMark;
            dGVServiceSelection.Columns.Add(dGVICA);

            dSS.Tables.Add();
            dSS.Tables[0].Columns.Add("MADV", typeof(string));
            dSS.Tables[0].Columns.Add("TENDV", typeof(string));
            dSS.Tables[0].Columns.Add("SOLUONG", typeof(int));
            dGVServiceSelected.DataSource = dSS.Tables[0];

            dGVServiceSelected.Columns["MADV"].Visible=false;
            dGVServiceSelected.Columns["TENDV"].HeaderText = "Tên dịch vụ";
            dGVServiceSelected.Columns["TENDV"].ReadOnly = true;
            dGVServiceSelected.Columns["SOLUONG"].HeaderText = "Số lượng";

            DataGridViewImageColumn dGVICS = new DataGridViewImageColumn();
            dGVICS.Name = "REMOVE";
            dGVICS.HeaderText = "Xóa";
            dGVICS.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dGVICS.Image = Resources.CrossMark;
            dGVServiceSelected.Columns.Insert(3, dGVICS);

            dGVServiceSelected.DataSource = dSS.Tables[0];

        }
        private void SetQuantityColumnValue()
        {
            foreach (DataRow row in dSA.Tables[0].Rows)
            {
                row["SOLUONG"] = 1;
            }
        }

        private void dGVServiceSelection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dGVServiceSelection.Columns["ADD"].Index && e.RowIndex >= 0)
            {
                DataRow dR = dSS.Tables[0].NewRow();
                dR["MADV"] = dGVServiceSelection.Rows[e.RowIndex].Cells["MADV"].Value.ToString();
                dR["TENDV"] = dGVServiceSelection.Rows[e.RowIndex].Cells["TENDV"].Value.ToString();
                dR["SOLUONG"] = dGVServiceSelection.Rows[e.RowIndex].Cells["SOLUONG"].Value;
                dSA.Tables[0].Rows.RemoveAt(e.RowIndex);
                dSS.Tables[0].Rows.Add(dR);
                dGVServiceSelected.Sort(dGVServiceSelected.Columns["TENDV"], ListSortDirection.Ascending);
            }
        }
        private void bTAdd_Click(object sender, EventArgs e)
        {
            foreach(DataRow dR in dSS.Tables[0].Rows)
            {
                query = "insert into CTDV(MAHD, MADV, SOLUONG, THOIGIANSD, MAPHG) values('" + reservationID+"','"+dR["MADV"]+"',"+dR["SOLUONG"] + ",'"+DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss") +"','" + roomID + "')";
                fn.setDataNoMsg(query);
            }
            EventHub.OnServicesUpdated();
            this.Close();
        }

        private void dGVServiceSelected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dR = dSA.Tables[0].NewRow();
            dR["MADV"] = dGVServiceSelected.Rows[e.RowIndex].Cells["MADV"].Value.ToString();
            dR["TENDV"] = dGVServiceSelected.Rows[e.RowIndex].Cells["TENDV"].Value.ToString();
            dR["SOLUONG"] = dGVServiceSelected.Rows[e.RowIndex].Cells["SOLUONG"].Value;
            dSS.Tables[0].Rows.RemoveAt(e.RowIndex);
            dSA.Tables[0].Rows.Add(dR);
            dGVServiceSelection.Sort(dGVServiceSelection.Columns["TENDV"], ListSortDirection.Ascending);
        }

        private void bTExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
