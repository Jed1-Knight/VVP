using System;

namespace lab15._3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите радиусы большей и меньшей окружностей в " + (i + 1) + " раз: ");
                double r1 = Convert.ToDouble(Console.ReadLine());
                double r2 = Convert.ToDouble(Console.ReadLine());
                double ans = RingS(r1, r2);
                Console.WriteLine("Площадь кольца равна " + ans);
            }
        }

        static double RingS(double r1, double r2)
        {
            double s1 = Math.PI * r1 * r1;
            double s2 = Math.PI * r2 * r2;
            double sRing = s1 - s2;

            return sRing;
        }
    }
}