using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_library;

namespace Student_projects
{
    class Program
    {
		 static double Sum_num_1_laba3(int[] array)
        {
            double sum = 0;
            foreach (var item in array)
                if (item % 2 == 0)
                    sum += Math.Pow(Convert.ToDouble(item), 2);
            return sum;
        }
        static void num_1_laba3()
        {
            Console.Write("Введите размер массива: ");
            uint.TryParse(Console.ReadLine(), out uint size);
            int[] array = new int[size];
            MyArray.one_dimensional_array_generation(array);
            Console.WriteLine("Исходные массив: ");
            MyArray.one_dimensional_array_output(array);
            Console.WriteLine("Сумма чётных элементов равна: " + Sum_num_1_laba3(array));
        }
        static int Finding_the_min_element_num_2_laba3(int[] array)
        {
            int min = array[0];
            foreach (var item in array)
                if (item < min)
                    min = item;
            return min;
        }
        static int Finding_the_index_of_the_min_element_num_2_laba3(int[] array, int min)
        {
            int index = -1;
            for (int i = array.Length - 1; i >= 0; i--)
                if (array[i] == min)
                {
                    index = i;
                    break;
                }
            return index;
        }
        static void num_2_laba3()
        {
            Console.Write("Введите размер массива: ");
            uint.TryParse(Console.ReadLine(), out uint size);
            int[] array = new int[size];
            MyArray.one_dimensional_array_generation(array);
            Console.WriteLine("Исходные массив: ");
            MyArray.one_dimensional_array_output(array);
            int min = Finding_the_min_element_num_2_laba3(array);
            Console.WriteLine("Минимальный элемент массива равен: " + min);
            Console.WriteLine("Индекс минимального элемента массива равен: " + Finding_the_index_of_the_min_element_num_2_laba3(array, min));
        }
        static void coppy_matrix_num_3_laba_3(int[,] new_array, int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    new_array[i, j] = array[i, j];
                }
            }
        }
        static int[,] Exponentiation_of_a_matrix_num_3_laba_3(int[,] array, uint n)
        {
            int[,] matrix = null;
            int[,] new_array = new int[array.GetLength(0), array.GetLength(1)];

            coppy_matrix_num_3_laba_3(new_array, array);
            for (int k = 1; k < n; k++)
            {
                matrix = new int[array.GetLength(0), array.GetLength(1)];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int a = 0; a < array.GetLength(1); a++)
                        {
                            matrix[i, j] += new_array[i, a] * array[a, j];
                        }
                    }
                }
                coppy_matrix_num_3_laba_3(new_array, matrix);
            }
            if (n == 1)
                matrix = array;
            return matrix;
        }
        static void num_3_laba_3()
        {
            Console.Write("Введите размер массива: ");
            uint.TryParse(Console.ReadLine(), out uint size);
            Console.Write("Введите степень больше 0: ");
            uint.TryParse(Console.ReadLine(), out uint n);
            if (n <= 0)
                Console.WriteLine("Ошибка");
            else
            {
                int[,] array = new int[size, size];
                MyArray.two_dimensional_array_generation(array);
                Console.WriteLine("Исходный массив: ");
                MyArray.two_dimensional_array_output(array);
                MyArray.two_dimensional_array_output(Exponentiation_of_a_matrix_num_3_laba_3(array, n));
            }
        }
        static void Main(string[] args)
        {

        }
	}
}