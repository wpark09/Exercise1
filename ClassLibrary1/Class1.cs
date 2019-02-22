using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CircleCalculations
    {
 
        public double Circumference(double value)
        {
            return 2 * Math.PI * value;

        }

        public double Area(double value)
        {
            return Math.PI * value * value;

        }

        public double Volume(double value)
        {
            return ((4.0/3.0) * Math.PI * Math.Pow(value,3)) / 2.0;

        }
            
    }

    public class TriangleCalculations
    {
            //p = (1 / 2) * (a + b + c);
            //triarea = Math.Sqrt(p* (p - a) * (p - b) * (p - c));
    }
}
