using System;

namespace lab14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа A и B: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(i);
                Console.WriteLine();
            }


        }
    }
}