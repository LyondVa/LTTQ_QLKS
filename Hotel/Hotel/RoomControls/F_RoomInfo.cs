using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.All_user_control;
using Hotel.SmallForm;

namespace Hotel.RoomControls
{
    public partial class F_RoomInfo : Form
    {
        string query;
        DataSet dS = new DataSet();
        DataSet dSService = new DataSet();
        function fn = new function();
        string roomID, reservationID, cleanStatus, roomStatus, note;
        public F_RoomInfo()
        {
            InitializeComponent();
            EventHub.ServicesUpdated += ServicesLoad;
        }
        public F_RoomInfo(UC_RoomUnitBase room)
        {
            InitializeComponent();
            ButtonSet(room);
            LabelSet(room);
            this.roomID = room.RoomID;
            this.reservationID = room.ReservationID;
            this.cleanStatus = room.CleanStatus;
            this.roomStatus = room.RoomStatus;
            this.note = room.Note; if (room is UC_RoomUnitBooked || room is UC_RoomUnitOccupied)
            {
                PropertiesLoad();
                lBBookClient.Text = dS.Tables[0].Rows[0]["KHOTEN"].ToString();
                lBcheckInDate.Text = room.CheckInDate.Substring(0, 10);
                lBCheckOutTime.Text = room.CheckOutDate.Substring(0, 10);

                ServicesLoad();
                dGVService.DataSource = dSService.Tables[0];
                dGVService.Columns["TENDV"].HeaderText = "Tên dịch vụ";
                dGVService.Columns["SOLUONG"].HeaderText = "SL";
                dGVService.Columns["THOIGIANSD"].HeaderText = "thời gian sử dụng";
            }
            else
            {
                dGVService.Columns.Add("TENDV", "Dịch vụ");
                dGVService.Columns.Add("SOLUONG", "SL");
                dGVService.Columns.Add("THOIGIANSD", "Thời gian sử dụng");
            }
            dGVService.Columns["TENDV"].Width = 100;
            dGVService.Columns["SOLUONG"].Width = 50;
            EventHub.ServicesUpdated += ServicesLoad;
        }
        private void F_RoomInfo_Load(object sender, EventArgs e)
        {
            tBNote.Text = note;
            lBRoomID.Text = roomID;
            if (roomStatus == "Bình thường")
            {
                cBRoomStatus.SelectedIndex = 0;
            }
            else
            {
                cBRoomStatus.SelectedIndex = 1;
            }
            if (cleanStatus == "Đã dọn")
            {
                cBCleanStatus.SelectedIndex = 0;
            }
            else
            {
                cBCleanStatus.SelectedIndex = 1;
            }
        }
        private void PropertiesLoad()
        {
            query = "select KHOTEN " +
                    "from CTPHG " +
                    "left join HOADON on CTPHG.MAHD = HOADON.MAHD " +
                    "left join KHACHHANG on HOADON.MAKH = KHACHHANG.MAKH " +
                    "where CTPHG.MAHD = '" + reservationID + "'";
            dS = fn.getData(query);
        }
        private void ServicesLoad()
        {
            query = "select TENDV, SOLUONG, THOIGIANSD " +
                    "from CTDV " +
                    "inner join DICHVU on CTDV.MADV = DICHVU.MADV " +
                    "where CTDV.MAHD = '" + reservationID + "' and CTDV.MAPHG = '" + roomID + "'";
            dSService = fn.getData(query);
        }
        private void LabelSet(UC_RoomUnitBase room)
        {
            if (room is UC_RoomUnitMaintenance || room is UC_RoomUnitAvailable)
            {
                pNCheckInDate.Visible = false;
                pNCheckOutDate.Visible = false;
                pNClientName.Visible = false;
            }
        }
        private void ButtonSet(UC_RoomUnitBase room)
        {
            if (room is UC_RoomUnitAvailable)
            {
                pNBTBook.Visible = true;
                bTBook.Visible = true;
                pNBTBook.Dock = DockStyle.Right;
            }
            else if (room is UC_RoomUnitBooked)
            {
                pNBTCheckIn.Visible = true;
                bTCheckIn.Visible = true;
                pNBTCheckIn.Dock = DockStyle.Right;
                pNBTCancel.Visible = true;
                bTCancel.Visible = true;
                pNBTCancel.Dock = DockStyle.Right;
            }
            else if (room is UC_RoomUnitOccupied)
            {
                pNBTService.Visible = true;
                bTService.Visible = true;
                pNBTService.Dock = DockStyle.Right;
            }
            this.Invalidate();
        }
        private void bTExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bTBook_Click(object sender, EventArgs e)
        {
            if(Global.isAdmin == 1)
            {
                MessageBox.Show("Vui lòng dùng tài khoản nhân viên để đặt phòng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            F_BookRoom bR = new F_BookRoom();
            this.Close();
            background br2 = new background();
            br2.Show();
            bR.ShowDialog();
            bR.Focus();
            br2.Hide();
        }

        private void bTUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Xác nhận cập nhật thông tin phòng?", "Thông tin phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dR == DialogResult.Yes)
            {
                try
                {
                    query = "update PHONG " +
                            "set TRANGTHAI = N'" + cBRoomStatus.Text + "', DONDEP = N'" + cBCleanStatus.Text + "' " +
                            "where MAPHG = '" + roomID + "'";
                    fn.setData(query, "Cập nhật thành công");
                    this.Close();
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
            if(cBCleanStatus.SelectedIndex == 1)
            {
                MessageBox.Show("Phòng chưa dọn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dR = MessageBox.Show("Xác nhận nhận phòng?", "Thông tin phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dR == DialogResult.Yes)
            {
                try
                {
                    query = "update HOADON " +
                            "set NGNHANPHGTHAT = '" + DateTime.Now.ToString(Global.dateFormat) + "' " +
                            "from HOADON " +
                            "where NGNHANPHGTHAT is null and HOADON.MAHD = '" + reservationID + "';" +
                            "update KHACHHANG " +
                            "set STAYING = 1 " +
                            "from KHACHHANG, HOADON " +
                            "where HOADON.MAHD = '" + reservationID + "';";
                    fn.setData(query, "Thành công");
                    EventHub.OnDatabaseUpdated();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //private void bTCheckOut_Click(object sender, EventArgs e)
        //{
        //    DialogResult dR = MessageBox.Show("Xác nhận thanh toán?", "Thông tin phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    if (dR == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            query = "update HOADON " +
        //                    "set NGTRPHGTHAT = '" + DateTime.Now.ToString(Global.dateFormat) + "' " +
        //                    "from HOADON " +
        //                    "where NGTRPHGTHAT is null and HOADON.MAHD = '" + reservationID + "';" +
        //                    "update KHACHHANG " +
        //                    "set STAYING = 0 " +
        //                    "from KHACHHANG, HOADON " +
        //                    "where HOADON.MAHD = '" + reservationID + "';" +
        //                    "update PHONG " +
        //                    "set DONDEP = N'Chưa dọn' " +
        //                    "from PHONG, CTPHG " +
        //                    "where PHONG.MAPHG = CTPHG.MAPHG " +
        //                    "and MAHD = '" + reservationID +"'";
        //            fn.setData(query, "Thành công");
        //            EventHub.OnDatabaseUpdated();
        //            this.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //}

        private void bTService_Click(object sender, EventArgs e)
        {
            F_AddService serviceForm = new F_AddService(roomID, reservationID);
            this.Close();
            background br2 = new background();
            br2.Show();
            serviceForm.ShowDialog();
            serviceForm.Focus();
            br2.Hide();
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
                            "where CTPHG.MAPHG = '" + roomID + "'";
                    dSC = fn.getData(query);
                    tempMAHD = dSC.Tables[0].Rows[0]["MAHD"].ToString();
                    query = "delete from CTDV " +
                            "where MAHD = '" + tempMAHD + "'";
                    fn.setData(query, "Thành công");
                    query = "delete from MAHD " +
                            "where MAHD = '" + tempMAHD + "'";
                    fn.setData(query, "Thành công");
                    EventHub.OnDatabaseUpdated();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
