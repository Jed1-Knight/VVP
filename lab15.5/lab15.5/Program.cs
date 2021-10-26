using System;

namespace lab15._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double ans = Fact2(n);
            Console.WriteLine("Двойной факториал равен " + ans);
        }

        static double Fact2(int n)
        {
            double res = 1;
            if (n % 2 == 0)
                for (int i = 2; i <= n; i += 2)
                    res *= i;
            else
                for (int i = 1; i <= n; i += 2)
                    res *= i;

            return res;
        }
    }
}