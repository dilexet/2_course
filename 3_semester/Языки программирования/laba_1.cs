using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_library;

namespace Student_projects
{
    class Program
    {
        static void num_2()
        {
            Console.Write("a = ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("b = ");
            int.TryParse(Console.ReadLine(), out int b);
            Console.WriteLine("{0}+{1}={1}+{0}", a, b);
        }
        static void num_3()
        {
            Console.Write("a = ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("b = ");
            int.TryParse(Console.ReadLine(), out int b);
            Console.Write("c = ");
            int.TryParse(Console.ReadLine(), out int c);
            Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, a + b + c);
        }
        static void num_4()
        {
            Console.Write("a = ");
            double.TryParse(Console.ReadLine(), out double a);
            Console.Write("b = ");
            double.TryParse(Console.ReadLine(), out double b);
            Console.WriteLine("{0:0.0}*{1:0.0}={2:0.0}", Math.Round(a, 1, MidpointRounding.AwayFromZero), Math.Round(b, 1, MidpointRounding.AwayFromZero), Math.Round(a * b, 1, MidpointRounding.AwayFromZero));
        }
        static void num_5()
        {
            Console.Write("a = ");
            double.TryParse(Console.ReadLine(), out double a);
            Console.Write("b = ");
            double.TryParse(Console.ReadLine(), out double b);
            Console.WriteLine("{0:0.000}/{1:0.000}={2:0.000}", Math.Round(a, 3, MidpointRounding.AwayFromZero), Math.Round(b, 3, MidpointRounding.AwayFromZero), Math.Round(a / b, 3, MidpointRounding.AwayFromZero));
        }
        static void num_6()
        {
            Console.Write("a = ");
            double.TryParse(Console.ReadLine(), out double a);
            Console.Write("b = ");
            double.TryParse(Console.ReadLine(), out double b);
            Console.Write("c = ");
            double.TryParse(Console.ReadLine(), out double c);
            Console.WriteLine("({0:0.00}+{1:0.00})+{2:0.00}={0:0.00}+({1:0.00}+{2:0.00})", Math.Round(a, 2, MidpointRounding.AwayFromZero), Math.Round(b, 2, MidpointRounding.AwayFromZero), Math.Round(c, 2, MidpointRounding.AwayFromZero));
        }
        static void num_8()
        {
            Console.WriteLine("\t{0} -> {0:x}", 12);
            Console.WriteLine("\t{0} -> {0:x}", 256);
            Console.WriteLine("\t{0} -> {0:x}", 1001);
            Console.WriteLine("\t{0} -> {0:x}", 123456789);
        }
        static void num_9()
        {
            Console.WriteLine("Однажды в студеную зимнюю пору\nЯ из лесу вышел.\nБыл сильный мороз...\n\t\tА.С.Пушкин");
        }
        static void Main(string[] args)
        {
            int number = 0;
            do
            {
                Console.Write("Введите номер задания(0 - выход): ");
                int.TryParse(Console.ReadLine(), out number);
                Console.WriteLine();
                switch (number)
                {
                    case 0:
                        break;
                    case 2:
                        num_2();
                        break;
                    case 3:
                        num_3();
                        break;
                    case 4:
                        num_4();
                        break;
                    case 5:
                        num_5();
                        break;
                    case 6:
                        num_6();
                        break;
                    case 8:
                        num_8();
                        break;
                    case 9:
                        num_9();
                        break;
                    default:
                        Console.WriteLine("Неправильный ввод");
                        break;
                }
                Console.WriteLine();
            } while (number != 0);
            Console.ReadLine();
        }
    }
}
