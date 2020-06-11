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
            var gigi = new Person("Gigi", new DateTime(04 / 05 / 2001));

            gigi.Birthday = new DateTime(2001, 04, 01);

            Console.WriteLine(gigi.ToString());
        }
    }
}
