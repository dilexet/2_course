using System;
using System.Threading;

namespace Task_2_AND_3
{
    class Application
    {
        // Entry point
        // Точка входа.
        static void Main()
        {
            // m m m | a
            // m m m | a
            // m m m | a
 
            // Matrix coefficients
            // Матрица коеффциентов СЛАУ
            double[,] matrix = new double[,] {
            { 10, 3, 6}, 
            { 3, 14, 9}, 
            { 1, 7, 10}
            };
 
           
            // matrix of free coefficients
            // матрица свободных членов
            double[] additional = new double[] {
                10, 
                14, 
                12
            };
 
            
 
            // Create and init.
            // Объявляем и инициализимруем классы.
            Seidel seidel = new Seidel(matrix, additional, 0.0001);
            Jacobi jacobi = new Jacobi(matrix, additional, 0.0001);
 
            // set method args of ThreadStart delegate 
            // Передаем методы потоку через делегат ThreadStart
            Thread z = new Thread(
                seidel.CalculateMatrix);
            Thread y = new Thread(
                jacobi.CalculateMatrix);
 
            // Start threads
            // Запускаем потоки.
            z.Start();
            y.Start();
 
            // wait for endings
            // Ожидаем завершения.
            z.Join();
            y.Join();
 
            // Show results of calculations 
            // Выводим на экран.
            Console.WriteLine("\n Seidel method:");
            ShowMatrix(seidel.ResultMatrix, matrix);
            Console.WriteLine("\n Jakobi method:");
            ShowMatrix(jacobi.ResultMatrix, matrix);
            
        }
 
        
        static void ShowMatrix(double[] x, double [,] matrix)
        {
            Console.WriteLine("\n Result:");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"x{i+1} = {x[i]}");
            }

