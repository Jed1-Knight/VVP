using System;

namespace lab8._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int ans = num % 100 * 10 + num / 100;
            Console.WriteLine("Перевёрнутое число: " + ans);
        }
    }
}