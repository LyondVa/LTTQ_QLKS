using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class DTB : Form
    {
        function fn = new function();
        public DTB()
        {
            InitializeComponent();
            
        }

        private void btAccess_Click(object sender, EventArgs e)
        {
            if (tbDTB.Text != "")
            {
                fn.dtbName = tbDTB.Text.Trim();
                if (fn.TestConnection() == 0)
                {
                    MessageBox.Show("Không thể kết nối đến CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
