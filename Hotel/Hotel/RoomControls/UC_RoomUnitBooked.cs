using Hotel.Properties;
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
        DataSet dS = new DataSet();
        public UC_RoomUnitBooked()
        {
            InitializeComponent();
        }
        public UC_RoomUnitBooked(string roomID, string roomTypeID, string cleanStatus, string roomStatus, string floor,string note, string reservationID, string checkInStatus, string checkInDate, string checkOutDate) : base(roomID, roomTypeID, cleanStatus, roomStatus, floor, reservationID, note, checkInStatus, checkInDate, checkOutDate)
        {
            InitializeComponent();
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
        #region Unit Click
        private void UC_RoomUnitBooked_Click(object sender, EventArgs e)
        {
            rFn.UnitClick(this);
        }
        #endregion
    }
}
