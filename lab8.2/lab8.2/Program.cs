using System;

namespace lab8._2
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
            decimal ans = Math.Floor(count);

            Console.WriteLine("Кол-во отрезков B: " + ans);
        }
    }
}