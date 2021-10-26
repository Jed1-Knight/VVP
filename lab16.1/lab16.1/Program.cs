using System;
using System.Collections.Generic; // получаем доступ к коллекциям, а в частности - к спискам

namespace lab16._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("В очередной раз введите очередное число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = -1;

            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                k += 2;
                numbers.Add(k);
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine("numbers[" + i + "] = " + numbers[i]);
        }
    }
}