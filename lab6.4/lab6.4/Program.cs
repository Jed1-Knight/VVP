using System;
using static System.Math;

namespace lab6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double ans = AgressiveFunction(x);
            Console.WriteLine("y = " + ans);
        }

        static double AgressiveFunction(double x)
        {
            double y;
            y = 3 * Pow(x, 6) - 6 * Pow(x, 2) - 7;
            return y;
        }
    }
}