using System;

namespace lab5._3
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Допустим, точка C гарантированно расположена между A и B, это условие не требует проверки */
            int ac, bc, mult;
            Console.Write("A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("C = ");
            int c = Convert.ToInt32(Console.ReadLine());

            ac = Math.Abs(a - c);
            bc = Math.Abs(b - c);
            mult = ac * bc;
            Console.WriteLine("AC = " + ac + ", BC = " + bc + ", AC * BC = " + mult);
        }
    }
}