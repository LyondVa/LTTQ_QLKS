using NUnit.Framework;
using Moq;
using System.Data;
using System.Windows.Forms;
using Hotel.All_user_control;
using System;
using Guna.UI2.WinForms;

namespace Hotel.Test.SourceCode
{
    [TestFixture]
    public class UC_CustomerInfoTests
    {
        private UC_CustomerInfo _customerInfo;
        private Mock<function> _mockFunction;
        private DataSet _mockDataSet;

        [SetUp]
        public void SetUp()
        {
            _mockFunction = new Mock<function>();
            _customerInfo = new UC_CustomerInfo();

            // Mock dataset to simulate database results
            _mockDataSet = new DataSet();
            var dataTable = new DataTable();
            dataTable.Columns.Add("Mã Khách Hàng");
            dataTable.Columns.Add("Họ Tên");
            dataTable.Columns.Add("Quốc Tịch");
            dataTable.Columns.Add("CCCD");
            dataTable.Columns.Add("Giới Tính");
            dataTable.Columns.Add("Ngày Sinh");
            dataTable.Columns.Add("Số Điện Thoại");
            dataTable.Columns.Add("Địa Chỉ");
            dataTable.Columns.Add("Email");
            _mockDataSet.Tables.Add(dataTable);

            // Mock methods of `function`
            _mockFunction.Setup(f => f.getData(It.IsAny<string>())).Returns(_mockDataSet);
            _mockFunction.Setup(f => f.setData(It.IsAny<string>(), It.IsAny<string>()));

            // Inject the mocked `function` instance
            _customerInfo.GetType()
                .GetField("fn", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .SetValue(_customerInfo, _mockFunction.Object);

            // Initialize UI controls
            _customerInfo.GetType()
                .GetMethod("InitializeComponent", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .Invoke(_customerInfo, null);
        }

        [Test]
        public void TestSetCustomerInfo_ShouldLoadCustomerData()
        {
            // Act
            _customerInfo.GetType()
                .GetMethod("setCustomerInfo", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)
                .Invoke(_customerInfo, null);

            // Assert
            _mockFunction.Verify(f => f.getData(It.Is<string>(s => s.Contains("HOATDONG = 1"))), Times.Once,
                "setCustomerInfo should call getData with the correct query.");
        }

        [Test]
        public void TestSearchTextChanged_ShouldFilterResults()
        {
            // Arrange
            var tbSearch = (Guna2TextBox)_customerInfo.GetType().GetField("tbSearch", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_customerInfo);
            tbSearch.Text = "Test Name";

            // Act
            _customerInfo.GetType().GetMethod("tbSearch_TextChanged", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).Invoke(_customerInfo, new object[] { tbSearch, EventArgs.Empty });

            // Assert
            _mockFunction.Verify(f => f.getData(It.Is<string>(s => s.Contains("KHOTEN like N'%Test Name%' and HOATDONG = 1"))), Times.AtLeastOnce);
        }


        [Test]
        public void TestExportButtonClick_ShouldInvokeToExcel()
        {
            // Arrange
            var btExport = (Button)_customerInfo.GetType()
                .GetField("btExport", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .GetValue(_customerInfo);
            var saveFileDialog = (SaveFileDialog)_customerInfo.GetType()
                .GetField("saveFileDialog1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .GetValue(_customerInfo);
            saveFileDialog.FileName = "ExportedFile.xlsx";

            // Act
            _customerInfo.GetType()
                .GetMethod("btExport_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .Invoke(_customerInfo, new object[] { btExport, EventArgs.Empty });

            // Assert
            _mockFunction.Verify(f => f.ToExcel(It.IsAny<DataGridView>(), It.Is<string>(s => s.EndsWith("ExportedFile.xlsx"))),
                Times.Once, "btExport_Click should call ToExcel with the correct parameters.");
        }

        [Test]
        public void TestDeactivateCustomer_ShouldSetCustomerInactive()
        {
            // Arrange
            var expectedCustomerId = "KH01";
            _mockFunction.Setup(f => f.setDataNoMsg(It.IsAny<string>())).Verifiable() ;

            // Act

            // Assert
            _mockFunction.Verify(f => f.setDataNoMsg(It.Is<string>(s => s.Contains($"update KHACHHANG set HOATDONG = 0 where MAKH = '{expectedCustomerId}'"))), Times.Once);
        }

    }
}

