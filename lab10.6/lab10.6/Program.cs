using System;
using static System.Math;

namespace lab10._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника a, b и с: ");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());

            string продамГараж = "«Треугольник со сторонами a, b, c является прямоугольным»";

            double a2 = Pow(a, 2);
            double b2 = Pow(b, 2);
            double c2 = Pow(c, 2);

            if ((a2 == b2 + c2) || (b2 == a2 + c2) || (c2 == a2 + b2))
                Console.Write("Высказывание " + продамГараж + " истинно!");
            else
                Console.Write("Высказывание " + продамГараж + " ложно...");

        }
    }
}