using Guna.UI2.WinForms;
using Hotel.All_user_control;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Guna.UI2.Native.WinApi;

namespace Hotel.Test.SourceCode___Lam_theo_nay_ne
{
    
    [TestFixture, Apartment(ApartmentState.STA)]
    class UC_ChartTest
    {
        private UC_Chart chartControl;
        private Mock<function> mockFunctions;

        [SetUp]
        public void SetUp()
        {
            mockFunctions = new Mock<function>();
            chartControl = new UC_Chart();
        }

        [Test]
        public void TestSetDSYear([Values(169998m, -230024m)] decimal expectedDoanhThu)
        {
            // Arrange
            var cbNamMock = new Mock<Guna2ComboBox>();
            cbNamMock.Setup(cb => cb.Text).Returns("Năm 2023");
            SetPrivateField(chartControl, "cbNam", cbNamMock.Object);

            var mockData = new DataSet();
            var dataTable = new DataTable();
            dataTable.Columns.Add("THANG");
            dataTable.Columns.Add("THUNHAP");
            dataTable.Columns.Add("CHIPHI");
            dataTable.Columns.Add("DOANHTHU");
            for (int i = 1; i <= 12; i++)
            {
                dataTable.Rows.Add(i, expectedDoanhThu, 0m, expectedDoanhThu);
            }
            mockData.Tables.Add(dataTable);
            mockFunctions.Setup(fn => fn.getData(It.IsAny<string>())).Returns(mockData);

            // Act
            InvokePrivateMethod(chartControl, "SetDSYear", null);

            // Assert
            var dsYear = GetPrivateField<DataSet>(chartControl, "dsYear");
            Assert.That(dsYear.Tables.Count, Is.EqualTo(1));
            Assert.That(dsYear.Tables[0].Rows.Count, Is.EqualTo(12));
            for (int i = 0; i < 12; i++)
            {
                Assert.That(dsYear.Tables[0].Rows[i]["DOANHTHU"], Is.EqualTo(expectedDoanhThu));
            }
        }
        [Test]
        public void TestSetDSMonth([Values(0m, 590000m)] decimal expectedLuong)
        {
            // Arrange
            var cbNamMock = new Mock<Guna2ComboBox>();
            cbNamMock.Setup(cb => cb.Text).Returns("Năm 2023");
            SetPrivateField(chartControl, "cbNam", cbNamMock.Object);

            var cbThangMock = new Mock<Guna2ComboBox>();
            cbThangMock.Setup(cb => cb.Text).Returns("12");
            SetPrivateField(chartControl, "cbThang", cbThangMock.Object);

            var mockData = new DataSet();
            var dataTable = new DataTable();
            dataTable.Columns.Add("PHONG");
            dataTable.Columns.Add("DICHVU");
            dataTable.Columns.Add("LUONG");
            dataTable.Rows.Add(0m, 0m, expectedLuong);
            mockData.Tables.Add(dataTable);
            mockFunctions.Setup(fn => fn.getData(It.IsAny<string>())).Returns(mockData);

            // Act
            InvokePrivateMethod(chartControl, "SetDSMonth", null);

            // Assert
            var dsMonth = GetPrivateField<DataSet>(chartControl, "dsMonth");
            Assert.That(dsMonth.Tables.Count, Is.EqualTo(1));
            Assert.That(dsMonth.Tables[0].Rows.Count, Is.EqualTo(1));
            Assert.That(dsMonth.Tables[0].Rows[0]["PHONG"], Is.EqualTo(0m));
            Assert.That(dsMonth.Tables[0].Rows[0]["DICHVU"], Is.EqualTo(0m));
            Assert.That(dsMonth.Tables[0].Rows[0]["LUONG"], Is.EqualTo(expectedLuong));
        }
        [Test]
        public void TestSetLabel()
        {
            // Arrange
            var testData = new DataTable();
            testData.Columns.Add("PHONG");
            testData.Columns.Add("DICHVU");
            testData.Columns.Add("LUONG");
            testData.Rows.Add(1000000, 2000000, 3000000);
            var dsMonth = new DataSet();
            dsMonth.Tables.Add(testData);
            SetPrivateField(chartControl, "dsMonth", dsMonth);

            // Act
            InvokePrivateMethod(chartControl, "SetLabel", null);

            // Assert
            var label4 = GetPrivateField<System.Windows.Forms.Label>(chartControl, "label4");
            var label5 = GetPrivateField<System.Windows.Forms.Label>(chartControl, "label5");
            var label6 = GetPrivateField<System.Windows.Forms.Label>(chartControl, "label6");

            Assert.That(label4.Text, Is.EqualTo("1000000 VNĐ"), "Label4 value is incorrect.");
            Assert.That(label5.Text, Is.EqualTo("2000000 VNĐ"), "Label5 value is incorrect.");
            Assert.That(label6.Text, Is.EqualTo("3000000 VNĐ"), "Label6 value is incorrect.");
        }

