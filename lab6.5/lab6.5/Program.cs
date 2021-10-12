using System;
using static System.Math;

namespace lab6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double ans = AnotherAggressiveFunction(x);
            Console.WriteLine("y = " + ans);
        }

        static double AnotherAggressiveFunction(double x)
        {
            double y;
            y = 4 * Pow((x - 3), 6) - 7 * Pow((x - 3), 3) + 2;
            return y;
        }
    }
}