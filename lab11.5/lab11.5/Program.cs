using System;

namespace lab11._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string description = "число";
            if (num == 0)
                description = "Нулевое " + description;
            else
            {
                if (num % 2 == 0)
                    description = "чётное " + description;
                else
                    description = "нечётное " + description;

                if (num > 0)
                    description = "Положительное " + description;
                else
                    description = "Отрицательное " + description;

            }

            Console.WriteLine(description);
        }
    }
}