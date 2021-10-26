using System;
using System.Collections.Generic;

namespace lab16._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Размерность массива (N) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Первый элемент массива (A) = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второй элемент массива (B) = ");
            int b = Convert.ToInt32(Console.ReadLine());
            int mem;
            List<int> list = new List<int>();

            list.Add(a);
            list.Add(b);
            Console.WriteLine("list[0] = " + list[0]);
            Console.WriteLine("list[1] = " + list[1]);

            for (int i = 2; i < n; i++)
            {
                mem = list[i - 1] + list[i - 2];
                list.Add(mem);
                Console.WriteLine("list[" + i + "] = " + mem);
            }
        }
    }
}