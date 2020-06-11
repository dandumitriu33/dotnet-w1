using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Employee : Person, Room
    {
        public int RoomNumber { get; set; }
        public Employee() 
        {
            
        }
        public double Salary { get; set; }
        public string Profession { get; set; }

        public override string ToString()
        {
            return $"The {Gender}'s Employee info is: Name: {Name}, Birthday: {Birthday.ToString()}, " +
                $"Profession: {Profession}, Salary: {Salary}, Room {RoomNumber}";
        }
    }
}
