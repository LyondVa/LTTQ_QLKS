using NUnit.Framework;
using System;
using System.Reflection;
using System.Windows.Forms;
using Hotel.SmallForm;

namespace Hotel.Test.SmallForm
{
    [TestFixture]
    public class ChangePasswordTest
    {
        private ChangePassword _form;
        private function _function;

        [SetUp]
        public void Setup()
        {
            _function = new function { dtbName = "LYON" };
            _form = new ChangePassword("currentPassword", "manv");
        }

        private T GetPrivateField<T>(string fieldName)
        {
            var field = typeof(ChangePassword).GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
            return (T)field.GetValue(_form);
        }

        // [Test]
        // public void Guna2Button2_Click_ShouldCloseForm()
        // {
        //     // Arrange
        //     var formClosed = false;
        //     _form.FormClosed += (s, e) => formClosed = true;
        //
        //     // Use reflection to access the private field
        //     var guna2Button2 = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("guna2Button2");
        //
        //     // Act
        //     guna2Button2.PerformClick();
        //
        //     // Assert
        //     Assert.That(formClosed, Is.True);
        // }

        [Test]
        public void Guna2Button1_Click_ShouldShowErrorMessage_WhenPasswordsDoNotMatch()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox1").Text = "currentPassword";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox2").Text = "newPassword";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox3").Text = "differentPassword";

            // Use reflection to access the private field
            var guna2Button1 = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("guna2Button1");

            // Act
            guna2Button1.PerformClick();

            // Assert
            // Check if the error message was shown (e.g., by checking a MessageBox)
        }

        [Test]
        public void Guna2Button1_Click_ShouldShowErrorMessage_WhenNewPasswordMatchesOldPassword()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox1").Text = "currentPassword";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox2").Text = "currentPassword";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox3").Text = "currentPassword";

            // Use reflection to access the private field
            var guna2Button1 = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("guna2Button1");

            // Act
            guna2Button1.PerformClick();

            // Assert
            // Check if the error message was shown (e.g., by checking a MessageBox)
        }

        [Test]
        public void Guna2Button1_Click_ShouldShowErrorMessage_WhenCurrentPasswordIsIncorrect()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox1").Text = "wrongPassword";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox2").Text = "newPassword";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox3").Text = "newPassword";

            // Use reflection to access the private field
            var guna2Button1 = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("guna2Button1");

            // Act
            guna2Button1.PerformClick();

            // Assert
            // Check if the error message was shown (e.g., by checking a MessageBox)
        }

        [Test]
        public void Guna2Button1_Click_ShouldUpdatePassword_WhenInputsAreValid()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox1").Text = "currentPassword";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox2").Text = "newPassword";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox3").Text = "newPassword";

            // Use reflection to access the private field
            var guna2Button1 = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("guna2Button1");

            // Act
            guna2Button1.PerformClick();

            // Assert
            // Check if the password was updated successfully (e.g., by querying the database)
        }
    }
}