using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Student_library;

namespace Student_projects
{
    
    class Program
    {
        static void number_one()
        {
            Console.Write("Введите строку: ");
            StringBuilder s = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Исходная строка:");
            Console.WriteLine(s);
            Console.Write("Введите substr1: ");
            String substr1 = Console.ReadLine();
            Console.Write("Введите substr2: ");
            String substr2 = Console.ReadLine();
            s.Replace(substr1, substr2);
            Console.WriteLine("Полученнаяя строка:");
            Console.WriteLine(s);
        }

        static void number_two()
        {
            Console.Write("Введите текст: ");
            String text = Console.ReadLine();
            const char space = ' ';
            const char dot = '.';
            const char comma = ',';
            char[] delimeters = { space, dot, comma };
            String[] subText = text.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            int max_char = 0;
            foreach (var item in subText)
            {
                if (item.Length > max_char)
                {
                    max_char = item.Length;
                }
            }
            Console.WriteLine("\nСамые длинные слова в сообщении: ");
            foreach (var item in subText)
            {
                if (item.Length == max_char)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static int number_three_GetAlphabetIndex(char letter)
        {
            const string alphabet = @"АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя";
            return alphabet.IndexOf(letter) / 2 + 1;
        }
        static int number_three_GetDigitsCount(int value)
        {
            return (int)Math.Log10(value) + 1;
        }
        static int number_three_GetDigit(int value, int index)
        {
            return (int)(value / Math.Pow(10, number_three_GetDigitsCount(value) - 1 - index) % 10);
        }
        static int number_three_GetSum(ref int sum)
        {
            while (number_three_GetDigitsCount(sum) > 1)
            {
                int new_sum = 0;
                for (int i = 0; i < number_three_GetDigitsCount(sum); i++)
                {
                    new_sum += number_three_GetDigit(sum, i);
                }
                sum = new_sum;
            }
            return sum;
        }
        static void number_three()
        {
            Console.Write("Введите имя: ");
            String Name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            String Surname = Console.ReadLine();
            Console.Write("Введите отчество: ");
            String Lastname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Исходные данные: {0} {2} {1}\n", Name, Surname, Lastname);
            String FIO = Name + Surname + Lastname;
            int sum = 0;
            foreach (var item in FIO)
            {
                sum += number_three_GetAlphabetIndex(item);
            }
            number_three_GetSum(ref sum);
            Console.WriteLine(sum);
        }

        static char number_four_GetAlphabetSymbol(int number)
        {
            const string alphabet = @"абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            if (number > 33)
                number -= 33;

            return alphabet[number - 1];
        }
        static void number_four()
        {
            Console.Write("Введите текст: ");
            String text = Console.ReadLine();
            Console.Write("Укажите сдвиг: ");
            int.TryParse(Console.ReadLine(), out int k);
            String new_text = "";
            int index = 0;
            foreach (var item in text)
            {
                if (item == ' ' || item == ',' || item == '.')
                {
                    new_text += item;
                    continue;
                }
                index = 0;
                index = number_three_GetAlphabetIndex(item) + k;
                new_text += number_four_GetAlphabetSymbol(index);
            }
            Console.WriteLine("\nПолученное сообщение: " + new_text);
        }
        static void Main(string[] args)
        {
            number_four();
        }
    }
}