using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public GenderEnum Gender { get; set; }


        public Person()
        {

        }
        public Person(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public enum GenderEnum 
        {
            Male,
            Female
        }

        public override string ToString()
        {
            return $"The {Gender}'s name is {Name} and the birthday is {Birthday.ToString()}";
        }
    }
}
