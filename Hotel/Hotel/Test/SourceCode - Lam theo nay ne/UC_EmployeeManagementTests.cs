using Guna.UI2.WinForms;
using Hotel.All_user_control;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Hotel.Test.SourceCode___Lam_theo_nay_ne
{
    [TestFixture]
    public class UC_EmployeeManagementTests
    {
        private Mock<function> _mockFunction;
        private UC_Employee2 _ucEmployee2;
        private Mock<DataGridView> _mockDataGridView;
        private DataSet _mockDataSet;

        [SetUp]
        public void Setup()
        {
            // Mock function class
            _mockFunction = new Mock<function>();

            // Create mock data set
            _mockDataSet = new DataSet();
            var dataTable = new DataTable();
            dataTable.Columns.Add("Mã Nhân Viên");
            dataTable.Rows.Add("NV001");
            _mockDataSet.Tables.Add(dataTable);

            // Mock the data returned by getData
            _mockFunction.Setup(fn => fn.getData(It.IsAny<string>())).Returns(_mockDataSet);

            // Create UC_Employee2 and pass mocked function
            _ucEmployee2 = new UC_Employee2();

            // Assign mocked function to the UC_Employee2 instance
            _ucEmployee2.fn = _mockFunction.Object;
        }

        [Test]
        public void SetEmployee_ShouldDisplayEmployeeData()
        {
            // Act
            _ucEmployee2.setEmployee();

            // Assert
            var dataGridView = _ucEmployee2.Controls.OfType<DataGridView>().FirstOrDefault();
            Assert.That(dataGridView, Is.Not.Null);
            Assert.That(dataGridView.Rows.Count, Is.EqualTo(1));  // Assuming one row added in mock data
            Assert.That(dataGridView.Rows[0].Cells["Mã Nhân Viên"].Value, Is.EqualTo("NV001"));
        }


        [Test]
        public void TbSearch_TextChanged_ShouldFilterEmployeeData()
        {
            // Arrange
            string searchText = "John";
            string query = "SELECT MANV as 'Mã Nhân Viên', NHOTEN as 'Họ Tên', NCCCD as 'CCCD', NGIOITINH as 'Giới Tính', CONVERT(DATE, NNGSINH) as 'Ngày Sinh', NSDT as 'SDT', NDIACHI as 'Địa Chỉ', NEMAIL as'Email', CHUCVU as 'Chức Vụ', cast(LUONG as decimal) as 'Lương' " +
                            "from NHANVIEN " +
                            "where NHOTEN like N'%John%' and HOATDONG = 1" +
                            "ORDER BY MANV ASC";

            // Tạo mock data giống như kết quả của truy vấn
            var dataTable = new DataTable();
            dataTable.Columns.Add("Mã Nhân Viên");
            dataTable.Columns.Add("Họ Tên");
            dataTable.Columns.Add("CCCD");
            dataTable.Columns.Add("Giới Tính");
            dataTable.Columns.Add("Ngày Sinh");
            dataTable.Columns.Add("SDT");
            dataTable.Columns.Add("Địa Chỉ");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Chức Vụ");
            dataTable.Columns.Add("Lương");

            // Chỉ thêm dữ liệu phù hợp với truy vấn
            dataTable.Rows.Add("NV001", "John Doe", "123456789", "Nam", DateTime.Now.AddYears(-30).ToShortDateString(), "0123456789", "123 Street", "john.doe@example.com", "Nhân viên", 5000000);

            var mockDataSet = new DataSet();
            mockDataSet.Tables.Add(dataTable);

            // Mock hành vi của fn.getData
            _mockFunction.Setup(fn => fn.getData(query)).Returns(mockDataSet);

            // Thiết lập _ucEmployee2
            _ucEmployee2.fn = _mockFunction.Object;
            _ucEmployee2.setEmployee();

            // Act
            _ucEmployee2.tbSearch.Text = searchText;
            _ucEmployee2.tbSearch_TextChanged(this, EventArgs.Empty);

            // Assert
            var dataGridView = _ucEmployee2.guna2DataGridView1;
            Assert.That(dataGridView, Is.Not.Null, "DataGridView should not be null.");
            Assert.That(dataGridView.Rows.Count, Is.EqualTo(1), "Filtered data should only contain one row.");
            Assert.That(dataGridView.Rows[0].Cells["Họ Tên"].Value, Is.EqualTo("John Doe"), "The filtered row should match the search text.");
        }



        [Test]
        public void Guna2DataGridView1_CellClick_ShouldChangePasswordSuccessfully_WhenCorrectCurrentPasswordProvided()
        {
            // Arrange
            var table = new DataTable();
            table.Columns.Add("MANV", typeof(string));
            table.Rows.Add("NV001");
            _ucEmployee2.guna2DataGridView1.DataSource = table;

            string currentPassword = "nva"; // Mật khẩu hiện tại
            string newPassword = "123"; // Mật khẩu mới
            string confirmPassword = "123"; // Xác nhận mật khẩu mới

            _mockFunction.Setup(fn => fn.getData2(It.IsAny<string>())).Returns(currentPassword);

            _ucEmployee2.manv = "NV001"; // Set current employee ID to match the selected row

            // Act
            _ucEmployee2.guna2DataGridView1_CellClick(this, new DataGridViewCellEventArgs(0, 0));

            System.Threading.Thread.Sleep(100);

            // Assert: Kiểm tra form ChangePassword được hiển thị
            var cpDialog = Application.OpenForms.OfType<ChangePassword>().FirstOrDefault();
            Assert.That(cpDialog, Is.Not.Null, "ChangePassword dialog was not opened.");

            // Điền giá trị mật khẩu
            var txtBox1 = cpDialog.Controls.OfType<Guna2TextBox>().FirstOrDefault(tb => tb.Name == "guna2TextBox1");
            var txtBox2 = cpDialog.Controls.OfType<Guna2TextBox>().FirstOrDefault(tb => tb.Name == "guna2TextBox2");
            var txtBox3 = cpDialog.Controls.OfType<Guna2TextBox>().FirstOrDefault(tb => tb.Name == "guna2TextBox3");
            Assert.That(txtBox1, Is.Not.Null, "guna2TextBox1 is null in ChangePassword form.");
            Assert.That(txtBox2, Is.Not.Null, "guna2TextBox2 is null in ChangePassword form.");
            Assert.That(txtBox3, Is.Not.Null, "guna2TextBox3 is null in ChangePassword form.");

            // Set giá trị cho các ô mật khẩu
            txtBox1.Text = currentPassword;
            txtBox2.Text = newPassword;
            txtBox3.Text = confirmPassword;

            // Nhấn nút "Đổi mật khẩu"
            var changePasswordButton = cpDialog.Controls.OfType<Guna2Button>().FirstOrDefault(btn => btn.Name == "guna2Button1");
            Assert.That(changePasswordButton, Is.Not.Null, "Change password button is null.");
            changePasswordButton.PerformClick();

            // Kiểm tra hành vi sau khi đổi mật khẩu
            _mockFunction.Verify(fn => fn.setData(
                It.Is<string>(q => q.Contains("UPDATE TAIKHOAN SET MATKHAU = '" + newPassword + "' WHERE MANV = 'NV001'")),
                It.IsAny<string>()), Times.Once, "Password was not updated as expected.");

            // Đóng form
            Assert.That(cpDialog.Visible, Is.False, "ChangePassword dialog was not closed.");
        }



        [Test]
        public void Guna2Button1_Click_ShouldExportDataToExcel()
        {
            // Arrange
            var saveFileDialogMock = new Mock<SaveFileDialog>();
            saveFileDialogMock.Setup(s => s.ShowDialog()).Returns(DialogResult.OK);
            saveFileDialogMock.SetupGet(s => s.FileName).Returns("output.xlsx");

            SaveFileDialog _saveFileDialog = new SaveFileDialog();
            _saveFileDialog.ShowDialog();

            // Act
            _ucEmployee2.guna2Button1_Click(this, EventArgs.Empty);

            // Assert
            _mockFunction.Verify(fn => fn.ToExcel(It.IsAny<DataGridView>(), "output.xlsx"), Times.Once);
        }

    }

}
