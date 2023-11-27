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
    

    public partial class UC_Addroom : UserControl
    {
        function fn = new function();
        string query;
        public UC_Addroom()
        {
            InitializeComponent();
        }

        private void UC_Addroom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btAddRoom_Click(object sender, EventArgs e)
        {
            if(txtRoomNumber.Text !="" && cbRoomType.Text!="" && cbBed.Text != "" && txtPrice.Text != "")
            {
                string roomno = txtRoomNumber.Text;
                string type = cbRoomType.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                string bed = cbBed.Text;
                query = "insert into rooms (roomNo, roomType, bed, price) values('"+roomno+"','"+type+"','"+bed+"',"+price+")";
                fn.setData(query, "Đã thêm phòng");
                UC_Addroom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Xin vui lòng điền đầy đủ thông tin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAll()
        {
            txtRoomNumber.Clear();
            cbRoomType.SelectedIndex = -1;
            cbBed.SelectedIndex =-1;
            txtPrice.Clear();
        }

        private void UC_Addroom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btAddRoom_Enter(object sender, EventArgs e)
        {

        }

        private void UC_Addroom_Enter(object sender, EventArgs e)
        {
            UC_Addroom_Load(this, null);
        }
    }
}
