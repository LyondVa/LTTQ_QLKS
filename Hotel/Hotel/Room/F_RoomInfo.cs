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
    public partial class F_RoomInfo : Form
    {
        string roomID, esCheckOutTime, guestName, employeeName, roomStatus, note, cleanStatus;
        string query;
        DataSet dS;
        function fn = new function();
        public F_RoomInfo()
        {
            InitializeComponent();
        }
        public F_RoomInfo(string roomID, string esCheckoutTime, string guestName, string employeeName, string roomStatus, string note, string cleanStatus)
        {
            InitializeComponent();
            this.roomID = roomID;
            this.esCheckOutTime = esCheckoutTime;
            this.guestName = guestName;
            this.employeeName = employeeName;
            this.roomStatus = roomStatus;
            this.note = note;
            this.cleanStatus = cleanStatus;
            TempServiceLoad();
        }
        private void F_RoomInfo_Load(object sender, EventArgs e)
        {
            lBRoomID.Text = roomID;
            lBEsCheckoutTime.Text = esCheckOutTime;
            lBBookClient.Text = guestName;
            lBBookEmployee.Text = employeeName;
            if (roomStatus == "Trống")
            {
                cBRoomStatus.SelectedIndex = 0;
            }
            else
            {
                cBRoomStatus.SelectedIndex = 1;
            }
            tBNote.Text = note;
            if (cleanStatus == "Đã dọn dẹp")
            {
                cBCleanStatus.SelectedIndex = 0;
            }
            else
            {
                cBCleanStatus.SelectedIndex = 1;
            }
            dGVService.DataSource = dS;
        }
        private void TempServiceLoad()
        {
            try
            {
                query = "select TENDV as 'Tên dịch vụ', SOLUONG as 'Số lượng', THOIGIANSD as 'Thời gian đặt' " +
                    "from CTDV, DICHVU, CTPHG " +
                    "where TENDV.MADV = CTDV.MADV and CTDV.MAHD = CTPHG.MAHD " +
                    "and MAPHG = '" + roomID + "'";
                dS = fn.getData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bTExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bTBook_Click(object sender, EventArgs e)
        {
            F_BookRoom bR = new F_BookRoom();
            bR.Show();
            bR.Focus();
        }

        private void bTUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Xác nhận cập nhật thông tin phòng?", "Thông tin phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dR == DialogResult.Yes)
            {
                try
                {
                    query = "update PHONG " +
                            "set TRANGTHAI = '" + roomStatus + "', DONDEP ='" + cleanStatus + "' " +
                            "where MAPHG = '" + roomID + "'";
                    fn.setData(query, "Cập nhật thành công");
                    EventHub.OnDatabaseUpdated();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bTCheckIn_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Xác nhận nhận phòng?", "Thông tin phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dR == DialogResult.Yes)
            {
                try
                {
                    query = "update HOADON " +
                            "inner join CTPHG on HOADON.MAHD = CTPHG.MAHD " +
                            "set CHECKEDIN = 1 " +
                            "where CHECKEDIN = 0 and CTPHG.MAPHG = '" + roomID + "'";
                    fn.setData(query, "Thành công");
                    EventHub.OnDatabaseUpdated();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bTCheckOut_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Xác nhận nhận phòng?", "Thông tin phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dR == DialogResult.Yes)
            {
                try
                {
                    query = "update HOADON " +
                            "inner join CTPHG on HOADON.MAHD = CTPHG.MAHD " +
                            "set CHECKEDOUT = 1 " +
                            "where CHECKEDOUT = 0 and CTPHG.MAPHG = '" + roomID + "'";
                    fn.setData(query, "Thành công");
                    EventHub.OnDatabaseUpdated();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bTService_Click(object sender, EventArgs e)
        {

        }

        private void bTCancel_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Xác nhận hủy đặt phòng?", "Thông tin phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dR == DialogResult.Yes)
            {
                try
                {
                    DataSet dSC = new DataSet();
                    string tempMAHD;
                    query = "select MAHD " +
                            "from HOADON " +
                            "inner join CTPHG " +
                            "where CTPHG.MAPHG = '" + roomID +"'";
                    dSC = fn.getData(query);
                    tempMAHD = dSC.Tables[0].Rows[0]["MAHD"].ToString();
                    query = "delete from CTDV " +
                            "where MAHD = '" + tempMAHD + "'";
                    fn.setData(query, "Thành công");
                    query = "delete from MAHD " +
                            "where MAHD = '" + tempMAHD + "'";
                    fn.setData(query, "Thành công");
                    EventHub.OnDatabaseUpdated();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
