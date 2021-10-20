using System;

namespace lab10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа A и B: ");
            Console.Write("A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B = ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > 2 && b <= 3)
                Console.WriteLine("Выражение «Справедливы неравенства A > 2 и B <= 3» истинно");
            else
                Console.WriteLine("Выражение «Справедливы неравенства A > 2 и B <= 3» ложно");
        }
    }
}