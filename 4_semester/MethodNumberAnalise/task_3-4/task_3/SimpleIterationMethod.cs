using System;

namespace task_3
{
    public class SimpleIterationsMethod
    {
        // F(x,y) = sin(x+y) - 1.2*x - 0.1 = 0 
        // Dx = cos(x+y) - 1.2
        // Dy = cos(x+y)
        // G(x,y) = x^2 + y^2 = 1
        // Dx = 2x
        // Dy = 2y

        private double L11 = 5 / 6.0;
        private double L12 = -5 / 6.0 * Math.Cos(1);
        private double L21 = -5 / 6.0;
        private double L22 = -1 + 5 / 6.0 * Math.Cos(1);

        private double F(double x, double y)
        {
            return Math.Sin(x + y) - 1.2 * x - 0.1;
        }

        private double Dfx(double x, double y)
        {
            return Math.Cos(x + y) - 1.2;
        }
        
        private double Dfy(double x, double y)
        {
            return Math.Cos(x + y);
        }
        
        private double G(double x, double y)
        {
            return Math.Pow(x, 2) + Math.Pow(y, 2) - 1;
        }
        
        private double Dgx(double x, double y)
        {
            return 2 * x;
        }
        
        private double Dgy(double x, double y)
        {
            return 2 * y;
        }
        
        
        
        private double Fi_1(double x, double y)
        {
            return x + L11 * F(x, y) + L12 * G(x, y);
        }

        private double Fi_2(double x, double y)
        {
            return y + L21 * F(x, y) + L22 * F(x, y);
        }

        
        private void Lambda(double x, double y)
        {
            var f = Math.Sin(x + y) - 1.2 * x - 0.1;
            var g = Math.Pow(x, 2) + Math.Pow(y, 2) - 1;
            Console.WriteLine($"F (x,y) = {f:0.#####}");
            Console.WriteLine($"G (x,y) = {g:0.#####}");
        }
        
        public void Start(double x0, double y0, double epsilon)
        {
            double x;
            double y;
            int iteration = 0;
            do
            {
                
                x = Fi_1(x0, y0);
                y = Fi_2(x0, y0);
                x0 = x;
                y0 = y;
                iteration++;
            } while (Math.Abs(Fi_1(x,y) - x) > epsilon || Math.Abs(Fi_2(x,y) - y) > epsilon);
            
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"F(x,y) = {F(x,y):0.#########}");
            Console.WriteLine($"G(x,y) = {G(x,y):0.#########}");
            Console.WriteLine($"Iteration = {iteration}");
        }
    }
}