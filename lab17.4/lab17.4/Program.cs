using System;
using System.Collections.Generic;

namespace lab17._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x, localMax = -1;

            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("numbers[" + i + "] = ");
                x = Convert.ToInt32(Console.ReadLine());
                numbers.Add(x);
            }

            if (numbers[0] > numbers[1])
                localMax = 0;

            for (int i = 1; i < n - 1; i++)
                if ((numbers[i] > numbers[i - 1]) && (numbers[i] > numbers[i + 1]))
                    localMax = i;

            if (numbers[n - 1] > numbers[n - 2])
                localMax = n - 1;

            Console.WriteLine("Номер локального максимума равен " + localMax);
        }
    }
}