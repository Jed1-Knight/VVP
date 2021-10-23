using System;

namespace lab11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A и B: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                b = a;
            else if (b > a)
                a = b;
            else
            {
                a = 0;
                b = 0;
            }

            Console.WriteLine("A = " + a + ", B = " + b);
        }
    }
}