using System;

namespace lab14._6
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 1; // первое число
            int b = 1; // второе число
            int pos = 2; // так как n > 1, позиция изначально равна 2

            while (n > b)
            {
                b = a + b;
                a = b - a;
                pos++;
            }

            Console.WriteLine("Порядковый номер равен " + pos);
        }
    }
}