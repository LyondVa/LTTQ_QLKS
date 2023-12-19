using Hotel.All_user_control;
using Hotel.Properties;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.RoomControls
{
    public partial class F_BookRoom : Form
    {
        DataSet dSA = new DataSet();
        DataSet dSS = new DataSet();
        DataSet dSC = new DataSet();
        function fn = new function();
        RoomFunction rFn = new RoomFunction();
        #region Query
        string query;
        string checkInDate, checkOutDate;   
        //string queryR = "select A.MAPHG, MALOAIPHG, DONDEP, TRANGTHAI, CHECKEDIN, TANG, KHOTEN, NHOTEN " +
        //                 "from PHONG A " +
        //                 "left join CTPHG on A.MAPHG = CTPHG.MAPHG " +
        //                 "left join HOADON on CTPHG.MAHD = HOADON.MAHD " +
        //                 "left join KHACHHANG on HOADON.MAKH = KHACHHANG.MAKH " +
        //                 "left join NHANVIEN on HOADON.MANV = NHANVIEN.MANV " +
        //                 "where TRANGTHAI = N'Trống' "+
        //                 "union " +
        //                 "select A.MAPHG, MALOAIPHG, DONDEP, TRANGTHAI, CHECKEDIN, TANG, KHOTEN, NHOTEN " +
        //                 "from PHONG A " +
        //                 "left join CTPHG on " +
        //                 "A.MAPHG = CTPHG.MAPHG " +
        //                 "left join HOADON on CTPHG.MAHD = HOADON.MAHD " +
        //                 "left join KHACHHANG on HOADON.MAKH = KHACHHANG.MAKH " +
        //                 "left join NHANVIEN on HOADON.MANV = NHANVIEN.MANV " +
        //                 "where HOADON.MAHD = ( " +
        //                                     "select top 1 HOADON.MAHD " +
        //                                     "from HOADON " +
        //                                     "inner join CTPHG on CTPHG.MAHD = HOADON.MAHD " +
        //                                     "where A.MAPHG = CTPHG.MAPHG " +
        //                                     "and TRANGTHAI = N'Trống' " +
        //                                     "order by MAHD desc " +
        //                                     ")";

        string queryC = "select KCCCD, KHOTEN from KHACHHANG";
        #endregion
        public F_BookRoom()
        {
            InitializeComponent();
            dSS.Tables.Add();
            dSS.Tables[0].Columns.Add("MAPHG", typeof(string));
            dSS.Tables[0].Columns.Add("MALOAIPHG", typeof(string));
            dTPCheckInDate.MinDate = DateTime.Now;
            dTPCheckOutDate.MinDate = DateTime.Now.AddDays(1);
            checkInDate = dTPCheckInDate.Value.ToString(Global.dateFormat).Substring(0, 10) + " 14:00:00";
            checkOutDate = dTPCheckOutDate.Value.ToString(Global.dateFormat).Substring(0, 10) + " 12:00:00";
            InitializeGridViews();
        }
        private void InitializeGridViews()
        {
            DGVLoad();

            //dGVAvailableRoom.AutoGenerateColumns = false;
            //dGVAvailableRoom.ColumnCount = 2;

            //dGVAvailableRoom.Columns[0].Name = "MAPHG";
            dGVAvailableRoom.Columns[0].HeaderText = "Mã phòng";
            //dGVAvailableRoom.Columns[0].DataPropertyName = "MAPHG";

            //dGVAvailableRoom.Columns[1].Name = "MALOAIPHG";
            dGVAvailableRoom.Columns[1].HeaderText = "Mã loại phòng";
            //dGVAvailableRoom.Columns[1].DataPropertyName = "MALOAIPHG";

            DataGridViewImageColumn dGVARImgCol = new DataGridViewImageColumn();
            dGVARImgCol.Name = "ADD";
            dGVARImgCol.HeaderText = "Thêm";
            dGVARImgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dGVARImgCol.Image = Resources.PlusMark;
            dGVAvailableRoom.Columns.Insert(2, dGVARImgCol);
            //DGVImageColumnIni();

            dGVSelectedRoom.AutoGenerateColumns = false;
            dGVSelectedRoom.ColumnCount = 2;

            dGVSelectedRoom.Columns[0].Name = "MAPHG";
            dGVSelectedRoom.Columns[0].HeaderText = "MÃ phòng";
            dGVSelectedRoom.Columns[0].DataPropertyName = "MAPHG";

            dGVSelectedRoom.Columns[1].Name = "MALOAIPHG";
            dGVSelectedRoom.Columns[1].HeaderText = "Mã loại phòng";
            dGVSelectedRoom.Columns[1].DataPropertyName = "MALOAIPHG";

            DataGridViewImageColumn dGVSRImgCol = new DataGridViewImageColumn();
            dGVSRImgCol.Name = "REMOVE";
            dGVSRImgCol.HeaderText = "Xóa";
            dGVSRImgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dGVSRImgCol.Image = Resources.CrossMark;
            dGVSelectedRoom.Columns.Insert(2,dGVSRImgCol);

            dGVSelectedRoom.DataSource = dSS.Tables[0];
        }
        private void DGVLoad()
        {
            string queryR = "select distinct p.MAPHG , MALOAIPHG " +
                            "from PHONG p " +
                            "left join CTPHG c on p.MAPHG = c.MAPHG " +
                            "left join HOADON d on c.MAHD = d.MAHD " +
                            "where c.MAPHG is null or d.NGNHANPHG > '" + checkOutDate + "' or d.NGTRPHG < '" + checkInDate + "'";
            dSA = fn.getData(queryR);
            dGVAvailableRoom.DataSource = dSA.Tables[0];
            dSS.Tables[0].Rows.Clear();
        }
        private void bTExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void DGVImageColumnIni()
        //{
        //    for(int i = 0;i<dGVAvailableRoom.Rows.Count;i++) 
        //    {
        //        ((DataGridViewImageCell)dGVAvailableRoom.Rows[i].Cells["ADD"]).Value = Resources.PlusMark;
        //    }
        //}
        private void dGVAvailableRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dGVAvailableRoom.Columns["ADD"].Index && e.RowIndex >= 0)
            {
                DataRow dR = dSS.Tables[0].NewRow();
                dR["MAPHG"] = dGVAvailableRoom.Rows[e.RowIndex].Cells["MAPHG"].Value.ToString();
                dR["MALOAIPHG"] = dGVAvailableRoom.Rows[e.RowIndex].Cells["MALOAIPHG"].Value.ToString();
                dGVAvailableRoom.Rows.RemoveAt(e.RowIndex);
                dSS.Tables[0].Rows.Add(dR);
                dGVSelectedRoom.Sort(dGVSelectedRoom.Columns["MAPHG"], ListSortDirection.Ascending);
            }
        }
        private void dGVSelectedRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dGVSelectedRoom.Columns["REMOVE"].Index && e.RowIndex >= 0)
            {
                DataRow dR = dSA.Tables[0].NewRow();
                dR["MAPHG"] = dGVSelectedRoom.Rows[e.RowIndex].Cells["MAPHG"].Value.ToString();
                dR["MALOAIPHG"] = dGVSelectedRoom.Rows[e.RowIndex].Cells["MALOAIPHG"].Value.ToString();
                dGVSelectedRoom.Rows.RemoveAt(e.RowIndex);
                dSA.Tables[0].Rows.Add(dR);
                dGVAvailableRoom.Sort(dGVAvailableRoom.Columns["MAPHG"], ListSortDirection.Ascending);
            }
        }
        private void bTAdd_Click(object sender, EventArgs e)
        {
            DataSet dSTemp1 = new DataSet();
            DataSet dSTemp2 = new DataSet();
            query = "SELECT MAKH FROM KHACHHANG WHERE KCCCD = '" + tBClientID.Text + "'";
            dSTemp1 = fn.getData(query);
            if (dSTemp1.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin khách hàng");
                return;
            }
            query = "INSERT INTO HOADON(MAKH, MANV, NGNHANPHG, NGTRPHG) VALUES ('" + dSTemp1.Tables[0].Rows[0]["MAKH"].ToString() + "','" + Global.globalEmID +"','" + checkInDate + "','" + checkOutDate +"')";
            fn.setDataNoMsg(query);
            query = "SELECT TOP 1 MAHD " +
                    "FROM HOADON " +
                    "INNER JOIN KHACHHANG ON KHACHHANG.MAKH = HOADON.MAKH " +
                    "WHERE KCCCD = '" + tBClientID.Text + "' " +
                    "ORDER BY MAHD DESC";
            dSTemp2 = fn.getData(query);
            foreach (DataRow dR in dSS.Tables[0].Rows)
            {
                query = "INSERT INTO CTPHG(MAPHG, MAHD, TIENDATPHG) VALUES ('" + dR["MAPHG"].ToString() + "','" + dSTemp2.Tables[0].Rows[0]["MAHD"].ToString()+ "'," + 7000 + ")";
                fn.setDataNoMsg(query);
            }
            EventHub.OnDatabaseUpdated();
            this.Close();
        }

        private void tBClientID_TextChanged(object sender, EventArgs e)
        {
            dSC = fn.getData(queryC);
            tBClientName.Text = "";
            DataRow[] dR = rFn.FindInDataset(dSC, tBClientID.Text, "KCCCD");
            if (tBClientID.Text.Length > 0)
            {
                if (dR != null)
                {
                    tBClientName.Text = dR[0]["KHOTEN"].ToString();
                    bTClientRegistration.Enabled = false;
                }
            }
        }

        private void bTClientRegistration_Click(object sender, EventArgs e)
        {
            Form cusResForm = new Form();
            UC_CustomerRes customerRes = new UC_CustomerRes(tBClientID.Text);
            cusResForm.Size = new System.Drawing.Size(1050, 650);
            cusResForm.Text = "Thêm khách hàng";
            cusResForm.Controls.Add(customerRes);
            cusResForm.Controls[0].Dock = DockStyle.Fill;
            cusResForm.Show();
            cusResForm.Focus();
            //query = 
        }

        private void dTPCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            checkInDate = dTPCheckInDate.Value.ToString(Global.dateFormat).Substring(0, 10) + " 14:00:00";
            dTPCheckOutDate.MinDate = dTPCheckInDate.Value;
            if (dTPCheckInDate.Value >= dTPCheckOutDate.Value)
            {
                dTPCheckOutDate.Value = dTPCheckInDate.Value.AddDays(1);
            }
            DGVLoad();
        }

        private void dTPCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            checkOutDate = dTPCheckOutDate.Value.ToString(Global.dateFormat).Substring(0, 10) + " 12:00:00";
            DGVLoad();
        }
    }
}
