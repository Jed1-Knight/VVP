using System;

namespace lab10._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника a, b и с: ");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());

            string группа721СамаяКрутая = "«Существует треугольник со сторонами a, b, c»";

            // (в случае a + b = c) || (a + c = b) || (b + c = a) имеем вырожденный треуг.
            if ((a > b + c) || (b > a + c) || (c > a + b))
                Console.Write("Высказывание " + группа721СамаяКрутая + " ложно...");
            else
                Console.Write("Высказывание " + группа721СамаяКрутая + " истинно!");
        }
    }
}