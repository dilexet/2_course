using System;

namespace task_3
{
    public class NewtonMethod
    {
        /// <summary>
        /// a c
        /// b d
        /// </summary>
        /// <returns></returns>
        private static double Determinant(double a, double c, double b, double d)
        {
            return a * d - b * c;
        }

        #region F(x)
        
        private double F(double x, double y)
        {
            return Math.Sin(x + 2) - y - 1.5;
        }
        
        private double Dfx(double x, double y)
        {
            return Math.Cos(x + 2);
        }

        private double Dfy(double x, double y)
        {
            return -1;
        }
        
        #endregion

        #region G(x)
        
        private double G(double x, double y)
        {
            return x + Math.Cos(y - 2) - 0.5;
        }
        
        private double Dgx(double x, double y)
        {
            return 1;
        }
        private double Dgy(double x, double y)
        {
            return -Math.Sin(y - 2);
        }
        
        #endregion
        
        
        public void Start(double x0, double y0, double epsilon)
        {
            double x = x0;
            double y = y0;
            int iteration = 0;
            while (Math.Abs(F(x, y)) > epsilon || Math.Abs(G(x, y)) > epsilon)  
            {
                double a = Determinant(F(x0, y0), Dfy(x0, y0), G(x0, y0), Dgy(x0, y0));
                double b = Determinant(Dfx(x0, y0), F(x0, y0), Dgx(x0, y0), G(x0, y0));
                double j = Determinant(Dfx(x0, y0), Dfy(x0, y0), Dgx(x0, y0), Dgy(x0, y0));
                x = x0 - a / j;
                y = y0 - b / j;
                x0 = x;
                y0 = y;
                iteration++;
            }
            
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"F(x,y) = {F(x,y):0.#########}");
            Console.WriteLine($"G(x,y) = {G(x,y):0.#########}");
            Console.WriteLine($"Iteration = {iteration}");
        }
    }

}