﻿using Hotel.Properties;
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
    public partial class UC_RoomUnitBooked : UC_RoomUnitBase
    {
        RoomFunction rFn = new RoomFunction();
        function fn = new function();
        DataSet dS = new DataSet();
        string query;
        public UC_RoomUnitBooked()
        {
            InitializeComponent();
        }
        public UC_RoomUnitBooked(string roomID, string roomTypeID, string cleanStatus, string roomStatus, string floor,string note, string reservationID, string checkInStatus, string checkInDate, string checkOutDate) : base(roomID, roomTypeID, cleanStatus, roomStatus, floor, reservationID, note, checkInStatus, checkInDate, checkOutDate)
        {
            InitializeComponent();
            SetSpace(checkInDate, this.checkOutDate);
            this.lBRoomID.Text = roomID;
            this.lBRoomTypeID.Text = roomTypeID;
            if (cleanStatus == "Đã dọn")
            {
                pBCleanStatus.Image = Resources.CleanIcon;
            }
            else
            {
                pBCleanStatus.Image = Resources.UncleanIcon;
            }
        }
        private void SetSpace(string checkInDate, string checkOutDate)
        {
            query = "select KHOTEN from KHACHHANG, HOADON where KHACHHANG.MAKH = HOADON.MAKH and MAHD = '" + reservationID + "'";
            dS = fn.getData(query);
            lbSpace.Text = dS.Tables[0].Rows[0][0].ToString() + "\n" + checkInDate.Substring(0, 10) + "\n" + checkOutDate.Substring(0, 10);
        }
        #region Unit Click
        private void UC_RoomUnitBooked_Click(object sender, EventArgs e)
        {
            rFn.UnitClick(this);
        }
        #endregion
    }
}
