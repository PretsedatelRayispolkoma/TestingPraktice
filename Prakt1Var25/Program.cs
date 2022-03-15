using System;

namespace Prakt1Var25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("a value: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("b value: ");
                double b = Convert.ToDouble(Console.ReadLine());
                double c;
                Console.WriteLine("eps value: ");
                double eps = Convert.ToDouble(Console.ReadLine());

                do
                {
                    c = (a + b) / 2;
                    if (GetF(c) * GetF(a) < 0)
                        b = c;
                    else
                        a = c;
                    Console.WriteLine(c);
                }
                while (Math.Abs(b - a) >= 2 * eps);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static double GetF(double x)
        {
            return (x + Math.Log(x + 0.5) - 0.5);
        }
    }
}
