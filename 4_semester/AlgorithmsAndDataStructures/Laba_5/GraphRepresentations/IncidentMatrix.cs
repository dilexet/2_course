using System;
using System.Collections.Generic;

namespace Laba_5.GraphRepresentations
{
    // 5 5
    // 1 2
    // 1 3
    // 2 4
    // 2 5
    // 3 5

    public class IncidentMatrix
    {
        // Из спика смежных вершин в матрицу инцидентости
        public static int[,] ToIncidentMatrix(List<AdjacencyRib> list)
        {
            var ribs = new List<Tuple<int, int>>();
            foreach (var item in list)
            {
                int v = item.RibsNumber;
                var arr = item.AdjacencyRibs;
                foreach (var val in arr)
                {
                    if (!ribs.Contains(new Tuple<int, int>(val, v)))
                    {
                        ribs.Add(new Tuple<int, int>(v, val));
                    }
                    
                }
            }

            int[,] matrix = new int[list.Count, ribs.Count];
            
            for (int i = 0; i < ribs.Count;i++)
            {
                var edge = ribs[i];
                matrix[edge.Item1 - 1, i] = 1;
                matrix[edge.Item2 - 1, i] = 1;
            }

            return matrix;
        }
        

        public static void PrintAdjacencyMatrix(int[,] matrix, List<IncidentRibs> ribsList)
        {
            for (int i = 0; i < IncidentRibs.CountTops; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < ribsList.Count; j++)
                    {
                        Console.Write('\t');
                        Console.Write($"({ribsList[j].V}, {ribsList[j].W})");
                    }

                    Console.WriteLine();
                }

                Console.Write(i + 1);
                Console.Write('\t');
                for (int j = 0; j < ribsList.Count; j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write('\t');
                }

                Console.WriteLine();
            }
        }
    }
}