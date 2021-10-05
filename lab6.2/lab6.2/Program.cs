using System;
using static System.Console;

namespace lab6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("a = ");
            int a = Convert.ToInt32(ReadLine());
            Write("b = ");
            int b = Convert.ToInt32(ReadLine());
            Write("c = ");
            int c = Convert.ToInt32(ReadLine());
            int t; // и сюда добавим коробочку для хранения значения одной из переменных

            t = a;
            a = c;
            c = b;
            b = t;

            Write("Теперь a = " + a + ", b = " + b + ", c = " + c);
        }
    }
}