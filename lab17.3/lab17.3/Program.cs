using System;
using System.Collections.Generic;

namespace lab17._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x, min;

            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("numbers[" + i + "] = ");
                x = Convert.ToInt32(Console.ReadLine());
                numbers.Add(x);
            }

            min = numbers[0];

            for (int i = 0; i < n; i += 2)
                if (numbers[i] < min)
                    min = numbers[i];

            Console.WriteLine(min);
        }
    }
}