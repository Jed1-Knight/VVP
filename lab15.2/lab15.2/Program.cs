using System;

namespace lab15._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа А и В: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            int ans = Sign(a) + Sign(b);

            Console.WriteLine("Ответ равен " + ans);
        }

        static int Sign(double x)
        {
            if (x > 0)
                return 1;
            else if (x < 0)
                return -1;
            else
                return 0;
        }
    }
}