using System;

namespace Laba_2
{
    public static class Program
    {
        #region ArrayWorkRegion
        
        private static int[] GenerateArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-123, 890);
            }
            return array;
        }

        private static void GetArray(int[] array)
        {
            foreach (var el in array)
            {
                Console.Write($"{el} ");
            }
        }

        #endregion

        // 1) Сортировка прямым включением
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
        
        #endregion

        // 2) Сортировка выбором
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

        #endregion

        // 3) Cортировка обменом (шейкерная сортировка)
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

        #endregion

        // 4) Сортировка с помощью разделения – быстрая сортировка Хоара
        #region SplitSortRegion

        // метод возвращающий индекс опорного элемента
        private static int Partition(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;
            for (int i = minIndex; i < maxIndex; i++) // просматриваем с minIndex по maxIndex
            {
                if (array[i].CompareTo(array[maxIndex]) <= 0) // если элемент m[i] не превосходит m[maxIndex],
                {
                    pivot++; 
                    var t = array[pivot];
                    array[pivot] = array[i]; 
                    array[i] = t; 
                    
                }
            }
            pivot++; 
            var t2 = array[pivot];
            array[pivot] = array[maxIndex]; 
            array[maxIndex] = t2; 
            return pivot; // в индексе pivot хранится <новая позиция элемента m[maxIndex]> + 1
        }
        
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }

        #endregion

        // 5) Пирамидальная сортировка
        #region HeapsortRegion
        
        private static int[] Heapsort(int[] array) 
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

        // Процедура для преобразования в двоичную кучу поддерева с корневым узлом i, что является
        // индексом в arr[]. n - размер кучи
        private static void Heapify(int[] array, int n, int i)
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

        #endregion

        public static void Main()
        {
            Console.Write("Введите количестов элементов массива: ");
            var size = Convert.ToInt32(Console.ReadLine());
            
            var arrayInt = GenerateArray(size);
            Console.WriteLine("Исходный массив: ");
            GetArray(arrayInt);
            
            
            Console.WriteLine("\nОтсортированный массив: ");
            var sortInt = Heapsort(arrayInt);
            GetArray(sortInt);
        }
    }
}