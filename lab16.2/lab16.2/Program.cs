using System;
using System.Collections.Generic;

namespace lab16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Первый член геометрической прогрессии A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Знаменатель D = ");
            int d = Convert.ToInt32(Console.ReadLine());
            double mem;

            List<int> progression = new List<int>();

            for (int i = 0; i < n; i++)
            {
                mem = a * Math.Pow(d, i);
                Console.WriteLine("Член №" + (i + 1) + " = " + mem);
            }
        }
    }
}