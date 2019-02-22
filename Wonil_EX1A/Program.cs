using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wonil_EX1A
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleCalculations circlecalculation = new CircleCalculations();

            double radius;

            Console.Write("Circumference Calculation. Enter radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            if (radius < 0)
            {
                Console.WriteLine("Radius cannot be a negative value.");
            }

            else
            {
                Console.WriteLine($"The circumference of circle is: {circlecalculation.Circumference(radius)}");


                Console.Write("Area Calculation. Enter radius: ");
                radius = Convert.ToDouble(Console.ReadLine());

                    if (radius < 0)
                    {
                        Console.WriteLine("Radius cannot be a negative value.");
                    }
                    else
                    {
                        Console.WriteLine($"The area of circle is: {circlecalculation.Area(radius)}");
                    }
            }
            
            Console.Write("Volume Calculation. Enter radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            if (radius < 0)
            {
                Console.WriteLine("Radius cannot be a negative value.");
            }
            else
            {
                Console.WriteLine($"The volume of hemisphere is: {circlecalculation.Volume(radius)}");
            }

            // Area of a triangle
            //TriangleCalculations trianglecalculations = new TriangleCalculations();

            double a, b, c, p, triarea;

            Console.Write("Enter the length of first side: ");
            //a = Convert.ToDouble(Console.ReadLine());
            a = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of second side: ");
            //b = Convert.ToDouble(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of third side: ");
            //c = Convert.ToDouble(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            p = (a + b + c)/2;

            triarea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"The area of triangle is: {triarea}");


            // Solving a quadratic equation
            double coef1, coef2, coef3, ans1, ans2, sqrt;

            Console.WriteLine("ax^2 + bx + c = 0.");
            Console.Write("Enter a: ");
            coef1 = double.Parse (Console.ReadLine());

            Console.Write("Enter b: ");
            coef2 = double.Parse (Console.ReadLine());

            Console.Write("Enter c: ");
            coef3 = double.Parse (Console.ReadLine());

            sqrt = Math.Sqrt(Math.Pow(coef2, 2) - 4 * coef1 * coef3);
            ans1 = (-1 * coef2 + sqrt) / (2 * coef1);
            ans2 = (-1 * coef2 - sqrt) / (2 * coef1);

            if (sqrt >= 0)
            {
                Console.WriteLine($"The value of x is: {ans1}, {ans2}");
            }
            else
            {
                Console.WriteLine("You cannot take the square root of a negative number!");
            }
        }
    }
}
