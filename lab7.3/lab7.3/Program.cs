using System;

namespace lab7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y; //x и y кг конфет
            double a, cost, costY; //a - цена x кг, cost - цена 1 кг, costY - стоимость y кг конфет

            Console.Write("Введите вес конфет: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите стоимость данной массы конфет: ");
            a = Convert.ToDouble(Console.ReadLine());

            cost = a / x;
            Console.WriteLine("В таком случае 1 кг конфет будет стоить " + cost + " руб.");

            Console.Write("Введите вес конфет: ");
            y = Convert.ToInt32(Console.ReadLine());
            costY = cost * y;
            Console.WriteLine(y + " кг конфет будет стоить " + costY + " руб.");
        }
    }
}