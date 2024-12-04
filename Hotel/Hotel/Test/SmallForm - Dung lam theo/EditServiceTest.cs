using NUnit.Framework;
using System;
using System.Reflection;
using System.Windows.Forms;
using Hotel.SmallForm;

namespace Hotel.Test.SmallForm
{
    [TestFixture]
    public class EditServiceTest
    {
        private EditService _form;
        private function _function;

        [SetUp]
        public void Setup()
        {
            _function = new function { dtbName = "LYON" };
            _form = new EditService("1", "Room Cleaning", "50");
            _form.fn = _function;
        }

        private T GetPrivateField<T>(string fieldName)
        {
            var field = typeof(EditService).GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
            return (T)field.GetValue(_form);
        }

        [Test]
        public void BtEsc_Click_ShouldCloseForm()
        {
            // Arrange
            var formClosed = false;
            _form.FormClosed += (s, e) => formClosed = true;

            // Use reflection to access the private field
            var btEsc = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("btEsc");

            // Act
            btEsc.PerformClick();

            // Assert
            Assert.That(formClosed, Is.True);
        }

        [Test]
        public void BtUpdate_Click_ShouldUpdateService_WhenInputsAreValid()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("txtName").Text = "Room Cleaning";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("txtPrice").Text = "50";

            // Use reflection to access the private field
            var btUpdate = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("btUpdate");

            // Act
            btUpdate.PerformClick();

            // Assert
            // Check if the service was updated successfully (e.g., by querying the database)
        }

        [Test]
        public void BtUpdate_Click_ShouldShowErrorMessage_WhenInputsAreInvalid()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("txtName").Text = "";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("txtPrice").Text = "";

            // Use reflection to access the private field
            var btUpdate = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("btUpdate");

            // Act
            btUpdate.PerformClick();

            // Assert
            // Check if the error message was shown (e.g., by checking a MessageBox)
        }

        [Test]
        public void BtDelete_Click_ShouldDeleteService()
        {
            // Arrange
            var serviceDeleted = false;
            EventHub.ServicesUpdated += () => serviceDeleted = true;

            // Use reflection to access the private field
            var btDelete = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("btDelete");

            // Act
            btDelete.PerformClick();

            // Assert
            Assert.That(serviceDeleted, Is.True);
        }
    }
}