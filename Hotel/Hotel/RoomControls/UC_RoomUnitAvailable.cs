using Hotel.Properties;
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
    public partial class UC_RoomUnitAvailable : UC_RoomUnitBase
    {
        RoomFunction rFn = new RoomFunction();
        DataSet dS = new DataSet();
        public UC_RoomUnitAvailable()
        {
            InitializeComponent();
        }
        public UC_RoomUnitAvailable(string roomID, string roomTypeID, string cleanStatus, string roomStatus, string floor, string note) : base(roomID, roomTypeID, cleanStatus, roomStatus, floor, note)
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
            //pBRoomStatus.Image = imageList[1];
        }
        #region Unit Click
        private void UC_RoomUnitAvailable_Click(object sender, EventArgs e)
        {
            rFn.UnitClick(this);
        }
        #endregion

    }
}
