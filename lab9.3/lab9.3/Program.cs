using System;

namespace lab9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число K: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int day = (k + n - 2) % 7 + 1;
            Console.WriteLine("Номер дня недели: " + day);
        }
    }
}