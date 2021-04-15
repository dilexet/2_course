using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Laba_3
{
    internal class Program
    {
        // получаем купюры покупателя
        private static int[] GetA()
        {
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"[{i + 1}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            return a;
        }

        // получаем купюры продавца
        private static int[] GetB()
        {
            Console.Write("M = ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[m];
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write($"[{i + 1}] = ");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }

            return b;
        }

        // купюры продавца и покупателя вместе
        private static int[] GetC(int[] a, int[] b)
        {
            List<int> c = new List<int>();
            c.AddRange(a);
            c.AddRange(b);
            return c.OrderBy(i => i).ToArray();
        }

        public static void Main()
        {
            // var a = GetA();
            // var b = GetB();
            int[] a = {3, 5, 6, 3, 8};
            int[] b = {3, 9, 6, 3, 5};
            var c = GetC(a, b);
            int s = 0;
            int p = 0;
            int i = 0;
            while (i <= a.Length && c[i] <= s + 1)
            {
                s = s + c[i];
                i = i + 1;
            }

            if (s < a.Length)
            {
                foreach (var item in a)
                {
                    p += item;
                }

                p -= s;
            }

            Console.WriteLine("RESULT = " + p);
        }
    }
}