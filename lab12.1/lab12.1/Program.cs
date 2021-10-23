using System;

namespace lab12._1
{
    class Program
    {
        static void Main(string[] args)
        {

            string date = "";

            Console.Write("Введите номер дня: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер месяца: ");
            int month = Convert.ToInt32(Console.ReadLine());

            string[] dates1 = { "первое ", "второе ", "третье ", "четвертое ", "пятое ", "шестое ", "седьмое ", "восьмое ", "девятое " };
            string[] dates2 = { "одиннадцатое ", "двенадцатое ", "тринадцатое ", "четырнадцатое ", "пятнадцатое ", "шестнадцатое ", "семнадцатое ", "восемнадцатое ", "девятнадцатое " };
            string[] dates3 = { "десятое ", "двадцатое ", "тридцатое " };
            string[] months = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };

            if (day < 10)
                date = dates1[day - 1];
            else if (day == 10)
                date = dates3[day / 10 - 1];
            else if (day < 20)
                date = dates2[day % 10 - 1];
            else if (day == 20)
                date = dates3[day / 10 - 1];
            else if (day < 30)
                date = "двадцать " + dates1[day % 10 - 1];
            else if (day == 30)
                date = dates3[day / 10 - 1];
            else if (day == 31)
                date = "тридцать " + dates1[day % 10 - 1];

            date = date + months[month - 1];

            Console.WriteLine(date);
        }
    }
}