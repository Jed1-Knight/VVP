using System;

namespace lab14._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int sum = 0;
            while (sum < n)
            {
                k++;
                sum += k;
            }

            Console.WriteLine("Минимальное k = " + k + ", сумма = " + sum);
        }
    }
}