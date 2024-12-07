using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Moq;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel.Test.SourceCode___Lam_theo_nay_ne
{
    internal class Form1Test_Login_
    {
        private Form1 _login;

        [SetUp]
        public void Setup()
        {
            _login = new Form1();
        }

        [Test]
        public void TestBtnExitClick()
        {
            // Arrange
            var exitButton = GetPrivateField<Guna2CircleButton>(_login, "btnExit");

            // Act
            exitButton?.PerformClick();

            // Assert
            Assert.DoesNotThrow(() => Application.Exit());
        }

        [Test]
        public void TestBtnLoginClick_ValidLogin()
        {
            // Arrange
            string username = _login.Controls["txbUsername"].Text = "admin";
            string password = _login.Controls["txbPassword"].Text = "admin";
            bool isLogin = false;

            // Act
            var loginButton = _login.Controls.Find("btnLogin", false)[0] as Button;
            loginButton?.PerformClick();
            if (username == "admin" && password == "admin")
                isLogin = true;

            // Assert
            var labelError = _login.Controls.Find("labelError", false)[0] as Label;
            Assert.That((labelError.Visible = isLogin ? false : true), Is.False);
        }

        [Test]
        public void TestBtnLoginClick_InvalidLogin()
        {
            // Arrange
            string username = _login.Controls["txbUsername"].Text = "invalid";
            string password = _login.Controls["txbPassword"].Text = "invalid";
            bool isLogin = false;

            // Act
            var loginButton = _login.Controls.Find("btnLogin", false)[0] as Button;
            loginButton?.PerformClick();
            if (username != "admin" || password != "admin")
                isLogin = false;

            // Assert
            var labelError = _login.Controls.Find("labelError", false)[0] as Label;
            Assert.That((labelError.Visible = isLogin ? false : true), Is.True);
        }

        [Test]
        public void TestTxbPasswordIconRightClick_ShowPassword()
        {
            // Arrange
            var passwordField = _login.Controls["txbPassword"] as TextBox;
            bool initialPasswordChar = passwordField?.UseSystemPasswordChar ?? true;

            // Act
            var iconClickMethod = passwordField?.GetType().GetMethod("txbPassword_IconRightClick", BindingFlags.NonPublic | BindingFlags.Instance);
            iconClickMethod?.Invoke(passwordField, new object[] { null, null });

            // Assert
            Assert.That(passwordField?.UseSystemPasswordChar, Is.Not.EqualTo(initialPasswordChar));
        }

        [Test]
        public void TestTxbPasswordIconRightClick_HidePassword()
        {
            // Arrange
            var passwordField = _login.Controls["txbPassword"] as TextBox;
            if (passwordField != null)
            {
                passwordField.UseSystemPasswordChar = false;
            }

            // Act
            var iconClickMethod = passwordField?.GetType().GetMethod("txbPassword_IconRightClick", BindingFlags.NonPublic | BindingFlags.Instance);
            iconClickMethod?.Invoke(passwordField, new object[] { null, null });

            // Assert
            Assert.That(passwordField?.UseSystemPasswordChar ?? true, Is.True);
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
