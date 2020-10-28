using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    public struct NewCard
    {
        public string cardtype;
        public int digit1;
        public int digit2;
        public uint digitsCount;
    }

    class AddNewCards
    {
        /// <summary>
        /// Запись массива в файл
        /// </summary>
        /// <param name="temp_cards"></param>
        private static void InputFile(NewCard[] temp_cards)
        {
            string path = @"C:\Users\Nikto\source\repos\Student_projects\Student_projects\number_cards.txt";
            string data = temp_cards[0].cardtype + " " + Convert.ToString(temp_cards[0].digitsCount) + " " + Convert.ToString(temp_cards[0].digit1) + " " + Convert.ToString(temp_cards[0].digit2);
            using (FileStream file = new FileStream(path, FileMode.Append))
            {
                using (StreamWriter write = new StreamWriter(file))
                {
                    write.WriteLine(data);
                }

            }
        }
        /// <summary>
        /// Возвращает массив с новой картой
        /// </summary>
        /// <returns></returns>
        public static void CreationNewCard(string cardtype, string digit, uint digitsCount)
        {
            NewCard[] temp_cards = new NewCard[1];
            temp_cards[0].cardtype = cardtype;
            temp_cards[0].digitsCount = digitsCount;
            if (digit.Length == 1)
            {
                int.TryParse(digit, out temp_cards[0].digit1);
                temp_cards[0].digit2 = -1;
            }
            else
            {
                int.TryParse(Convert.ToString(digit[0]), out temp_cards[0].digit1);
                int.TryParse(Convert.ToString(digit[1]), out temp_cards[0].digit2);
            }
            InputFile(temp_cards);
        }
       
       

        /// <summary>
        /// Чтени из файла и запись в массив
        /// </summary>
        /// <param name="cards"></param>
        public static void Output(ref NewCard[] cards)
        {
            string path = @"C:\Users\Nikto\source\repos\Student_projects\Student_projects\number_cards.txt";
            string[] arr_data = File.ReadAllLines(path);
            foreach (string data in arr_data)
            {
                AddingNewCard(ref cards, data);
            }
        }
        /// <summary>
        /// Добавление карточки в массив из строки
        /// </summary>
        /// <param name="cards"></param>
        /// <param name="data"></param>
        private static void AddingNewCard(ref NewCard[] cards, string data)
        {
            string[] arr_data = data.Split(' ');
            if (cards == null)
            {
                cards = new NewCard[1];
                cards[0].cardtype = arr_data[0];
                cards[0].digitsCount = uint.Parse(arr_data[1]);
                cards[0].digit1 = int.Parse(arr_data[2]);
                cards[0].digit2 = int.Parse(arr_data[3]);

            }
            else
            {
                NewCard[] zadolbalca_cards = new NewCard[cards.Length + 1];
                zadolbalca_cards[cards.Length].cardtype = arr_data[0];
                zadolbalca_cards[cards.Length].digitsCount = uint.Parse(arr_data[1]);
                zadolbalca_cards[cards.Length].digit1 = int.Parse(arr_data[2]);
                zadolbalca_cards[cards.Length].digit2 = int.Parse(arr_data[3]);
                for (int i = 0; i < cards.Length; i++)
                {
                    zadolbalca_cards[i] = cards[i];
                }
                cards = zadolbalca_cards;
            }
        }


    }
}
