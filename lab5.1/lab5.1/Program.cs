using System;

namespace lab5
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой точки: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты первой точки: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Расстояние между точками равняется " + distance);
        }
    }
}