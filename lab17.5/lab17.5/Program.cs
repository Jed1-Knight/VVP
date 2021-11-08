using System;
using System.Collections.Generic;

namespace lab17._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x;
            int a1 = -1;
            int a2 = -1;

            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("numbers[" + i + "] = ");
                x = Convert.ToInt32(Console.ReadLine());
                numbers.Add(x);
            }

            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (numbers[i] == numbers[j])
                    {
                        a1 = i;
                        a2 = j;
                    }

            Console.WriteLine("Номера одинаковых элементов: " + a1 + ", " + a2);
        }
    }
}