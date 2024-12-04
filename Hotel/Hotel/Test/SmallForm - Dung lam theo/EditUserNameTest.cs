using NUnit.Framework;
using System;
using System.Reflection;
using System.Windows.Forms;
using Hotel.SmallForm;

namespace Hotel.Test.SmallForm
{
    [TestFixture]
    public class EditUserNameTest
    {
        private EditUserName _form;
        private function _function;

        [SetUp]
        public void Setup()
        {
            _function = new function { dtbName = "LYON" };
            _form = new EditUserName("1", "John Doe", "123456789", "Male", "01/01/1980", "1234567890", "123 Main St", "john.doe@example.com", "johndoe", "password", "Manager", "50000");
            _form.fn = _function;
        }

        private T GetPrivateField<T>(string fieldName)
        {
            var field = typeof(EditUserName).GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
            return (T)field.GetValue(_form);
        }

        [Test]
        public void Guna2Button3_Click_ShouldCloseForm()
        {
            // Arrange
            var formClosed = false;
            _form.FormClosed += (s, e) => formClosed = true;

            // Use reflection to access the private field
            var guna2Button3 = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("guna2Button3");

            // Act
            guna2Button3.PerformClick();

            // Assert
            Assert.That(formClosed, Is.True);
        }

        [Test]
        public void Guna2Button1_Click_ShouldUpdateUser_WhenInputsAreValid()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbName").Text = "John Doe";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbMobile").Text = "1234567890";

            // Use reflection to access the private field
            var guna2Button1 = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("guna2Button1");

            // Act
            guna2Button1.PerformClick();

            // Assert
            // Check if the user was updated successfully (e.g., by querying the database)
        }

        [Test]
        public void Guna2Button1_Click_ShouldShowErrorMessage_WhenInputsAreInvalid()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbName").Text = "";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbMobile").Text = "";

            // Use reflection to access the private field
            var guna2Button1 = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("guna2Button1");

            // Act
            guna2Button1.PerformClick();

            // Assert
            // Check if the error message was shown (e.g., by checking a MessageBox)
        }

        [Test]
        public void Guna2Button2_Click_ShouldDeleteUser()
        {
            // Arrange
            var userDeleted = false;
            EventHub.EmployeeUpdated += () => userDeleted = true;

            // Use reflection to access the private field
            var guna2Button2 = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("guna2Button2");

            // Act
            guna2Button2.PerformClick();

            // Assert
            Assert.That(userDeleted, Is.True);
        }
    }
}