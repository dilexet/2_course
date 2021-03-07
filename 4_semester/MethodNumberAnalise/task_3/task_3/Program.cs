using System;

namespace task_3
{
    internal static class Program
    {
       
        public static void Main()
        {
            Console.WriteLine("\nSimple iterations method:\n");
             new SimpleIterationsMethod().Start(0, 0, 0.0001);
            
            Console.WriteLine("\nNewton method:\n");
            new NewtonMethod().Start(0.1, 0.1, 0.0001);

           
        }
    }
}