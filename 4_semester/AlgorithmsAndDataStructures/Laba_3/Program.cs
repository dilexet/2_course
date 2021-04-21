using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba_3
{
    static class Program
    {
        private static int _curValue;
        
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
        
        private static int[] GetC(int[] a, int[] b)
        {
            List<int> c = new List<int>();
            c.AddRange(a);
            c.AddRange(b);
            return c.OrderBy(i => i).ToArray();
        }

        private static bool Check(int value, int[] array, int cur)
        {
            int nMax = array.ToList().LastOrDefault(x => x < cur);

            int item = value / cur;
            if (item == 0)
            {
                if (nMax == 0)
                {
                    var newArr = array.ToList().Where(x => x < array[array.Length - 1]).ToArray();
                    if (newArr.Length > 0)
                    {
                        return Check(_curValue, newArr, newArr[newArr.Length - 1]);
                    }

                    return false;
                }

                return Check(value, array, nMax);
            }

            int newValue;
            int count = array.Count(x => x == cur);
            if (item >= count)
            {
                newValue = value - cur * count;
            }
            else
            {
                newValue = value - cur * item;
            }

            if (newValue == 0) return true;
            if (nMax == 0) return false;
            return Check(newValue, array, nMax);
        }

        public static void Main()
        {
            var a = GetA();
            var b = GetB();
            var c = GetC(a, b);
            int p = a.ToList().Sum();
            while (p >= 0)
            {
                _curValue = p;
                if (!Check(p, c, c[c.Length - 1]))
                {
                    Console.WriteLine("Buyer's banknotes amount - " + a.ToList().Sum());
                    Console.WriteLine("We can't give change at a price of - " + p);
                    break;
                }
                p--;
            }
        }
    }
}