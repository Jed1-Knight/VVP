using System;
using static System.Math;

namespace lab11._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точек A, B, C.");
            Console.Write("xA = ");
            int xA = Convert.ToInt32(Console.ReadLine());
            Console.Write("yA = ");
            int yA = Convert.ToInt32(Console.ReadLine());

            Console.Write("xB = ");
            int xB = Convert.ToInt32(Console.ReadLine());
            Console.Write("yB = ");
            int yB = Convert.ToInt32(Console.ReadLine());

            Console.Write("xC = ");
            int xC = Convert.ToInt32(Console.ReadLine());
            Console.Write("yC = ");
            int yC = Convert.ToInt32(Console.ReadLine());

            double ab = Sqrt(Pow(xB - xA, 2) + Pow(yB - yA, 2));
            double ac = Sqrt(Pow(xC - xA, 2) + Pow(yC - yA, 2));
            double distance = ab;
            string point = "B";

            if (ab > ac)
            {
                distance = ac;
                point = "C";
            }

            Console.WriteLine(point + ", A" + point + " = " + distance);

        }
    }
}