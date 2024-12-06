using NUnit.Framework;
using System;
using System.Reflection;
using System.Windows.Forms;
using Hotel.RoomControls;
using Guna.UI2.WinForms;
using System.Collections.Generic;

namespace Hotel.Test.SourceCode
{
    [TestFixture]
    public class UC_RoomGridTest
    {
        private UC_RoomGrid _roomGrid;

        [SetUp]
        public void SetUp()
        {
            _roomGrid = new UC_RoomGrid();
        }

        [Test]
        public void TestPopulateGrid_DefaultCriterion()
        {
            // Arrange
            InvokePrivateMethod(_roomGrid, "PopulateList", new object[] { 1 });

            // Act
            InvokePrivateMethod(_roomGrid, "PopulateGrid", new object[] { 0 });

            // Assert
            Assert.That(_roomGrid.Controls, Is.Not.Null);
            Assert.That(_roomGrid.Controls.Count, Is.GreaterThan(0));
        }

        [Test]
        public void TestSearchTimeConversion_Morning()
        {
            // Arrange
            SetPrivateFieldValue(_roomGrid, "dTPFilter", DateTime.Parse("2023-12-03"));
            SetPrivateComboBoxIndex(_roomGrid, "cBTime", 0);

            // Act
            InvokePrivateMethod(_roomGrid, "SearchTimeConversion", null);

            // Assert
            var searchTime = GetPrivateField<DateTime>(_roomGrid, "searchTime");
            Assert.That(searchTime, Is.EqualTo(DateTime.Parse("2023-12-03 12:0:0")));
        }

        [Test]
        public void TestSearchTimeConversion_Afternoon()
        {
            // Arrange
            SetPrivateFieldValue(_roomGrid, "dTPFilter", DateTime.Parse("2023-12-03"));
            SetPrivateComboBoxIndex(_roomGrid, "cBTime", 1);

            // Act
            InvokePrivateMethod(_roomGrid, "SearchTimeConversion", null);

            // Assert
            var searchTime = GetPrivateField<DateTime>(_roomGrid, "searchTime");
            Assert.That(searchTime, Is.EqualTo(DateTime.Parse("2023-12-03 14:0:0")));
        }

        [Test]
        public void TestUpdateGrid()
        {
            // Arrange
            InvokePrivateMethod(_roomGrid, "PopulateList", new object[] { 1 });

            // Act
            InvokePrivateMethod(_roomGrid, "UpdateGrid", null);

            // Assert
            Assert.That(_roomGrid.Controls, Is.Not.Null);
            Assert.That(_roomGrid.Controls.Count, Is.GreaterThan(0));
        }

        [Test]
        public void TestLoadRoomEmpty()
        {
            // Arrange
            SetPrivateField(_roomGrid, "rooms", new List<UC_RoomUnitBase>
            {
                new UC_RoomUnitBase { RoomStatus = "Bình thường", CheckInDate = "" },
                new UC_RoomUnitBase { RoomStatus = "Bình thường", CheckInDate = "2023-12-03" }
            });

            // Act
            InvokePrivateMethod(_roomGrid, "LoadRoomEmpty", null);

            // Assert
            var rooms = GetPrivateField<List<UC_RoomUnitBase>>(_roomGrid, "rooms");
            Assert.That(rooms.Count, Is.EqualTo(1));
            Assert.That(rooms[0].CheckInDate, Is.EqualTo(""));
        }

        [Test]
        public void TestFilter_Changed()
        {
            // Arrange
            SetPrivateFieldValue(_roomGrid, "dTPFilter", DateTime.Parse("2023-12-03"));
            SetPrivateComboBoxIndex(_roomGrid, "cBTime", 0);

            // Act
            _roomGrid.GetType().GetMethod("Filter_Changed", BindingFlags.NonPublic | BindingFlags.Instance)
                .Invoke(_roomGrid, new object[] { null, EventArgs.Empty });

            // Assert
            var searchTime = GetPrivateField<DateTime>(_roomGrid, "searchTime");
            Assert.That(searchTime, Is.EqualTo(DateTime.Parse("2023-12-03 12:0:0")));
            Assert.That(_roomGrid.Controls, Is.Not.Null);
            Assert.That(_roomGrid.Controls.Count, Is.GreaterThan(0));
        }

        [Test]
        public void TestDTPFilter_ValueChanged()
        {
            // Arrange
            SetPrivateFieldValue(_roomGrid, "dTPFilter", DateTime.Parse("2023-12-03"));

            // Act
            _roomGrid.GetType().GetMethod("dTPFilter_ValueChanged", BindingFlags.NonPublic | BindingFlags.Instance)
                .Invoke(_roomGrid, new object[] { null, EventArgs.Empty });

            // Assert
            var searchTime = GetPrivateField<DateTime>(_roomGrid, "searchTime");
            Assert.That(searchTime, Is.EqualTo(DateTime.Parse("2023-12-03 14:00:00")));
            Assert.That(_roomGrid.Controls, Is.Not.Null);
            Assert.That(_roomGrid.Controls.Count, Is.GreaterThan(0));
        }

        [Test]
        public void TestCBTime_SelectedIndexChanged()
        {
            // Arrange
            SetPrivateComboBoxIndex(_roomGrid, "cBTime", 1);

            // Act
            _roomGrid.GetType().GetMethod("cBTime_SelectedIndexChanged", BindingFlags.NonPublic | BindingFlags.Instance)
                .Invoke(_roomGrid, new object[] { null, EventArgs.Empty });

            // Assert
            var searchTime = GetPrivateField<DateTime>(_roomGrid, "searchTime");
            Assert.That(searchTime, Is.EqualTo(DateTime.Parse("2024-12-05 14:0:0")));
            Assert.That(_roomGrid.Controls, Is.Not.Null);
            Assert.That(_roomGrid.Controls.Count, Is.GreaterThan(0));
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
            fieldInfo.SetValue(obj, value);
        }

        private void SetPrivateFieldValue(object obj, string fieldName, DateTime value)
        {
            FieldInfo fieldInfo = obj.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldInfo == null)
            {
                throw new ArgumentException($"Field '{fieldName}' not found in type '{obj.GetType().FullName}'.");
            }
            var dateTimePicker = (Guna2DateTimePicker)fieldInfo.GetValue(obj);
            dateTimePicker.Value = value;
        }

        private void SetPrivateComboBoxIndex(object obj, string fieldName, int index)
        {
            FieldInfo fieldInfo = obj.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldInfo == null)
            {
                throw new ArgumentException($"Field '{fieldName}' not found in type '{obj.GetType().FullName}'.");
            }
            var comboBox = (Guna2ComboBox)fieldInfo.GetValue(obj);
            comboBox.SelectedIndex = index;
        }
    }
}