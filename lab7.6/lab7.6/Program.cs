using System;

namespace lab7._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j; // счётчики
            double x, y, k; // неизвестные и коэффициенты
            double[,] Matrix = new double[2, 3]; // матрица коэффициентов 
            Console.WriteLine("Система линейных уравнений вида");
            Console.WriteLine("A1*x + B1*y = C1");
            Console.WriteLine("A2*x + B2*y = C2");

            for (i = 0; i < Matrix.GetLength(0); i++) // читаем значения
                for (j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write("Matrix[" + i + "][" + j + "] = ");
                    Matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }

            if (Matrix[1, 0] != 0) // если A2 != 0
            {
                k = Matrix[0, 0] / Matrix[1, 0]; // находим коэффициент для последующего обнуления значения A1
                for (j = 0; j < Matrix.GetLength(1); j++) // вычитаем из первого уравнения второе, умноженное на k
                    Matrix[0, j] -= Matrix[1, j] * k;

                y = Matrix[0, 2] / Matrix[0, 1]; // получаем уравнение вида 0*x + B1*y = C1, откуда находим y = C1 / B1;
                x = (Matrix[1, 2] - Matrix[1, 1] * y) / Matrix[1, 0]; // из второго уравнения спокойно находим x, так как знаем значение y
            }
            else // если A2 == 0
            {
                y = Matrix[1, 2] / Matrix[1, 1];
                x = (Matrix[0, 2] - Matrix[0, 1] * y) / Matrix[0, 0];
            }

            Console.WriteLine("Ответ: (" + x + "; " + y + ")"); // выводим ответ 
        }
    }
}