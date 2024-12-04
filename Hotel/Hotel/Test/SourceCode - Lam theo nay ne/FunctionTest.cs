using NUnit.Framework;
using System.Data;
using System.Data.SqlClient;
using Hotel;

namespace Hotel.Test.SourceCode
{
    [TestFixture]
    public class FunctionTests
    {
        private function _function;

        [SetUp]
        public void Setup()
        {
            _function = new function
            {
                dtbName = "LYON" // Set your database name here
            };
        }

        [Test]
        public void TestConnection_ShouldReturn1_WhenConnectionIsSuccessful()
        {
            // Arrange
            // (Setup is already done in the Setup method)

            // Act
            int result = _function.TestConnection();

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void TestConnection_ShouldReturn0_WhenConnectionFails()
        {
            // Arrange
            _function.dtbName = "InvalidDatabaseName";

            // Act
            int result = _function.TestConnection();

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void GetData_ShouldReturnDataSet_WhenQueryIsValid()
        {
            // Arrange
            string query = "SELECT * FROM KHACHHANG"; // Replace with a valid query

            // Act
            DataSet result = _function.getData(query);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Tables.Count, Is.GreaterThan(0));
        }

        [Test]
        public void GetData_ShouldReturnNull_WhenQueryIsInvalid()
        {
            // Arrange
            string query = "Select * from InvalidTable";

            // Act
            DataSet result = _function.getData(query);

            // Assert
            Assert.That(result, Is.Null);
        }

        [Test]
        public void SetData_ShouldExecuteQuery_WhenQueryIsValid()
        {
            // Arrange
            string query = "INSERT INTO NHANVIEN (NHOTEN, NSDT, NGIOITINH, NEMAIL, CHUCVU, LUONG, NCCCD, NDIACHI, NNGSINH) VALUES (N'Nguyễn Văn A', '0987654321', 'Nam', 'nguyenvana@gmail.com', N'Quản lý', 200000, '123456789', N'Số 1, Đường 1, Quận 1, TP.HCM', '1980-01-01')"; // Replace with a valid query
            string message = "Data inserted successfully";

            // Act
            _function.setData(query, message);

            // Assert
            // No exception means the test passed
        }

        [Test]
        public void SetDataNoMsg_ShouldExecuteQuery_WhenQueryIsValid()
        {
            // Arrange
            string query = "INSERT INTO NHANVIEN (NHOTEN, NSDT, NGIOITINH, NEMAIL, CHUCVU, LUONG, NCCCD, NDIACHI, NNGSINH) VALUES (N'Nguyễn Văn A', '0987654321', 'Nam', 'nguyenvana@gmail.com', N'Quản lý', 200000, '123456789', N'Số 1, Đường 1, Quận 1, TP.HCM', '1980-01-01')"; // Replace with a valid query

            // Act
            _function.setDataNoMsg(query);

            // Assert
            // No exception means the test passed
        }

        [Test]
        public void GetForCombo_ShouldReturnSqlDataReader_WhenQueryIsValid()
        {
            // Arrange
            string query = "SELECT TOP 1 KCCCD FROM KHACHHANG"; // Replace with a valid query

            // Act
            SqlDataReader result = _function.getForCombo(query);

            // Assert
            Assert.That(result, Is.Not.Null);
            result.Close();
        }

        [Test]
        public void GetData2_ShouldReturnString_WhenQueryIsValid()
        {
            // Arrange
            string query = "SELECT TOP 1 KCCCD FROM KHACHHANG"; // Replace with a valid query

            // Act
            string result = _function.getData2(query);

            // Assert
            Assert.That(result, Is.Not.Null);
        }
    }
}
