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
        string query;
        DataSet dS = new DataSet();
        function fn = new function();
        string roomID;
        public F_RoomInfo()
        {
            InitializeComponent();
        }
        public F_RoomInfo(string roomID)
        {
            InitializeComponent();
            this.roomID = roomID;
            PropertiesLoad();
            dGVService.DataSource = dS.Tables[0];
            dGVService.Columns["MALOAIPHG"].Visible = false;
            dGVService.Columns["TRANGTHAI"].Visible = false;
            dGVService.Columns["DONDEP"].Visible = false;
            dGVService.Columns["GHICHU"].Visible = false;
            dGVService.Columns["KHOTEN"].Visible = false;
            dGVService.Columns["NHOTEN"].Visible = false;
            lBRoomID.Text = roomID;
            lBBookClient.Text = dS.Tables[0].Rows[0]["KHOTEN"].ToString();
            lBBookEmployee.Text = dS.Tables[0].Rows[0]["NHOTEN"].ToString();
            lBBookClient.Text = dS.Tables[0].Rows[0]["KHOTEN"].ToString();
            tBNote.Text = dS.Tables[0].Rows[0]["GHICHU"].ToString();
            if (dS.Tables[0].Rows[0]["TRANGTHAI"].ToString() == "Trống")
            {
                cBRoomStatus.SelectedIndex = 0;
            }
            else
            {
                cBRoomStatus.SelectedIndex = 1;
            }
            if (dS.Tables[0].Rows[0]["DONDEP"].ToString() == "Đã dọn dẹp")
            {
                cBCleanStatus.SelectedIndex = 0;
            }
            else
            {
                cBCleanStatus.SelectedIndex = 1;
            }
        }
        private void F_RoomInfo_Load(object sender, EventArgs e)
        {
        }
        private void PropertiesLoad()
        {
            try
            {
                query = "select MALOAIPHG, TRANGTHAI, DONDEP, GHICHU, KHOTEN, NHOTEN, TENDV as 'Tên dịch vụ', SOLUONG as 'Số lượng', THOIGIANSD as 'Thời gian đặt' " +
                        "from PHONG " +
                        "left join CTPHG on PHONG.MAPHG = CTPHG.MAPHG " +
                        "left join HOADON on CTPHG.MAHD = HOADON.MAHD " +
                        "left join KHACHHANG on HOADON.MAKH = KHACHHANG.MAKH " +
                        "left join NHANVIEN on HOADON.MANV = NHANVIEN.MANV " +
                        "left join CTDV on HOADON.MAHD = CTDV.MAHD " +
                        "left join DICHVU on CTDV.MADV = DICHVU.MADV " +
                        "where PHONG.MAPHG = '" + roomID +"'";
                dS = fn.getData(query);
            }
            catch(Exception ex) 
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
                            "set TRANGTHAI = '" + cBRoomStatus.Text + "', DONDEP ='" + cBCleanStatus.Text + "' " +
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
            DialogResult dR = MessageBox.Show("Xác nhận thanh toán?", "Thông tin phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
