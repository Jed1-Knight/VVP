using System;
using System.Collections.Generic;

namespace lab17._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x;
            int diff;

            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("numbers[" + i + "] = ");
                x = Convert.ToInt32(Console.ReadLine());
                numbers.Add(x);
            }

            diff = numbers[1] - numbers[0];

            for (int i = 1; i < n; i++)
                if (diff != numbers[i] - numbers[i - 1])
                    diff = 0;

            Console.WriteLine(diff);
        }
    }
}