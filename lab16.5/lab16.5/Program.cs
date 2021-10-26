using System;
using System.Collections.Generic;

namespace lab16._5
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

            for (int i = 1; i < n; i += 2)
                Console.WriteLine("a[" + i + "] = " + a[i]);

            Console.WriteLine("----------");

            if (n % 2 != 0)
                for (int i = n - 1; i >= 0; i -= 2)
                    Console.WriteLine("a[" + i + "] = " + a[i]);
            else
                for (int i = n - 2; i >= 0; i -= 2)
                    Console.WriteLine("a[" + i + "] = " + a[i]);
        }
    }
}