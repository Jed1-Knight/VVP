using System;

namespace labs9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во прошедших секунд: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int minutes = n / 60;
            int seconds = n - minutes * 60;
            Console.Write("С начала последней минуты прошло " + seconds + " секунд");
        }
    }
}