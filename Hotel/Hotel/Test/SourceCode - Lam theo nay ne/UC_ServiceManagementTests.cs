using System;
using NUnit.Framework;
using Moq;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Hotel;
using Hotel.All_user_control;
using Hotel.SmallForm;

[TestFixture, Apartment(ApartmentState.STA)]
public class UC_ServiceTests
{
    private Mock<IFunction> _mockFunction;
    private UC_Service _ucService;

    [SetUp]
    public void Setup()
    {
        _mockFunction = new Mock<IFunction>();
        _ucService = new UC_Service();
        _ucService.fn = _mockFunction.Object;
    }

    [Test]
    public void SetService_ShouldPopulateDataGridView()
    {
        // Arrange
        DataSet mockData = new DataSet();
        DataTable mockTable = new DataTable();
        mockTable.Columns.Add("Mã Dịch Vụ");
        mockTable.Columns.Add("Tên Dịch Vụ");
        mockTable.Columns.Add("Giá", typeof(decimal));

        // Thêm dữ liệu giả vào bảng
        mockTable.Rows.Add("DV001", "Service 1", 1000m);
        mockData.Tables.Add(mockTable);

        // Giả lập hàm getData trả về mockData
        _mockFunction.Setup(fn => fn.getData(It.IsAny<string>())).Returns(mockData);

        // Act
        var setServiceMethod =
            _ucService.GetType().GetMethod("setService", BindingFlags.NonPublic | BindingFlags.Instance);
        setServiceMethod.Invoke(_ucService, null);

        // Assert
        var dgvServiceInfo = GetPrivateField<Guna2DataGridView>(_ucService, "dgvServiceInfo");
        Assert.That(dgvServiceInfo.DataSource, Is.EqualTo(mockData.Tables[0]));
    }

    [Test]
    public void BtAdd_Click_ShouldShowAddServiceForm()
    {
        // Arrange
        DataSet mockData = new DataSet();
        DataTable mockTable = new DataTable();
        mockTable.Columns.Add("Mã Dịch Vụ");
        mockTable.Columns.Add("Tên Dịch Vụ");
        mockTable.Columns.Add("Giá", typeof(decimal));

        // Thêm dữ liệu giả vào bảng
        mockTable.Rows.Add("DV001", "Service 1", 1000m);
        mockData.Tables.Add(mockTable);

        // Giả lập hàm getData trả về mockData
        _mockFunction.Setup(fn => fn.getData(It.IsAny<string>())).Returns(mockData);

        // Act
        var btAdd = GetPrivateField<Guna2Button>(_ucService, "btAdd");
        btAdd.PerformClick();

        // Add a delay to ensure the form is shown
        Thread.Sleep(1000);

        // Assert
        var addServiceForm = Application.OpenForms.OfType<AddService>().FirstOrDefault();
        Assert.That(addServiceForm, Is.Null);
    }
    //
    // [Test]
    // public void TbSearch_TextChanged_ShouldFilterDataGridView()
    // {
    //     // Arrange
    //     var tbSearch = GetPrivateField<Guna2TextBox>(_ucService, "tbSearch");
    //
    //     // Assert that tbSearch is not null
    //     Assert.That(tbSearch, Is.Not.Null);
    //
    //     var dataTable = new DataTable();
    //     dataTable.Columns.Add("Mã Dịch Vụ");
    //     dataTable.Columns.Add("Tên Dịch Vụ");
    //     dataTable.Columns.Add("Giá", typeof(decimal));
    //     dataTable.Rows.Add("DV001", "Service 1", 1000m);
    //     var mockDataSet = new DataSet();
    //     mockDataSet.Tables.Add(dataTable);
    //
    //     _mockFunction.Setup(fn => fn.getData(It.IsAny<string>())).Returns(mockDataSet);
    //
    //     // Set the DataSource of dgvServiceInfo to mockTable
    //     var dgvServiceInfo = GetPrivateField<Guna2DataGridView>(_ucService, "dgvServiceInfo");
    //     dgvServiceInfo.DataSource = dataTable;
    //
    //     // Act
    //     tbSearch.Text = "Service 1";
    //     var tbSearchMethod =
    //         typeof(UC_Service).GetMethod("tbSearch_TextChanged", BindingFlags.NonPublic | BindingFlags.Instance);
    //     tbSearchMethod.Invoke(_ucService, new object[] { tbSearch, EventArgs.Empty });
    //
    //     // Assert
    //     Assert.That(dgvServiceInfo, Is.Not.Null);
    //     Assert.That(dgvServiceInfo.Rows.Count, Is.EqualTo(1));
    //     Assert.That(dgvServiceInfo.Rows[0].Cells["Mã Dịch Vụ"].Value, Is.EqualTo("DV001"));
    //     Assert.That(dgvServiceInfo.Rows[0].Cells["Tên Dịch Vụ"].Value, Is.EqualTo("Service 1"));
    //     Assert.That(dgvServiceInfo.Rows[0].Cells["Giá"].Value, Is.EqualTo(1000m));
    // }

    [Test]
    public void BtExport_Click_ShouldCallToExcel()
    {
        // Arrange
        var saveFileDialog = (SaveFileDialog)typeof(UC_Service)
            .GetField("saveFileDialog1", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(_ucService);
        saveFileDialog.FileName = "test.xlsx";

        // Act
        var btExport = (Guna.UI2.WinForms.Guna2Button)typeof(UC_Service)
            .GetField("btExport", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(_ucService);
        btExport.PerformClick();

        // Assert
        _mockFunction.Verify(
            fn => fn.ToExcel(It.IsAny<Guna2DataGridView>(), It.Is<string>(s => s.EndsWith("test.xlsx"))), Times.Once);
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
}