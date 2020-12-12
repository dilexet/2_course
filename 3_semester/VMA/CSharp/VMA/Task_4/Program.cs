using System;

namespace Task_4
{
    internal class Program
    {
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

        public static void Main(string[] args)
        {
            int n = 4;
            double[,] A = new double[,]
            {
                {2.2, 1, 0.5, 2},
                {1, 1.3, 2, 1},
                {0.5, 2, 0.5, 1.6},
                {2, 1, 1.6, 2}
            };
            //////// 1 этап /////////////////////
            double[,] B1 = new double[,]
            {
                {1, 0, 0, 0},
                {0, 1, 0, 0},
                {0, 0, 1, 0},
                {0, 0, 0, 1}
            };
            double[,] B1_1 = new double[,]
            {
                {1, 0, 0, 0},
                {0, 1, 0, 0},
                {0, 0, 1, 0},
                {0, 0, 0, 1}
            };
            double bn1N1 = 1 / A[n - 1, n - 2];
            // Console.WriteLine(bn1N1);
            // Получение матрицы B1
            for (int j = 0; j < n; j++)
            {
                if (j == n - 2)
                {
                    B1[n - 2, n - 2] = bn1N1;
                }
                else
                {
                    B1[n - 2, j] = (-1) * (A[n - 1, j] / A[n - 1, n - 2]);
                }
            }

            // Получение матрицы B1 ^ -1
            for (int i = 0; i < n; i++)
            {
                B1_1[n - 2, i] = A[n - 1, i];
            }

            double[,] Ditem = new double[n, n];
            double[,] D = new double[n, n];
            // Ditem = B1 ^ -1 * A
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Ditem[i, j] += B1_1[i, k] * A[k, j];
                    }
                }
            }

            // D = Ditem * B
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        D[i, j] += Ditem[i, k] * B1[k, j];
                    }
                }
            }
        /////////////////////////////////
        /// 2 этап //////////////
        double[,] B2 = new double[,]
        {
            {1, 0, 0, 0},
            {0, 1, 0, 0},
            {0, 0, 1, 0},
            {0, 0, 0, 1}
        };
        double bn1N1_2 = 1 / D[n - 2, n - 3];
        // Получение матрицы B2
        for (int j = 0; j < n; j++)
        {
            if (j == n - 3)
            {
                B2[n - 3, n - 3] = bn1N1_2;
            }
            else
            {
                B2[n - 3, j] = (-1) * (D[n - 2, j] / D[n - 2, n - 3]);
            }
        }
        double[,] B2_1 = new double[,]
        {
            {1, 0, 0, 0},
            {0, 1, 0, 0},
            {0, 0, 1, 0},
            {0, 0, 0, 1}
        };
        // Получение матрицы B2 ^ -1
        for (int i = 0; i < n; i++)
        {
            B2_1[n - 3, i] = D[n - 2, i];
        }

        Ditem = null;
        Ditem = new double[n, n];
        double[,] D2 = new double[n, n];
        // Ditem = B2 ^ -1 * D1
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    Ditem[i, j] += B2_1[i, k] * D[k, j];
                }
            }
        }

        // D2 = Ditem * B2
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    D2[i, j] += Ditem[i, k] * B2[k, j];
                }
            }
        }
        //////////////////////////////////
        /// 3 этап ///////////////
        double[,] B3 = new double[,]
        {
            {1, 0, 0, 0},
            {0, 1, 0, 0},
            {0, 0, 1, 0},
            {0, 0, 0, 1}
        };
        double bn1N1_3 = 1 / D2[n - 3, n - 4];
        
        // Получение матрицы B3
        for (int j = 0; j < n; j++)
        {
            if (j == n - 4)
            {
                B3[n - 4, n - 4] = bn1N1_3;
            }
            else
            {
                B3[n - 4, j] = (-1) * (D2[n - 3, j] / D2[n - 3, n - 4]);
            }
        }
        double[,] B3_1 = new double[,]
        {
            {1, 0, 0, 0},
            {0, 1, 0, 0},
            {0, 0, 1, 0},
            {0, 0, 0, 1}
        };
        // Получение матрицы B3 ^ -1
        for (int i = 0; i < n; i++)
        {
            B3_1[n - 4, i] = D2[n - 3, i];
        }

        Ditem = null;
        Ditem = new double[n, n];
        double[,] D3 = new double[n, n];
        // Ditem = B3 ^ -1 * D2
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    Ditem[i, j] += B3_1[i, k] * D2[k, j];
                }
            }
        }

        // D3 = Ditem * B3
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    D3[i, j] += Ditem[i, k] * B3[k, j];
                }
            }
        }

        D3[1, 1] = 0;
        
        /// 4 этап ///////////////
        double[,] B = new double[n,n];
        Ditem = null;
        Ditem = new double[n, n];
        // Ditem = B1 * B2
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    Ditem[i, j] += B1[i, k] * B2[k, j];
                }
            }
        }

        // B = Ditem * B3
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    B[i, j] += Ditem[i, k] * B3[k, j];
                }
            }
        }
        
        }
    }
}