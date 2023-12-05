using System;
using System.Collections;
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
    public partial class F_UpdateRoom : Form
    {
        string query;
        function fn = new function();
        public F_UpdateRoom()
        {
            InitializeComponent();
        }

        private void bTExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bTUpdate_Click(object sender, EventArgs e)
        {
            if (tBRoomID.Text == "" || tBRoomType.Text == "" || textBox.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tất cả các trường", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                query = "update rooms set roomNo = '" + textBox.Text + "',roomType = '" + tBRoomType.Text + "',bed='" + textBox3.Text + "',price='" + textBox4.Text + "',booked='" + textBox5.Text + "' where roomid='" + tBRoomID.Text + "'";
                string msg = "Cập nhật Thành công";
                fn.setData(query, msg);
            }
        }
    }
}
