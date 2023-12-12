using System;
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
    public partial class F_AddRoom : Form
    {
        DataSet ds;
        string query;
        function fn = new function();
        RoomFunction rFn = new RoomFunction();
        public F_AddRoom(DataSet ds)
        {
            InitializeComponent();
            this.ds = ds;
            rFn.SetRoomTypeID(cBRoomTypeID);
        }
        private void bTExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bTAdd_Click(object sender, EventArgs e)
        {
            if (cBRoomTypeID.Text == "" || cBRoomStatus.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tất cả các trường", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                query = "insert into PHONG values('P" + cBFloor.Text + cBRoomID.Text + "','" + cBRoomTypeID.Text + "','" + cBRoomStatus.Text + "','" + Convert.ToInt16(cBFloor.Text) + "','','" + cBCleanStatus.Text + "')";
                string msg = "Thêm Thành công";
                fn.setData(query, msg);
                EventHub.OnDatabaseUpdated();
                this.Close();
            }
        }

        private void cBFloor_SelectedItemChanged(object sender, EventArgs e)
        {
            rFn.SetRoomID(0, cBRoomID, ds, cBFloor.Text);
        }
    }
}
