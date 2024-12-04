using NUnit.Framework;
using System;
using System.Reflection;
using System.Windows.Forms;
using Hotel.SmallForm;

namespace Hotel.Test.SmallForm
{
    [TestFixture]
    public class AddEmployeeTest
    {
        private AddEmployee _form;
        private function _function;

        [SetUp]
        public void Setup()
        {
            _function = new function { dtbName = "LYON" };
            _form = new AddEmployee();
            _form.fn = _function;
        }

        private T GetPrivateField<T>(string fieldName)
        {
            var field = typeof(AddEmployee).GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
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
        public void BtAdd_Click_ShouldAddEmployee_WhenInputsAreValid()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbName").Text = "Jane Doe";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbPosition").Text = "Manager";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbCCCD").Text = "987654321";
            GetPrivateField<Guna.UI2.WinForms.Guna2DateTimePicker>("txtBirth").Value = DateTime.Now.AddYears(-25);
            GetPrivateField<Guna.UI2.WinForms.Guna2ComboBox>("cbGender").Text = "Female";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbPhone").Text = "0123456789";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbAddress").Text = "456 Main St";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbEmail").Text = "jane.doe@example.com";

            // Use reflection to access the private field
            var btAdd = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("btAdd");

            // Act
            btAdd.PerformClick();

            // Assert
            // Check if the employee was added successfully (e.g., by querying the database)
        }

        [Test]
        public void BtAdd_Click_ShouldShowErrorMessage_WhenInputsAreInvalid()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbName").Text = "";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbPosition").Text = "";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbCCCD").Text = "";
            GetPrivateField<Guna.UI2.WinForms.Guna2DateTimePicker>("txtBirth").Value = DateTime.Now;
            GetPrivateField<Guna.UI2.WinForms.Guna2ComboBox>("cbGender").Text = "";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbPhone").Text = "";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbAddress").Text = "";
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbEmail").Text = "";

            // Use reflection to access the private field
            var btAdd = GetPrivateField<Guna.UI2.WinForms.Guna2Button>("btAdd");

            // Act
            btAdd.PerformClick();

            // Assert
            // Check if the error message was shown (e.g., by checking a MessageBox)
        }

        [Test]
        public void TbCCCD_TextChanged_ShouldEnableAddButton_WhenCCCDIsUnique()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbCCCD").Text = "987654321";

            // Act
            _form.GetType().GetMethod("tbCCCD_TextChanged", BindingFlags.NonPublic | BindingFlags.Instance)
                .Invoke(_form, new object[] { null, null });

            // Assert
            Assert.That(GetPrivateField<Guna.UI2.WinForms.Guna2Button>("btAdd").Enabled, Is.True);
        }

        [Test]
        public void TbCCCD_TextChanged_ShouldDisableAddButton_WhenCCCDIsNotUnique()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbCCCD").Text = "ExistingCCCD";

            // Act
            _form.GetType().GetMethod("tbCCCD_TextChanged", BindingFlags.NonPublic | BindingFlags.Instance)
                .Invoke(_form, new object[] { null, null });

            // Assert
            Assert.That(GetPrivateField<Guna.UI2.WinForms.Guna2Button>("btAdd").Enabled, Is.False);
        }

        [Test]
        public void TbPhone_TextChanged_ShouldEnableAddButton_WhenPhoneIsUnique()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbPhone").Text = "0123456789";

            // Act
            _form.GetType().GetMethod("tbPhone_TextChanged", BindingFlags.NonPublic | BindingFlags.Instance)
                .Invoke(_form, new object[] { null, null });

            // Assert
            Assert.That(GetPrivateField<Guna.UI2.WinForms.Guna2Button>("btAdd").Enabled, Is.True);
        }

        [Test]
        public void TbPhone_TextChanged_ShouldDisableAddButton_WhenPhoneIsNotUnique()
        {
            // Arrange
            GetPrivateField<Guna.UI2.WinForms.Guna2TextBox>("tbPhone").Text = "ExistingPhone";

            // Act
            _form.GetType().GetMethod("tbPhone_TextChanged", BindingFlags.NonPublic | BindingFlags.Instance)
                .Invoke(_form, new object[] { null, null });

            // Assert
            Assert.That(GetPrivateField<Guna.UI2.WinForms.Guna2Button>("btAdd").Enabled, Is.False);
        }

        [Test]
        public void TbPhone_KeyPress_ShouldAllowOnlyNumericInput()
        {
            // Arrange
            var keyPressEventArgs = new KeyPressEventArgs('a');

            // Act
            _form.GetType().GetMethod("tbPhone_KeyPress", BindingFlags.NonPublic | BindingFlags.Instance)
                .Invoke(_form, new object[] { null, keyPressEventArgs });

            // Assert
            Assert.That(keyPressEventArgs.Handled, Is.True);
        }
    }
}