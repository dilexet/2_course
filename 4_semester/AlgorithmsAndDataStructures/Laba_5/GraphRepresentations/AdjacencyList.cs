using System;
using System.Collections.Generic;

namespace Laba_5.GraphRepresentations
{
    public class AdjacencyList
    {
        // Из матрицы смежности в список смежности
        public static List<AdjacencyRib> ToAdjacencyList(int[,] matrix)
        {
            List<AdjacencyRib> adjacencyRibs = new List<AdjacencyRib>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                List<int> ribs = new List<int>();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] >= 1)
                    {
                        ribs.Add(j + 1);
                    }
                }
                adjacencyRibs.Add(new AdjacencyRib(i + 1, ribs.ToArray()));
            }

            return adjacencyRibs;
        }

        public static void PrintAdjacencyList(List<AdjacencyRib> adjacencyRibs)
        {
            foreach (var item in adjacencyRibs)
            {
                Console.Write($"{item.RibsNumber} = ");
                foreach (var values in item.AdjacencyRibs)
                {
                    Console.Write($"{values}  ");
                }

                Console.WriteLine();
            }
        }
    }
}