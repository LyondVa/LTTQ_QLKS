using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Hotel.RoomControls
{
    public partial class UC_RoomGrid : UserControl
    {
        DataSet dS = new DataSet();
        string query;
        function fn = new function();
        List<UC_RoomUnitBase> rooms = new List<UC_RoomUnitBase>();
        DateTime searchTime/* = DateTime.Parse("Dec 3, 2023")*/;
        public UC_RoomGrid()
        {
            InitializeComponent();
            TableLayoutPanelScrollbars();
            PopulateList(1);
            EventHub.DatabaseUpdated += UpdateGrid;
            dTPFilter.Value = DateTime.Now;
        }
        private void UC_RoomGrid_load(object sender, EventArgs e)
        {
            PopulateGrid(1);
        }
        private void UpdateGrid()
        {
            PopulateGrid(1);
        }
        private void PopulateGrid(int criterion = 0)
        {
            fLPFloor1.Controls.Clear();
            fLPFloor2.Controls.Clear();
            fLPFloor3.Controls.Clear();
            fLPFloor4.Controls.Clear();
            fLPFloor5.Controls.Clear();
            PopulateList(criterion);

            foreach (UC_RoomUnitBase roomUnit in rooms)
            {
                switch (roomUnit.GetFloor())
                {
                    case "1":
                        fLPFloor1.Controls.Add(roomUnit); 
                        break;
                    case "2":
                        fLPFloor2.Controls.Add(roomUnit);
                        break;
                    case "3":
                        fLPFloor3.Controls.Add(roomUnit);
                        break;
                    case "4":
                        fLPFloor4.Controls.Add(roomUnit);
                        break;
                    case "5":
                        fLPFloor5.Controls.Add(roomUnit);
                        break;
                }
            }
        }
        #region Test
        //private void RefreshDataSet()
        //{

        //    try
        //    {
        //        query = "select A.MAPHG, MALOAIPHG, DONDEP, TRANGTHAI, CHECKEDIN, TANG, KHOTEN, NHOTEN, NGNHANPHG, NGTRPHG " +
        //                 "from PHONG A " +
        //                 "left join CTPHG on A.MAPHG = CTPHG.MAPHG " +
        //                 "left join HOADON on CTPHG.MAHD = HOADON.MAHD " +
        //                 "left join KHACHHANG on HOADON.MAKH = KHACHHANG.MAKH " +
        //                 "left join NHANVIEN on HOADON.MANV = NHANVIEN.MANV " +
        //                 "union " +
        //                 "select A.MAPHG, MALOAIPHG, DONDEP, TRANGTHAI, CHECKEDIN, TANG, KHOTEN, NHOTEN, NGNHANPHG, NGTRPHG " +
        //                 "from PHONG A " +
        //                 "left join CTPHG o" +
        //                 "n A.MAPHG = CTPHG.MAPHG " +
        //                 "left join HOADON on CTPHG.MAHD = HOADON.MAHD " +
        //                 "left join KHACHHANG on HOADON.MAKH = KHACHHANG.MAKH " +
        //                 "left join NHANVIEN on HOADON.MANV = NHANVIEN.MANV " +
        //                 "where HOADON.MAHD = ( " +
        //                                     "select top 1 HOADON.MAHD " +
        //                                     "from HOADON " +
        //                                     "inner join CTPHG on CTPHG.MAHD = HOADON.MAHD " +
        //                                     "where A.MAPHG = CTPHG.MAPHG " +
        //                                     "order by MAHD desc " +
        //                                     ")";
        //        dS = fn.getData(query);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        //private void PopulateList(int criterion = 0)
        //{
        //    rooms.Clear();
        //    if (criterion == 1)
        //    {
        //        RefreshDataSet();
        //    }
        //    foreach (DataRow dR in dS.Tables[0].Rows)
        //    {
        //        if (dR["TRANGTHAI"].ToString() == "Trống")
        //        {
        //            UC_RoomUnitAvailable roomA = new UC_RoomUnitAvailable(dR["MAPHG"].ToString(), dR["MALOAIPHG"].ToString(), dR["DONDEP"].ToString(), dR["TRANGTHAI"].ToString(), dR["TANG"].ToString(), dR["CHECKEDIN"].ToString());
        //            rooms.Add(roomA);
        //        }
        //        else if (dR["TRANGTHAI"].ToString() == "Bảo trì")
        //        {
        //            UC_RoomUnitMaintenance roomM = new UC_RoomUnitMaintenance(dR["MAPHG"].ToString(), dR["MALOAIPHG"].ToString(), dR["DONDEP"].ToString(), dR["TRANGTHAI"].ToString(), dR["TANG"].ToString(), dR["CHECKEDIN"].ToString());
        //            rooms.Add(roomM);
        //        }
        //        else if (dR["TRANGTHAI"].ToString() == "Không trống")
        //        {
        //            if (dR["CHECKEDIN"].ToString() == "False")
        //            {
        //                UC_RoomUnitBooked roomB = new UC_RoomUnitBooked(dR["MAPHG"].ToString(), dR["MALOAIPHG"].ToString(), dR["DONDEP"].ToString(), dR["TRANGTHAI"].ToString(), dR["TANG"].ToString(), dR["CHECKEDIN"].ToString());
        //                rooms.Add(roomB);
        //            }
        //            else if (dR["CHECKEDIN"].ToString() == "True")
        //            {
        //                UC_RoomUnitOccupied roomO = new UC_RoomUnitOccupied(dR["MAPHG"].ToString(), dR["MALOAIPHG"].ToString(), dR["DONDEP"].ToString(), dR["TRANGTHAI"].ToString(), dR["TANG"].ToString(), dR["CHECKEDIN"].ToString());
        //                rooms.Add(roomO);
        //            }
        //        }
        //    }
        //}
        #endregion
        #region DataSetter
        private void RefreshDataSet()
        {
            try
            {
                query = "select A.MAPHG, MALOAIPHG, DONDEP, TRANGTHAI, TANG, GHICHU, CTPHG.MAHD, CHECKEDIN, CHECKEDOUT, NGNHANPHG, NGTRPHG " +
                         "from PHONG A " +
                         "left join CTPHG on A.MAPHG = CTPHG.MAPHG " +
                         "left join HOADON on CTPHG.MAHD = HOADON.MAHD ";
                dS = fn.getData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PopulateList(int criterion = 0)
        {
            int roomFlag = 0;
            string tRoomID = "";
            rooms.Clear();
            if (criterion == 1)
            {
                RefreshDataSet();
            }
            DataRowCollection dRT = dS.Tables[0].Rows;
            for (int i = 0; i < dRT.Count; i++)
            {
                if (dRT[i]["MAPHG"].ToString() != tRoomID)
                {
                    roomFlag = 0;
                }
                else if (roomFlag == 1)
                {
                    continue;
                }
                tRoomID = dRT[i]["MAPHG"].ToString();
                if (dRT[i]["TRANGTHAI"].ToString() == "Bảo trì")
                {
                    UC_RoomUnitMaintenance roomM = new UC_RoomUnitMaintenance(dRT[i]["MAPHG"].ToString(), dRT[i]["MALOAIPHG"].ToString(), dRT[i]["DONDEP"].ToString(), dRT[i]["TRANGTHAI"].ToString(),  dRT[i]["TANG"].ToString(), dRT[i]["GHICHU"].ToString());
                    rooms.Add(roomM);
                    roomFlag = 1;
                }
                else if (dRT[i]["NGNHANPHG"] != DBNull.Value && dRT[i]["NGTRPHG"] != DBNull.Value)
                {
                    if (Convert.ToDateTime(dRT[i]["NGNHANPHG"]) < searchTime && Convert.ToDateTime(dRT[i]["NGTRPHG"]) > searchTime && dRT[i]["CHECKEDOUT"].ToString() == "False")
                    {
                        if (dRT[i]["CHECKEDIN"].ToString() == "True")
                        {
                            UC_RoomUnitOccupied roomO = new UC_RoomUnitOccupied(dRT[i]["MAPHG"].ToString(), dRT[i]["MALOAIPHG"].ToString(), dRT[i]["DONDEP"].ToString(), dRT[i]["TRANGTHAI"].ToString(), dRT[i]["TANG"].ToString(), dRT[i]["MAHD"].ToString(),dRT[i]["GHICHU"].ToString(),  dRT[i]["CHECKEDIN"].ToString(), dRT[i]["NGNHANPHG"].ToString(), dRT[i]["NGTRPHG"].ToString());
                            rooms.Add(roomO);
                            roomFlag = 1;
                        }
                        else
                        {
                            UC_RoomUnitBooked roomB = new UC_RoomUnitBooked(dRT[i]["MAPHG"].ToString(), dRT[i]["MALOAIPHG"].ToString(), dRT[i]["DONDEP"].ToString(), dRT[i]["TRANGTHAI"].ToString(), dRT[i]["TANG"].ToString(), dRT[i]["MAHD"].ToString(),dRT[i]["GHICHU"].ToString(),  dRT[i]["CHECKEDIN"].ToString(), dRT[i]["NGNHANPHG"].ToString(), dRT[i]["NGTRPHG"].ToString());
                            rooms.Add(roomB);
                            roomFlag = 1;
                        }
                    }
                }
                else
                {
                    UC_RoomUnitAvailable roomA = new UC_RoomUnitAvailable(dRT[i]["MAPHG"].ToString(), dRT[i]["MALOAIPHG"].ToString(), dRT[i]["DONDEP"].ToString(), dRT[i]["TRANGTHAI"].ToString(), dRT[i]["TANG"].ToString(), dRT[i]["GHICHU"].ToString());
                    roomA.CheckInStatus = "N/a";
                    rooms.Add(roomA);
                    roomFlag = 1;
                }
                if (i < dRT.Count - 1 && dRT[i + 1]["MAPHG"].ToString() != tRoomID && roomFlag == 0)
                {
                    UC_RoomUnitAvailable roomA = new UC_RoomUnitAvailable(dRT[i]["MAPHG"].ToString(), dRT[i]["MALOAIPHG"].ToString(), dRT[i]["DONDEP"].ToString(), dRT[i]["TRANGTHAI"].ToString(), dRT[i]["TANG"].ToString(), dRT[i]["GHICHU"].ToString());
                    roomA.CheckInStatus = "N/a";
                    rooms.Add(roomA);
                    roomFlag = 1;
                }
            }
        }
        #endregion
        #region RadioButtonCheck prerequisites
        private void LoadRoomEmpty()
        {
            rooms = rooms.Where(r => r.RoomStatus == "Bình thường" && r.CheckInStatus == "N/a").ToList();
        }
        private void LoadRoomManitenance()
        {
            rooms = rooms.Where(r => r.RoomStatus == "Bảo trì").ToList();
        }
        private void LoadRoomBooked()
        {
            rooms = rooms.Where(r => r.RoomStatus == "Không trống" && r.CheckInStatus == "False").ToList();
        }
        private void LoadRoomOccupied()
        {
            rooms = rooms.Where(r => r.RoomStatus == "Không trống" && r.CheckInStatus == "True").ToList();
        }
        private void LoadRoomStatus()
        {
            foreach (Guna2RadioButton rBT in gBRoomStatusFilter.Controls)
            {
                if (rBT.Checked)
                {
                    if (rBT == rBTEmpty)
                    {
                        LoadRoomEmpty();
                    }
                    else if (rBT == rBTMaintenance)
                    {
                        LoadRoomManitenance();
                    }
                    else if (rBT == rBTBooked)
                    {
                        LoadRoomBooked();
                    }
                    else if (rBT == rBTOccupied)
                    {
                        LoadRoomOccupied();
                    }
                }
            }
        }
        private void LoadRoomVIP()
        {
            rooms = rooms.Where(r => r.RoomTypeID == "LP01").ToList();
        }
        private void LoadRoomDeluxed()
        {
            rooms = rooms.Where(r => r.RoomTypeID == "LP02").ToList();
        }
        private void LoadRoomStandard()
        {
            rooms = rooms.Where(r => r.RoomTypeID == "LP03").ToList();
        }
        private void LoadRoomEconomy()
        {
            rooms = rooms.Where(r => r.RoomTypeID == "LP04").ToList();
        }
        private void LoadRoomType()
        {
            foreach (Guna2RadioButton rBT in gBRoomTypeFilter.Controls)
            {
                if (rBT.Checked)
                {
                    if (rBT == rBTVIP)
                    {
                        LoadRoomVIP();
                    }
                    else if (rBT == rBTDeluxed)
                    {
                        LoadRoomDeluxed();
                    }
                    else if (rBT == rBTStandard)
                    {
                        LoadRoomStandard();
                    }
                    else if (rBT == rBTEconomy)
                    {
                        LoadRoomEconomy();
                    }
                }
            }
        }
        private void LoadRoomClean()
        {
            rooms = rooms.Where(r => r.CleanStatus == "Đã dọn").ToList();
        }
        private void LoadRoomUnclean()
        {
            rooms = rooms.Where(r => r.CleanStatus == "Chưa dọn").ToList();
        }
        private void LoadRoomCleanStatus()
        {
            foreach (Guna2RadioButton rBT in gBCleanStatusFilter.Controls)
            {
                if (rBT.Checked)
                {
                    if (rBT == rBTClean)
                    {
                        LoadRoomClean();
                    }
                    else if (rBT == rBTUnclean)
                    {
                        LoadRoomUnclean();
                    }
                }
            }
        }
        #endregion
        private void Filter_Changed(object sender, EventArgs e)
        {
            PopulateList();
            LoadRoomStatus();
            LoadRoomType();
            LoadRoomCleanStatus();
            PopulateGrid();
        }
        #region Micellaneous
        private void PanelControlAdd(object sender, ControlEventArgs e)
        {
            //FlowLayoutPanel panel = sender as FlowLayoutPanel;
            //if (panel.Controls.Count % 3 == 0)
            //{
            //    panel.SetFlowBreak(e.Control as Control, true);
            //}
        }
        void TableLayoutPanelScrollbars()
        {
            tLPFloors.HorizontalScroll.Maximum = 0;
            tLPFloors.AutoScroll = false;
            tLPFloors.VerticalScroll.Visible = false;
            tLPFloors.AutoScroll = true;
        }
        #endregion

        private void dTPFilter_ValueChanged(object sender, EventArgs e)
        {
            //DO NOT debug by setting breakpoints in this method!!!!
            searchTime = dTPFilter.Value;
            tBSearch.Text = dTPFilter.Text;
            guna2TextBox1.Text = dS.Tables[0].Rows[0]["NGNHANPHG"].ToString();
            guna2TextBox2.Text = dS.Tables[0].Rows[0]["NGTRPHG"].ToString();
            guna2TextBox3.Text = (Convert.ToDateTime(dS.Tables[0].Rows[0]["NGNHANPHG"]) < searchTime && Convert.ToDateTime(dS.Tables[0].Rows[0]["NGTRPHG"]) > searchTime).ToString();
            PopulateList();
            LoadRoomStatus();
            LoadRoomType();
            LoadRoomCleanStatus();
            PopulateGrid();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
