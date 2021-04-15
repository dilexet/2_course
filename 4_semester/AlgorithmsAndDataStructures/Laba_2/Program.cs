using System;
using System.Linq;

namespace Laba_2
{
    static class Program
    {
        private static int _numberOfComparisons;
        private static int _numberOfPermutations;
        private static int[] _intArray;

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
        
        public static void Main()
        {
            Console.WriteLine("Введите длину массива: ");
            var size = Convert.ToInt32(Console.ReadLine());
            _intArray = GenerateArray(size);
            Console.WriteLine("\nИсходный массив:");
            GetArray(_intArray.ToArray());
            Console.WriteLine();
            // 1
            Console.WriteLine("\n1) сортировка включением;\n");
            InclusionSort(_intArray.ToArray());
            Console.WriteLine("Сравнения: " + _numberOfComparisons + "\nПерестановок: " + _numberOfPermutations);
            GetArray(_intArray);
            Console.WriteLine();

            // 2
            Console.WriteLine("\n2) сортировка выбором;\n");
            SelectionSort(_intArray.ToArray());
            Console.WriteLine("Сравнения: " + _numberOfComparisons + "\nПерестановок: " + _numberOfPermutations);
            GetArray(_intArray);
            Console.WriteLine();

            // 3
            Console.WriteLine("\n3) сортировка обменом(шейкерная сортировка);\n");
            ExchangeSort(_intArray.ToArray());
            Console.WriteLine("Сравнения: " + _numberOfComparisons + "\nПерестановок: " + _numberOfPermutations);
            GetArray(_intArray);
            Console.WriteLine();

            // 4
            _numberOfComparisons = 0;
            _numberOfPermutations = 0;
            Console.WriteLine("\n4) сортировка с помощью разделения – быстрая сортировка Хаара;\n");
            DualPivotQuickSort(_intArray.ToArray(), 1, _intArray.Length - 2);
            Console.WriteLine("Сравнения: " + _numberOfComparisons + "\nПерестановок: " + _numberOfPermutations);
            GetArray(_intArray);
            Console.WriteLine();

            // 5
            _numberOfComparisons = 0;
            _numberOfPermutations = 0;
            Console.WriteLine("\n5) пирамидальная сортировка\n");
            HeapSort(_intArray.ToArray());
            Console.WriteLine("Сравнения: " + _numberOfComparisons + "\nПерестановок: " + _numberOfPermutations);
            GetArray(_intArray);
            Console.WriteLine();
        }

        private static void SwapInt(int[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        // TODO: сортировка включением
        private static void InclusionSort(int[] array)
        {
            _numberOfComparisons = 0;
            _numberOfPermutations = 0;
            for (int left = 0; left < array.Length; left++)
            {
                // Вытаскиваем значение элемента
                int value = array[left];
                // Перемещаемся по элементам, которые перед вытащенным элементом
                int i = left - 1;
                for (; i >= 0; i--)
                {
                    _numberOfComparisons++;
                    // Если вытащили значение меньшее — передвигаем больший элемент дальше
                    if (value < array[i])
                    {
                        array[i + 1] = array[i];
                    }
                    else
                    {
                        // Если вытащенный элемент больше — останавливаемся
                        break;
                    }
                }

                // В освободившееся место вставляем вытащенное значение
                _numberOfPermutations++;
                array[i + 1] = value;
            }
        }

        // TODO: Сортировка выбором
        private static void SelectionSort(int[] intArray)
        {
            _numberOfComparisons = 0;
            _numberOfPermutations = 0;
//        for (int left = 0; left < intArray.length; left++) {
//            int minInd = left;
//            for (int i = left; i < intArray.length; i++) {
//                numberOfComparisons++;
//                if (intArray[i] < intArray[minInd]) {
//                    minInd = i;
//                }
//            }
//            swapInt(intArray, left, minInd);
//            numberOfPermutations++;
//        }
            for (int i = 0; i < intArray.Length; i++)
            {
                // i - номер текущего шага
                int pos = i;
                int min = intArray[i];
                // цикл выбора наименьшего элемента
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    _numberOfComparisons++;
                    if (intArray[j] < min)
                    {
                        pos = j; // pos - индекс наименьшего элемента
                        min = intArray[j];
                    }
                }

                intArray[pos] = intArray[i];
                intArray[i] = min; // меняем местами наименьший с array[i]
                _numberOfPermutations++;
            }
        }

        // TODO: Сортировка обеменом (шейкерная)
        private static void ExchangeSort(int[] array)
        {
            _numberOfComparisons = 0;
            _numberOfPermutations = 0;
            bool isSwapped;
            int leftBorder = 0;
            int rightBorder = array.Length - 1;
            do
            {
                isSwapped = false;
                for (int i = leftBorder; i + 1 <= rightBorder; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        SwapInt(array, i, i + 1);
                        isSwapped = true;
                        _numberOfPermutations++; //увеличиваем кол-во сравнений
                    }

                    _numberOfComparisons++; //увеличиваем кол-во перестановок
                }

                rightBorder--;

                for (int i = rightBorder; i - 1 >= leftBorder; i--)
                {
                    _numberOfComparisons++;
                    if (array[i] < array[i - 1])
                    {
                        SwapInt(array, i, i - 1);
                        isSwapped = true;
                        _numberOfPermutations++;
                    }
                }

                leftBorder++;
            } while (leftBorder < rightBorder && isSwapped);
        }


