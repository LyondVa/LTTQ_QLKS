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
        public UC_RoomUnitBooked()
        {
            InitializeComponent();
        }
        #region Unit Click
        private void UC_RoomUnitBooked_Click(object sender, EventArgs e)
        {
            rFn.UnitClick();
        }
        #endregion
    }
}
