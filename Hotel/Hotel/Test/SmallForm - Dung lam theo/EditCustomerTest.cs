using NUnit.Framework;
using System;
using System.Reflection;
using System.Windows.Forms;
using Hotel.SmallForm;

namespace Hotel.Test.SmallForm
{
    [TestFixture]
    public class EditCustomerTest
    {
        private EditCustomer _form;
        private function _function;

        [SetUp]
        public void Setup()
        {
            _function = new function { dtbName = "LYON" };
            _form = new EditCustomer("1", "John Doe", "USA", "123456789", "Nam", "01/01/1980", "1234567890", "123 Main St", "john.doe@example.com");
            _form.fn = _function;
        }

        private T GetPrivateField<T>(string fieldName)
        {
            var field = typeof(EditCustomer).GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
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
        public void BtSave_Click_ShouldSaveCustomer_WhenInputsAreValid()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbCustomerName").Text = "John Doe";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbCustomerPhone").Text = "1234567890";

            // Use reflection to access the private field
            var btSave = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("btSave");

            // Act
            btSave.PerformClick();

            // Assert
            // Check if the customer was saved successfully (e.g., by querying the database)
        }

        [Test]
        public void BtSave_Click_ShouldShowErrorMessage_WhenInputsAreInvalid()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbCustomerName").Text = "";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbCustomerPhone").Text = "";

            // Use reflection to access the private field
            var btSave = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("btSave");

            // Act
            btSave.PerformClick();

            // Assert
            // Check if the error message was shown (e.g., by checking a MessageBox)
        }
    }
}