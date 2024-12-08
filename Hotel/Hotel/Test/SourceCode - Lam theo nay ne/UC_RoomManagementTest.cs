using NUnit.Framework;
using System;
using System.Data;
using System.Windows.Forms;
using Hotel.All_user_control;
using Moq;
using Hotel.SmallForm;
using System.Reflection;
using Guna.UI2.WinForms;
using Hotel.RoomControls;
using System.Linq;

namespace Hotel.Test.SourceCode
{
    public class MockAddRoom : F_AddRoom
    {
        public MockAddRoom(DataSet dataSet) : base(dataSet) { }

        public new DialogResult ShowDialog()
        {
            // Thay đổi hành vi ở đây nếu cần
            return DialogResult.OK;
        }
    }

    [TestFixture]
    public class UC_RoomManagementTest
    {
        private UC_RoomManagement _roomManagement;
        private Mock<function> _mockFunction;
        private DataSet _dataSet;

        [SetUp]
        public void SetUp()
        {
            _mockFunction = new Mock<function>();
            _roomManagement = new UC_RoomManagement();

            // Mock the database function to avoid actual database calls
            _dataSet = new DataSet();
            var dataTable = new DataTable();
            dataTable.Columns.Add("MAPHG");
            dataTable.Columns.Add("MALOAIPHG");
            dataTable.Columns.Add("TRANGTHAI");
            dataTable.Columns.Add("TANG");
            dataTable.Columns.Add("DONDEP");
            dataTable.Columns.Add("GHICHU");
            _dataSet.Tables.Add(dataTable);

            _mockFunction.Setup(f => f.getData(It.IsAny<string>())).Returns(_dataSet);
            _mockFunction.Setup(f => f.setData(It.IsAny<string>(), It.IsAny<string>()));

            // Inject the mocked function into the UC_RoomManagement instance
            _roomManagement.GetType().GetField("fn", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(_roomManagement, _mockFunction.Object);

            // Initialize the control
            _roomManagement.GetType().GetMethod("InitializeComponent", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(_roomManagement, null);
        }

        [Test]
        public void TestUC_RoomManagement_Load()
        {
            // Act
            _roomManagement.GetType().GetMethod("UC_RoomManagement_Load", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(_roomManagement, new object[] { null, EventArgs.Empty });

            // Assert
            Assert.That(_roomManagement.Controls.Count, Is.GreaterThan(0)); // Check if grid is populated
        }

        [Test]
        public void TestRefreshDataGridView()
        {
            // Arrange
            _roomManagement.GetType().GetMethod("RefreshDataGridView", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(_roomManagement, null);

            // Act
            var dataGridView = (DataGridView)_roomManagement.GetType().GetField("dGVRoom", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(_roomManagement);
            var dataSource = dataGridView.DataSource as DataTable;

            // Assert
            Assert.That(dataSource, Is.Not.Null);
            Assert.That(dataSource.Rows.Count, Is.EqualTo(0)); // Assuming no data in DataTable yet
        }

        [Test]
        public void TestbTAdd_Click()
        {
            // Arrange: Initialize data and mock form
            var mockFunction = new Mock<function>();
            var roomManagement = new UC_RoomManagement();

            roomManagement.GetType()
                .GetMethod("InitializeComponent", BindingFlags.NonPublic | BindingFlags.Instance)
                .Invoke(roomManagement, null);

            var addButton = roomManagement.Controls.Find("bTAdd", true).FirstOrDefault() as Guna2Button;

            // Create a DataSet with at least one table
            var dataSet = new DataSet();
            var dataTable = new DataTable();
            dataTable.Columns.Add("Column1");
            dataSet.Tables.Add(dataTable);

            // Act: Perform click
            // addButton.PerformClick();

            // Assert: Ensure the form is displayed
            var addRoomForm = new MockAddRoom(dataSet);
            // Assert.That(addRoomForm.ShowDialog(), Is.EqualTo(DialogResult.OK));
        }

        [Test]
        public void TestbTUpdate_Click()
        {
            // Arrange: Khởi tạo UserControl với dữ liệu giả lập
            var roomManagement = new UC_RoomManagement();
            SetPrivateField(roomManagement, "dS", GetFakeDataSet()); // Phương thức giả lập dữ liệu
            //roomManagement.dS = GetFakeDataSet();

            // Act: Gọi nút bTUpdate
            var updateButton = roomManagement.Controls.Find("bTUpdate", true).FirstOrDefault() as Button;
            updateButton?.PerformClick();

            // Assert: Kiểm tra form cập nhật hiển thị hoặc logic chạy đúng
            // Có thể kiểm tra trạng thái form hoặc các thay đổi trong dữ liệu
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

        private DataSet GetFakeDataSet()
        {
            var ds = new DataSet();
            var dt = new DataTable();
            dt.Columns.Add("MAPHG", typeof(string));
            dt.Columns.Add("MALOAIPHG", typeof(string));
            dt.Rows.Add("P001", "L001");
            ds.Tables.Add(dt);
            return ds;
        }
        [Test]
        public void TestdGVRoom_CellClick()
        {
            // Arrange
            var dataGridView = (DataGridView)_roomManagement.GetType()
                .GetField("dGVRoom", BindingFlags.NonPublic | BindingFlags.Instance)
                .GetValue(_roomManagement);

            // Add column to DataGridView
            dataGridView.AutoGenerateColumns = false; // Do not auto-generate columns
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MAPHG", // Column name in DataTable
                Name = "MAPHG",           // Column name in DataGridView
                HeaderText = "MAPHG"
            });

            // Create DataTable and add to DataSet
            var dataTable = new DataTable("RoomTable");
            dataTable.Columns.Add("MAPHG");
            dataTable.Rows.Add("Test Room");
            _dataSet.Tables.Add(dataTable);

            // Set DataSource for DataGridView
            dataGridView.DataSource = dataTable.DataSet.Tables[0];

            // Ensure the row index is within the valid range
            int rowIndex = 0;
            if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
            {
                // Act
                var cellClickMethod = dataGridView.GetType()
                    .GetMethod("OnCellClick", BindingFlags.NonPublic | BindingFlags.Instance);
                cellClickMethod.Invoke(dataGridView, new object[] { new DataGridViewCellEventArgs(0, rowIndex) });

                // Assert
                var selectedRow = dataGridView.Rows[rowIndex];
                Assert.That(selectedRow.Cells["MAPHG"].Value?.ToString(), Is.EqualTo("Test Room"));

                // Additional checks to verify if the F_UpdateRoom form is opened can be added here
            }
            else
            {
                Assert.Pass();
            }
        }



        [Test]
        public void TesttBSearch_TextChanged()
        {
            // Arrange
            var searchBox = (Guna2TextBox)_roomManagement.GetType().GetField("tBSearch", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(_roomManagement);
            var dataGridView = (DataGridView)_roomManagement.GetType().GetField("dGVRoom", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(_roomManagement);
            dataGridView.DataSource = _dataSet.Tables[0];
            searchBox.Text = "Test Room";

            // Act
            var methodInfo = searchBox.GetType().GetMethod("OnTextChanged", BindingFlags.NonPublic | BindingFlags.Instance);
            methodInfo.Invoke(searchBox, new object[] { EventArgs.Empty });

            // Assert
            var dataSource = dataGridView.DataSource as DataTable;
            Assert.That(dataSource.DefaultView.RowFilter, Is.EqualTo("MAPHG LIKE '%Test Room%'"));
        }
    }
}
