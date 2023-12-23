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
    public partial class UC_RoomUnitOccupied : UC_RoomUnitBase
    {
        RoomFunction rFn = new RoomFunction();
        DataSet dS = new DataSet();
        public UC_RoomUnitOccupied()
        {
            InitializeComponent();
        }
        public UC_RoomUnitOccupied(string roomID, string roomTypeID, string cleanStatus, string roomStatus, string floor, string note, string reservationID, string checkInDate, string checkOutDate, string checkInDateActual, string checkOutDateActual) : base(roomID, roomTypeID, cleanStatus, roomStatus, floor, reservationID, note, checkInDate, checkOutDate, checkInDateActual, checkOutDateActual)
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
        private void UC_RoomUnitOccupied_Click(object sender, EventArgs e)
        {
            rFn.UnitClick(this);
        }

        #endregion
    }
}