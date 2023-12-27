using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.RoomControls;
namespace Hotel.SmallForm
{
    public partial class AddCustomer : Form
    {
        DataSet dS = new DataSet();
        RoomFunction rFn = new RoomFunction();
        function fn = new function();
        string query;
        bool cccdError = false, sdtError = false;
        public AddCustomer()
        {
            InitializeComponent();
            txtBirth.Value = DateTime.Now;
        }
        public AddCustomer(string reservationID)
        {
            InitializeComponent();
            txtBirth.Value = DateTime.Now;
            tbCCCD.Text = reservationID;
        }

        private void btEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if ( tbName.Text != "" && tbNationality.Text != "" && tbCCCD.Text != "" && txtBirth.Text != "" && cbGender.Text != "" && tbPhone.Text != "" && tbAddress.Text != "" && tbEmail.Text != "")
            {
                string name = tbName.Text;
                string nationality = tbNationality.Text;
                string cccd = tbCCCD.Text;
                string dob = txtBirth.Value.ToString(Global.dateFormat);
                string gender = cbGender.Text;
                string phone = tbPhone.Text;
                string address = tbAddress.Text;
                string email = tbEmail.Text;
                query = "INSERT INTO KHACHHANG (KHOTEN, QUOCTICH, KCCCD, KNGSINH, KGIOITINH, KSDT, KDIACHI, KEMAIL) VALUES " +
                        "( N'" + name + "', N'" + nationality + "', '" + cccd + "', '" + dob + "', N'" + gender + "', '" + phone + "', N'" + address + "', N'" + email + "')";
                fn.setData(query, "Thêm Khách Hàng Thành Công!");
                EventHub.OnServicesUpdated();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void tbCCCD_TextChanged(object sender, EventArgs e)
        {
            query = "select KCCCD from KHACHHANG";
            dS = fn.getData(query);
            if(rFn.FindInDataset(dS, tbCCCD.Text,"KCCCD") != null)
            {
                btAdd.Enabled = false;
                sdtError = true;
                errorProvider1.SetError(tbCCCD, "CCCD Không được trùng");
            }
            else
            {
                if (!cccdError)
                {
                    btAdd.Enabled = true;
                }
                sdtError = false;
                errorProvider1.SetError(tbCCCD, null);
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            query = "select KSDT from KHACHHANG";
            dS = fn.getData(query);
            if (rFn.FindInDataset(dS, tbPhone.Text, "KSDT") != null)
            {
                btAdd.Enabled = false;
                cccdError = true;
                errorProvider1.SetError(tbPhone, "SDT Không được trùng");
            }
            else
            {
                if(!sdtError) 
                {
                    btAdd.Enabled = true;
                }
                cccdError = false;
                errorProvider1.SetError(tbPhone, null);
            }
        }
    }
}
