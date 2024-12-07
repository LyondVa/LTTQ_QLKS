using NUnit.Framework;
using System;
using System.Data;
using System.Windows.Forms;
using Moq;
using Hotel.All_user_control;
using Guna.UI2.WinForms;

namespace Hotel.Test.SourceCode
{
    [TestFixture]
    public class UC_CustomerDetailTests
    {
        private UC_CustomerDetail _customerDetail;
        private Mock<function> _mockFunction;
        private DataSet _dataSet;

        [SetUp]
        public void SetUp()
        {
            _mockFunction = new Mock<function>();
            _customerDetail = new UC_CustomerDetail();

            // Mock the database function to avoid actual database calls
            _dataSet = new DataSet();
            var dataTable = new DataTable();
            dataTable.Columns.Add("Mã Khách Hàng");
            dataTable.Columns.Add("Họ Tên");
            dataTable.Columns.Add("Mã Phòng");
            dataTable.Columns.Add("Ngày Nhận Phòng");
            dataTable.Columns.Add("Tiền Đặt Phòng");
            _dataSet.Tables.Add(dataTable);

            _mockFunction.Setup(f => f.getData(It.IsAny<string>())).Returns(_dataSet);
            _mockFunction.Setup(f => f.setData(It.IsAny<string>(), It.IsAny<string>()));

            // Inject the mocked function into the UC_CustomerDetail instance
            _customerDetail.GetType().GetField("fn", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(_customerDetail, _mockFunction.Object);

            // Initialize the control
            _customerDetail.GetType().GetMethod("InitializeComponent", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).Invoke(_customerDetail, null);
        }

        [Test]
        public void TestRefreshWithSearch_SelectedIndex0()
        {
            // Arrange
            var txtSearch = (ComboBox)_customerDetail.GetType().GetField("txtSearch", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_customerDetail);
            txtSearch.SelectedIndex = 0;

            // Act
            _customerDetail.GetType().GetMethod("RefreshWithSearch", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).Invoke(_customerDetail, null);

            // Assert
            _mockFunction.Verify(f => f.getData(It.Is<string>(s => s.Contains("where HOATDONG = 1"))), Times.Once);
        }

        [Test]
        public void TestRefreshWithSearch_SelectedIndex1()
        {
            // Arrange
            var txtSearch = (ComboBox)_customerDetail.GetType().GetField("txtSearch", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_customerDetail);
            txtSearch.SelectedIndex = 1;

            // Act
            _customerDetail.GetType().GetMethod("RefreshWithSearch", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).Invoke(_customerDetail, null);

            // Assert
            _mockFunction.Verify(f => f.getData(It.Is<string>(s => s.Contains("where KHACHHANG.STAYING = 1 and HOATDONG = 1"))), Times.Exactly(2));
        }





        [Test]
        public void TestRefreshWithSearch_SelectedIndex2()
        {
            // Arrange
            var txtSearch = (ComboBox)_customerDetail.GetType().GetField("txtSearch", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_customerDetail);
            txtSearch.SelectedIndex = 2;

            // Act
            _customerDetail.GetType().GetMethod("RefreshWithSearch", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).Invoke(_customerDetail, null);

            // Assert
            _mockFunction.Verify(f => f.getData(It.Is<string>(s => s.Contains("where KHACHHANG.STAYING = 0 and HOATDONG = 1"))), Times.Exactly(2));
        }





        [Test]
        public void TesttxtSearch_SelectedIndexChanged()
        {
            // Arrange
            var txtSearch = (ComboBox)_customerDetail.GetType().GetField("txtSearch", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_customerDetail);
            txtSearch.SelectedIndex = 1;

            // Act
            _customerDetail.GetType().GetMethod("txtSearch_SelectedIndexChanged", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).Invoke(_customerDetail, new object[] { txtSearch, EventArgs.Empty });

            // Assert
            _mockFunction.Verify(f => f.getData(It.Is<string>(s => s.Contains("where KHACHHANG.STAYING = 1 and HOATDONG = 1"))), Times.Exactly(2));
        }


        [Test]
        public void TesttbNameSearch_TextChanged()
        {
            // Arrange
            var tbNameSearch = (Guna2TextBox)_customerDetail.GetType().GetField("tbNameSearch", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_customerDetail);
            tbNameSearch.Text = "Test Name";
            var txtSearch = (ComboBox)_customerDetail.GetType().GetField("txtSearch", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_customerDetail);
            txtSearch.SelectedIndex = 0;

            // Act
            _customerDetail.GetType().GetMethod("tbNameSearch_TextChanged", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).Invoke(_customerDetail, new object[] { tbNameSearch, EventArgs.Empty });

            // Assert
            _mockFunction.Verify(f => f.getData(It.Is<string>(s => s.Contains("where KHACHHANG.KHOTEN like N'%Test Name%' and HOATDONG = 1"))), Times.Exactly(2));
        }
    }
}
