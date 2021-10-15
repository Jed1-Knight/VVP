using System;

namespace lab7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, s, t, st; // скорости, изначальное расстояние, время, расстояние через t часов

            Console.Write("Cкорость первого автомобиля: ");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cкорость второго автомобиля: ");
            v2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Изначальное расстояние: ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Время автомобилей в пути: ");
            t = Convert.ToInt32(Console.ReadLine());

            // ответ получается путём сложения изначального расстояния между автомобилями и суммы скоростей, умноженных на время в пути
            st = s + (v1 + v2) * t;
            Console.WriteLine("Расстояние между автомобилями через " + t + " часов равняется " + st + " км.");
        }
    }
}