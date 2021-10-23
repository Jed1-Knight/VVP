using System;

namespace lab11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            int[] arr = { x, y, z };
            Array.Sort(arr);
            int sum = arr[1] + arr[2];
            Console.WriteLine("Сумма двух наибольших равна " + sum);
        }
    }
}