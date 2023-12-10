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
    public partial class UC_RoomGrid : UserControl
    {
        DataSet dS = new DataSet();
        string query;
        //List<>
        public UC_RoomGrid()
        {
            InitializeComponent();
        }

        private void PopulateGrid()
        {

        }

        private void RefreshDataSet()
        {

            try
            {
                query = "select MAPHG, MALOAIPHG, DONDEP, TRANGTHAI,  " +
                        "from ";
            }
            catch(Exception ex) { }
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
