using Guna.UI2.WinForms;
using Hotel.SmallForm;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.RoomControls
{
    internal class RoomFunction
    {
        function fn = new function();
        public void SetRoomID(int criterion, Guna2ComboBox cB, DataSet ds,  string floor = "0")
        {
            cB.Items.Clear();
            switch (criterion)
            {
                case 0:
                    DataRow[] dr;
                    for (int i = 0; i < 9; i++)
                    {
                        dr = ds.Tables[0].Select("MAPHG = 'P" + floor + "0" + (i + 1) + "'");
                        if (dr.Length != 0)
                        {
                            continue;
                        }
                        cB.Items.Add("0" + (i + 1));
                    }
                    break;
                case 1:
                    foreach(DataRow dR in ds.Tables[0].Rows)
                    {
                        cB.Items.Add(dR["MAPHG"].ToString());
                    }
                    break;
            }
        }
        public void SetRoomTypeID(Guna2ComboBox cB)
        {
            string query = "select MALOAIPHG " +
                           "from LOAIPHONG " +
                           "order by MALOAIPHG asc";
            DataSet dS = new DataSet();
            dS = fn.getData(query);
            foreach (DataRow dR in dS.Tables[0].Rows)
            {
                cB.Items.Add(dR[0].ToString());
            }
        }
        public DataRow[] FindInDataset(DataSet ds, string subject, string column)
        {
            DataRow[] dr;
            dr = ds.Tables[0].Select(column + "='" + subject + "'");
            if (dr.Length != 0)
            {
                return dr;
            }
            return null;
        }
        public void UnitClick(UC_RoomUnitBase room)
        {
            F_RoomInfo roomInfo = new F_RoomInfo(room);
            background br = new background();
            br.Show();
            roomInfo.ShowDialog();
            roomInfo.Focus();
            br.Hide();
        }
    }
}
