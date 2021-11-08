using System;
using System.Collections.Generic;

namespace lab18._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N be like: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double x;
            double s = 0;
            int k = 0;

            List<double> a = new List<double>();
            List<double> b = new List<double>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                x = Convert.ToInt32(Console.ReadLine());
                a.Add(x);
            }

            Console.WriteLine("-------");

            for (int i = 0; i < n; i++)
            {
                s += a[i];
                b.Add(s / (i + 1));
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine("b[" + i + "] = " + b[i]);
        }
    }
}