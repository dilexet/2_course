using System;
using System.Collections.Generic;

namespace Task_5
{
    internal class Program
    {
        
        static decimal[,] Operations(decimal[,] A, decimal[,] B, decimal[,] One_matrix, decimal[,] matrix, decimal[] mas, uint num)
        {

            decimal p = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (i == j)
                    p += A[i, j];
            }
            p/=num;

            mas[num-1] = p;

            if (mas[mas.Length - 1] == 0)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[i, j] = A[i, j] - p * One_matrix[i, j];
                }

                A = Multiplication(matrix, B);
            }
            return A;
        }
        
        
        static decimal[,] Multiplication(decimal[,] a, decimal[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            decimal[,] r = new decimal[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }
        
        public static List<double> GetRootsOfCubicEquations(double a, double b, double c)
        {
            var q = (Math.Pow(a, 2) - 3 * b) / 9;
            var r = (2 * Math.Pow(a, 3) - 9 * a * b + 27 * c) / 54;

            if (Math.Pow(r, 2) < Math.Pow(q, 3))
            {
                var t = Math.Acos(r / Math.Sqrt(Math.Pow(q, 3))) / 3;
                var x1 = -2 * Math.Sqrt(q) * Math.Cos(t) - a / 3;
                var x2 = -2 * Math.Sqrt(q) * Math.Cos(t + (2 * Math.PI / 3)) - a / 3;
                var x3 = -2 * Math.Sqrt(q) * Math.Cos(t - (2 * Math.PI / 3)) - a / 3;
                return new List<double> { x1, x2, x3 };
            }
            else
            {
                var A = -Math.Sign(r) * Math.Pow(Math.Abs(r) + Math.Sqrt(Math.Pow(r, 2) - Math.Pow(q, 3)), (1.0 / 3.0));
                var B = (A == 0) ? 0.0 : q / A;

                var x1 = (A + B) - a / 3;

                if (A == B)
                {
                    var x2 = -A - a / 3;
                    return new List<double> { Math.Abs(x1), Math.Abs(x2) };
                }
                return new List<double> { Math.Abs(x1) };
            }
        }
        public static double[] raschet(double b, double c)
        {
            double a = 1;
            double x1 = 0;
            double x2 = 0;
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
            }

            return new[] {x1, x2};
        }
        static void Calucate()
        {
            decimal[,] matrix = new decimal[3, 3]
            {
                {2, 0, 1},
                {0, 2, 1},
                {0, 9, 2}
            };

            decimal[,] one_matrix = new decimal[3, 3] {
                { 1, 0, 0},
                { 0, 1, 0},
                { 0, 0, 1}
            };

            decimal[] p_mas = new decimal[3];
            decimal[,] A = new decimal[3, 3];
            decimal[,] B = new decimal[3, 3];

            // 1 step
            A = matrix;
            A = Operations(A, B, one_matrix, matrix,p_mas, 1);
            

            // 2 step

            A = Operations(A, B, one_matrix, matrix, p_mas, 2);
            

            // 3 step 

            A = Operations(A, B, one_matrix, matrix, p_mas, 3);

            

            List<double> nums = GetRootsOfCubicEquations(-Convert.ToDouble(p_mas[0]), -Convert.ToDouble(p_mas[1]), -Convert.ToDouble(p_mas[2]));
            Console.WriteLine("\nКорни характеристического уравнения:");
            foreach(double num in nums)
            {
                Console.WriteLine(num);
            }
        }

        public static void Main(string[] args)
        {
            Calucate();
        }
    }
}