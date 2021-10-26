using System;

namespace lab14._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа A и B: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int gcd; // greatest common divisor

            while (a != b)
                if (a > b)
                    a = a - b;
                else
                    b = b - a;

            gcd = b;
            Console.WriteLine("НОД = " + gcd);
        }
    }
}