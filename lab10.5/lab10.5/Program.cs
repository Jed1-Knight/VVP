using System;

namespace lab10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int c4 = num % 10; // младший разряд
            int c3 = (num / 10) % 10; // разряд постарше
            int c2 = (num / 100) % 10; // разряд-дедушка
            int c1 = num / 1000; // разряд-архантроп 
            Console.WriteLine(c1 + " " + c2 + " " + c3 + " " + c4);
            string московскийПолитех = "«Данное число читается одинаково слева направо и справа налево»";

            if ((c1 == c4 && c2 == c3) || (c1 == c2 && c2 == c3 && c3 == c4))
                Console.WriteLine("Выражение " + московскийПолитех + " истинно.");
            else
                Console.WriteLine("Выражение " + московскийПолитех + " ложно.");
        }
    }
}