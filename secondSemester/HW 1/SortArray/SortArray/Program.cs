using System;

namespace Homework_1
{
    public static class SortArray
    {
        public static void Main()
        {
            Console.WriteLine("Enter the length of array:");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[length];

            FillingArray(array); // заполняем массив

            Console.WriteLine("This array:"); // массив до сортировки
            OutputArray(array);

            SortingArray(array);

            Console.WriteLine("This sorted array:"); // отсортированный массив
            OutputArray(array);
        }

        //  заполняем массив случайными числами
        public static void FillingArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(0, 20);
        }

        // выводим массив
        public static void OutputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array[i]);
            Console.WriteLine();
        }

        // сортируем массив
        public static void SortingArray(int[] array)
        {
            int temp = 0;
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = j; i < array.Length; i++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}