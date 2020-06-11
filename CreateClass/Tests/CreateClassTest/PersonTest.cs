using System;
using CreateClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreateClassTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void PersonToStringTestValid()
        {
            // Arrange
            var mike = new Person();
            mike.Name = "Mike";
            mike.Gender = Person.GenderEnum.Male;
            mike.Birthday = new DateTime(2002, 04, 23);
            string expected = "The Male's name is Mike and the birthday is 4/23/2002 12:00:00 AM";


            // Act
            string actual = mike.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
