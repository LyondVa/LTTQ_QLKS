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
    public partial class UC_RoomUnitBase : UserControl
    {
        protected string roomID, roomTypeID, cleanStatus, roomStatus, floor;
        public UC_RoomUnitBase()
        {
            InitializeComponent();
        }
        public UC_RoomUnitBase(string roomID, string roomTypeID, string cleanStatus, string roomStatus, string floor)
        {
            InitializeComponent();
            this.roomID = roomID;
            this.roomTypeID = roomTypeID;
            this.cleanStatus = cleanStatus;
            this.roomStatus = roomStatus;
            this.floor = floor;
        }
        public string GetFloor()
        {
            return floor;
        }
    }
}
