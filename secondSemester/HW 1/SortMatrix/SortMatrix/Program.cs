using System;

namespace Homework_1
{
    class Snail
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number:");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the another number:");
            int M = Convert.ToInt32(Console.ReadLine());

            int[][] matrix = new int[N][];
            for (int i = 0; i < N; i++)
                matrix[i] = new int[M];

            FillingMatrix(matrix, N, M); // заполняем матрицу

            Console.WriteLine("This matrix:");
            OutputMatrix(matrix, N, M); // выводим
            Console.WriteLine();

            SortingMatrix(matrix, N, M); // сортируем

            Console.WriteLine("This sorted matrix:"); // выводим
            OutputMatrix(matrix, N, M);
        }

        // заполняем матрицу случайными числами
        public static void FillingMatrix(int[][] matrix, int N, int M)
        {
            Random rand = new Random();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    matrix[i][j] = rand.Next(0, 10);
        }

        // выводим матрицу
        public static void OutputMatrix(int[][] matrix, int N, int M)
        {
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                    Console.Write("{0} ", matrix[i][j]);
                Console.WriteLine();
            }
        }

        // сортирует столбцы матрицы по первому элементу
        public static void SortingMatrix(int[][] matrix, int N, int M)
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = i; j < M; j++)
                {
                    if (matrix[0][j] < matrix[0][i])
                        ChangeColumns(matrix, N, i, j);
                }
            }
        }

        // меняет два столбца местами
        public static void ChangeColumns(int[][] matrix, int N, int i, int j)
        {
            int temp = 0;
            for (int k = 0; k < N; k++)
            {
                temp = matrix[k][i];
                matrix[k][i] = matrix[k][j];
                matrix[k][j] = temp;
            }
        }
    }
}
