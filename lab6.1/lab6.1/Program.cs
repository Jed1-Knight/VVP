using System;
using static System.Console;

namespace lab6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("a = ");
            int a = Convert.ToInt32(ReadLine());
            Write("b = ");
            int b = Convert.ToInt32(ReadLine());
            int t; // переменная для хранения значения одной из переменных

            t = a;
            a = b;
            b = t;

            Write("Теперь a = " + a + ", b = " + b);
        }
    }
}