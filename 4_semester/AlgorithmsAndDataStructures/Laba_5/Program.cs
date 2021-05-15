using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Laba_5.GraphRepresentations;

namespace Laba_5
{
    internal class Program
    {
        private static List<IncidentRibs> ReadFile()
        {
            List<IncidentRibs> ribsList = new List<IncidentRibs>();
            using (StreamReader streamReader = new StreamReader("file.txt"))
            {
                var data = Regex.Split(streamReader.ReadToEnd(), "\\r\\n");
                bool flag = true;
                foreach (var line in data)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        try
                        {
                            if (flag)
                            {
                                var item = Regex.Split(line, " ");
                                IncidentRibs.CountTops = Convert.ToInt32(item[0]);
                                IncidentRibs.CountRibs = Convert.ToInt32(item[1]);
                                flag = false;
                                continue;
                            }

                            var items = Regex.Split(line, " ");
                            int v = Convert.ToInt32(items[0]);
                            int w = Convert.ToInt32(items[1]);
                            ribsList.Add(new IncidentRibs(v, w));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ошибка в преобразование: ");
                            Console.WriteLine(e);
                            throw;
                        }
                    }
                }
            }

            ribsList.Sort();
            return ribsList;
        }

        private static void PrintIncidentRibs(List<IncidentRibs> ribs)
        {
            Console.Write("v\t");
            foreach (var rib in ribs)
            {
                Console.Write(rib.V);
                Console.Write("\t");
            }

            Console.WriteLine();
            Console.Write("w\t");
            foreach (var rib in ribs)
            {
                Console.Write(rib.W);
                Console.Write("\t");
            }

            Console.WriteLine();
        }

        public static void Main()
        {
            var ribs = ReadFile();
            AdjacencyRib.CountRib = IncidentRibs.CountRibs;

            var matrix = AdjacencyMatrix.ToAdjacencyMatrix(ribs);
            var list = AdjacencyList.ToAdjacencyList(matrix);
            var incMatrix = IncidentMatrix.ToIncidentMatrix(list);


            Console.WriteLine("\nСписок инцидентных ребер: \n");
            PrintIncidentRibs(ribs);
            Console.WriteLine("\nМатрица смежности: \n");
            AdjacencyMatrix.PrintAdjacencyMatrix(matrix);
            Console.WriteLine("\nСписок смежных вершин: \n");
            AdjacencyList.PrintAdjacencyList(list);
            Console.WriteLine("\nМатрица инцидентности: \n");
            IncidentMatrix.PrintAdjacencyMatrix(incMatrix, ribs);

            Console.WriteLine("\nВведите номер вершины");
            int top = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("\n\nПоиск в ширину: \n");
            SearchByWidth(ribs, top);
            Console.WriteLine("\n\nПоиск в глубину: \n");
            SearchByDepth(ribs, top);
        }

        private static void SearchByWidth(List<IncidentRibs> ribs, int top)
        {
            Queue<int> queue = new Queue<int>();
            int[] nodes = new int[7]; // вершины графа
            for (int i = 0; i < 7; i++)
                nodes[i] = 0; // исходно все вершины равны 0

            queue.Enqueue(top - 1); // помещаем в очередь первую вершину

            while (queue.Count != 0) // пока очередь не пуста
            {
                int node = queue.Dequeue(); // извлекаем вершину
                nodes[node] = 2; // отмечаем ее как посещенную

                var elements = ribs.Where(r => r.V == node + 1 || r.W == node + 1).ToArray();

                for (int j = 0; j < elements.Length; j++) // проверяем для нее все смежные вершины
                {
                    var element = elements[j];

                    if (element.V == node + 1 && nodes[element.W - 1] == 0)
                    {
                        queue.Enqueue(element.W - 1); // добавляем ее в очередь
                        nodes[element.W - 1] = 1; // отмечаем вершину как обнаруженную
                    }
                    else if (element.W == node + 1 && nodes[element.V - 1] == 0)
                    {
                        queue.Enqueue(element.V - 1); // добавляем ее в очередь
                        nodes[element.V - 1] = 1; // отмечаем вершину как обнаруженную
                    }
                }

                Console.Write(node + 1); // выводим номер вершины
                Console.Write("\t");
            }
        }

        private static void SearchByDepth(List<IncidentRibs> ribs, int top)
        {
            Stack<int> stack = new Stack<int>();
            int[] nodes = new int[7]; // вершины графа
            for (int i = 0; i < 7; i++) // исходно все вершины равны 0
                nodes[i] = 0;
            stack.Push(top - 1); // помещаем в очередь первую вершину

            while (stack.Count != 0) // пока стек не пуст
            {
                int node = stack.Peek(); // извлекаем вершину
                stack.Pop();
                if (nodes[node] == 2)
                {
                    continue;
                }

                nodes[node] = 2; // отмечаем ее как посещенную

                var elements = ribs.Where(r => r.V == node + 1 || r.W == node + 1).ToArray();

                for (int j = elements.Length - 1; j >= 0; j--) // проверяем для нее все смежные вершины
                {
                    var element = elements[j];

                    if (element.V == node + 1 && nodes[element.W - 1] != 2) // если вершина смежная и не обнаружена
                    {
                        stack.Push(element.W - 1); // добавляем ее в cтек
                        nodes[element.W - 1] = 1; // отмечаем вершину как обнаруженную
                    }
                    else if (element.W == node + 1 && nodes[element.V - 1] != 2) // если вершина смежная и не обнаружена
                    {
                        stack.Push(element.V - 1); // добавляем ее в cтек
                        nodes[element.V - 1] = 1; // отмечаем вершину как обнаруженную
                    }
                }

                Console.Write(node + 1); // выводим номер вершины
                Console.Write("\t");
            }
        }
    }
}