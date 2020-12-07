using System;
using System.Diagnostics;
using System.Linq;

namespace Task_1
{
    class Program
    {
        static int[,] CreatedMatrix(int a = 1, int b = 10, int i = 3, int j = 3)
        {
            int[,] matrix = new int[i, j];
            Random random = new Random();
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    matrix[k, l] = random.Next(a, b);
                }
            }

            return matrix;
        }

        static void PrintElementMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }

                Console.WriteLine();
            }
        }

        static int NormaMatrix(int[,] matrix)
        {
            int[] itemMatrix = new int [matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    itemMatrix[i] += matrix[i, j];
                }
            }

            return itemMatrix.Max();
        }
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var matrix = CreatedMatrix();
            PrintElementMatrix(matrix);
            Console.WriteLine($"\nnorma = {NormaMatrix(matrix)}");
            stopwatch.Stop();
            Console.WriteLine($"time = {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}