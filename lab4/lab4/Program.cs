using System;

namespace labs
{
    class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();
            Console.Write("Введите номер задачи: ");
            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
                    program.Task1();
                    break;
                case "2":
                    program.Task2();
                    break;
                case "3":
                    program.Task3();
                    break;
                case "4":
                    program.Task4();
                    break;
                case "5":
                    program.Task5();
                    break;
            }

        }

        void Task1()
        {
            Console.WriteLine("Введите стороны прямоугольника: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int perimeter = 2 * (a + b);
            int square = a * b;
            Console.WriteLine("Площадь: " + square + ". Периметр: " + perimeter);
        }

        void Task2()
        {
            float pi = 3.14f;
            Console.WriteLine("Введите диаметр окружности: ");
            int d = Convert.ToInt32(Console.ReadLine());
            float length = pi * d;
            Console.WriteLine("Длина окружности равняется " + length);
        }

        void Task3()
        {
            Console.WriteLine("Введите два числа: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double s = (a + b) / 2;
            Console.WriteLine("Среднее арифметическое = " + s);
        }

        void Task4()
        {
            Console.WriteLine("Введите два числа: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double sum = a * a + b * b;
            double dif = a * a - b * b;
            double mult = a * a * b * b;
            double quo = (a * a) / (b * b);
            Console.WriteLine("Сумма: " + sum + ", Разность: " + dif + ", Произведение: " + mult + ", Частное: " + quo);
        }

        void Task5()
        {
            Console.WriteLine("Введите два числа: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double sum = Math.Abs(a) + Math.Abs(b);
            double dif = Math.Abs(a) - Math.Abs(b);
            double mult = Math.Abs(a) * Math.Abs(b);
            double quo = Math.Abs(a) / Math.Abs(b);
            Console.WriteLine("Сумма: " + sum + ", Разность: " + dif + ", Произведение: " + mult + ", Частное: " + quo);
        }
    }
}