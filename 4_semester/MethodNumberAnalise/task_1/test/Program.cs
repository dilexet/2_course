using System;

namespace test
{
    public class HalfMethod
    {
        private double F(double x)
        {
            return Math.Sin(x + 2) - Math.Pow(x, 2) + 2 * x - 1;
        }

        public void Start(double begin, double end, double epsilon)
        {
            int count = 0;
            double xn = 0.0;
            while ((end - begin) >= epsilon)

            {
                count++;

                xn = (begin + end) / 2;

                if (F(end) * F(xn) < 0)

                    begin = xn;

                else

                    end = xn;
            }

            Console.WriteLine($"X:{xn}, Iterations:{count}");
        }
    }

    public class NewtonMethod
    {
        private double F(double x)
        {
            return Math.Sin(x + 2) - Math.Pow(x, 2) + 2 * x - 1;
        }

        private double G(double x)
        {
            return x + 0.5 * F(x);
        }

        private double Df(double x)
        {
            return Math.Cos(x + 2) - 2 * x + 2;
        }

        private double Fx(double x)
        {
            return x - F(x) / Df(x);
        }

        public void Start(double x, double epsilon)
        {
            int count = 0;

            while (epsilon <= Math.Abs(F(x)))

            {
                count++;

                if (Df(x) == 0) break;

                x = Fx(x);
            }

            Console.WriteLine($"X:{x}, Iterations:{count}");

            Console.WriteLine($"F(x):{F(x)}, G(x):{G(x)}");
        }
    }

    public class SimpleIterationsMethod
    {
        private double F(double x)
        {
            return Math.Sin(x + 2) - Math.Pow(x, 2) + 2 * x - 1;
        }

        private double G(double x)
        {
            return x + 0.5 * F(x);
        }

        public void Start(double x, double epsilon)
        {
            int count = 0;

            while (epsilon <= Math.Abs(F(x)))

            {
                count++;

                x = G(x);
            }

            Console.WriteLine($"X:{x}, Iterations:{count}");

            Console.WriteLine($"F(x):{F(x)}, G(x):{G(x)}");
        }
    }

    static class Program
    {
        private const double Epsilon = 0.00001;

        private static void Main()
        {
            double begin = 1;
            double end = 1.3;


            Console.WriteLine("1 - Метод деления пополам.\n" +
                              "2 - Метод итераций.\n" +
                              "3 - Метод Ньютона.\n");
                              var value = Console.ReadKey(true).Key;

            switch (value)
            {
                case ConsoleKey.D1:
                    HalfMethod halfMethod = new HalfMethod();
                    halfMethod.Start(begin, end, Epsilon);
                    break;
                case ConsoleKey.D2:
                    SimpleIterationsMethod simpleIterationsMethod = new SimpleIterationsMethod();
                    simpleIterationsMethod.Start(1, Epsilon);
                    break;
                case ConsoleKey.D3:
                    NewtonMethod newtonMethod = new NewtonMethod();
                    newtonMethod.Start(1.2, Epsilon);
                    break;
                default:
                    Console.WriteLine("Некорректный ввод.");
                    break;
            }
        }
    }
}