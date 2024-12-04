using NUnit.Framework;
using System;
using System.Reflection;
using System.Windows.Forms;
using Hotel.All_user_control;
using Hotel.SmallForm;

namespace Hotel.Test.SmallForm
{
    [TestFixture]
    public class F_AddServiceTest
    {
        private F_AddService _form;
        private function _function;

        [SetUp]
        public void Setup()
        {
            _function = new function { dtbName = "LYON" };
            _form = new F_AddService("101", "202");
            _form.fn = _function;
        }

        private T GetPrivateField<T>(string fieldName)
        {
            var field = typeof(F_AddService).GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
            return (T)field.GetValue(_form);
        }

        [Test]
        public void BtExit_Click_ShouldCloseForm()
        {
            // Arrange
            var formClosed = false;
            _form.FormClosed += (s, e) => formClosed = true;

            // Use reflection to access the private field
            var btExit = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("bTExit");

            // Act
            btExit.PerformClick();

            // Assert
            Assert.That(formClosed, Is.True);
        }

        [Test]
        public void BtAdd_Click_ShouldSaveService_WhenServicesAreSelected()
        {
            // Arrange
            var dGVServiceSelection = GetPrivateField<Guna.UI2.WinForms.Guna2DataGridView>("dGVServiceSelection");
            var dGVServiceSelected = GetPrivateField<Guna.UI2.WinForms.Guna2DataGridView>("dGVServiceSelected");

            // Ensure there are rows in the DataGridView
            if (dGVServiceSelection.Rows.Count > 0)
            {
                // Simulate selecting a service
                dGVServiceSelection.Rows[0].Cells["SOLUONG"].Value = 2;
                dGVServiceSelection.Rows[0].Cells["ADD"].Value = true;
            }

            // Use reflection to access the private field
            var btAdd = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("bTAdd");

            // Act
            btAdd.PerformClick();

            // Assert
            // Check if the service was saved successfully (e.g., by querying the database)
        }

        [Test]
        public void BtAdd_Click_ShouldShowErrorMessage_WhenNoServicesAreSelected()
        {
            // Arrange
            var dGVServiceSelected = GetPrivateField<Guna.UI2.WinForms.Guna2DataGridView>("dGVServiceSelected");

            // Ensure no services are selected
            dGVServiceSelected.Rows.Clear();

            // Use reflection to access the private field
            var btAdd = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("bTAdd");

            // Act
            btAdd.PerformClick();

            // Assert
            // Check if the error message was shown (e.g., by checking a MessageBox)
        }
    }
}