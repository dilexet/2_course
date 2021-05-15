using System;
using System.Collections.Generic;

namespace Laba_5.GraphRepresentations
{
    public class AdjacencyMatrix
    {
        // Из списка инцидентных ребер к матрице смежности
        public static int[,] ToAdjacencyMatrix(List<IncidentRibs> ribsList)
        {
            int countRibs = IncidentRibs.CountTops;
            int[,] matrix = new int[countRibs, countRibs];

            foreach (var item in ribsList)
            {
                matrix[item.V - 1, item.W - 1] = 1;
                matrix[item.W - 1, item.V - 1] = 1;
            }

            return matrix;
        }

        public static void PrintAdjacencyMatrix(int[,] matrix)
        {
            for (int i = 0; i < IncidentRibs.CountTops; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < IncidentRibs.CountTops; j++)
                    {
                        Console.Write('\t');
                        Console.Write(j + 1);
                    }

                    Console.WriteLine();
                }

                Console.Write(i + 1);
                Console.Write('\t');
                for (int j = 0; j < IncidentRibs.CountTops; j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write('\t');
                }

                Console.WriteLine();
            }
        }
    }
}