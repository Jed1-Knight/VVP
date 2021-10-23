using System;

namespace lab12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите направление движения: ");
            string c = Console.ReadLine(); // ввод на кириллице 
            Console.Write("Введите цифровую команду: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string ans = "";

            switch (c)
            {
                case "С":
                    ans = "С";
                    break;
                case "З":
                    ans = "З";
                    break;
                case "Ю":
                    ans = "Ю";
                    break;
                case "В":
                    ans = "В";
                    break;
            }

            switch (n)
            {
                case 0:
                    //а ничего тут не будет ХЫ
                    break;
                case -1:
                    if (ans == "С")
                        ans = "В";
                    else if (ans == "З")
                        ans = "С";
                    else if (ans == "Ю")
                        ans = "З";
                    else if (ans == "В")
                        ans = "Ю";
                    break;
                case 1:
                    if (ans == "С")
                        ans = "З";
                    else if (ans == "З")
                        ans = "Ю";
                    else if (ans == "Ю")
                        ans = "В";
                    else if (ans == "В")
                        ans = "С";
                    break;
            }

            Console.WriteLine("Направление робота: " + ans);
        }
    }
}