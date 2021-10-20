using System;

namespace lab8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер файла в байтах: ");
            decimal bytes = Convert.ToDecimal(Console.ReadLine());
            decimal kilobytes = Math.Ceiling(bytes / 1024);
            Console.WriteLine("Вес файла в килобайтах: " + kilobytes + " кб.");
        }
    }
}