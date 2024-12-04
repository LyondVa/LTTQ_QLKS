using NUnit.Framework;
using System;
using System.Reflection;
using System.Windows.Forms;
using Hotel.SmallForm;

namespace Hotel.Test.SmallForm
{
    [TestFixture]
    public class AddServiceTest
    {
        private AddService _form;
        private function _function;

        [SetUp]
        public void Setup()
        {
            _function = new function { dtbName = "LYON" };
            _form = new AddService();
            _form.fn = _function;
        }

        private T GetPrivateField<T>(string fieldName)
        {
            var field = typeof(AddService).GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
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
        public void BtAdd_Click_ShouldAddService_WhenInputsAreValid()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbServiceName").Text = "Room Cleaning";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbServicePrice").Text = "50";

            // Use reflection to access the private field
            var btAdd = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("btAdd");

            // Act
            btAdd.PerformClick();

            // Assert
            // Check if the service was added successfully (e.g., by querying the database)
        }

        [Test]
        public void BtAdd_Click_ShouldShowErrorMessage_WhenInputsAreInvalid()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbServiceName").Text = "";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbServicePrice").Text = "";

            // Use reflection to access the private field
            var btAdd = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("btAdd");

            // Act
            btAdd.PerformClick();

            // Assert
            // Check if the error message was shown (e.g., by checking a MessageBox)
        }

        [Test]
        public void TbServicePrice_KeyPress_ShouldAllowOnlyNumericInput()
        {
            // Arrange
            var keyPressEventArgs = new KeyPressEventArgs('a');

            // Act
            _form.GetType().GetMethod("tbServicePrice_KeyPress", BindingFlags.NonPublic | BindingFlags.Instance)
                .Invoke(_form, new object[] { null, keyPressEventArgs });

            // Assert
            Assert.That(keyPressEventArgs.Handled, Is.True);
        }
    }
}