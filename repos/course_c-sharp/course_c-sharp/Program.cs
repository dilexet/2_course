using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace course_c_sharp
{
    class Program
    {
        static void RandMass(int[] mass)
        {
            Random random = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(100);
            }
        }
        static void PrintMass<T>(T[] mass)
        {
            foreach (var item in mass)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

       

       
        static void Main(string[] args)
        {
            long value = 123456;
            Console.WriteLine((int)((value / Math.Pow(10, 6 - 4)) % 10));
            
        }
    }
}






 
































































