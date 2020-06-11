using System;
using CreateClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreateClassTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void CreatePersonTestValid()
        {
            // Arrange
            var john = new Person();
            john.Name = "John";
            var expected = "John";

            // Act
            string actual = john.Name;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateEmployeeTestValid()
        {
            // Arrange
            var john = new Employee();
            john.Salary = 300.5;
            var expected = 300.5;

            // Act
            double actual = john.Salary;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
