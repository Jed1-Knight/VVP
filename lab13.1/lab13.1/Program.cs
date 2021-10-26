using System;

namespace lab13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цену за 1 кг конфет: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            for (double i = 0.1; i <= 1; i += 0.1)
                Console.WriteLine("Стоимость " + Math.Round(i, 2) + " кг конфет равна " + Math.Round(amount * i, 2));

        }
    }
}