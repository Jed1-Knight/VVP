using System;

namespace lab15._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5 чисел: ");

            double[] nums = new double[5];

            for (int i = 0; i < 5; i++)
                nums[i] = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < 5; i++)
                Console.WriteLine(nums[i] + "^3 = " + PowerA3(nums[i]));
        }

        static double PowerA3(double a)
        {
            double b = a * a * a;

            return b;
        }
    }
}