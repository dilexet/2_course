using System;

namespace task_3
{
    public class SimpleIterationsMethod
    {
        private double Fi_1(double y)
        {
            var x = 0.5 - Math.Cos(y - 2);
            return x;
        }

        private double Fi_2(double x)
        {
            var y = Math.Sin(x + 2) - 1.5;
            return y;
        }

        private void F(double x, double y)
        {
            var f1 = Math.Sin(x + 2) - y - 1.5;
            var f2 = x + Math.Cos(y - 2) - 0.5;
            Console.WriteLine($"F1 (x,y) = {f1}");
            Console.WriteLine($"F2 (x,y) = {f2}");
        }
        
        public void Start(double x0, double y0, double epsilon)
        {
            double x;
            double y;
            int iteration = 0;
            do
            {
                
                x = Fi_1(y0);
                y = Fi_2(x0);
                x0 = x;
                y0 = y;
                iteration++;
            } while (Math.Abs(Fi_1(y) - x) > epsilon || Math.Abs(Fi_2(x) - y) > epsilon);
            
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"Iteration = {iteration}");
            Console.WriteLine($"Fi_1 = {Fi_1(y)}");
            Console.WriteLine($"Fi_2 = {Fi_2(x)}");
            F(x, y);
        }
    }
}