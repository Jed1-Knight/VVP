using System;
using System.Collections.Generic;

namespace lab18._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N be like: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x;

            List<int> a = new List<int>();
            List<int> b = new List<int>();
            int[] t = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                x = Convert.ToInt32(Console.ReadLine());
                a.Add(x);
            }

            Console.WriteLine("-------");

            for (int i = 0; i < n; i++)
            {
                Console.Write("b[" + i + "] = ");
                x = Convert.ToInt32(Console.ReadLine());
                b.Add(x);
            }

            Console.WriteLine("-------");

            b.CopyTo(t);
            b.Clear();

            a.ForEach(delegate (int num) // блин, делегаты прикольные
            {
                b.Add(num);
            });

            a.Clear();

            for (int i = 0; i < t.Length; i++) // а тут заполню массив, как нормальный человек
                a.Add(t[i]);

            for (int i = 0; i < n; i++)
                Console.WriteLine("a[" + i + "] = " + a[i]);

            Console.WriteLine("-------");

            for (int i = 0; i < n; i++)
                Console.WriteLine("b[" + i + "] = " + b[i]);

        }
    }
}