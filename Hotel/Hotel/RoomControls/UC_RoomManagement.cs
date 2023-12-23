using Hotel.RoomControls;
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
    public partial class UC_RoomManagement : UserControl
    {
        string query, message;
        function fn = new function();
        DataSet dS = new DataSet();
        public UC_RoomManagement()
        {
            InitializeComponent();
            EventHub.DatabaseUpdated += RefreshDataGridView;
            this.Load += UC_RoomManagement_Load;
        }
        private void RefreshDataGridView()
        {
            query = "select * from PHONG";
            dS = fn.getData(query);
            dGVRoom.DataSource = dS.Tables[0];
            dGVRoom.Columns["MAPHG"].HeaderText = "Mã phòng";
            dGVRoom.Columns["MALOAIPHG"].HeaderText = "Mã loại phòng";
            dGVRoom.Columns["TRANGTHAI"].HeaderText = "Trạng thái";
            dGVRoom.Columns["TANG"].HeaderText = "Tầng";
            dGVRoom.Columns["DONDEP"].HeaderText = "Dọn dẹp";
            dGVRoom.Columns["GHICHU"].Visible = false;
        }
        private void UC_RoomManagement_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void bTAdd_Click(object sender, EventArgs e)
        {
            F_AddRoom form = new F_AddRoom(dS);
            form.Show();
        }

        private void bTUpdate_Click(object sender, EventArgs e)
        {
            F_UpdateRoom form = new F_UpdateRoom(dS, dGVRoom);
            form.Show();
        }

        private void bTDelete_Click(object sender, EventArgs e)
        {
            if(dGVRoom.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    int selectedRowIndex = dGVRoom.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dGVRoom.Rows[selectedRowIndex];
                    string subject = selectedRow.Cells["MAPHG"].Value?.ToString();
                    query = "delete from phong where MAPHG = '" + subject + "'";
                    message = "Xóa thành công";
                    fn.setData(query, message);
                    EventHub.OnDatabaseUpdated();
                }
            }
        }

        private void tBSearch_TextChanged(object sender, EventArgs e)
        {
            (dGVRoom.DataSource as DataTable).DefaultView.RowFilter = string.Format("MAPHG LIKE '%"+tBSearch.Text+"%'", tBSearch.Text);
        }

    }
}
