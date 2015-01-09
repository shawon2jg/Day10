using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{

    class Program
    {
        
        static void Main(string[] args)
        {
            Circle aCircle = new Circle();

            Console.Write("Enter the Radius of a circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            if (radius < 1)
            {
                Console.Write("Radius cann't be negative!!! ");
            }
            else
            {
                Console.Write("The diameter of the circle is: ");
                Console.WriteLine(aCircle.Diameter(radius));

                Console.Write("The perimeter of the circle is: ");
                Console.WriteLine(aCircle.Perimeter(radius));

                Console.Write("The area of the circle is: ");
                Console.WriteLine(aCircle.Area(radius));
            }

            Console.ReadKey();

        }
    }
}
