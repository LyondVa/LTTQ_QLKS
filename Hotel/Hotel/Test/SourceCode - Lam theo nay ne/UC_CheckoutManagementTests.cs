using Hotel.All_user_control;
using Moq;
using NUnit.Framework;
using System;
using System.Data;

namespace Hotel.Test.SourceCode___Lam_theo_nay_ne
{
    [TestFixture]
    public class UC_CheckoutManagementTests
    {
        private UC_CheckOut _uc;
        private Mock<function> _mockFn;

        [SetUp]
        public void Setup()
        {
            // Tạo đối tượng UC_CheckOut và Mock cho function
            _uc = new UC_CheckOut();
            _mockFn = new Mock<function>();
            _uc.fn = _mockFn.Object;
        }

        [Test]
        public void RefreshData_ShouldLoadCorrectDataToGridView()
        {
            // Arrange
            string expectedQuery = "select HOADON.MAHD as 'Mã Hóa Đơn', KHACHHANG.MAKH as 'Mã Khách Hàng', KHACHHANG.KHOTEN as 'Họ Tên', HOADON.NGNHANPHG as 'Ngày Nhận Phòng', HOADON.NGTRPHG as 'Ngày trả phòng', cast(HOADON.TONGTIEN as decimal) as 'Tổng tiền' from KHACHHANG inner join HOADON on KHACHHANG.MAKH = HOADON.MAKH where KHACHHANG.STAYING = 1 and NGTRPHGTHAT is null";

            // Tạo dữ liệu giả lập
            DataSet mockData = new DataSet();
            DataTable mockTable = new DataTable();
            mockTable.Columns.Add("Mã Hóa Đơn");
            mockTable.Columns.Add("Mã Khách Hàng");
            mockTable.Columns.Add("Họ Tên");
            mockTable.Columns.Add("Ngày Nhận Phòng");
            mockTable.Columns.Add("Ngày trả phòng");
            mockTable.Columns.Add("Tổng tiền", typeof(decimal));

            // Thêm một hàng dữ liệu giả vào bảng
            mockTable.Rows.Add("HD001", "KH001", "Nguyen Van A", DateTime.Now.AddDays(-5), DateTime.Now, 500000);
            mockData.Tables.Add(mockTable);

            // Giả lập hàm getData trả về mockData
            _mockFn.Setup(fn => fn.getData(It.Is<string>(q => q == expectedQuery))).Returns(mockData);

            // Act
            _uc.RefreshData();

            // Assert
            _mockFn.Verify(fn => fn.getData(expectedQuery), Times.Once);
            Assert.That(_uc.guna2DataGridView1.DataSource, Is.EqualTo(mockData.Tables[0]));
        }


        [Test]
        public void UC_CheckOut_Load_ShouldLoadDataToGridView()
        {
            // Arrange
            DataSet mockData = new DataSet();
            DataTable mockTable = new DataTable();
            mockTable.Columns.Add("Mã Hóa Đơn");
            mockTable.Columns.Add("Mã Khách Hàng");
            mockTable.Columns.Add("Họ Tên");
            mockTable.Columns.Add("Ngày Nhận Phòng");
            mockTable.Columns.Add("Ngày trả phòng");
            mockTable.Columns.Add("Tổng tiền", typeof(decimal));

            // Thêm dữ liệu giả vào bảng
            mockTable.Rows.Add("HD001", "KH001", "Nguyen Van A", DateTime.Now.AddDays(-5), DateTime.Now, 500000);
            mockData.Tables.Add(mockTable);

            // Giả lập hàm getData trả về mockData
            _mockFn.Setup(fn => fn.getData(It.IsAny<string>())).Returns(mockData);

            // Act
            _uc.UC_CheckOut_Load(null, null);

            // Assert
            Assert.That(_uc.guna2DataGridView1.DataSource, Is.EqualTo(mockData.Tables[0]));
        }


        [Test]
        public void txtName_TextChanged_ShouldFilterDataBasedOnInput()
        {
            // Arrange
            _uc.txtName = new Guna.UI2.WinForms.Guna2TextBox(); // Khởi tạo txtName
            string input = "Nguyen";
            _uc.txtName.Text = input;

            string expectedQuery = $"select HOADON.MAHD as 'Mã Hóa Đơn', KHACHHANG.MAKH as 'Mã Khách Hàng', KHACHHANG.KHOTEN as 'Họ Tên', HOADON.NGNHANPHG as 'Ngày Nhận Phòng', HOADON.NGTRPHG as 'Ngày trả phòng', cast(HOADON.TONGTIEN as decimal) as 'Tổng tiền' from KHACHHANG inner join HOADON on KHACHHANG.MAKH = HOADON.MAKH where KHOTEN like N'{input}%' and KHACHHANG.STAYING = 1 and NGTRPHGTHAT is null";
            DataSet mockData = new DataSet(); // Giả lập dữ liệu trả về từ cơ sở dữ liệu

            DataTable mockTable = new DataTable();
            mockTable.Columns.Add("Mã Hóa Đơn");
            mockTable.Columns.Add("Mã Khách Hàng");
            mockTable.Columns.Add("Họ Tên");
            mockTable.Columns.Add("Ngày Nhận Phòng");
            mockTable.Columns.Add("Ngày trả phòng");
            mockTable.Columns.Add("Tổng tiền", typeof(decimal));

            mockData.Tables.Add(mockTable);

            _mockFn.Setup(fn => fn.getData(expectedQuery)).Returns(mockData);

            // Act
            _uc.txtName_TextChanged(null, null);

            // Assert
            _mockFn.Verify(fn => fn.getData(expectedQuery), Times.Once);
            Assert.That(_uc.guna2DataGridView1.DataSource, Is.EqualTo(mockData.Tables[0]));
        }
        

    }
}
