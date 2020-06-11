﻿using System;
using CreateClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreateClassTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void EmployeeToStringTestValid()
        {
            // Arrange
            var mike = new Employee();
            mike.Name = "Mike";
            mike.Gender = Person.GenderEnum.Male;
            mike.Birthday = new DateTime(2002, 04, 23);
            mike.Profession = "programmer";
            mike.Salary = 300.5;
            mike.RoomNumber = 5;
            string expected = "The Male's Employee info is: Name: Mike, Birthday: 4/23/2002 12:00:00 AM, Profession: programmer, Salary: 300.5, Room 5";

            // Act
            string actual = mike.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
