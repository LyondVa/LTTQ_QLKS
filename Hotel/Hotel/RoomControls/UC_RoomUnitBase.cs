using Hotel.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.RoomControls
{
    public partial class UC_RoomUnitBase : UserControl
    {
        protected string roomID, roomTypeID, cleanStatus, roomStatus, floor;
        protected List<Image> imageList = new List<Image>();
        private void UC_RoomUnitBase_Load(object sender, EventArgs e)
        {
            this.Invalidate();
        }

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
            imageList.Add(Resources.CheckMark);
            imageList.Add(Resources.CrossMark);
        }
        public string GetFloor()
        {
            return floor;
        }
    }
}
