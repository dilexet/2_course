using System;

namespace Laba_2
{
    public static class Program
    {
        #region ArrayWorkRegion

        private enum ArrayType
        {
            Int = 1,
            String = 2
        }

        private static T[] GenerateArray<T>(int size, ArrayType arrayType)
        {
            Random random = new Random();
            switch (arrayType)
            {
                case ArrayType.Int:
                    Int32[] arrayInt = new Int32[size];
                    for (int i = 0; i < size; i++)
                    {
                        arrayInt[i] = random.Next(-123, 890);
                    }

                    return arrayInt as T[];
                case ArrayType.String:
                    Char[] arrayChar = new Char[size];
                    for (int i = 0; i < size; i++)
                    {
                        arrayChar[i] = (char) random.Next(97, 123);
                    }

                    return arrayChar as T[];
            }

            return null;
        }

        private static void GetArray<T>(T[] array)
        {
            foreach (var el in array)
            {
                Console.Write($"{el} ");
            }
        }

        #endregion

        // Сортировка прямым включением
        #region DirectSortRegion

        private static int[] DirectSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var a = array[i];
                int j = i;
                while (j > 0 && a < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }

                array[j] = a;
            }

            var result = array;
            return result;
        }

        private static char[] DirectSort(char[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var a = array[i];
                int j = i;
                while (j > 0 && a < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }

                array[j] = a;
            }

            var result = array;
            return result;
        }

        #endregion

        // Сортировка выбором
        #region SortSelectionRegion
        
        public static int[] SortSelection(int[] array)
        {
            int length = array.Length;

            for (int i = 0; i < length - 1; i++)
            {
                var min = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    var temp = array[i];
                    array[i] = array[min];
                    array[min] = temp;
                }
            }

            var result = array;
            return result;
        }
        
        public static char[] SortSelection(char[] array)
        {
            int length = array.Length;

            for (int i = 0; i < length - 1; i++)
            {
                var min = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    var temp = array[i];
                    array[i] = array[min];
                    array[min] = temp;
                }
            }

            var result = array;
            return result;
        }

        #endregion

        // Cортировка обменом (шейкерная сортировка)
        #region ShakerSortRegion
        
        public static int[] ShakerSort(int[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var swapFlag = false;
                //проход слева направо
                for (var j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapFlag = true;
                    }
                }

                //проход справа налево
                for (var j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        var temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                        swapFlag = true;
                    }
                }

                //если обменов не было выходим
                if (!swapFlag)
                {
                    break;
                }
            }

            var result = array;
            return result;
        }
        
        public static char[] ShakerSort(char[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var swapFlag = false;
                //проход слева направо
                for (var j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapFlag = true;
                    }
                }

                //проход справа налево
                for (var j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        var temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                        swapFlag = true;
                    }
                }

                //если обменов не было выходим
                if (!swapFlag)
                {
                    break;
                }
            }

            var result = array;
            return result;
        }

        #endregion

        // Сортировка с помощью разделения – быстрая сортировка Хоара
        #region SplitSortRegion

        private static int Partition<T>(T[] array, int a, int b) where T : IComparable<T>
        {
            int i = a;
            for (int j = a; j <= b; j++) // просматриваем с a по b
            {
                if (array[j].CompareTo(array[b]) <= 0) // если элемент m[j] не превосходит m[b],
                {
                    T t = array[i]; // меняем местами m[j] и m[a], m[a+1], m[a+2] и так далее...
                    array[i] = array[j]; // то есть переносим элементы меньшие m[b] в начало,
                    array[j] = t; // а затем и сам m[b] «сверху»
                    i++; // таким образом последний обмен: m[b] и m[i], после чего i++
                }
            }

            return i - 1; // в индексе i хранится <новая позиция элемента m[b]> + 1
        }

        public static void Quicksort<T>(T[] array, int a, int b) where T : IComparable<T> // a - начало подмножества, b - конец
        {
            // для первого вызова: a = 0, b = <элементов в массиве> - 1
            if (a >= b)
            {
                return;
            }

            int c = Partition(array, a, b);
            Quicksort(array, a, c - 1);
            Quicksort(array, c + 1, b);
        }

        #endregion

        // Пирамидальная сортировка
        #region HeapsortRegion
        
        public static int[] HeapSort(int[] array) 
        {
            int n = array.Length;

            // Построение кучи (перегруппируем массив)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            // Один за другим извлекаем элементы из кучи
            for (int i=n-1; i>=0; i--)
            {
                // Перемещаем текущий корень в конец
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                // вызываем процедуру heapify на уменьшенной куче
                Heapify(array, i, 0);
            }

            var result = array;
            return result;
        }
        
        public static char[] Heapsort(char[] array) 
        {
            int n = array.Length;

            // Построение кучи (перегруппируем массив)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            // Один за другим извлекаем элементы из кучи
            for (int i=n-1; i>=0; i--)
            {
                // Перемещаем текущий корень в конец
                char temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                // вызываем процедуру heapify на уменьшенной куче
                Heapify(array, i, 0);
            }

            var result = array;
            return result;
        }

        // Процедура для преобразования в двоичную кучу поддерева с корневым узлом i, что является
        // индексом в arr[]. n - размер кучи
        public static void Heapify(int[] array, int n, int i)
        {
            int largest = i;
            // Инициализируем наибольший элемент как корень
            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2

            // Если левый дочерний элемент больше корня
            if (l < n && array[l] > array[largest])
                largest = l;

            // Если правый дочерний элемент больше, чем самый большой элемент на данный момент
            if (r < n && array[r] > array[largest])
                largest = r;

            // Если самый большой элемент не корень
            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;

                // Рекурсивно преобразуем в двоичную кучу затронутое поддерево
                Heapify(array, n, largest);
            }
        }

        private static void Heapify(char[] array, int n, int i)
        {
            int largest = i;
            // Инициализируем наибольший элемент как корень
            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2

            // Если левый дочерний элемент больше корня
            if (l < n && array[l] > array[largest])
                largest = l;

            // Если правый дочерний элемент больше, чем самый большой элемент на данный момент
            if (r < n && array[r] > array[largest])
                largest = r;

            // Если самый большой элемент не корень
            if (largest != i)
            {
                char swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;

                // Рекурсивно преобразуем в двоичную кучу затронутое поддерево
                Heapify(array, n, largest);
            }
        }

        #endregion

        public static void Main()
        {
            Console.Write("Введите количестов элементов массива: ");
            var size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите тип данных массива Int/String:");
            Console.WriteLine("1. Int;\n2. String;");
            Console.Write("Ввод: ");
            var arrayType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n__---------------------------------\n");
            switch (arrayType)
            {
                case 1:
                    var arrayInt = GenerateArray<int>(size, (ArrayType) arrayType);
                    Console.WriteLine("Исходный массив: ");
                    GetArray(arrayInt);
                    Console.WriteLine("\nОтсортированный массив: ");
                    GetArray(DirectSort(arrayInt));
                    break;
                case 2:
                    var arrayChar = GenerateArray<char>(size, (ArrayType) arrayType);
                    Console.WriteLine("Исходный массив: ");
                    GetArray(arrayChar);
                    Console.WriteLine("\nОтсортированный массив: ");
                    GetArray(DirectSort(arrayChar));
                    break;
            }
        }
    }
}