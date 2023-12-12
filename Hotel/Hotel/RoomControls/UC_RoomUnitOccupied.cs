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
        public UC_RoomUnitOccupied(string roomID, string roomTypeID, string cleanStatus, string roomStatus, string floor) : base(roomID, roomTypeID, cleanStatus, roomStatus, floor)
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
        private void UC_RoomUnitOccupied_Click(object sender, EventArgs e)
        {
            rFn.UnitClick(roomID);
        }

        #endregion
    }
}