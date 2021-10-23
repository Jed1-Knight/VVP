using System;

namespace lab12._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dates = { "одно", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            string[] dates2 = { "одиннадцать ", "двенадцать ", "тринадцать ", "четырнадцать ", "пятнадцать ", "шестнадцать ", "семнадцать ", "восемнадцать ", "девятнадцать " };
            string[] datesDozens = { "десять ", "двадцать ", "тридцать ", "сорок " };
            string ans;

            Console.Write("Введите количество заданий: ");
            int count = Convert.ToInt32(Console.ReadLine());

            if (count % 10 == 0)
                ans = datesDozens[count / 10 - 1] + "заданий";
            else if (count < 20)
                ans = dates2[count % 10 - 1] + "заданий";
            else if (count % 10 == 1)
                ans = datesDozens[count / 10 - 1] + dates[0] + " задание";
            else if (count % 10 <= 4)
                ans = datesDozens[count / 10 - 1] + dates[count % 10 - 1] + " задания";
            else
                ans = datesDozens[count / 10 - 1] + dates[count % 10 - 1] + " заданий";


            Console.WriteLine(ans);
        }
    }
}