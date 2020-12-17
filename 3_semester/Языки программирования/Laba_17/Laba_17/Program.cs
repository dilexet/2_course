using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Laba_17.Gifts;

namespace Laba_17
{
    internal class Program
    {
        private static ICollection<ITucker> ReadFile(StreamReader streamReader)
        {
            string line = "";
            ICollection<ITucker> tuckers = new List<ITucker>();
            while ((line = streamReader.ReadLine()) != null)
            {
                if (!string.IsNullOrEmpty(line)) 
                    SplitLine(line, tuckers);
            }

            return tuckers;
        }

        private static void SplitLine(string line, ICollection<ITucker> tuckers)
        {
            string[] words = Regex.Split(line, @"[^а-яА-яa-zA-z0-9]");
            if (words[0] == "Фрукт")
                tuckers.Add(AddFruit(words));
            else if (words[0] == "Конфета")
                tuckers.Add(AddSweets(words));
            else if (words[0] == "Вафля")
                tuckers.Add(AddWafles(words));
            else
            {
                Console.WriteLine("Ошибка: Ты облажался...)");
                throw new NotImplementedException();
            }
        }

        private static Waffles AddWafles(string[] words)
        {
            return new Waffles(
                words[1], 
                float.Parse(words[2]), 
                float.Parse(words[3]), 
                double.Parse(words[4]), 
                words[5],
                bool.Parse(words[6]));
        }

        private static Sweets AddSweets(string[] words)
        {
            return new Sweets(
                words[1], 
                float.Parse(words[2]), 
                float.Parse(words[3]), 
                double.Parse(words[4]), 
                float.Parse(words[5]),
                words[6]);
        }

        private static Fruit AddFruit(string[] words)
        {
            return new Fruit(
                words[1], 
                float.Parse(words[2]), 
                float.Parse(words[3]), 
                double.Parse(words[4]), 
                bool.Parse(words[5]),
                bool.Parse(words[6]));
        }

        public static void Main(string[] args)
        {
            Gift gift;
            
            using (StreamReader streamReader = new StreamReader(
                    @"C:\Users\dilexet\Documents\GitHub\2_course\3_semester\Языки программирования\Laba_17\Laba_17\bin\Debug\input.txt"))
            {
                ICollection<ITucker> tuckers = ReadFile(streamReader);
                gift = new Gift(ref tuckers);
            }
            
            using (StreamWriter streamWriter = new StreamWriter(
                    @"C:\Users\dilexet\Documents\GitHub\2_course\3_semester\Языки программирования\Laba_17\Laba_17\bin\Debug\output.txt", 
                    false))
            {
                gift.WriteFile(streamWriter);
            }
        }
    }
}