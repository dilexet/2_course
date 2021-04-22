using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba_3
{
    static class Program
    {
        private static int _curValue = 0;
        
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

        private static bool Check(int requiredAmountBanknotes, int[] availableBanknotes, int maximumBanknote)
        {
            int newMaximumBanknote = availableBanknotes.ToList().LastOrDefault(x => x < maximumBanknote);

            int item = requiredAmountBanknotes / maximumBanknote;
            if (item == 0)
            {
                if (newMaximumBanknote == 0)
                {
                    var newArr = availableBanknotes.ToList().Where(x => x < availableBanknotes[availableBanknotes.Length - 1]).ToArray();
                    if (newArr.Length > 0)
                    {
                        return Check(_curValue, newArr, newArr[newArr.Length - 1]);
                    }

                    return false;
                }

                return Check(requiredAmountBanknotes, availableBanknotes, newMaximumBanknote);
            }

            int newValue;
            int count = availableBanknotes.Count(x => x == maximumBanknote);
            if (item >= count)
            {
                newValue = requiredAmountBanknotes - maximumBanknote * count;
            }
            else
            {
                newValue = requiredAmountBanknotes - maximumBanknote * item;
            }

            if (newValue == 0)
            {
                return true;
            }

            if (newMaximumBanknote == 0)
            {
                return false;
            }
            return Check(newValue, availableBanknotes, newMaximumBanknote);
        }

        public static void Main()
        {
            var a = GetA();
            var b = GetB();
            var c = GetC(a, b);
            int p = a.ToList().Sum();
            int i = 1;
            while (i <= p)
            {
                if (!Check(i, c, c[c.Length - 1]))
                {
                    Console.WriteLine("Buyer's banknotes amount - " + a.ToList().Sum());
                    Console.WriteLine("We can't give change at a price of - " + (p - i));
                    break;
                }
                i++;
            }
        }
    }
}