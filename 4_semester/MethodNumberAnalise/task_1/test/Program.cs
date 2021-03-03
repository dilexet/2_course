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

            // Console.WriteLine($"F(x):{F(x)}, G(x):{G(x)}");
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

            // Console.WriteLine($"F(x):{F(x)}, G(x):{G(x)}");
        }
    }

    static class Program
    {
        private const double Epsilon = 0.00001;

        private static void Main()
        {
            double begin = 1;
            double end = 1.3;

            Console.WriteLine("\n1 - Метод деления пополам.\n");
            new HalfMethod().Start(begin, end, Epsilon);

            Console.WriteLine("\n2 - Метод итераций.\n");
            new SimpleIterationsMethod().Start(begin, Epsilon);

            Console.WriteLine("\n3 - Метод Ньютона.\n");
            new NewtonMethod().Start(begin, Epsilon);
        }
    }
}