using System;

namespace lab9._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int century = (n - 1) / 100 + 1;
            // вычитаем единицу для корректной работы пограничных значений, делением на 100 получаем предыдущее столетие, прибавлением единицы получаем ответ
            Console.WriteLine(century + " столетие"); // столетие начинается с xx01 года, а не с xx00, оказывается 
        }
    }
}