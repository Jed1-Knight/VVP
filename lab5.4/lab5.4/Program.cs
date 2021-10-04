using System;

namespace lab5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2, a, b, p, s;

            Console.WriteLine("Введите координаты первой вершины.");
            Console.Write("x1 = ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты второй вершины.");
            Console.Write("x2 = ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = Convert.ToInt32(Console.ReadLine());

            a = Math.Abs(x2 - x1);
            b = Math.Abs(y2 - y1);

            p = (a + b) * 2;
            s = a * b;
            Console.WriteLine("Периметр равен " + p + ", площадь равна " + s);
        }
    }
}