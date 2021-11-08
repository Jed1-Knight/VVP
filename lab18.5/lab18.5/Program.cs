using System;
using System.Collections.Generic;

namespace lab18._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N be like: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x;
            int t;

            List<int> a = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                x = Convert.ToInt32(Console.ReadLine());
                a.Add(x);
            }

            Console.WriteLine("-------");

            for (int i = 0; i < n - 1; i++)
                if (a[i] > a[i + 1])
                {
                    t = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = t;
                }

            for (int i = 0; i < n; i++)
                Console.WriteLine("a[" + i + "] = " + a[i]);
        }
    }
}