        [Test]
        public void TestSetChart1()
        {
            // Arrange
            var testData = new DataTable();
            testData.Columns.Add("PHONG");
            testData.Columns.Add("DICHVU");
            testData.Rows.Add(1000000, 2000000);
            var dsMonth = new DataSet();
            dsMonth.Tables.Add(testData);
            SetPrivateField(chartControl, "dsMonth", dsMonth);

            // Act
            InvokePrivateMethod(chartControl, "SetChart1", null);

            // Assert
            var chart1 = GetPrivateField<System.Windows.Forms.DataVisualization.Charting.Chart>(chartControl, "chart1");
            Assert.That(chart1.Series["Doanh Thu"].Points.Count, Is.EqualTo(2), "Chart1 should have 2 points.");
        }

        [Test]
        public void TestSetChart2()
        {
            // Arrange
            var testData = new DataTable();
            testData.Columns.Add("THANG");
            testData.Columns.Add("THUNHAP");
            testData.Columns.Add("CHIPHI");
            testData.Columns.Add("DOANHTHU");

            // Thêm dữ liệu giả vào bảng
            testData.Rows.Add("Tháng 1", 1000, 500, 1500);
            testData.Rows.Add("Tháng 2", 1200, 600, 1600);

            var dsYear = new DataSet();
            dsYear.Tables.Add(testData);

            // Thiết lập dữ liệu vào đối tượng chartControl
            SetPrivateField(chartControl, "dsYear", dsYear);

            // Act
            InvokePrivateMethod(chartControl, "SetChart2", null);

            // Assert
            var chart2 = GetPrivateField<System.Windows.Forms.DataVisualization.Charting.Chart>(chartControl, "chart2");

            // Kiểm tra số lượng điểm của các chuỗi trong chart2
            Assert.That(chart2.Series[0].Points.Count, Is.EqualTo(2), "Series 0 (THUNHAP) should have 2 points.");
            Assert.That(chart2.Series[1].Points.Count, Is.EqualTo(2), "Series 1 (CHIPHI) should have 2 points.");
            Assert.That(chart2.Series[2].Points.Count, Is.EqualTo(2), "Series 2 (DOANHTHU) should have 2 points.");

            // Kiểm tra giá trị của các điểm trong các chuỗi
            Assert.That(chart2.Series[0].Points[0].YValues[0], Is.EqualTo(1000), "THUNHAP value for Tháng 1 is incorrect.");
            Assert.That(chart2.Series[1].Points[0].YValues[0], Is.EqualTo(500), "CHIPHI value for Tháng 1 is incorrect.");
            Assert.That(chart2.Series[2].Points[0].YValues[0], Is.EqualTo(1500), "DOANHTHU value for Tháng 1 is incorrect.");
            Assert.That(chart2.Series[0].Points[1].YValues[0], Is.EqualTo(1200), "THUNHAP value for Tháng 2 is incorrect.");
            Assert.That(chart2.Series[1].Points[1].YValues[0], Is.EqualTo(600), "CHIPHI value for Tháng 2 is incorrect.");
            Assert.That(chart2.Series[2].Points[1].YValues[0], Is.EqualTo(1600), "DOANHTHU value for Tháng 2 is incorrect.");
        }

        [Test]
        public void TestRefreshData()
        {
            // Act
            InvokePrivateMethod(chartControl, "RefreshData", null);

            // Assert
            var dsMonth = GetPrivateField<DataSet>(chartControl, "dsMonth");
            var dsYear = GetPrivateField<DataSet>(chartControl, "dsYear");
            Assert.That(dsMonth, Is.Not.Null, "Dataset for month should not be null after refresh.");
            Assert.That(dsYear, Is.Not.Null, "Dataset for year should not be null after refresh.");
        }

        private void InvokePrivateMethod(object obj, string methodName, object[] parameters)
        {
            MethodInfo methodInfo = obj.GetType().GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);
            if (methodInfo == null)
            {
                throw new ArgumentException($"Method '{methodName}' not found in type '{obj.GetType().FullName}'.");
            }
            methodInfo.Invoke(obj, parameters);
        }

        private T GetPrivateField<T>(object obj, string fieldName)
        {
            FieldInfo fieldInfo = obj.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldInfo == null)
            {
                throw new ArgumentException($"Field '{fieldName}' not found in type '{obj.GetType().FullName}'.");
            }
            return (T)fieldInfo.GetValue(obj);
        }

        private void SetPrivateField<T>(object obj, string fieldName, T value)
        {
            FieldInfo fieldInfo = obj.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldInfo == null)
            {
                throw new ArgumentException($"Field '{fieldName}' not found in type '{obj.GetType().FullName}'.");
            }
            if (fieldInfo.FieldType != typeof(T))
            {
                throw new ArgumentException($"Field '{fieldName}' expects a value of type '{fieldInfo.FieldType}', but got '{typeof(T)}'.");
            }
            fieldInfo.SetValue(obj, value);
        }
    }
}
