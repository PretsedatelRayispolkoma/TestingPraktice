using System;
using System.Collections.Generic;

namespace Prakt1Var25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            try
            {
                Console.WriteLine("Enter the a side");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the b side");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the c side");
                c = Convert.ToDouble(Console.ReadLine());

                Triangle triangle = new Triangle(a, b, c);
                Console.WriteLine(triangle);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    internal class Triangle
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            if(a > 0 && b > 0 && c > 0)
            {
                if(a + b > c && b + c > a && a + c > b)
                {
                    this.a = a;
                    this.b = b;
                    this.c = c;
                }
                else
                {
                    throw new Exception("The sum of the two sides is less than the other side");
                }
            }
            else
            {
                throw new Exception("One or more side is equals or less than zero");
            }
        }

        private string GetTriangleCornerType()
        {
            List<double> sideList = new List<double> { a, b, c };
            sideList.Sort();

            double otherSidesSquare = (Math.Pow(sideList[0], 2) + Math.Pow(sideList[1], 2) - Math.Pow(sideList[2], 2))/(2*sideList[0]*sideList[1]);

            if (0 > otherSidesSquare)
                return "Тупоугольный";
            else if (0 < otherSidesSquare)
                return "Остроугольный";
            else
                return "Прямоугольный";
        }

        private string GetTriangleSideType()
        {
            if (a == b && b == c && a == c)
                return "Равносторонний";
            else if (a == b || b == c || a == c)
                return "Равнобедренный";
            else
                return "Произвольный";
        }

        private double GetArea()
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        public override string ToString()
        {
            return $"{GetTriangleCornerType()}, {GetTriangleSideType()} Треугольник\n" +
                $"Со сторонами {a}, {b}, {c}\n" +
                $"И площадью, равной {GetArea()}";
        }
    }
}
