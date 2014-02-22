using System;

namespace Homework_1
{
    class Snail
    {
        public static void Main()
        {
            Console.Write("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++) 
                matrix[i] = new int[n];

            FillingMatrix(matrix, n); // заполняем матрицу

            OutputMatrix(matrix, n); // выводим

            OutputMatrixBySnail(matrix, n); // выводим по спирали
        }

        // заполняем матрицу случайными числами
        static void FillingMatrix(int[][] matrix, int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i][j] = rand.Next(0, 10);
        }

        // выводим матрицу
        static void OutputMatrix(int[][] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0} ", matrix[i][j]);
                Console.WriteLine();
            }
        }

        // выводим матрицу по спирали
        static void OutputMatrixBySnail(int[][] matrix, int n)
        {
            int step = 1; // количество элементов, на которые мы должны продвинуться

            // индексы матрицы
            int i = n / 2;
            int j = n / 2;
            Console.Write("{0} ", matrix[i][j]); // сразу выводим центральный

            int h = 0;
            while (true)
            {
                // идём вверх
                for (h = i - 1; h >= i - step; h--)
                {
                    if (h < 0) // если вышли за пределы
                    {
                        h = -10; // в if после данного for закончим работу функции
                        break;
                    }
                    Console.Write("{0} ", matrix[h][j]);
                }
                if (h == -10) // если прошли всю матрицу
                {
                    Console.WriteLine();
                    return;
                }
                i -= step;

                // идём влево
                for (h = j - 1; h >= j - step; h--)
                    Console.Write("{0} ", matrix[i][h]);
                j -= step;
                step++;

                // идём вниз
                for (h = i + 1; h <= i + step; h++)
                    Console.Write("{0} ", matrix[h][j]);
                i += step;

                // идём вправо
                for (h = j + 1; h <= j + step; h++)
                    Console.Write("{0} ", matrix[i][h]);
                j += step;
                step++;
            }
            
        }
    }
}
