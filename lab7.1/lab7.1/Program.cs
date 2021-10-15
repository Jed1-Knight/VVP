using System;

namespace lab7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение угла в градусах: ");
            int alpha = Convert.ToInt32(Console.ReadLine());
            double radians = 180 / System.Math.PI;
            double angle = alpha / radians;
            Console.WriteLine("Значение угла в радианах: " + angle);

        }
    }
}