using Guna.UI2.WinForms;
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

namespace Hotel.RoomControls
{
    public partial class F_UpdateRoom : Form
    {
        DataSet ds;
        string query;
        function fn = new function();
        RoomFunction rFn = new RoomFunction();
        public F_UpdateRoom(DataSet ds)
        {
            InitializeComponent();
            this.ds = ds;
            rFn.SetRoomTypeID(cBRoomTypeID);
            rFn.SetRoomID(1, cBRoomID, ds);
        }
        public F_UpdateRoom(DataSet ds, string roomid)
        {
            InitializeComponent();
            this.ds = ds;
            rFn.SetRoomTypeID(cBRoomTypeID);
            rFn.SetRoomID(1, cBRoomID, ds);
            cBRoomID.SelectedIndex = cBRoomID.Items.IndexOf(roomid);
        }
        private void bTExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bTUpdate_Click(object sender, EventArgs e)
        {
            if (cBRoomID.Text == "" || cBRoomTypeID.Text == "" || cBRoomTypeID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tất cả các trường", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string column = "MAPHG";
                if (rFn.FindInDataset(ds, cBRoomID.Text, column) == null)
                {
                    MessageBox.Show("Không tìm thấy mã phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = "update PHONG " +
                            "set MALOAIPHG = '" + cBRoomTypeID.Text + "', TRANGTHAI = N'" + cBRoomStatus.Text + "', DONDEP = N'" + cBCleanStatus.Text + "'" +
                            "where MAPHG = '" + cBRoomID.Text + "'";
                    string msg = "Cập nhật Thành công";
                    fn.setData(query, msg);
                    EventHub.OnDatabaseUpdated();
                    this.Close();
                }
            }
        }

        private void cBRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            query = "select MALOAIPHG, TRANGTHAI, DONDEP " +
                    "from PHONG " +
                    "where MAPHG = '" + cBRoomID.Text + "'";
            ds = fn.getData(query);
            DataRow dr = ds.Tables[0].Rows[0];
            cBRoomTypeID.SelectedIndex = cBRoomTypeID.Items.IndexOf(dr["MALOAIPHG"].ToString());
            cBRoomStatus.SelectedIndex = cBRoomStatus.Items.IndexOf(dr["TRANGTHAI"].ToString());
            cBCleanStatus.SelectedIndex = cBCleanStatus.Items.IndexOf(dr["DONDEP"].ToString());
        }
    }
}
