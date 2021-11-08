using System;
using System.Collections.Generic;

namespace lab18._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N be like: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x;
            int min, max, t;
            int indexMin = -1;
            int indexMax = -1;

            List<int> a = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                x = Convert.ToInt32(Console.ReadLine());
                a.Add(x);
            }

            Console.WriteLine("-------");

            // первичная инициализация min и max 
            max = a[0];
            min = a[0];

            for (int i = 0; i < n; i++)
            {
                if (a[i] >= max)
                {
                    max = a[i];
                    indexMax = i;
                }

                if (a[i] <= min)
                {
                    min = a[i];
                    indexMin = i;
                }
            }

            if (indexMax < indexMin) // для удобства меняем индексы местами, если макс. элемент встретился раньше мин. элемента
            {
                t = indexMax;
                indexMax = indexMin;
                indexMin = t;
            }

            for (int i = indexMin + 1; i < indexMax; i++)
                a[i] = 0;

            for (int i = 0; i < n; i++)
                Console.WriteLine("a[" + i + "] = " + a[i]);


        }
    }
}