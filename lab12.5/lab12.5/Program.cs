using System;

namespace lab12._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "крысы", "коровы", "тигра", "зайца", "дракона", "змеи", "лошади", "овцы", "обезьяны", "курицы", "собаки ", "свиньи" };
            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            string ans = "год ";

            // в восточном календаре один цвет идёт подряд два года, поэтому делим на 10
            if (year % 10 == 0 || year % 10 == 1)
                ans += "бело";
            if (year % 10 == 2 || year % 10 == 3)
                ans += "чёрно";
            if (year % 10 == 4 || year % 10 == 5)
                ans += "зелёно";
            if (year % 10 == 6 || year % 10 == 7)
                ans += "красно";
            if (year % 10 == 8 || year % 10 == 9)
                ans += "жёлто";

            if (Array.IndexOf(animals, animals[(year + 8) % 12]) >= 2 && Array.IndexOf(animals, animals[(year + 8) % 12]) <= 4) // подставляем правильное окончание 
                ans += "го ";
            else
                ans += "й ";

            ans += animals[(year + 8) % 12]; // остаток от деления на 12, т.к. животных 12. + 8, т.к. начинается с года крысы. 

            Console.WriteLine(ans);
        }
    }
}