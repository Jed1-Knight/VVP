using System;

namespace lab10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0 && num >= 10 && num <= 98) // 99 не включаем в диапазон, так как это нечётное число
                Console.WriteLine("Данное число является чётным двузначным");
            else
                Console.WriteLine("Данное число не является чётным двузначным");
        }
    }
}