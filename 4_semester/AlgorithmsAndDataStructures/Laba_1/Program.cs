using System;
using System.Collections.Generic;

namespace Laba_1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Введите кол-во чёрных карточек (1<=N<=50): ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] black = new int[n];
            int[] red = new int[n];
            
            for (int i = 0; i < n; i++) // O(N)
            {
                black[i] = i + 1;
            }
            
            Console.WriteLine("Введите числа красных карточек: ");
            for (int i = 0; i < n; i++) // O(N)
            {
                int item;
                item = Convert.ToInt32(Console.ReadLine());
                red[i] = item;
            }
            Console.Write("\nЧёрные карточки:\t");
            foreach (var item in black) // O(N)
            {
                Console.Write(item + " ");
            }
            Console.Write("\nКрасные карточки:\t");
            foreach (var item in red) // O(N)
            {
                Console.Write(item + " ");
            }

            int count = 0;
            List<int> result = new List<int>();
            
            for (int i = 0; i < n; i++) // O(N*N)
            {
                for (int j = 0; j < n; j++)
                {
                    if (black[i] == red[j])
                    {
                        count++;
                        if (!result.Contains(black[i]))
                        {
                            result.Add(black[i]);
                        }
                    }
                }
            }
            Console.WriteLine($"\nВ выбраном множестве {count} элементов");
            Console.Write("Черные номера выбраных карточек:\t");
            foreach (var item in result) // O(N)
            {
                Console.Write(item + " ");
            }
        }
    }
}