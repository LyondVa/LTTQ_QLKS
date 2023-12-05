using Hotel.RoomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.All_user_control
{
    public partial class UC_RoomManagement : UserControl
    {
        string query;
        function fn = new function();
        DataSet ds = new DataSet();
        public UC_RoomManagement()
        {
            InitializeComponent();
        }
        private void UC_RoomManagement_Load(object sender, EventArgs e)
        {            
            query = "select * from rooms";
            ds = fn.getData(query);
            dGVRoom.DataSource = ds.Tables[0];
        }

        private void tSLAdd_Click(object sender, EventArgs e)
        {
            F_AddRoom form = new F_AddRoom();
            form.Show();
        }

        private void tSLUpdate_Click(object sender, EventArgs e)
        {
            F_UpdateRoom form = new F_UpdateRoom();
            form.Show();
        }

        private void tSLDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
