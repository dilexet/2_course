using System;
using System.Collections.Generic;
using System.Numerics;
using MathNet.Numerics;

namespace Task_4
{
    internal class Program
    {
        public static List<Complex> GetRootsOfCubicEquations(double a, double b, double c)
        {
            var q = (Math.Pow(a, 2) - 3 * b) / 9;
            var r = (2 * Math.Pow(a, 3) - 9 * a * b + 27 * c) / 54;
 
            if (Math.Pow(r, 2) < Math.Pow(q, 3))
            {
                var t = Math.Acos(r / Math.Sqrt(Math.Pow(q, 3))) / 3;
                var x1 = -2 * Math.Sqrt(q) * Math.Cos(t) - a / 3;
                var x2 = -2 * Math.Sqrt(q) * Math.Cos(t + (2 * Math.PI / 3)) - a / 3;
                var x3 = -2 * Math.Sqrt(q) * Math.Cos(t - (2 * Math.PI / 3)) - a / 3;
                return new List<Complex> { x1, x2, x3 };
            }
            else
            {
                var A = -Math.Sign(r) * Math.Pow(Math.Abs(r) + Math.Sqrt(Math.Pow(r, 2) - Math.Pow(q, 3)), (1.0 / 3.0));
                var B = (A == 0) ? 0.0 : q / A;
 
                var x1 = (A + B) - a / 3;
                var x2 = -(A + B) / 2 - (a / 3) + (Complex.ImaginaryOne * Math.Sqrt(3) * (A - B) / 2);
                var x3 = -(A + B) / 2 - (a / 3) - (Complex.ImaginaryOne * Math.Sqrt(3) * (A - B) / 2);
 
                if (A == B)
                {
                    x2 = -A - a / 3;
                    return new List<Complex> { x1, x2 };
                }
                return new List<Complex> { x1, x2, x3 };
            }
        }
        public static Complex[] raschet(double b, double c)
        {
            double a = 1;
            Complex x1 = 0;
            Complex x2 = 0;
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
            }

            return new[] {x1, x2};
        }
        static void PrintElementMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }

                Console.WriteLine();
            }
        }

        static double[,] MatrixMultiplication(double[,] a, double[,] b)
        {
            int n = a.GetLength(0);
            double[,] c = new double[n, n];
            // Ditem = B1 ^ -1 * A
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return c;
        }

        static double[,] GeneratingTheIdentityMatrix(int size)
        {
            double[,] matrix = new double[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                        matrix[i, j] = 1;
                }
            }

            return matrix;
        }

        public static void Main()
        {
            int n = 2;
            double[,] A =
            {
                {2, 1},
                {9, 2}
            };
           

            List<double[,]> listMatrixB = new List<double[,]>();
            List<double[,]> listMatrixD = new List<double[,]>();
            listMatrixD.Add(A);

            for (int count = 0; count < n - 1; count++)
            {
                double values = listMatrixD[count][n - 1 - count, n - 2 - count];
                double[,] Bn = GeneratingTheIdentityMatrix(n);
                for (int j = 0; j < n; j++)
                {
                    if (j == n - 2 - count)
                    {
                        Bn[n - 2 - count, n - 2 - count] = 1 / values;
                    }
                    else
                    {
                        Bn[n - 2 - count, j] = (-1) * (listMatrixD[count][n - 1 - count, j] /
                                                       listMatrixD[count][n - 1 - count, n - 2 - count]);
                    }
                }
                listMatrixB.Add(Bn);
                double[,] Bn_1 = GeneratingTheIdentityMatrix(n);
                for (int i = 0; i < n; i++)
                {
                    Bn_1[n - 2 - count, i] = listMatrixD[count][n - 1 - count, i];
                }

                double[,] Dn = new double[n, n];
                Dn = MatrixMultiplication(MatrixMultiplication(Bn_1, listMatrixD[count]), Bn);
                listMatrixD.Add(Dn);
                PrintElementMatrix(Dn);
                Console.WriteLine("\n");
            }

            Complex[] lambda = new Complex[n];
            if (n == 3)
            {
                lambda = GetRootsOfCubicEquations((-1) * listMatrixD[n - 1][0, 0],
                    (-1) * listMatrixD[n - 1][0, 1],
                    (-1) * listMatrixD[n - 1][0, 2]).ToArray();
               
            }
            else if (n == 2)
            {
                lambda = raschet((-1) * listMatrixD[n - 1][0, 0], 
                    (-1) * listMatrixD[n - 1][0, 1]);
               
            }
            
            Console.WriteLine("\nСобственные значения:");
            int index = 1;
            foreach (var item in lambda)
            {
                Console.WriteLine($"x{index} = {item}");
                index++;
            }
            
        }
    }
}