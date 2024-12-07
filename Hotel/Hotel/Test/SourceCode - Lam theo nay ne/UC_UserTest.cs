using System;
using System.Reflection;
using System.Windows.Forms;
using Hotel.RoomControls;
using Guna.UI2.WinForms;
using System.Collections.Generic;
using NUnit.Framework;
using Hotel.All_user_control;
using Moq;
using System.Data;

namespace Hotel.Test.SourceCode___Lam_theo_nay_ne
{
    [TestFixture]
    public class UC_UserTest
    {
        private UC_User _ucUser;
        private Mock<function> _mockFunction;
        private DataSet _mockDataSet;

        [SetUp]
        public void Setup()
        {
            _mockFunction = new Mock<function>();
            _ucUser = new UC_User();

            // Mock DataSet
            _mockDataSet = new DataSet();
            var dataTable = new DataTable();
            dataTable.Columns.Add("Mã Nhân Viên");
            dataTable.Columns.Add("Họ Tên");
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("Password");
            dataTable.Columns.Add("Chức Vụ");
            dataTable.Rows.Add("NV01", "Nguyễn Văn A", "nva", "nva", "Quản lý");
            _mockDataSet.Tables.Add(dataTable);

            _mockFunction
                .Setup(fn => fn.getData(It.IsAny<string>()))
                .Returns(_mockDataSet);
            SetPrivateField(_ucUser, "fn", _mockFunction.Object);
        }

        [Test]
        public void TestSetEmployee()
        {
            // Act
            _ucUser.setEmployee();

            // Assert
            var dataGrid = GetPrivateField<Guna2DataGridView>(_ucUser, "guna2DataGridView1");
            Assert.That(dataGrid.DataSource, Is.Not.Null);
            var dataSource = dataGrid.DataSource as DataTable;
            Assert.That(dataSource.Rows[0]["Mã Nhân Viên"], Is.EqualTo("NV01"));
        }

        [Test]
        public void TestSearchEmployee()
        {
            // Arrange
            var textBox = GetPrivateField<Guna2TextBox>(_ucUser, "tbSearch");
            textBox.Text = "Nguyễn";

            // Act
            InvokePrivateMethod(_ucUser, "tbSearch_TextChanged", new object[] { null, EventArgs.Empty });

            // Assert
            var dataGrid = GetPrivateField<Guna2DataGridView>(_ucUser, "guna2DataGridView1");
            Assert.That(dataGrid.DataSource, Is.Not.Null);
            var dataSource = dataGrid.DataSource as DataTable;
            Assert.That(dataSource.Rows[0]["Họ Tên"].ToString().Contains("Nguyễn"));
        }

        [Test]
        public void TestAddEmployeeButtonClick()
        {
            // Act
            var button = GetPrivateField<Guna2Button>(_ucUser, "guna2Button2");
            button.PerformClick();

            // Assert
            _mockFunction.Verify(fn => fn.getData(It.IsAny<string>()), Times.AtLeastOnce);
        }

        [Test]
        public void TestDeactivateEmployee()
        {
            // Arrange
            var dataGrid = GetPrivateField<Guna2DataGridView>(_ucUser, "guna2DataGridView1");
            dataGrid.DataSource = _mockDataSet.Tables[0];

            // Act
            var cellEventArgs = new DataGridViewCellEventArgs(0, 0);
            InvokePrivateMethod(_ucUser, "DeactivateEmployee", new object[] { null, cellEventArgs });

            // Assert
            _mockFunction.Verify(fn => fn.setDataNoMsg(It.Is<string>(q => q.Contains("update NHANVIEN set HOATDONG = 0"))), Times.Once);
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
