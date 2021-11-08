using System;
using System.Collections.Generic;

namespace lab18._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N be like: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x;
            int odd = 0;

            List<int> a = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                x = Convert.ToInt32(Console.ReadLine());
                a.Add(x);
            }

            Console.WriteLine("-------");

            for (int i = 0; i < n; i++)
                if (a[i] % 2 != 0)
                    odd = a[i];

            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                    a[i] += odd;
                Console.WriteLine("a[" + i + "] = " + a[i]);
            }
        }
    }
}