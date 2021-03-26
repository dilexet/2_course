using System;

namespace task_5
{
    static class Program
    {
        static void Main()
        {
            decimal[] massY =
            {
                (decimal) 0.26183, (decimal) 0.27644, (decimal) 0.29122, (decimal) 0.30617, (decimal) 0.32130,
                (decimal) 0.33660, (decimal) 0.35207, (decimal) 0.36773, (decimal) 0.38537, (decimal) 0.39959
            };

            decimal[] dy = Test.Newton1(massY, 9);

            Console.WriteLine("\nПо первой формуле:");
            Console.WriteLine($"x = 0.156; y = {Test.Pn1(dy, (decimal) 0.156, (decimal) 0.01, (decimal) 0.26183, (decimal) 0.05):0.#####}");
            Console.WriteLine($"x = 0.026; y = {Test.Pn1(dy, (decimal) 0.026, (decimal) 0.01, (decimal) 0.26183, (decimal) 0.05):0.#####}");
            Console.WriteLine($"x = 0.1563; y = {Test.Pn1(dy, (decimal) 0.1563, (decimal) 0.01, (decimal) 0.26183, (decimal) 0.05):0.#####}");
            
            Console.WriteLine("\nПo второй формуле:");
            Console.WriteLine($"x = 0.156; y = {Test.Pn2(dy, (decimal) 0.3627, (decimal) 0.46, (decimal) 0.39959, (decimal) 0.05):0.#####}");
            Console.WriteLine($"x = 0.026; y = {Test.Pn2(dy, (decimal) 0.4058, (decimal) 0.46, (decimal) 0.39959, (decimal) 0.05):0.#####}");
            Console.WriteLine($"x = 0.1563; y = {Test.Pn2(dy, (decimal) 0.377, (decimal) 0.46, (decimal) 0.39959, (decimal) 0.05):0.#####}");
            
            
        }
    }
}