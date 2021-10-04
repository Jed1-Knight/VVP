using System;

namespace lab5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ac, bc, sum;
            Console.Write("A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("C = ");
            int c = Convert.ToInt32(Console.ReadLine());

            ac = Math.Abs(a - c);
            bc = Math.Abs(b - c);
            sum = ac + bc;
            Console.WriteLine("AC = " + ac + ", BC = " + bc + ", AC + BC = " + sum);

        }
    }
}