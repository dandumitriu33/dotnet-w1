using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public Person(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        enum gender 
        {
            Male,
            Female
        }

        public override string ToString()
        {
            return $"The person's name is {Name} and the birthday is {Birthday.ToString()}";
        }
    }
}
