using System;
using static System.Math;

namespace lab5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3, a, b, c, s, p, mp;

            Console.WriteLine("Введите координаты вершин A, B и С: ");
            Console.Write("xA = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("yA = ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("xB = ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("yB = ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("xC = ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("yC = ");
            y3 = Convert.ToDouble(Console.ReadLine());

            a = Sqrt(Pow((x2 - x1), 2) + Pow((y2 - y1), 2));
            b = Sqrt(Pow((x3 - x2), 2) + Pow((y3 - y2), 2));
            c = Sqrt(Pow((x3 - x1), 2) + Pow((y3 - y1), 2));
            p = Round((a + b + c), 3);
            mp = p / 2; // полупериметр для подсчёта площади
            s = Round(Sqrt(mp * (mp - a) * (mp - b) * (mp - c)), 3);
            Console.WriteLine("Периметр: " + p);
            Console.WriteLine("Площадь: " + s);
        }
    }
}