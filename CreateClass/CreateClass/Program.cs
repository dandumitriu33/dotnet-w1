using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var jim = new Person("Jim", new DateTime(04 / 05 / 2001));
            jim.Gender = Person.GenderEnum.Male;
            jim.Birthday = new DateTime(2001, 04, 01);

            Employee mike = new Employee();
            mike.Name = "Mike";
            mike.Birthday = new DateTime(2003, 02, 21);
            mike.Gender = Person.GenderEnum.Male;
            mike.Profession = "programmer";
            mike.Salary = 5000000.12;
            mike.RoomNumber = 5;

            Console.WriteLine(jim.ToString());
            Console.WriteLine(mike.ToString());
        }
    }
}
