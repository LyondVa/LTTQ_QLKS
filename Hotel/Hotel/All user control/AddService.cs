using Hotel.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Hotel.All_user_control
{
    public partial class AddService : Form
    {
        string query;
        DataSet dSS, dSA;
        function fn = new function();
        string reservationID;
        public AddService(string reservationID)
        {
            InitializeComponent();
            InitializeSerivceSelection();
            this.reservationID = reservationID;
        }
        private void InitializeSerivceSelection()
        {
            query = "select MADV, TENDV " +
                    "from DICHVU ";
            dSS = fn.getData(query);

            dGVServiceSelection.DataSource = dSS;
            dGVServiceSelection.Columns["MADV"].Visible = false;
            dGVServiceSelection.Columns["TENDV"].HeaderText = "Tên dịch vụ";

            dGVServiceSelection.Columns.Add(new DataGridViewColumn());
            dGVServiceSelection.Columns[2].Name = "SOLUONG";
            dGVServiceSelection.Columns[2].HeaderText = "Số lượng";

            DataGridViewImageColumn dGVIC = new DataGridViewImageColumn();
            dGVIC.Name = "ADD";
            dGVIC.HeaderText = "Thêm";
            dGVIC.Image = Resources.PlusMark;
            dGVServiceSelection.Columns.Add(dGVIC);

        }
        private void InitializeAddServiceed()
        {
            dSA = fn.getData(query);

        }
    }
}
