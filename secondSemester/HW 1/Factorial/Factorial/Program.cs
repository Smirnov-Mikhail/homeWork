using System;

namespace Homework_1
{
    public static class Factorial
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Calculate(number));
        }

        // считаем искомый факториал
        public static int Calculate(int number)
        {
            if (number < 0)
                return 0;
            if (number < 2)
                return 1;
            return number * Calculate(number - 1);
        }
    }
}