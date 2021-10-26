using System;

namespace lab14._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа A и B: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            while (a >= b)
                a -= b;

            Console.WriteLine("Незанятая часть: " + a);
        }
    }
}