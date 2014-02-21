using System;

namespace Homework_1
{
    public static class Fibonacci
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Calculate(number));
        }

        // считаем искомое число фибоначчи
        public static int Calculate(int number)
        {
            if (number < 1)
                return -1;
            else if (number < 3)
                return 1;

            int current = 1;
            int previous = 1;
            for (int i = 2; i < number; i++)
            {
                int next = current + previous;
                previous = current;
                current = next;
            }

            return current;
        }
    }
}
