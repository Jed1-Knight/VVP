using System;

namespace lab13._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вещественное A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите целое N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double ans = 1;

            for (int i = 1; i <= n; i++)
                ans += Math.Pow(a * -1, i);

            Console.WriteLine(ans);
        }
    }
}