            Console.WriteLine("\nПроверочка\n");
            double item = 0.0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    item = 0.0;
                    for (int k = 0; k < 3; k++)
                    {
                        item += matrix[i, k] * x[k];
                    }
                }
                Console.Write($"{item}\n");
            }
        }
    }
 
    
 
    /// <summary>
    /// Class Jacobi 
    /// Класс отвечает за работу метода Якоби
    /// </summary>
    class Jacobi
    {
        // Матрица ответов
        private double[] _resultMatrix;
        public double[] ResultMatrix
        {
            get
            {
                if (_resultMatrix != null)
                    return _resultMatrix;
                else
                {
                    return new double[] { 0, 0, 0 };
                }
            }
        }
 
        // Основная матрица и свободные члены.
        private double[,] matrix;
        private double[] addtional;
 
        // точность (кол-во итераций)
        private double _accuracy;
        // избегаем ошибок с итерациями.
        public double Accuracy
        {
            get
            {
                return _accuracy;
            }
            set
            {
                if (value <= 0.0)
                    _accuracy = 0.1;
                else
                    _accuracy = value;
            }
        }
 
        // Конструктор. Получает значения при создании.
        public Jacobi(double[,] matrix, double[] freeElements, double accuracy)
        {
            this.matrix = matrix;
            addtional = freeElements;
            Accuracy = accuracy;
 
        }
 
        // Сам метод рассчета.
        public void CalculateMatrix()
        {
            // общий вид:
            // [x1]   [ b1/a11 ]   / 0 x x \ 
            // [x2] = [ b2/a22 ] - | x 0 x |
            // [x3]   [ b3/a33 ]   \ x x 0 /
            // где x - делится на диагональый элемент первоначальной матрицы.
            // где b - эелементы из свободных членов
            // где а - элементы из матрицы
 
            // матрица коеффициентов + столбец свободных членов.
            double[,] a = new double[matrix.GetLength(0), matrix.GetLength(1) + 1];
 
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1) - 1; j++)
                    a[i, j] = matrix[i, j];
 
            for (int i = 0; i < a.GetLength(0); i++)
                a[i, a.GetLength(1) - 1] = addtional[i];
            
            //---------------
            // Метод Якоби.
            //---------------
 
            // Введем вектор значений неизвестных на предыдущей итерации,
            // размер которого равен числу строк в матрице, т.е. size,
            // причем согласно методу изначально заполняем его нулями
 
            double[] previousValues = new double[a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                previousValues[i] = 0.0;
            }
 
            // Будем выполнять итерационный процесс до тех пор,
            // пока не будет достигнута необходимая точность
            while (true)
            {
                // Введем вектор значений неизвестных на текущем шаге
                double[] currentValues = new double[a.GetLength(0)];
 
                // Посчитаем значения неизвестных на текущей итерации
                // в соответствии с теоретическими формулами
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    // Инициализируем i-ую неизвестную значением
                    // свободного члена i-ой строки матрицы
                    currentValues[i] = a[i, a.GetLength(0)];
 
                    // Вычитаем сумму по всем отличным от i-ой неизвестным
                    for (int j = 0; j < a.GetLength(0); j++)
                    {
                        if (i != j)
                        {
                            currentValues[i] -= a[i, j] * previousValues[j];
                        }
                    }
 
                    // Делим на коэффициент при i-ой неизвестной
                    currentValues[i] /= a[i, i];
                }
 
                // Посчитаем текущую погрешность относительно предыдущей итерации
                double differency = 0.0;
 
                for (int i = 0; i < a.GetLength(0); i++)
                    differency += Math.Abs(currentValues[i] - previousValues[i]);
 
                // Если необходимая точность достигнута, то завершаем процесс
                if (differency < _accuracy)
                    break;
 
                // Переходим к следующей итерации, так
                // что текущие значения неизвестных
                // становятся значениями на предыдущей итерации
                previousValues = currentValues;
            }
 
            _resultMatrix = previousValues;
        }
 
    }
 
    /// <summary>
    /// Класс Отвечает за работу метода Зейделя.
    /// Class Seidel
    /// </summary>
    class Seidel
    {
        // Матрица ответов
        private double[] _resultMatrix;
        public double[] ResultMatrix
        {
            get
            {
                if (_resultMatrix != null)
                    return _resultMatrix;
                else
                {
                    return new double[] { 0, 0, 0 };
                }
            }
        }
        
 
        // Основная матрица и свободные члены.
        private double[,] matrix;
        private double[] addtional;
 
        // точность (кол-во итераций)
        private double _accuracy;
        // избегаем ошибок с итерациями.
        public double Accuracy
        {
            get
            {
                return _accuracy;
            }
            set
            {
                if (value <= 0.0)
                    _accuracy = 0.1;
                else
                    _accuracy = value;
            }
        }
 
        // Конструктор. Получает значения при создании.
        public Seidel(double[,] matrix, double[] freeElements, double accuracy)
        {
            this.matrix = matrix;
            addtional = freeElements;
            Accuracy = accuracy;
 
        }
 
        // Сам метод рассчета.
        public void CalculateMatrix()
        {
 
            // общий вид:
            // [x1]   [ b1/a11 ]   / 0 x x \ 
            // [x2] = [ b2/a22 ] - | x 0 x |
            // [x3]   [ b3/a33 ]   \ x x 0 /
            // где x - делится на диагональый элемент первоначальной матрицы.
            // где b - эелементы из свободных членов
            // где а - элементы из матрицы
 
            // матрица коеффициентов + столбец свободных членов.
            double[,] a = new double[matrix.GetLength(0), matrix.GetLength(1) + 1];
 
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1) - 1; j++)
                    a[i, j] = matrix[i, j];
 
            for (int i = 0; i < a.GetLength(0); i++)
                a[i, a.GetLength(1) - 1] = addtional[i];
 
            //---------------
            // Метод Зейделя.
            //---------------
 
            // Введем вектор значений неизвестных на предыдущей итерации,
            // размер которого равен числу строк в матрице, т.е. size,
            // причем согласно методу изначально заполняем его нулями
            double[] previousValues = new double[matrix.GetLength(0)];
            for (int i = 0; i < previousValues.GetLength(0); i++)
            {
                previousValues[i] = 0.0;
            }
 
            // Будем выполнять итерационный процесс до тех пор,
            // пока не будет достигнута необходимая точность
            while (true)
            {
                // Введем вектор значений неизвестных на текущем шаге
                double[] currentValues = new double[a.GetLength(0)];
 
                // Посчитаем значения неизвестных на текущей итерации
                // в соответствии с теоретическими формулами
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    // Инициализируем i-ую неизвестную значением
                    // свободного члена i-ой строки матрицы
                    currentValues[i] = a[i, a.GetLength(0)];
 
                    // Вычитаем сумму по всем отличным от i-ой неизвестным
                    for (int j = 0; j < a.GetLength(0); j++)
                    {
                        // При j < i можем использовать уже посчитанные
                        // на этой итерации значения неизвестных
                        if (j < i)
                        {
                            currentValues[i] -= a[i, j] * currentValues[j];
                        }
 
                        // При j > i используем значения с прошлой итерации
                        if (j > i)
                        {
                            currentValues[i] -= a[i, j] * previousValues[j];
                        }
                    }
 
                    // Делим на коэффициент при i-ой неизвестной
                    currentValues[i] /= a[i, i];
                }
 
                // Посчитаем текущую погрешность относительно предыдущей итерации
                double differency = 0.0;
 
                for (int i = 0; i < a.GetLength(0); i++)
                    differency += Math.Abs(currentValues[i] - previousValues[i]);
 
                // Если необходимая точность достигнута, то завершаем процесс
                if (differency < _accuracy)
                    break;
 
                // Переходим к следующей итерации, так
                // что текущие значения неизвестных
                // становятся значениями на предыдущей итерации
 
                previousValues = currentValues;
            }
 
            // результат присваиваем матрице результатов.
            _resultMatrix = previousValues;
        }
 
 
 
    }
}