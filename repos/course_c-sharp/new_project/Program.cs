using System;


namespace new_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // конвертация строки, class Convert
            /*
            string data;
            data = Console.ReadLine(); // считывает данные в строку (всегда только в строку)
            int a = Convert.ToInt32(data); // конвертирует строку в int
            Console.WriteLine(a); // вывод числа
            
            string str = "1.9";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            }; // указываем какой символ-разделитель будет использоваться для конвертации дробных чисел

            double a = Convert.ToDouble(str, numberFormatInfo);
            */
            // конвертация строки, parse и tryparse
            /*
            string str2 = "5.9";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            }; // указываем какой символ-разделитель будет использоваться для конвертации дробных чисел

            double a = double.Parse(str2, numberFormatInfo);
            

            string str3 = "mmf";
            int a3;
            bool result = int.TryParse(str3, out a3); // не бросает исключений
            if (result)
            {
                Console.WriteLine(a3);
            }
            else
            {
                Console.WriteLine("Error");
            }
            */
            // switch, пример работы с обработкой нажатия клавиш 
            /*
            ConsoleKey consoleKey = Console.ReadKey().Key;
            switch (consoleKey)
            {
                case ConsoleKey.Backspace:
                    Console.WriteLine("Вы нажали backspace");
                    break;
                case ConsoleKey.Tab:
                    Console.WriteLine("Вы нажали tab");
                    break;
                case ConsoleKey.Spacebar:
                    Console.WriteLine("Вы нажали spacebar");
                    break;
                default:
                    break;
            }
            */
            // очистка консоли - Console.Clear()
            // задать цвет - Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
