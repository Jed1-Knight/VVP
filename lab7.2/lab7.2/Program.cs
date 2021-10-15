using System;

namespace lab7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение угла в радианах: ");
            double angle = Convert.ToDouble(Console.ReadLine());
            double radians = 180 / System.Math.PI;
            double degrees = angle * radians;
            Console.WriteLine("Значение угла в градусах: " + degrees);
        }
    }
}