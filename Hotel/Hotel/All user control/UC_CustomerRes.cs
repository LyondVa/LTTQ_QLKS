using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.All_user_control
{
    public partial class UC_CustomerRes : UserControl
    {
        function fn = new function();
        string query;
        public UC_CustomerRes()
        {
            InitializeComponent();
        }

        public void setComboBox(String query,ComboBox cb)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for(int i=0;i<sdr.FieldCount;i++)
                {
                    cb.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        
        public void clearAll()
        {
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtNationality.Clear();
            txtPhoneNumber.Clear();
            txtName.Clear();
            txtBirth.ResetText();
            txtChecking.ResetText();
            txtIDProof.Clear();
            txtPrice.Clear();
            cbBed.SelectedItem = -1;
            cbGender.SelectedItem = -1;
            cbRoomNum.Items.Clear();
            cbRoomType.SelectedItem = -1;

        }

        private void cbBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRoomType.SelectedIndex = -1;
            cbRoomNum.Items.Clear();
            txtPrice.Clear();
        }
        int rid;
        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRoomNum.Items.Clear();
            query = "select roomNo from rooms where bed = '" + cbBed.Text + "' and roomType = '" + cbRoomType.Text + "' and booked = 'NO'";
            setComboBox(query, cbRoomNum);
        }

        private void cbRoomNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            query = "select price, roomid from rooms where roomNo = '" + cbRoomNum.Text + "'";
            DataSet ds = fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void UC_CustomerRes_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txtIDProof_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           if(txtName.Text != ""&& txtPhoneNumber.Text !="" && txtNationality.Text != "" && cbGender.Text != "" && txtBirth.Text != "" && txtIDProof.Text != "" && txtAddress.Text != "" && txtChecking.Text != "" && txtPrice.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtPhoneNumber.Text);
                String national = txtNationality.Text;
                String gender = cbGender.Text;
                String dob = txtBirth.Text;
                String idproof = txtIDProof.Text;
                String address = txtAddress.Text;
                String checkin = txtChecking.Text;
                query = "insert into customer (cname, mobile, nationality, gender, dob, idproof, address, checkin, roomid) values('"+name+"',"+mobile +",'"+national+"','"+gender+"','"+dob+"','"+idproof+"','"+address+"','"+checkin+"',"+rid+") update rooms set booked ='YES' where roomNo = '"+cbRoomNum.Text+"'";
                fn.setData(query, "Số Phòng " + cbRoomNum.Text + "Đăng ký khách hàng thành công.");
                clearAll();
           }
            else
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ thông tin.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
