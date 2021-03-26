using System;
using System.Linq;

namespace task_5
{
    public class Delete
    {
        public static decimal Factorial(decimal x)
        {
            if (x == 0) return 1;
            else return x * Factorial(x - 1);        
        }
        public static void ShowResult(decimal[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"\t {mas[i]} \t");
            }
        }
        public static decimal Pn1(decimal x, decimal[] dy)
        {
            decimal Q = (x - (decimal)1.115) / (decimal)0.005;
            decimal q = Q;
            decimal Xn = (decimal)8.65729;
            decimal xn = Xn;
            for (int i = 0; i < dy.Length; i++)
            {
                Xn = (q / Factorial(i + 1)) * dy[i];
                xn += Xn;
                q *= (Q - (i + 1));
            }
            return xn;
        }
        public static decimal Pn2(decimal x, decimal[] dy)
        {
            decimal Q = (x - (decimal)1.160) / (decimal)0.005;
            decimal q = Q;
            decimal Xn = (decimal)6.19548;
            decimal xn = Xn;
            for (int i = 0; i < dy.Length; i++)
            {
                Xn = (q / Factorial(i + 1)) * dy[i];
                xn += Xn;
                q *= (Q + (i + 1));
            }
            return xn;
        }
       public static decimal[] Newton1(decimal[] masY, int n)
        {
            decimal[] mas = new decimal[masY.Length];
            int m = n;
            decimal[] dy = new decimal[m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m ; j++)
                {                
                        mas[j] = (masY[j+1] - masY[j]);
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
            int m = n; int k = 2;
            decimal[] dy = new decimal[m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[j] = (masY[j+1] - masY[j]);
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
            decimal[] masY = {(decimal)8.65729, (decimal)8.29329, (decimal)7.95829, (decimal)7.64893, (decimal)7.39235,
            (decimal)7.30962, (decimal) 6.84813, (decimal) 6.61658, (decimal) 6.39954, (decimal) 6.19548};

            decimal[] dy = Newton1(masY, 9);
            decimal[,] masy = new decimal[100, 2];
            int i = 0;
            for(decimal j = (decimal)1.1; j<(decimal)1.2; j += (decimal)0.001)
            {
                masy[i, 0] = j;
                masy[i, 1] = Pn1(j, dy);
                Console.WriteLine("x= " + masy[i, 0]);
                Console.WriteLine("y= " + masy[i, 1]);
                i++;
            }
            return masy;
        }
        public static void Lala()
        {
            //  Calculate();

            decimal[] masY = {(decimal)8.65729, (decimal)8.29329, (decimal)7.95829, (decimal)7.64893, (decimal)7.39235,
            (decimal)7.30962, (decimal) 6.84813, (decimal) 6.61658, (decimal) 6.39954, (decimal) 6.19548};

            decimal[] masY2 = masY.ToArray();

            decimal[] masX = { 1.116M, 1.1527M, 1.156M, 1.1452M, 1.1383M, 1.1575M };

            decimal[] dy = Newton1(masY, 9);

            decimal xn;

            for(int i = 0; i< masX.Length; i++)
            {
                xn = Pn1(masX[i], dy);
                Console.WriteLine($"Newton 1 \nx = {masX[i]} | y = { xn } ");
            }

            dy = Newton2(masY2, 9);

            for (int i = 0; i < masX.Length; i++)
            {
                xn = Pn2(masX[i], dy);
                Console.WriteLine($"Newton 2 \nx = {masX[i]} | y = { xn } ");
            }
        }
    }
}