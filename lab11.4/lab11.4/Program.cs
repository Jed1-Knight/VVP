using System;

namespace lab11._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки. ");
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            int q;

            if (x > 0)
            {
                if (y > 0)
                    q = 1;
                else
                    q = 4;
            }
            else
            {
                if (y > 0)
                    q = 2;
                else
                    q = 3;
            }

            Console.WriteLine("Четверть номер " + q);
        }
    }
}