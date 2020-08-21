using System;


namespace new_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // конвертация строки, class Convert
            /*
            string data;
            data = Console.ReadLine(); // считывает данные в строку (всегда только в строку)
            int a = Convert.ToInt32(data); // конвертирует строку в int
            Console.WriteLine(a); // вывод числа
            
            string str = "1.9";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            }; // указываем какой символ-разделитель будет использоваться для конвертации дробных чисел

            double a = Convert.ToDouble(str, numberFormatInfo);
            */
            // конвертация строки, parse и tryparse
            /*
            string str2 = "5.9";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            }; // указываем какой символ-разделитель будет использоваться для конвертации дробных чисел

            double a = double.Parse(str2, numberFormatInfo);
            

            string str3 = "mmf";
            int a3;
            bool result = int.TryParse(str3, out a3); // не бросает исключений
            if (result)
            {
                Console.WriteLine(a3);
            }
            else
            {
                Console.WriteLine("Error");
            }
            */
            // switch, пример работы с обработкой нажатия клавиш 
            /*
            ConsoleKey consoleKey = Console.ReadKey().Key;
            switch (consoleKey)
            {
                case ConsoleKey.Backspace:
                    Console.WriteLine("Вы нажали backspace");
                    break;
                case ConsoleKey.Tab:
                    Console.WriteLine("Вы нажали tab");
                    break;
                case ConsoleKey.Spacebar:
                    Console.WriteLine("Вы нажали spacebar");
                    break;
                default:
                    break;
            }
            */
            // очистка консоли - Console.Clear()
            // задать цвет - Console.ForegroundColor = ConsoleColor.Red;
			
			// одномерные массивы 
            /*
            int[] mass;
            mass = new int[5];
            int size = mass.Length; // размер массива
            int[] new_mass = Enumerable.Repeat(5, 10).ToArray(); // инициализация массива определённым значениями (значения, количество)
            int[] new_mass2 = Enumerable.Range(1, 8).ToArray(); // инициализация массива с определённого значения (начальное значение, количество)

            int result = new_mass.Max(); // max элемент в массиве
            int result2 = new_mass.Min(); // min элемент в массиве
            int sum = new_mass.Sum(); // сумма всех элементов в массиве
            int sum_chet = new_mass.Where(i => i % 2 == 0).Sum(); // сумма всех чётных элементов в массиве

            int[] arr = new_mass.Distinct().ToArray(); // в массив arr добавяться только уникальные элементы из массива new_mass
            int[] arr2 = new_mass.OrderBy(i => i).ToArray(); // массив arr - это отсортированный массив new_mass в порядке возрастания
            int[] arr3 = new_mass.OrderByDescending(i => i).ToArray(); // массив arr - это отсортированный массив new_mass в порядке убывания

            Array.Sort(new_mass); // сортировка массива
            int result3 = Array.Find(new_mass, i => i < 5); // (массив, условие поиска) - первый элемент который удовлетворит условию будет помещён в переменную result
            int result4 = Array.FindLast(new_mass, i => i < 5); // тоже самое только поиск начинается с конца
            int [] res_mass = Array.FindAll(new_mass, i => i < 5); // тоже самое но возвращает массив
            int index = Array.FindIndex(new_mass, i => i == 77); // возвращает индекс элемента который удовлетворяет условию
            int index2 = Array.FindLastIndex(new_mass, i => i == 77); // с конца

            Array.Reverse(new_mass); // преобразует массив так, что элементы в нём будут в обратном порядке
            */
			// индексы и диапозоны (пока только .Net Core)
            /*
            int[] MyArray = { 2, 10, 5, 6, 77, 89 };
                       
            Console.WriteLine(MyArray[^1]); // получаем первый элемент с конца массива

            int[] Myarray2 = MyArray[1..4]; // задаём диапозон чисел которые хотим извлечь
            */
			
			// двумерный массив
            /*
            int[,] mass;
            mass = new int[4, 5];
            mass[0, 2] = 5;

            Random random = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = random.Next(100);
                }
            }

            foreach (var item in mass)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            // .GetLenght(0) - возвращает кол-во элементов определённого измерения
            //т.е. если (0) то получаем количество элементов в первом измерении (по вертикали, т.е. колв-во строк), если (1) то во втором
            // (по горизонтали, т.е. кол-во столбцов)
            for (int i = 0; i < mass.GetLength(0); i++) 
            {
                for (int j  = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write($"{mass[i, j]} ");
                }
                Console.WriteLine();
            }
            */
			
			 // ступенчатые(зубчатые) массивы
            /*
            int[][] mass = new int[3][];
            mass[0] = new int[5];
            mass[1] = new int[2];
            mass[2] = new int[10];
            Random random = new Random();

            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                {
                    mass[i][j] = random.Next(100);
                }
            }

            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                {
                    Console.Write(mass[i][j] + " ");
                }
                Console.WriteLine();
            }
            */
			
			// трёхмерный массив
            /*
            int[,,] mass = new int[4, 3, 5]; // [z, y, x]
            Random rand = new Random();
            for (int z = 0; z < mass.GetLength(0); z++)
            {
                for (int y = 0; y < mass.GetLength(1); y++)
                {
                    for (int x = 0; x < mass.GetLength(2); x++)
                    {
                        mass[z, y, x] = rand.Next(100);
                    }
                }
            }

            for (int z = 0; z < mass.GetLength(0); z++)
            {
                for (int y = 0; y < mass.GetLength(1); y++)
                {
                    for (int x = 0; x < mass.GetLength(2); x++)
                    {
                        Console.Write(mass[z, y, x] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            */

			// трёхмерные зубчтатые массивы
            /*
            Random random = new Random();
            int[][][] mass = new int[random.Next(2,5)][][];
            for (int z = 0; z < mass.Length; z++)
            {
                mass[z] = new int[random.Next(2, 5)][];
                for (int y = 0; y < mass[z].Length; y++)
                {
                    mass[z][y] = new int[random.Next(2, 5)];
                    for (int x = 0; x < mass[z][y].Length; x++)
                    {
                        mass[z][y][x] = random.Next(100);
                    }
                }
            }

            for (int z = 0; z < mass.Length; z++)
            {
                for (int y = 0; y < mass[z].Length; y++)
                {
                    for (int x = 0; x < mass[z][y].Length; x++)
                    {
                        Console.Write(mass[z][y][x] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            */

        }
    }
}
