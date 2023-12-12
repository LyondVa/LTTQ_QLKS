﻿using Hotel.Properties;
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
        string queryR = "select A.MAPHG, MALOAIPHG, DONDEP, TRANGTHAI, CHECKEDIN, TANG, KHOTEN, NHOTEN " +
                         "from PHONG A " +
                         "left join CTPHG on A.MAPHG = CTPHG.MAPHG " +
                         "left join HOADON on CTPHG.MAHD = HOADON.MAHD " +
                         "left join KHACHHANG on HOADON.MAKH = KHACHHANG.MAKH " +
                         "left join NHANVIEN on HOADON.MANV = NHANVIEN.MANV " +
                         "union " +
                         "select A.MAPHG, MALOAIPHG, DONDEP, TRANGTHAI, CHECKEDIN, TANG, KHOTEN, NHOTEN " +
                         "from PHONG A " +
                         "left join CTPHG o" +
                         "n A.MAPHG = CTPHG.MAPHG " +
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
        string queryC = "select KCCCD, KHOTEN from KHACHHANG";
        #endregion
        public F_BookRoom()
        {
            InitializeComponent();
            dSA = fn.getData(queryR);
            dSS.Tables.Add();
            dSS.Tables[0].Columns.Add("MAPHG", typeof(string));
            dSS.Tables[0].Columns.Add("MALOAIPHG", typeof(string));
            dSC = fn.getData(queryC);
            InitializeGridViews();
        }
        private void InitializeGridViews()
        {
            dGVAvailableRoom.AutoGenerateColumns = false;
            dGVAvailableRoom.ColumnCount = 2;

            dGVAvailableRoom.Columns[0].Name = "MAPHG";
            dGVAvailableRoom.Columns[0].HeaderText = "Mã phòng";
            dGVAvailableRoom.Columns[0].DataPropertyName = "MAPHG";

            dGVAvailableRoom.Columns[1].Name = "MALOAIPHG";
            dGVAvailableRoom.Columns[1].HeaderText = "Mã loại phòng";
            dGVAvailableRoom.Columns[1].DataPropertyName = "MALOAIPHG";

            DataGridViewImageColumn dGVARImgCol = new DataGridViewImageColumn();
            dGVARImgCol.Name = "ADD";
            dGVARImgCol.HeaderText = "Thêm";
            dGVAvailableRoom.Columns.Add(dGVARImgCol);

            dGVAvailableRoom.DataSource = dSA.Tables[0];

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
            dGVSelectedRoom.Columns.Add(dGVSRImgCol);
            dGVSelectedRoom.DataSource = dSS.Tables[0];
        }
        private void dGVAvailableRoom_RowAdded(object sender, DataGridViewRowEventArgs e)
        {
            for(int row = 0; row <= dGVAvailableRoom.Rows.Count - 1; row++)
            {
                ((DataGridViewImageCell)dGVAvailableRoom.Rows[row].Cells[2]).Value = Resources.PlusMark;
            }
        }
        
        private void bTExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
            query = 
        }

        private void tBClientID_TextChanged(object sender, EventArgs e)
        {
            tBClientName.Clear();
            DataRow[] dR = rFn.FindInDataset(dSC, tBClientID.Text, "KCCCD");
            if (tBClientID.Text.Length > 0)
            {
                if ( dR != null)
                {
                    tBClientName.Text = dR[0]["KHOTEN"].ToString();
                }
            }
        }
    }
}
