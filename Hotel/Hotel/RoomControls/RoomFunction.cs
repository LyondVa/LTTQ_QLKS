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
        public void SetRoomID(DomainUpDown dUD, DataSet ds, string floor)
        {
            DataRow[] dr;
            dUD.Items.Clear();
            for (int i = 0; i < 9; i++)
            {
                dr = ds.Tables[0].Select("MAPHG = 'P" + floor + "0"+ (i+1) +"'");
                if (dr.Length != 0)
                {
                    continue;
                }
                dUD.Items.Add("0" +(i + 1));
            }
        }
        public bool FindInDataset(DataSet ds, string subject, string column)
        {
            DataRow[] dr;
            dr = ds.Tables[0].Select(column+"='"+subject+"'");
            if (dr.Length != 0)
            {
                return true;
            }
            return false;
        }
        public void UnitClick()
        {
            RoomInfo roomInfo = new RoomInfo();
            roomInfo.Show();
            roomInfo.Focus();
        }
    }
}
