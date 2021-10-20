using System;

namespace lab9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int rect = a * b;
            int square = c * c;
            int k = 0;

            if (rect == square)
                k = 1;
            else if (a < c || b < c)
                k = 0;
            else if (a % c == 0 && b % c == 0)
                k = rect / square;
            else
                k = (a / c) * (b / c);

            int space = a * b - square * k;

            Console.WriteLine("Количество: " + k + ". Осталось: " + space);
        }
    }
}