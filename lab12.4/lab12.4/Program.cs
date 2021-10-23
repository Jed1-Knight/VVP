using System;

namespace lab12._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dates = { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            string[] dates2 = { "одиннадцать ", "двенадцать ", "тринадцать ", "четырнадцать ", "пятнадцать ", "шестнадцать ", "семнадцать ", "восемнадцать ", "девятнадцать " };
            string[] datesDozens = { "двадцать ", "тридцать ", "сорок ", "пятьдесят ", "шестьдесят ", "семьдесят ", "восемьдесят ", "девяносто " };
            string[] datesHundreds = { "сто ", "двести ", "триста ", "четыреста ", "пятьсот ", "шестьсот ", "семьсот ", "восемьсот ", "девятьсот " };
            string ans;

            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 100 > 10 && num % 100 < 20)
                ans = datesHundreds[num / 100 - 1] + dates2[num % 10 - 1];
            else if (num % 100 == 10)
                ans = datesHundreds[num / 100 - 1] + "десять";
            else if (num % 100 == 0)
                ans = datesHundreds[num / 100 - 1];
            else if (num % 100 < 10)
                ans = datesHundreds[num / 100 - 1] + dates[num % 10 - 1];
            else if (num % 10 == 0)
                ans = datesHundreds[num / 100 - 1] + datesDozens[(num / 10) % 10 - 2];
            else
                ans = datesHundreds[num / 100 - 1] + datesDozens[(num / 10) % 10 - 2] + dates[num % 10 - 1];

            Console.WriteLine(ans);
        }
    }
}