using System;

namespace lab11._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string description = "число";

            if (num >= 1 && num <= 9)
                description = "однозначное " + description;
            if (num >= 10 && num <= 99)
                description = "двузначное " + description;
            if (num >= 100 && num <= 999)
                description = "трёхзначное " + description;

            if (num % 2 == 0)
                description = "Чётное " + description;
            else
                description = "Нечётное " + description;

            Console.WriteLine(description);
        }
    }
}