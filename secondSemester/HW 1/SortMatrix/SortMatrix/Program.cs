using System;

namespace Homework_1
{
    class Snail
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the another number:");
            int m = Convert.ToInt32(Console.ReadLine());

            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
                matrix[i] = new int[m];

            FillingMatrix(matrix, n, m); // заполняем матрицу

            Console.WriteLine("This matrix:");
            OutputMatrix(matrix, n, m); // выводим
            Console.WriteLine();

            SortingMatrix(matrix, n, m); // сортируем

            Console.WriteLine("This sorted matrix:"); // выводим
            OutputMatrix(matrix, n, m);
        }

        // заполняем матрицу случайными числами
        static void FillingMatrix(int[][] matrix, int n, int m)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    matrix[i][j] = rand.Next(0, 10);
        }

        // выводим матрицу
        static void OutputMatrix(int[][] matrix, int n, int m)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write("{0} ", matrix[i][j]);
                Console.WriteLine();
            }
        }

        // сортирует столбцы матрицы по первому элементу
        static void SortingMatrix(int[][] matrix, int n, int m)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = i; j < m; j++)
                {
                    if (matrix[0][j] < matrix[0][i])
                        ChangeColumns(matrix, n, i, j);
                }
            }
        }

        // меняет два столбца местами
        static void ChangeColumns(int[][] matrix, int n, int i, int j)
        {
            int temp = 0;
            for (int k = 0; k < n; k++)
            {
                temp = matrix[k][i];
                matrix[k][i] = matrix[k][j];
                matrix[k][j] = temp;
            }
        }
    }
}
