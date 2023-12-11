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
    public partial class UC_Chartt : UserControl
    {
        function fn = new function();
        string query;
        public UC_Chartt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Chartt_Load(object sender, EventArgs e)
        {
            cbNam.SelectedIndex = 0;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = "select thang, tienPhong, tienDichVu, tienLuong, tongNhap, tienDoanhThu from doanhthu where nam ='"+cbNam.Text+"'";
            chart1.DataSource = fn.getData(query);

            // Sử dụng chuỗi đầu tiên trong SeriesCollection
            chart1.Series[0].XValueMember = "thang";
            chart1.Series[0].YValueMembers = "tienPhong";
            // Sử dụng chuỗi đầu tiên trong SeriesCollection
            chart1.Series[1].XValueMember = "thang";
            chart1.Series[1].YValueMembers = "tienDichVu";
            chart1.Series[1].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart1.Series[1].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            // Nếu bạn muốn thiết lập kiểu dữ liệu cho trục x và y, bạn có thể sử dụng những dòng sau đây
            chart1.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart1.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;

            chart1.DataBind();

            
            chart2.DataSource = fn.getData(query);

            // Sử dụng chuỗi đầu tiên trong SeriesCollection
            chart2.Series[0].XValueMember = "thang";
            chart2.Series[0].YValueMembers = "tongNhap";
            // Sử dụng chuỗi đầu tiên trong SeriesCollection
            chart2.Series[1].XValueMember = "thang";
            chart2.Series[1].YValueMembers = "tienLuong";
            chart2.Series[2].XValueMember = "thang";
            chart2.Series[2].YValueMembers = "tienDoanhThu";
            chart2.Series[1].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart2.Series[1].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            // Nếu bạn muốn thiết lập kiểu dữ liệu cho trục x và y, bạn có thể sử dụng những dòng sau đây
            chart2.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart2.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            chart2.Series[2].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart2.Series[2].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;

            chart2.DataBind();

        }
        private void SetupChart()
        {
            // Thiết lập tên trục và tiêu đề biểu đồ
            chart1.ChartAreas[0].AxisX.Title = "Cột";
            chart1.ChartAreas[0].AxisY.Title = "Số liệu";
            chart1.Titles.Add("Biểu đồ Số liệu từng Cột");

            // Tạo một loạt giả định dữ liệu
            string[] categories = { "Dữ liệu 1", "Dữ liệu 2", "Dữ liệu 3" };
            int[] values = { 20, 35, 45 };

            // Tạo loại biểu đồ (Column Chart)
            Series series = chart1.Series.Add("Số liệu");
            series.ChartType = SeriesChartType.Column;

            // Thêm dữ liệu vào biểu đồ
            for (int i = 0; i < categories.Length; i++)
            {
                DataPoint dataPoint = new DataPoint(i + 1, values[i]);
                dataPoint.Label = values[i].ToString(); // Hiển thị số liệu trực tiếp trên cột
                series.Points.Add(dataPoint);
            }

            // Tùy chỉnh một số thuộc tính của biểu đồ
            chart1.BackColor = System.Drawing.Color.LightGray;
            chart1.Series[0].Color = System.Drawing.Color.Blue;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
        }
        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
