using System;

namespace lab10._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int c3 = num % 10; // младший разряд
            int c2 = (num / 10) % 10; // разряд постарше
            int c1 = num / 100; // разряд-дедушка
            // имена переменных на кириллице - дурной тон, знаю
            string голубь = "Цифры данного числа образуют возрастающую или убывающую последовательность";
            Console.WriteLine(c1 + " " + c2 + " " + c3);

            if (c1 < c2 && c2 < c3)
                Console.WriteLine("Цифры числа образуют возрастающую пос-ть. Выражение «" + голубь + "» истинно");
            else if (c1 > c2 && c2 > c3)
                Console.WriteLine("Цифры числа образуют убывающую пос-ть. Выражение «" + голубь + "» истинно");
            else
                Console.WriteLine("Выражение «" + голубь + "» ложно. Нам очень жаль :(");
        }
    }
}