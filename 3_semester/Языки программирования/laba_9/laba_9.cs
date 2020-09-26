using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Student_library;
using System.Text.RegularExpressions;
using System.Data.SqlTypes;
using System.Runtime.InteropServices.ComTypes;
using System.Globalization;
using System.Threading;
using System.Security.Policy;
using System.Collections;

namespace Student_projects
{
    class Text
    {
        public void ReadingText(List<String> list)
        {
            String path = @"C:\Users\Nikto\source\repos\Student_projects\Student_projects\text_analysis.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                        SplittingText(line, list);
                    SortText(list);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        private void WritingText(List<String> listWords, List<String> list)
        {
            string path = @"C:\Users\Nikto\source\repos\Student_projects\Student_projects\text_processed.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    const char dot = '.';
                    const int countDot = 50;
                    String letter = "";
                    foreach (var item in listWords)
                    {
                        if (letter.ToLower() != item[0].ToString())
                        {
                            letter = GetLetter(item);
                            sw.WriteLine(letter);
                        }
                        sw.Write(item);
                        for (int i = 0; i < countDot - item.Length; i++)
                            sw.Write(dot);
                        sw.Write(list.Where(x => x == item).Count());
                        sw.WriteLine(":");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void SplittingText(String line, List<String> list)
        {
            char[] separator = { ',', '.', ' ', '?', '!', ';' };
            list.AddRange(line.ToLower().Split(separator, StringSplitOptions.RemoveEmptyEntries));
        }
        private void SortText(List<String> list)
        {
            list.Sort();
            var listWords = list.Distinct().ToList();
            WritingText(listWords, list);
        }
        private String GetLetter(String item)
        {
            String letter = item[0].ToString().ToUpper();
            return letter;
        }
    }
    class Task_1
    {
        static public void num_1()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            Console.Write("Введите слово: ");
            string reg = Console.ReadLine();
            if (Regex.IsMatch(text, reg))
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
        static public void num_2()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            Console.Write("Введите длину: ");
            int.TryParse(Console.ReadLine(), out int size);
            char[] symbol = { ' ', ',', '.' };
            foreach (var item in text.Split(symbol, StringSplitOptions.RemoveEmptyEntries))
            {
                if (item.Length == size)
                    Console.WriteLine(item);
            }
        }
        static public void num_3()
        {
            Console.Write("Введите текст: ");
            StringBuilder text = new StringBuilder(Console.ReadLine());
            char[] symbol = { ' ', ',', '.' };
            foreach (var item in text.ToString().Split(symbol))
            {
                if (item.Length == 1)
                    text.Replace(item + " ", "");
            }
            Console.WriteLine(text);

        }
        static public void num_4()
        {
            Console.Write("Введите текст: ");
            StringBuilder text = new StringBuilder(Console.ReadLine());
            char[] filterArray = { 'а', 'A', 'у', 'У', 'о', 'О', 'ы', 'Ы', 'и', 'И', 'э', 'Э', 'я', 'Я', 'ю', 'ю', 'ё', 'Ё', 'е', 'Е' };
            char[] symbol = { ' ', ',', '.' };
            foreach (var item in text.ToString().Split(symbol, StringSplitOptions.RemoveEmptyEntries))
            {
                foreach (var val in filterArray)
                {
                    if (item[0] == val)
                        text.Replace(item, "");

                }
            }
            Console.WriteLine(text);
        }
        static public void num_5()
        {
            Console.Write("Введите текст: ");
            StringBuilder text = new StringBuilder(Console.ReadLine());
            string reg = @"[a-zA-Z]+";
            Console.WriteLine(Regex.Replace(text.ToString(), reg, ""));
        }
        static public void num_6()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-us");
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            var matches = Regex.Matches(text, @"[-+]?\d+(?:\.\d+)?(?:[eE][-+]?\d+)?");
            var sum = 0.0;
            foreach (Match item in matches)
            {
                sum += double.Parse(item.Value);
            }
            Console.WriteLine(sum);
        }
        static public void num_7()
        {
            string text = Console.ReadLine();
            string reg1 = @"\d\d\d-\d\d\d";
            string reg2 = @"\d\d-\d\d-\d\d";
            string reg3 = @"\d\d\d-\d\d-\d\d";
            char[] symbol = { ' ', ',', '.' };
            foreach (var item in text.Split(symbol))
            {
                if (Regex.IsMatch(item, reg1))
                    Console.WriteLine(item);
                else if (Regex.IsMatch(item, reg2))
                    Console.WriteLine(item);
                else if (Regex.IsMatch(item, reg3))
                    Console.WriteLine(item);
            }
        }
        static public void num_8()
        {
            string text = Console.ReadLine();
            string reg = "[0-3][0-9].[0-1][0-9].[1,2][9,0][0-9][0-9]";
            char[] symbol = { ' ', ',' };
            foreach (var item in text.Split(symbol))
            {
                if (Regex.IsMatch(item, reg))
                {
                    string[] value = item.Split('.');
                    if (Convert.ToInt32(value[0]) >= 1 && Convert.ToInt32(value[0]) <= 31)
                        if (Convert.ToInt32(value[1]) >= 1 && Convert.ToInt32(value[1]) <= 12)
                            if (Convert.ToInt32(value[2]) <= 2020 && Convert.ToInt32(value[2]) >= 1940)
                                Console.WriteLine(item);
                }

            }
        }
        static public void num_9()
        {
            string text = Console.ReadLine();
            string reg = @"((https?|ftp)\:\/\/)?([a-z0-9]{1})((\.[a-z0-9-])|([a-z0-9-]))*\.([a-z]{2,6})(\/?)";
            char[] symbol = { ' ', ',' };
            foreach (var item in text.Split(symbol))
            {
                if (Regex.IsMatch(item, reg))
                    Console.WriteLine(item);
            }

        }
        static public void num_10()
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());
            string reg = "[0-2][0-9]:[0-6][0-9]:[0-6][0-9]";
            char[] symbol = { ' ', ',' };
            foreach (var item in text.ToString().Split(symbol))
            {
                if (Regex.IsMatch(item, reg))
                {
                    string[] value = item.Split(':');
                    int hh = Convert.ToInt32(value[0]);
                    int mm = Convert.ToInt32(value[1]);
                    int ss = Convert.ToInt32(value[2]);
                    if (ss >= 30)
                        mm++;
                    if (mm > 60)
                        hh++;
                    if (hh >= 1 && hh <= 24)
                        if (mm >= 0 && mm <= 60)
                            if (ss >= 0 && ss <= 60)
                                if (!(hh == 24 && mm > 0 && ss > 0))
                                    text.Replace(item, Convert.ToString(hh + ":" + mm));
                }
            }
            Console.WriteLine(text);
        }
    }
    class Program
    {
        static void Task_2()
        {
            Text text = new Text();
            List<String> list = new List<string>();
            text.ReadingText(list);
        }
       
        static void Main(string[] args)
        {
            
        }
    }
}