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
        public UC_RoomGrid()
        {
            InitializeComponent();
            EventHub.DatabaseUpdated += PopulateGrid;
        }

        private void PopulateGrid()
        {
            rooms.Clear();
            RefreshDataSet();
            foreach (DataRow dR in dS.Tables[0].Rows)
            {
                if (dR["TRANGTHAI"].ToString() == "Trống")
                {
                    UC_RoomUnitAvailable roomA = new UC_RoomUnitAvailable(dR["MAPHG"].ToString(), dR["MALOAIPHG"].ToString(), dR["DONDEP"].ToString(), dR["TRANGTHAI"].ToString(), dR["TANG"].ToString());
                    rooms.Add(roomA);
                }
                else if (dR["TRANGTHAI"].ToString() == "Bảo trì")
                {
                    UC_RoomUnitMaintenance roomM = new UC_RoomUnitMaintenance(dR["MAPHG"].ToString(), dR["MALOAIPHG"].ToString(), dR["DONDEP"].ToString(), dR["TRANGTHAI"].ToString(), dR["TANG"].ToString());
                    rooms.Add(roomM);
                }
                else if (dR["TRANGTHAI"].ToString() == "Không trống")
                {
                    if (dR["CHECKEDIN"].ToString() == "0")
                    {
                        UC_RoomUnitBooked roomB = new UC_RoomUnitBooked(dR["MAPHG"].ToString(), dR["MALOAIPHG"].ToString(), dR["DONDEP"].ToString(), dR["TRANGTHAI"].ToString(), dR["TANG"].ToString());
                        rooms.Add(roomB);
                    }
                    else
                    {
                        UC_RoomUnitOccupied roomO = new UC_RoomUnitOccupied(dR["MAPHG"].ToString(), dR["MALOAIPHG"].ToString(), dR["DONDEP"].ToString(), dR["TRANGTHAI"].ToString(), dR["TANG"].ToString());
                        rooms.Add(roomO);
                    }
                }
            }
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

        private void RefreshDataSet()
        {

            try
            {
                query =  "select A.MAPHG, MALOAIPHG, DONDEP, TRANGTHAI, CHECKEDIN, TANG, KHOTEN, NHOTEN " +
                         "from PHONG A " +
                         "left join CTPHG on A.MAPHG = CTPHG.MAPHG " +
                         "left join HOADON on CTPHG.MAHD = HOADON.MAHD " +
                         "left join KHACHHANG on HOADON.MAKH = KHACHHANG.MAKH " +
                         "left join NHANVIEN on HOADON.MANV = NHANVIEN.MANV " +
                         "union " +
                         "select A.MAPHG, MALOAIPHG, DONDEP, TRANGTHAI, CHECKEDIN, TANG, KHOTEN, NHOTEN " +
                         "from PHONG A " +
                         "left join CTPHG on A.MAPHG = CTPHG.MAPHG " +
                         "left join HOADON on CTPHG.MAHD = HOADON.MAHD " +
                         "left join KHACHHANG on HOADON.MAKH = KHACHHANG.MAKH " +
                         "left join NHANVIEN on HOADON.MANV = NHANVIEN.MANV " +
                         "where HOADON.MAHD = ( " +
                                             "select top 1 HOADON.MAHD " +
                                             "from HOADON " +
                                             "inner join CTPHG on CTPHG.MAHD = HOADON.MAHD " +
                                             "where A.MAPHG = CTPHG.MAPHG " +
                                             "order by MAHD desc " +
                                             ")";
                dS = fn.getData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PanelControlAdd(object sender, ControlEventArgs e)
        {
            FlowLayoutPanel panel = sender as FlowLayoutPanel;
            if (panel.Controls.Count % 3 == 0)
            {
                panel.SetFlowBreak(e.Control as Control, true);
            }
        }
        private void UC_RoomGrid_load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
