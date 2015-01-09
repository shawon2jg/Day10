using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
   
        public double Diameter(double radius)
        {
            return 2*radius;
        }

        public double Perimeter(double radius)
        {
            return Math.PI*Diameter(radius);
        }

        public double Area(double radius)
        {
            return Math.PI*radius*radius;
        }
    }
}
