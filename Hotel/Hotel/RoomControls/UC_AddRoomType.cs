using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.All_user_control
{
    public partial class UC_AddRoomType : UserControl
    {
        function fn = new function();
        public UC_AddRoomType()
        {
            InitializeComponent();
        }

        private void bTAdd_Click(object sender, EventArgs e)
        {
            string query = "insert into LOAIPHONG values ('" + tBRoomTypeID.Text + "','" + tBRoomTypeName.Text + "'," + Convert.ToInt16(tBPricePerNight.Text) + ","+ Convert.ToUInt16(dUDCapacity.Text) + "," + Convert.ToInt16(dUDBedNumber.Text) +")";
            string message = "Thêm thành công";
            fn.setData(query, message);
        }
    }
}
