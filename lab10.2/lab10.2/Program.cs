using System;

namespace lab10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа A, B и C: ");
            Console.Write("A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("C = ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a < b && b < c)
                Console.WriteLine("Выражение «Справедливо двойное неравенство A < B < C» истинно");
            else
                Console.WriteLine("Выражение «Справедливо двойное неравенство A < B < C» ложно");
        }
    }
}