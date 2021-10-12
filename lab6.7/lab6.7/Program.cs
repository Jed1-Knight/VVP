using System;

namespace lab6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A = ");
            double a = Convert.ToDouble(Console.ReadLine());
            double t1, t2;
            t1 = a;
            a = a * a;
            a = a * a;
            t1 *= a; // t1 == a^5
            t2 = t1 * t1; // можно обойтись и без t2, но она нужна в условии
            a = t1 * t2; // 


            Console.WriteLine("A^15 = " + a);
        }
    }
}