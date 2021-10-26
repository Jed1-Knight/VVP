using System;

namespace lab14._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вклад в банке составляет 1000 рублей. Введите проценты: ");
            int p = Convert.ToInt32(Console.ReadLine());
            double s = 1000;
            double c = 1 + (double)p / 100; // с помощью явного приведения типов получаем дробную часть с помощью выражения p / 100
            int k = 0;

            while (s <= 1100)
            {
                s *= c;
                k++;
            }

            Console.WriteLine("Кол-во месяцев равно " + k + ", а итоговый размер вклада составляет " + s + " руб.");
        }
    }
}