using System;

namespace task_5
{
    public static class Test
    {
        private static decimal Factorial(decimal x)
        {
            if (x == 0) return 1;
            return x * Factorial(x - 1);
        }

        public static void ShowResult(decimal[] mas)
        {
            foreach (var t in mas)
            {
                Console.Write($"\t {t} \t");
            }
        }

        public static decimal Pn1(decimal[] dy, decimal x, decimal x0, decimal y0, decimal h)
        {
            decimal q = (x - x0) / h;
            decimal item = q;
            decimal xn = y0;
            decimal value = xn;
            for (int i = 0; i < dy.Length; i++)
            {
                xn = item / Factorial(i + 1) * dy[i];
                value += xn;
                item *= (q - (i + 1));
            }

            Console.WriteLine();
            return value;
        }

        public static decimal Pn2(decimal[] dy, decimal x, decimal xk, decimal yk, decimal h)
        {
            decimal q = (x - xk) / h;
            decimal item = q;
            decimal xn = yk;
            decimal valueX = xn;
            for (int i = 0; i < dy.Length; i++)
            {
                xn = item / Factorial(i + 1) * dy[i];
                valueX += xn;
                item *= (q + (i + 1));
            }

            Console.WriteLine();
            return valueX;
        }

        public static decimal[] Newton1(decimal[] masY, int n)
        {
            decimal[] mas = new decimal[masY.Length];
            int m = n;
            decimal[] dy = new decimal[m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[j] = (masY[j + 1] - masY[j]);
                }

                dy[i] = mas[0];
                Array.Copy(mas, masY, mas.Length);
                m--;
            }

            return dy;
        }

        public static decimal[] Newton2(decimal[] masY, int n)
        {
            decimal[] mas = new decimal[masY.Length];
            int m = n;
            int k = 2;
            decimal[] dy = new decimal[m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[j] = (masY[j + 1] - masY[j]);
                }

                dy[i] = mas[mas.Length - k];
                k++;
                Array.Copy(mas, masY, mas.Length);
                m--;
            }

            return dy;
        }

        public static decimal[,] Calculate()
        {
            decimal[] masY =
            {
                (decimal) 0.26183, (decimal) 0.27644, (decimal) 0.29122, (decimal) 0.30617, (decimal) 0.32130,
                (decimal) 0.33660, (decimal) 0.35207, (decimal) 0.36773, (decimal) 0.38537, (decimal) 0.39959
            };

            decimal[] dy = Newton1(masY, 9);
            decimal[,] massY = new decimal[100, 2];
            int i = 0;
            for (decimal j = (decimal) 0.01; j < (decimal) 0.461; j += (decimal) 0.005)
            {
                massY[i, 0] = j;
                massY[i, 1] = Pn1(dy, j, (decimal) 0.01, (decimal) 0.26183, (decimal) 0.05);
                // Console.WriteLine($"x = {massY[i, 0]:0.###}");
                // Console.WriteLine($"y = {massY[i, 1]:0.#####}");
                i++;
            }

            return massY;
        }
    }
}