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
        public F_UpdateRoom(DataSet ds, Guna2DataGridView dGV)
        {
            InitializeComponent();
            this.ds = ds;
            rFn.SetRoomTypeID(cBRoomTypeID);
            rFn.SetRoomID(1, cBRoomID, ds);
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
                if (!rFn.FindInDataset(ds, cBRoomID.Text, column))
                {
                    MessageBox.Show("Không tìm thấy mã phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = "update PHONG " +
                            "set MALOAIPHG = '" + cBRoomTypeID.Text + "', TRANGTHAI = '" + cBRoomStatus.Text + "' " +
                            "where MAPHG = '" + cBRoomID.Text + "'";
                    string msg = "Cập nhật Thành công";
                    fn.setData(query, msg);
                    EventHub.OnDatabaseUpdated();
                    this.Close();
                }
            }
        }
    }
}