        private static void HeapSort(int[] array)
        {
            _numberOfComparisons = 0;
            _numberOfPermutations = 0;
            int n = array.Length;
            // Построение кучи (перегруппируем массив)
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(array, n, i);
            // Один за другим извлекаем элементы из кучи
            for (int i = n - 1; i >= 0; i--)
            {
                if (array[0] == array[i]) continue;

                _numberOfPermutations++;
                // Перемещаем текущий корень в конец
                SwapInt(array, 0, i);
                // Вызываем процедуру heapify на уменьшенной куче
                Heapify(array, i, 0);
            }
        }

        // Процедура для преобразования в двоичную кучу поддерева с корневым узлом i, что является
        // индексом в arr[]. n - размер кучи
        static void Heapify(int[] array, int n, int i)
        {
            int largest = i; // Инициализируем наибольший элемент как корень
            int l = 2 * i + 1; // левый = 2i + 1
            int r = 2 * i + 2; // правый = 2i + 2

            // Если левый дочерний элемент больше корня
            //numberOfComparisons++;
            if (l < n)
            {
                _numberOfComparisons++;
                if (array[l] > array[largest])
                {
                    largest = l;
                    //правый дочерний элемент больше, чем самый большой элемент н
                    // Еслиа данный момент
                }
            }

            //numberOfComparisons++;
            if (r < n)
            {
                _numberOfComparisons++;
                if (array[r] > array[largest])
                {
                    largest = r;
                    // Если самый большой элемент не корень
                }
            }

            if (largest != i)
            {
                SwapInt(array, i, largest);
                _numberOfPermutations++;
                // Рекурсивно преобразуем в двоичную кучу затронутое поддерево
                Heapify(array, n, largest);
            }
        }

        private static void DualPivotQuickSort(int[] arr, int leftPivotIndex, int rightPivotIndex)
        {
            
            if (leftPivotIndex <= rightPivotIndex + 1)
            {
                // piv[] stores left pivot and right pivot.
                // piv[0] means left pivot and
                // piv[1] means right pivot
                int[] pivots;
                pivots = Partition(arr, leftPivotIndex, rightPivotIndex);
                DualPivotQuickSort(arr, leftPivotIndex, pivots[0] - 2);
                DualPivotQuickSort(arr, pivots[0] + 2, pivots[1] - 2);
                DualPivotQuickSort(arr, pivots[1] + 2, rightPivotIndex);
            }
        }

        private static int[] Partition(int[] arr, int leftPivotIndex, int rightPivotIndex)
        {
            _numberOfComparisons++;
            if (arr[leftPivotIndex] > arr[rightPivotIndex])
            {
                _numberOfPermutations++;
                SwapInt(arr, leftPivotIndex, rightPivotIndex);
            }

            int leftMarker = leftPivotIndex - 1;
            int leftCenterMarker = leftPivotIndex + 1;
            int rightCenterMarker = rightPivotIndex - 1;
            int rightMarker = rightPivotIndex + 1;
            int leftPivot = arr[leftPivotIndex];
            int rightPivot = arr[rightPivotIndex];

            _numberOfComparisons++;
            if (arr[leftMarker] > rightPivot)
            {
                for (int i = leftMarker; i < rightPivotIndex; i++)
                {
                    SwapInt(arr, i, i + 1);
                    _numberOfPermutations++; // поменял
                }

                //numberOfPermutations++;
                rightPivotIndex--;
                leftPivotIndex--;
                leftCenterMarker--;
                rightCenterMarker--;
            }
            else
            {
                _numberOfComparisons++;
                if (arr[leftMarker] > leftPivot)
                {
                    for (int i = leftMarker; i < leftPivotIndex; i++)
                    {
                        SwapInt(arr, i, i + 1);
                        _numberOfPermutations++; // поменял
                    }

                    leftPivotIndex--;
                    leftCenterMarker--;
                    //numberOfPermutations++;
                }
            }

            _numberOfComparisons++;
            if (arr[rightMarker] < leftPivot)
            {
                for (int i = rightMarker; i > leftPivotIndex; i--)
                {
                    SwapInt(arr, i, i - 1);
                    _numberOfPermutations++; //поменял
                }

                //numberOfPermutations++;
                rightPivotIndex++;
                leftPivotIndex++;
                leftCenterMarker++;
                rightCenterMarker++;
            }
            else
            {
                _numberOfComparisons++;
                if (arr[rightMarker] < rightPivot)
                {
                    for (int i = rightMarker; i > rightPivotIndex; i--)
                    {
                        SwapInt(arr, i, i - 1);
                        _numberOfPermutations++;
                    }

                    rightPivotIndex++;
                    rightCenterMarker++;
                    //numberOfPermutations++;
                }
            }

            for (int i = leftCenterMarker; i <= rightCenterMarker; i++)
            {
                _numberOfComparisons++;
                if (arr[i] < leftPivot)
                {
                    for (int j = i; j > leftPivotIndex; j--)
                    {
                        SwapInt(arr, j, j - 1);
                        _numberOfPermutations++;
                    }

                    // numberOfPermutations++;
                    leftPivotIndex++;
                }
                else
                {
                    _numberOfComparisons++;
                    if (arr[i] > rightPivot)
                    {
                        for (int j = i; j < rightPivotIndex; j++)
                        {
                            SwapInt(arr, j, j + 1);
                            _numberOfPermutations++;
                        }

                        // numberOfPermutations++;
                        rightCenterMarker--;
                        i--;
                        rightPivotIndex--;
                    }
                }
            }

            return new[] {leftPivotIndex, rightPivotIndex};
        }
    }
}