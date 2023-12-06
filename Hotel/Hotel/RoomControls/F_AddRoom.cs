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
    public partial class F_AddRoom : Form
    {
        string query;
        function fn = new function();
        public F_AddRoom()
        {
            InitializeComponent();
        }

        private void bTExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bTAdd_Click(object sender, EventArgs e)
        {
            if(tBRoomID.Text == "" || tBRoomType.Text == "" || textBox.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tất cả các trường", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                query = "insert into rooms values(/*'" + tBRoomID.Text + "',*/'" + textBox.Text + "','" + tBRoomType.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                string msg = "Thêm Thành công";
                fn.setData(query, msg);
            }
        }
    }
}
