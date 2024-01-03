using Hotel.SmallForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Hotel.All_user_control
{
    public partial class UC_Chart : UserControl
    {
        function fn = new function();
        string query;
        DataSet dsMonth = new DataSet();
        DataSet dsYear = new DataSet();
        public UC_Chart()
        {
            InitializeComponent();
            RefreshData();
        }
        
        private void SetDSYear()
        {
            query = "EXEC DBO.DOANHTHUTUNGTHANG @NAM = " + Convert.ToInt16(cbNam.Text.Substring(cbNam.Text.Length - 4)) + "";
            dsYear = fn.getData(query);
        }

        private void SetDSMonth()
        {
            query = "SELECT DBO.TONGTIENPHONGTHANG(" + Convert.ToInt16(cbNam.Text.Substring(cbNam.Text.Length - 4)) + "," + Convert.ToInt16(cbThang.Text.Substring(cbThang.Text.Length - 2)) + ") AS 'PHONG', " +
                        "DBO.TONGTIENDICHVUTHANG(" + Convert.ToInt16(cbNam.Text.Substring(cbNam.Text.Length - 4)) + "," + Convert.ToInt16(cbThang.Text.Substring(cbThang.Text.Length - 2)) + ") AS 'DICHVU', " +
                        "DBO.TONGTIENLUONGTHANG() AS 'LUONG', " +
                        "DBO.TONGDOANHTHUTHANG(" + Convert.ToInt16(cbNam.Text.Substring(cbNam.Text.Length - 4)) + "," + Convert.ToInt16(cbThang.Text.Substring(cbThang.Text.Length - 2)) + ") AS 'DOANHTHU'";
            dsMonth = fn.getData(query);
        }

        private void SetLabel()
        {
            label4.Text = dsMonth.Tables[0].Rows[0]["PHONG"].ToString() + " VNĐ";
            label5.Text = dsMonth.Tables[0].Rows[0]["DICHVU"].ToString() + " VNĐ";
            label6.Text = dsMonth.Tables[0].Rows[0]["LUONG"].ToString() + " VNĐ";
        }

        private void SetChart1()
        {
            chart1.Series.Clear();
            chart1.Legends.Clear();
            chart1.Series.Add("Doanh Thu");
            chart1.Series["Doanh Thu"].ChartType = SeriesChartType.Pie;
            chart1.Series["Doanh Thu"].Points.AddXY("Tiền Phòng", dsMonth.Tables[0].Rows[0]["PHONG"]);
            chart1.Series["Doanh Thu"].Points.AddXY("Tiền Dịch Vụ", dsMonth.Tables[0].Rows[0]["DICHVU"]);
            chart1.Series["Doanh Thu"].IsValueShownAsLabel = true;
            chart1.Series["Doanh Thu"].Label = "#PERCENT{P0}";
            chart1.Legends.Add("Legend");
            chart1.Legends["Legend"].Docking = Docking.Bottom;
            chart1.Legends["Legend"].Alignment = StringAlignment.Center; 
            chart1.Series["Doanh Thu"].LegendText = "#AXISLABEL";
            chart1.Series["Doanh Thu"].LabelForeColor = Color.White;

            chart1.DataBind();
        }

        private void SetChart2()
        {
            chart2.DataSource = dsYear;
            chart2.Series[0].XValueMember = "THANG";
            chart2.Series[0].YValueMembers = "THUNHAP";
            chart2.Series[1].XValueMember = "THANG";
            chart2.Series[1].YValueMembers = "CHIPHI";
            chart2.Series[2].XValueMember = "THANG";
            chart2.Series[2].YValueMembers = "DOANHTHU";
            chart2.Series[1].XValueType = ChartValueType.String;
            chart2.Series[1].YValueType = ChartValueType.Int64;
            chart2.Series[0].XValueType = ChartValueType.String;
            chart2.Series[0].YValueType = ChartValueType.Int64;
            chart2.Series[2].XValueType = ChartValueType.String;
            chart2.Series[2].YValueType = ChartValueType.Int64;

            chart2.DataBind();
        } 

        private void RefreshData()
        {
            SetDSYear();
            SetDSMonth();
            SetLabel();
            SetChart1();
            SetChart2();
        }
        
        private void btReport_Click(object sender, EventArgs e)
        {
            Profit pf = new Profit();
            background br = new background();
            br.Show();
            pf.ShowDialog();
            pf.Focus();
            SetLabel();
            br.Hide();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            #region OLD CODE
            //query = "select THANG, TIENPHONG, TIENDICHVU, TIENLUONG, TONGNHAP, TIENDOANHTHU from DOANHTHU where NAM =N'" + cbNam.Text + "'";
            //string query2 = "select tienPhong, tienDichVu from doanhthu where thang = N'" + cbThang.Text + "' and nam = N'" + cbNam.Text + "'";
            //DataSet ds = fn.getData(query2);
            //if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            //{
            //    // Đảm bảo rằng cả hai cột đều tồn tại
            //    if (ds.Tables[0].Columns.Contains("TIENPHONG") && ds.Tables[0].Columns.Contains("TIENDICHVU"))
            //    {
            //        chart1.Series.Clear(); // Xóa các chuỗi có sẵn để sử dụng biểu đồ tròn

            //        // Tạo chuỗi cho biểu đồ tròn
            //        chart1.Series.Add("Doanh Thu");

            //        // Thiết lập kiểu biểu đồ tròn
            //        chart1.Series["Doanh Thu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            //        // Gán giá trị từ cột "tienPhong" và "tienDichVu" cho biểu đồ tròn
            //        chart1.Series["Doanh Thu"].Points.AddXY("Tiền Phòng", ds.Tables[0].Rows[0]["TIENPHONG"]);
            //        chart1.Series["Doanh Thu"].Points.AddXY("Tiền Dịch Vụ", ds.Tables[0].Rows[0]["TIENDICHVU"]);

            //        // Hiển thị giá trị phần trăm bên trong mỗi phần tử của biểu đồ tròn
            //        chart1.Series["Doanh Thu"].IsValueShownAsLabel = true;
            //        chart1.Series["Doanh Thu"].Label = "#PERCENT{P0}";

            //        // Hiển thị chú thích (legend) và đặt tên cho chú thích
            //        chart1.Legends.Add("Legend");
            //        chart1.Legends["Legend"].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            //        chart1.Legends["Legend"].Alignment = StringAlignment.Center; // Căn giữa chú thích

            //        // Gán tên cho chú thích
            //        chart1.Series["Doanh Thu"].LegendText = "#AXISLABEL";

            //        // Đặt màu trắng cho số trong biểu đồ
            //        chart1.Series["Doanh Thu"].LabelForeColor = System.Drawing.Color.White;

            //        chart1.DataBind();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Không có cột 'TIENPHONG' hoặc 'TIENDICHVU' trong kết quả truy vấn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Không có dữ liệu trả về từ truy vấn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //chart2.DataSource = fn.getData(query);

            //// Sử dụng chuỗi đầu tiên trong SeriesCollection
            //chart2.Series[0].XValueMember = "THANG";
            //chart2.Series[0].YValueMembers = "TONGNHAP";
            //// Sử dụng chuỗi đầu tiên trong SeriesCollection
            //chart2.Series[1].XValueMember = "THANG";
            //chart2.Series[1].YValueMembers = "TIENLUONG";
            //chart2.Series[2].XValueMember = "THANG";
            //chart2.Series[2].YValueMembers = "TIENDOANHTHU";
            //chart2.Series[1].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            //chart2.Series[1].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            //// Nếu bạn muốn thiết lập kiểu dữ liệu cho trục x và y, bạn có thể sử dụng những dòng sau đây
            //chart2.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            //chart2.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            //chart2.Series[2].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            //chart2.Series[2].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;

            //chart2.DataBind();

            //SetLabel();
            #endregion
            RefreshData();
        }
    }
}
