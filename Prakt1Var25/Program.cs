using System;

namespace Prakt1Var25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            double y;

            if (x < 0 || b != 0)
            {
                y = a * Math.Pow(x, 4) + b * Math.Pow(x, 2);

            }
            else if (x >= 0 && c != 0)
            {
                y = (x + a) / c; 
            }
            else
            {
                y = (15 * x) / (c + 9); 
            }

            Console.WriteLine(y);
        }
    }
}
