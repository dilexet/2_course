using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Laba_17.Gifts;

namespace Laba_17
{
    public class Gift
    {
        private ICollection<ITucker> _tuckers;

        private float Weight
        {
            get
            {
                float weight = 0.0f;
                foreach (var tucker in _tuckers)
                {
                    weight += tucker.Weight;
                }
                return weight;
            }
        }

        private double Cost
        {
            get
            {
                double cost = 0.0;
                foreach (var tucker in _tuckers)
                {
                    cost += tucker.Price * (tucker.Weight / 1000);
                }
                return cost;
            }
        }
        public Gift(ref ICollection<ITucker> tuckers)
        {
            _tuckers = tuckers;
            CheckFruit();
            while (Weight >= 1000.0)
            {
                RemoveHeavySweets();
            }
            SortedByCalorie();
        }

        public IEnumerator<ITucker> GetEnumerator()
        {
            return _tuckers.GetEnumerator();
        }

        private void SortedByCalorie()
        {
            var items = _tuckers.OrderBy(item => item.Calorie);
            _tuckers = items.ToList();
        }
        private void RemoveHeavySweets()
        {
            if (Weight >= 1000)
            {
                float max = 0.0f;
                foreach (var trucker in _tuckers)
                {
                    if (trucker as Sweets != null && trucker.Weight > max)
                        max = trucker.Weight;
                }

                var items = _tuckers.Where(item => item as Sweets != null && item.Weight >= max);
                _tuckers.Remove(items.First());

            }
        }
        private void CheckFruit()
        {

            foreach (var tucker in _tuckers)
                if (tucker as Fruit != null)
                    return;

            _tuckers.Add(new Fruit("Груша", 200, 35, 300, true, true));
            _tuckers.Add(new Fruit("Апельсин", 250, 30, 350, false, true));
        }
        
        public static ICollection<ITucker> ReadFile(StreamReader streamReader)
        {
            string line;
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

        public void WriteFile(StreamWriter streamWriter)
        {
            foreach (var tucker in _tuckers)
            {
                streamWriter.WriteLine(tucker.GetTucker());
            }
            streamWriter.WriteLine($"\nWeight gift: {Weight}\n" +
                                   $"Cost gift: {Cost}\n");
        }
    }
}