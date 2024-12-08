using NUnit.Framework;
using Moq;
using System.Data;
using Hotel.All_user_control;
using System.Windows.Forms;
using System;
using Guna.UI2.WinForms;
using System.Reflection;
using System.Threading;
using System.Windows.Forms.Design;

namespace Hotel.Test.SourceCode___Lam_theo_nay_ne
{

    public static class TestHelperExtensions
    {
        public static object InvokeNonPublicMethod(this object obj, string methodName, params object[] parameters)
        {
            // Lấy loại (type) của object
            var type = obj.GetType();

            // Tìm phương thức (method) với tên và tham số tương ứng
            var method = type.GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);

            if (method == null)
                throw new MissingMethodException($"Method '{methodName}' not found in {type.FullName}.");

            // Gọi phương thức và trả về kết quả
            return method.Invoke(obj, parameters);
        }

        public static T GetField<T>(this object obj, string fieldName)
        {
            // Lấy loại (type) của đối tượng
            var type = obj.GetType();

            // Tìm field theo tên và flag non-public
            var field = type.GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);

            if (field == null)
                throw new MissingFieldException($"Field '{fieldName}' not found in {type.FullName}.");

            // Lấy giá trị field và ép kiểu
            return (T)field.GetValue(obj);
        }

        public static void InvokePrivateEvent(this object obj, string eventName, EventArgs eventArgs)
        {
            // Tìm sự kiện trong lớp obj (trong trường hợp này là _ucService)
            var eventInfo = obj.GetType().GetEvent(eventName, BindingFlags.NonPublic | BindingFlags.Instance);

            // Kiểm tra xem sự kiện có tồn tại không
            if (eventInfo != null)
            {
                // Lấy phương thức Invoke của sự kiện và gọi nó
                var eventDelegate = eventInfo.GetAddMethod();
                eventDelegate.Invoke(obj, new object[] { eventArgs });
            }
            else
            {
                throw new InvalidOperationException($"Event '{eventName}' not found in class {obj.GetType().FullName}");
            }
        }
    }
    [TestFixture, Apartment(ApartmentState.STA)]
    public class UC_ServiceManagementTests
    {
        private Mock<function> _mockFunction;
        private UC_Service _ucService;

        [SetUp]
        public void Setup()
        {
            // Khởi tạo Mock và UC_Service
            _mockFunction = new Mock<function>();
            _ucService = new UC_Service();
            typeof(UC_Service).GetField("fn", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(_ucService, _mockFunction.Object);
        }


        [Test]
        public void Constructor_ShouldInitializeControls()
        {
            // Act
            var instance = new UC_Service();

            // Assert
            Assert.That(instance, Is.Not.Null, "Instance should not be null");

            var btAddField = typeof(UC_Service).GetField("btAdd", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.That(btAddField, Is.Not.Null, "btAdd field should exist");

            var btAdd = (Guna2Button)btAddField.GetValue(instance);
            Assert.That(btAdd.Visible, Is.False, "Button 'btAdd' visibility should be false by default");
        }

        [Test]
        public void SetService_ShouldLoadServicesIntoDataGridView()
        {
            // Arrange
            var testData = new DataSet();
            var dataTable = new DataTable();
            dataTable.Columns.Add("Mã Dịch Vụ");
            dataTable.Columns.Add("Tên Dịch Vụ");
            dataTable.Columns.Add("Giá");
            dataTable.Rows.Add("DV001", "Dịch vụ test", 100000);
            testData.Tables.Add(dataTable);

            _mockFunction.Setup(fn => fn.getData(It.IsAny<string>())).Returns(testData);

            // Act
            _ucService.InvokeNonPublicMethod("setService");

            // Assert
            var dgvServiceInfo = _ucService.GetField<DataGridView>("dgvServiceInfo");
            Assert.That(dgvServiceInfo.Rows.Count, Is.EqualTo(1), "DataGridView should contain 1 row");
            Assert.That(dgvServiceInfo.Rows[0].Cells["Mã Dịch Vụ"].Value.ToString(), Is.EqualTo("DV001"), "Service ID should match");
        }

        [Test]
        public void TbSearch_TextChanged_ShouldFilterServiceData()
        {
            // Arrange
            string searchText = "Massage";
            var dataTable = new DataTable();
            dataTable.Columns.Add("Mã Dịch Vụ");
            dataTable.Columns.Add("Tên Dịch Vụ");
            dataTable.Columns.Add("Giá");

            dataTable.Rows.Add("DV001", "Massage Toàn Thân", 500000);
            var mockDataSet = new DataSet();
            mockDataSet.Tables.Add(dataTable);

            _mockFunction.Setup(fn => fn.getData(It.IsAny<string>())).Returns(mockDataSet);

            _ucService = new UC_Service();
            _ucService.fn = _mockFunction.Object;

            // Act
            _ucService.tbSearch.Text = searchText;
            _ucService.tbSearch_TextChanged(this, EventArgs.Empty);

            // Assert
            var dataGridView = _ucService.dgvServiceInfo;
            Assert.That(dataGridView, Is.Not.Null, "DataGridView should not be null.");
            Assert.That(dataGridView.Rows.Count, Is.EqualTo(1), "Filtered data should only contain one row.");
            Assert.That(dataGridView.Rows[0].Cells["Tên Dịch Vụ"].Value, Is.EqualTo("Massage Toàn Thân"), "Filtered row does not match search text.");
        }


        [Test]
        public void DeactivateService_ShouldUpdateServiceActivity()
        {
            // Arrange
            var testData = new DataSet();
            var dataTable = new DataTable();
            dataTable.Columns.Add("Mã Dịch Vụ");
            dataTable.Rows.Add("DV002");
            testData.Tables.Add(dataTable);

            _mockFunction.Setup(fn => fn.getData(It.IsAny<string>())).Returns(testData);
            _mockFunction.Setup(fn => fn.setDataNoMsg(It.IsAny<string>())).Verifiable();

            _ucService.InvokeNonPublicMethod("setService");

            var dgvServiceInfo = _ucService.GetField<DataGridView>("dgvServiceInfo");
            dgvServiceInfo.Rows[0].Selected = true;

            // Act
            _ucService.InvokePrivateEvent("DeactivateService", new DataGridViewCellEventArgs(0, 0));

            // Assert
            _mockFunction.Verify(fn => fn.setDataNoMsg(It.Is<string>(q => q.Contains("update DICHVU set HOATDONG = 0 where MADV = 'DV002'"))));
        }

    }
}
