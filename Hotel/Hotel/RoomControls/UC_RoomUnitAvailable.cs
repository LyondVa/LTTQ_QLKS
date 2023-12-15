﻿using System;
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
    public partial class UC_RoomUnitAvailable : UC_RoomUnitBase
    {
        RoomFunction rFn = new RoomFunction();
        DataSet dS = new DataSet();
        public UC_RoomUnitAvailable()
        {
            InitializeComponent();
        }
        public UC_RoomUnitAvailable(string roomID, string roomTypeID, string cleanStatus, string roomStatus, string floor, string checkInStatus, string checkInDate = "", string checkOutDate ="") : base(roomID, roomTypeID, cleanStatus, roomStatus, floor, checkInStatus, checkInDate, checkOutDate)
        {
            InitializeComponent();
            this.lBRoomID.Text = roomID;
            this.lBRoomTypeID.Text = roomTypeID;
            if (cleanStatus == "Đã dọn")
            {
                pBCleanStatus.Image = imageList[0];
            }
            else
            {
                pBCleanStatus.Image = imageList[1];
            }
        }
        #region Unit Click
        private void UC_RoomUnitAvailable_Click(object sender, EventArgs e)
        {
            rFn.UnitClick(this);
        }
        #endregion

    }
}
