using NUnit.Framework;
using System;
using System.Reflection;
using System.Windows.Forms;
using Hotel.SmallForm;

namespace Hotel.Test.SmallForm
{
    [TestFixture]
    public class EmployeeInformationTest
    {
        private EmployeeInformation _form;

        [SetUp]
        public void Setup()
        {
            _form = new EmployeeInformation("John Doe", "123456789", "Male", "john.doe@example.com", "johndoe", "password", "Manager");
        }

        private T GetPrivateField<T>(string fieldName)
        {
            var field = typeof(EmployeeInformation).GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
            return (T)field.GetValue(_form);
        }

        [Test]
        public void Guna2Button1_Click_ShouldCloseForm()
        {
            // Arrange
            var formClosed = false;
            _form.FormClosed += (s, e) => formClosed = true;

            // Use reflection to access the private field
            var guna2Button1 = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("guna2Button1");

            // Act
            guna2Button1.PerformClick();

            // Assert
            Assert.That(formClosed, Is.True);
        }

        [Test]
        public void EmployeeInformation_Load_ShouldInitializeFields()
        {
            // Act
            _form.Show();

            // Assert
            Assert.That(GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox1").Text, Is.EqualTo("John Doe"));
            Assert.That(GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox2").Text, Is.EqualTo("123456789"));
            Assert.That(GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox3").Text, Is.EqualTo("Male"));
            Assert.That(GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox4").Text, Is.EqualTo("john.doe@example.com"));
            Assert.That(GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox5").Text, Is.EqualTo("johndoe"));
            Assert.That(GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox6").Text, Is.EqualTo("password"));
            Assert.That(GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("guna2TextBox7").Text, Is.EqualTo("Manager"));
        }
    }
}