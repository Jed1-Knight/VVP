using System;
using System.Collections.Generic;

namespace lab16._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Размерность массива (N) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x;

            List<int> a = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                x = Convert.ToInt32(Console.ReadLine());
                a.Add(x);
            }

            Console.WriteLine("----------");

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("a[" + i + "] = " + a[i]);
                Console.WriteLine("a[" + (n - i - 1) + "] = " + a[n - i - 1]);
            }

            if (n % 2 != 0)
                Console.WriteLine("a[" + n / 2 + "] = " + a[n / 2]);
        }
    }
}