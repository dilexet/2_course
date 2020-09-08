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

        static void num_1_laba2()
        {
            Console.Write("a = ");
            double.TryParse(Console.ReadLine(), out double a);
            Console.Write("b = ");
            double.TryParse(Console.ReadLine(), out double b);
            double z1, z2;
            z1 = Math.Pow(Math.Cos(a) - Math.Cos(b), 2) - Math.Pow(Math.Sin(a) - Math.Sin(b), 2);
            z2 = -4 * Math.Pow(Math.Sin((a - b) / 2), 2) * Math.Cos(a + b);
            Console.WriteLine("\nz1 = {0}\nz2 = {1}", z1, z2);
        }
        static void num_2_laba2()
        {
            Console.Write("x = ");
            double.TryParse(Console.ReadLine(), out double x);
            Console.Write("R = ");
            double.TryParse(Console.ReadLine(), out double R);
            double y;
            if (x <= -R)
                y = 0.25 * x + R / 4;
            else if (x > -R && x <= 0)
                y = R - Math.Sqrt(-2 * R * x - Math.Pow(x, 2));
            else if (x > 0 && x <= R)
                y = Math.Sqrt(Math.Pow(R, 2) - Math.Pow(x, 2));
            else
                y = R - x;
            Console.WriteLine("y = ", y);
        }
        static void num_3_laba2()
        {
            Console.Write("x = ");
            double.TryParse(Console.ReadLine(), out double x);
            Console.Write("y = ");
            double.TryParse(Console.ReadLine(), out double y);
            if (x == y || (y == -23 && x > -23))
                Console.WriteLine("На границе");
            else if (x > y)
                Console.WriteLine("Внутри");
            else
                Console.WriteLine("Снаружи");
        }
        static void num_4_laba2()
        {
            Console.WriteLine("Выберите фигуру:\n1) Круг;\n2) Прямоугольник;\n3) Треугольник.");

            ConsoleKey consoleKey = Console.ReadKey().Key;
            Console.WriteLine();
            switch (consoleKey)
            {
                case ConsoleKey.D1:
                    {
                        Console.Write("R = ");
                        double.TryParse(Console.ReadLine(), out double r);
                        r = Math.Abs(r);
                        double S = Math.PI * Math.Pow(r, 2);
                        double P = 2 * Math.PI * r;
                        Console.Clear();
                        Console.WriteLine("S = {0}\nP = {1}", S, P);
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        Console.Write("a = ");
                        double.TryParse(Console.ReadLine(), out double a);
                        Console.Write("b = ");
                        double.TryParse(Console.ReadLine(), out double b);
                        a = Math.Abs(a);
                        b = Math.Abs(b);
                        double S = a * b;
                        double P = 2 * (a + b);
                        Console.Clear();
                        Console.WriteLine("S = {0}\nP = {1}", S, P);
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        Console.Write("a = ");
                        double.TryParse(Console.ReadLine(), out double a);
                        Console.Write("b = ");
                        double.TryParse(Console.ReadLine(), out double b);
                        Console.Write("с = ");
                        double.TryParse(Console.ReadLine(), out double c);
                        a = Math.Abs(a);
                        b = Math.Abs(b);
                        c = Math.Abs(c);
                        if (a + b > c && b + c > a && a + c > b)
                        {
                            double P = a + b + c;
                            double p = P / 2;
                            double S = Math.Sqrt(P * (p - a) * (p - b) * (p - c));
                            Console.Clear();
                            Console.WriteLine("S = {0}\nP = {1}", S, P);
                        }
                        else
                            Console.WriteLine("Треугольник не существует");
                        break;
                    }
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
