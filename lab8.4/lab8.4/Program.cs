using System;

namespace lab8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двузначное число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int ans = num % 10 * 10 + num / 10;
            Console.WriteLine("Перевёрнутое число: " + ans);
        }
    }
}