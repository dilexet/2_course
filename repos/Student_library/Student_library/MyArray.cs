using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Student_library
{
    /// <summary>
    /// Класс для работы с массивами
    /// </summary>
    public static class MyArray
    {
        /// <summary>
        /// Вывод одномерного массива
        /// </summary>
        /// <param name="array"></param>
        public static void one_dimensional_array_output<T>(T[] array)
        {
            foreach(var data in array)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Рандомная генерация массива
        /// </summary>
        /// <param name="array"></param>
        public static void one_dimensional_array_generation(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
            }
        }

        /// <summary>
        /// Вывод двумерного массива
        /// </summary>
        /// <param name="array"></param>
        public static void two_dimensional_array_output<T>(T[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Генерация двумерного массива
        /// </summary>
        /// <param name="array"></param>
        public static void two_dimensional_array_generation(int[,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10);
                }
            }
        }

        /// <summary>
        /// Вывод трёхмерного массива
        /// </summary>
        /// <param name="array"></param>
        public static void three_dimensional_array_output<T>(T[,,] array)
        {
            for (int z = 0; z < array.GetLength(0); z++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    for (int x = 0; x < array.GetLength(2); x++)
                    {
                        Console.Write(array[z, y, x] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Генерация трёхмерного массива
        /// </summary>
        /// <param name="array"></param>
        public static void three_dimensional_array_generation(int[,,] array)
        {
            Random random = new Random();
            for (int z = 0; z < array.GetLength(0); z++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    for (int x = 0; x < array.GetLength(2); x++)
                    {
                        array[z, y, x] = random.Next(100);
                    }
                }
            }
        }
    }
}
