using System;
using System.Collections.Generic;

namespace lab17._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hello, K: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hello, L: ");
            int l = Convert.ToInt32(Console.ReadLine());
            int x;
            int sum = 0;
            int count = 0;
            double ans;

            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("numbers[" + i + "] = ");
                x = Convert.ToInt32(Console.ReadLine());
                numbers.Add(x);
            }

            for (int i = k; i <= l; i++)
            {
                count++;
                sum += numbers[i];
            }

            ans = (double)sum / count;

            Console.WriteLine("Среднее арифметическое чисел = " + ans);
        }
    }
}