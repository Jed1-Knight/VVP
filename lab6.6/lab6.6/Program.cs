using System;

namespace lab6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A = ");
            double a = Convert.ToDouble(Console.ReadLine());
            double t;
            a = a * a;
            a = a * a;
            t = a;
            a *= t;
            Console.WriteLine("A^8 = " + a);
        }
    }
}