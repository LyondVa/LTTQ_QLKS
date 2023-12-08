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
        }
        private void bTExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bTAdd_Click(object sender, EventArgs e)
        {
            if(tBRoomType.Text == "" || tBStatus.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tất cả các trường", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                query = "insert into PHONG values('P" + cBFloor.Text + cBRoomID.Text + "','" + tBRoomType.Text + "','" + tBStatus.Text + "'," + Convert.ToInt16(cBFloor.Text) + ", '')";
                string msg = "Thêm Thành công";
                fn.setData(query, msg);
                EventHub.OnDatabaseUpdated();
                this.Close();
            }
        }

        private void dUDFloor_SelectedItemChanged(object sender, EventArgs e)
        {
            rFn.SetRoomID(cBRoomID, ds, cBFloor.Text);
        }
    }
}
