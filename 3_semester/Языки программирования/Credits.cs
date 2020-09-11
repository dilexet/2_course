using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Student_library;

namespace Student_projects
{
    enum CardsType
    {
        Invalid = 0,
        MasterCard,
        AmericanExpress,
        Visa
    }
    public class Invalid
    {
        /// <summary>
        /// Возвращает количество цифр в карточке
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int GetDigitsCount(long card_number)
        {
            return (int)Math.Log10(card_number) + 1;
        }
        /// <summary>
        /// Возвращает цифру по указаному индексу
        /// </summary>
        /// <param name="number"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int GetDigit(long card_number, int index)
        {
            return (int)(card_number / Math.Pow(10, GetDigitsCount(card_number) - 1 - index) % 10);
        }
        /// <summary>
        /// Проверка карты на валидность
        /// </summary>
        /// <param name="card_number"></param>
        /// <returns></returns>
        public static bool CardCheck(long card_number)
        {
            int degits_count = GetDigitsCount(card_number);
            int sum_of_digits = 0;
            if (degits_count % 2 != 0) 
                for (int i = 0; i < degits_count; i++)
                {
                    int current_digit = GetDigit(card_number, i);
                    if ((i + 1) % 2 == 0)
                        current_digit *= 2;
                    if (current_digit > 9)
                        current_digit = current_digit / 10 + current_digit % 10;
                    sum_of_digits += current_digit;
                }
            else
                for (int i = 0; i < degits_count; i++)
                {
                    int current_digit = GetDigit(card_number, i);
                    if (i % 2 == 0)
                        current_digit *= 2;
                    if (current_digit > 9)
                        current_digit = current_digit / 10 + current_digit % 10;
                    sum_of_digits += current_digit;
                }
            if (sum_of_digits == 0)
                return false;
        
            return sum_of_digits % 10 == 0;
        }
       
    }
    class CardType
    {
        /// <summary>
        /// Возвращает тип карточки
        /// </summary>
        /// <param name="card_number"></param>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static string GetCardType(long card_number, NewCard[] cards)
        {                
            int digitsCount = Invalid.GetDigitsCount(card_number);
            int digit1 = Invalid.GetDigit(card_number, 0);
            int digit2 = Invalid.GetDigit(card_number, 1);
            if (digitsCount == 16 && digit1 == 5 && (digit2 >= 1 && digit2 <= 5))
                return "MasterCard";
            if (digitsCount == 15 && digit1 == 3 && (digit2 == 4 || digit2 == 7))
                return "AmericanExpress";
            if ((digitsCount == 13 || digitsCount == 16) && digit1 == 4)
                return "Visa";
            if (cards != null)
                foreach (var item in cards)
                {
                    if (item.digit2 == -1)
                    {
                        if (item.digitsCount == digitsCount && item.digit1 == digit1)
                            return item.cardtype;
                    }
                    else
                    {
                        if (item.digitsCount == digitsCount && item.digit1 == digit1 && item.digit2 == digit2)
                            return item.cardtype;
                    } 
                   
                }
            return "Invalid";
        }
    }
    struct NewCard
    {
        public string cardtype;
        public int digit1;
        public int digit2;
        public uint digitsCount;
    }
    class Program
    {
        /// <summary>
        /// Возвращает массив с новой картой
        /// </summary>
        /// <returns></returns>
        static NewCard[] CreationNewCard()
        {
            NewCard[] temp_cards = new NewCard[1];

            Console.Write("Введит название карточки: ");
            temp_cards[0].cardtype = Console.ReadLine();

            Console.Write("Введите кол-во цифр в карте: ");
            uint.TryParse(Console.ReadLine(), out temp_cards[0].digitsCount);

            Console.Write("Введите первые две цифры карточки: ");
            string digit = Console.ReadLine();
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
            return temp_cards;
        }
        /// <summary>
        /// Запись массива в файл
        /// </summary>
        /// <param name="temp_cards"></param>
        static void InputFile(NewCard[] temp_cards)
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
        /// Чтени из файла и запись в массив
        /// </summary>
        /// <param name="cards"></param>
        static void Output(ref NewCard[] cards)
        {
            string path = @"C:\Users\Nikto\source\repos\Student_projects\Student_projects\number_cards.txt";
            string[] arr_data = File.ReadAllLines(path);
            foreach (string data in arr_data)
            {
                AddingNewCard(ref cards, data);
            }
        }
        /// <summary>
        /// Добавление новой карточки в массив
        /// </summary>
        /// <param name="cards"></param>
        /// <param name="temp_cards"></param>
        static void AddingNewCard(ref NewCard[] cards, NewCard[] temp_cards)
        {
            if (cards == null)
            {
                cards = new NewCard[1];
                cards = temp_cards;
            } 
            else
            {
                NewCard[] zadolbalca_cards = new NewCard[cards.Length + 1];
                zadolbalca_cards[cards.Length] = temp_cards[0];
                for (int i = 0; i < cards.Length; i++)
                {
                    zadolbalca_cards[i] = cards[i];
                }
                cards = zadolbalca_cards;
            }
        }
        /// <summary>
        /// Добавление карточки в массив из строки
        /// </summary>
        /// <param name="cards"></param>
        /// <param name="data"></param>
        static void AddingNewCard(ref NewCard[] cards, string data)
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


        static void Main(string[] args)
        {
            NewCard[] cards = null;
            ConsoleKey consoleKey;
            do
            {
                Console.WriteLine("Выберите операцию:\n\n0. Выход;\n1. Работа с существующей карточкой;\n2. Создать новую карточку;\n3. Взять данные карты из файла\n");
                consoleKey = Console.ReadKey().Key;
                Console.Clear();
                switch (consoleKey)
                {
                    case ConsoleKey.D0:
                        break;
                    case ConsoleKey.D1:
                        Console.Write("Введите номер карточки:\t");
                        long.TryParse(Console.ReadLine(), out long number_cards);

                        string cardType = CardType.GetCardType(number_cards, cards);

                        Console.WriteLine("card_type -- " + cardType);

                        Console.WriteLine("Прошла ли карта идентификацию: " + (Invalid.CardCheck(number_cards) ? "YES" : "NO"));
                        break;
                    case ConsoleKey.D2:
                        AddingNewCard(ref cards, CreationNewCard());
                        break;
                    case ConsoleKey.D3:
                        Output(ref cards);
                        break;
                    default:
                        Console.WriteLine("Операция выбрана не верно");
                        break;
                }
                Console.WriteLine("\n");
            } while (consoleKey != ConsoleKey.D0);
            

        }


        /// <summary>
        /// Вывод массива с новыми карточками(используется для тестов)
        /// </summary>
        /// <param name="cards"></param>
        static void Print(NewCard[] cards)
        {
            foreach (var item in cards)
            {
                Console.WriteLine("Название: {0}\nРазмер: {1}\nПервая цифра: {2}\nВторая цифра: {3}", item.cardtype, item.digitsCount, item.digit1, item.digit2);
            }
        }
    }
}
