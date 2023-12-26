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
        public UC_Chart()
        {
            InitializeComponent();
            setLabel();
            macDinh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Chartt_Load(object sender, EventArgs e)
        {
            setLabel();
            macDinh();
            guna2Button1.PerformClick();

        }
       
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = "select THANG, TIENPHONG, TIENDICHVU, TIENLUONG, TONGNHAP, TIENDOANHTHU from DOANHTHU where NAM =N'" + cbNam.Text + "'";
            string query2 = "select tienPhong, tienDichVu from doanhthu where thang = N'" + cbThang.Text + "' and nam = N'" + cbNam.Text + "'";
            DataSet ds = fn.getData(query2);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Đảm bảo rằng cả hai cột đều tồn tại
                if (ds.Tables[0].Columns.Contains("TIENPHONG") && ds.Tables[0].Columns.Contains("TIENDICHVU"))
                {
                    chart1.Series.Clear(); // Xóa các chuỗi có sẵn để sử dụng biểu đồ tròn

                    // Tạo chuỗi cho biểu đồ tròn
                    chart1.Series.Add("Doanh Thu");

                    // Thiết lập kiểu biểu đồ tròn
                    chart1.Series["Doanh Thu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                    // Gán giá trị từ cột "tienPhong" và "tienDichVu" cho biểu đồ tròn
                    chart1.Series["Doanh Thu"].Points.AddXY("Tiền Phòng", ds.Tables[0].Rows[0]["TIENPHONG"]);
                    chart1.Series["Doanh Thu"].Points.AddXY("Tiền Dịch Vụ", ds.Tables[0].Rows[0]["TIENDICHVU"]);

                    // Hiển thị giá trị phần trăm bên trong mỗi phần tử của biểu đồ tròn
                    chart1.Series["Doanh Thu"].IsValueShownAsLabel = true;
                    chart1.Series["Doanh Thu"].Label = "#PERCENT{P0}";

                    // Hiển thị chú thích (legend) và đặt tên cho chú thích
                    chart1.Legends.Add("Legend");
                    chart1.Legends["Legend"].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
                    chart1.Legends["Legend"].Alignment = StringAlignment.Center; // Căn giữa chú thích

                    // Gán tên cho chú thích
                    chart1.Series["Doanh Thu"].LegendText = "#AXISLABEL";

                    // Đặt màu trắng cho số trong biểu đồ
                    chart1.Series["Doanh Thu"].LabelForeColor = System.Drawing.Color.White;

                    chart1.DataBind();
                }
                else
                {
                    MessageBox.Show("Không có cột 'TIENPHONG' hoặc 'TIENDICHVU' trong kết quả truy vấn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu trả về từ truy vấn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            chart2.DataSource = fn.getData(query);

            // Sử dụng chuỗi đầu tiên trong SeriesCollection
            chart2.Series[0].XValueMember = "THANG";
            chart2.Series[0].YValueMembers = "TONGNHAP";
            // Sử dụng chuỗi đầu tiên trong SeriesCollection
            chart2.Series[1].XValueMember = "THANG";
            chart2.Series[1].YValueMembers = "TIENLUONG";
            chart2.Series[2].XValueMember = "THANG";
            chart2.Series[2].YValueMembers = "TIENDOANHTHU";
            chart2.Series[1].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart2.Series[1].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            // Nếu bạn muốn thiết lập kiểu dữ liệu cho trục x và y, bạn có thể sử dụng những dòng sau đây
            chart2.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart2.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            chart2.Series[2].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart2.Series[2].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;

            chart2.DataBind();

            setLabel();

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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Profit pf = new Profit();
            background br = new background();
            br.Show();
            pf.ShowDialog();
            pf.Focus();
            setLabel();
            br.Hide ();
        }
        public void setLabel()
        {
            query = "SELECT MAX(TIENPHONG)  FROM  DOANHTHU WHERE NAM = N'" + cbNam.Text + "'";
            label4.Text = fn.getData2(query);
            query = "SELECT MAX(TIENDICHVU)  FROM  DOANHTHU WHERE NAM = N'" + cbNam.Text + "'";
            label5.Text = fn.getData2(query);
            query = "SELECT MAX(TIENLUONG) FROM DOANHTHU WHERE NAM = N'" + cbNam.Text + "'";
            label6.Text = fn.getData2(query);
        }
        
        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void macDinh()
        {
            cbNam.Text = "Năm 2021";
            cbThang.Text = "Tháng 1";
        }
    }
}
