using System;

namespace lab8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            decimal count = a / b;
            decimal emptyPart = a - b * count;

            Console.WriteLine("Незанятая часть в А: " + emptyPart);
        }
    }
}