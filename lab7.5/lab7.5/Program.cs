using System;

namespace lab7._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, a, b; // неизвестная и коэффициенты
            Console.WriteLine("Для решения линейного уравнения вида Ax + B = 0 введите значения коэффициентов. ");
            Console.Write("A = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("B = ");
            b = Convert.ToDouble(Console.ReadLine());
            if (b > 0) // условная конструкция для красивого вывода инфы :)
                Console.WriteLine("Имеем уравнение " + a + "x + " + b + " = 0");
            else if (b < 0)
                Console.WriteLine("Имеем уравнение " + a + "x - " + -b + " = 0");
            else
                Console.WriteLine("Имеем уравнение " + a + "x" + " = 0");

            x = (-1 * b) / a; // переносим b вправо, меняем знак, делим b на a
            Console.WriteLine("x = " + x);
        }
    }
}