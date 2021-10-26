using System;

namespace lab15._4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("x = ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("y = ");
                double y = Convert.ToDouble(Console.ReadLine());
                int q = Quarter(x, y);
                Console.WriteLine("Четверть №" + q);
            }
        }

        static int Quarter(double x, double y) // условия составлены для гарантированно ненулевых x и y
        {
            if (x > 0)
            {
                if (y > 0)
                    return 1;
                else
                    return 4;
            }
            else
            {
                if (y > 0)
                    return 2;
                else
                    return 3;
            }
        }
    }
}