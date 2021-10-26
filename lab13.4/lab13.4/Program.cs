using System;

namespace lab13._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вещественное A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите целое N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double ans = 0;

            for (int i = 0; i <= n; i++)
                ans += Math.Pow(a, i);

            Console.WriteLine(ans);
        }
    }
}