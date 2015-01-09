using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person();
            aPerson.firstName = "Tahsina";
            aPerson.middleName = "";
            aPerson.lastName = "Bristy";
            Console.WriteLine(aPerson.GetFullName());
            Console.WriteLine(aPerson.GetReverseName());

            Console.WriteLine();

            Person bPerson = new Person();
            bPerson.firstName = "Tayabur";
            bPerson.middleName = "Rahman";
            bPerson.lastName = "Masud";
            Console.WriteLine(bPerson.GetFullName());
            Console.WriteLine(bPerson.GetReverseName());

            Console.ReadKey();
        }
    }
}
