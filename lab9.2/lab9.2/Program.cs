using System;

namespace lab9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число K: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int day = k % 7;
            Console.WriteLine("Номер дня недели: " + day);
        }
    }
}