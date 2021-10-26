using System;

namespace lab13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вопрос к условию задачи: n сомножителей считается с числа 1.1 или с числа 1.4? 
            // Просто в условии написано 1.1 * 1.2 * 1.3 * ...
            // В случае начала счёта с 1.4 просто передадим в переменные k и ans другие значения
            Console.Write("Введите N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double k = 1.1; // здесь double k = 1.4;
            double ans = 1; // тогда тут будет double ans = 1.1 * 1.2 * 1.3;
            for (int i = 0; i < n; i++)
            {
                ans *= k;
                k += 0.1;
            }

            Console.WriteLine("Произведение равняется " + Math.Round(ans, 8));
        }
    }
}