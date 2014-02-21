using System;

namespace Homework_1
{
    class Snail
    {
        public static void Main()
        {
            Console.Write("Enter the number:");
            int N = Convert.ToInt32(Console.ReadLine());

            int[][] matrix = new int[N][];
            for (int i = 0; i < N; i++) 
                matrix[i] = new int[N];

            FillingMatrix(matrix, N); // заполняем матрицу

            OutputMatrix(matrix, N); // выводим

            OutputMatrixBySnail(matrix, N); // выводим по спирали
        }

        // заполняем матрицу случайными числами
        public static void FillingMatrix(int[][] matrix, int N)
        {
            Random rand = new Random();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    matrix[i][j] = rand.Next(0, 10);
        }

        // выводим матрицу
        public static void OutputMatrix(int[][] matrix, int N)
        {
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write("{0} ", matrix[i][j]);
                Console.WriteLine();
            }
        }

        // выводим матрицу по спирали
        public static void OutputMatrixBySnail(int[][] matrix, int N)
        {
            int step = 1; // количество элементов, на которые мы должны продвинуться

            // индексы матрицы
            int i = N / 2;
            int j = N / 2;
            Console.Write("{0} ", matrix[i][j]); // сразу выводим центральный

            int h = 0;
            while(true)
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
