using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_library;

namespace Student_projects
{
    enum CardType
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

        public static bool CardCheck(long card_number)
        {
            int degits_count = GetDigitsCount(card_number);
            int sum = 0;
            if (degits_count % 2 != 0) 
                for (int i = 0; i < degits_count; i++)
                {
                    int current_digit = GetDigit(card_number, i);
                    if ((i + 1) % 2 == 0)
                        current_digit *= 2;
                    if (current_digit > 9)
                        current_digit = current_digit / 10 + current_digit % 10;
                    sum += current_digit;
                }
            else
                for (int i = 0; i < degits_count; i++)
                {
                    int current_digit = GetDigit(card_number, i);
                    if (i % 2 == 0)
                        current_digit *= 2;
                    if (current_digit > 9)
                        current_digit = current_digit / 10 + current_digit % 10;
                    sum += current_digit;
                }
            if (sum == 0)
                return false;
        
            return sum % 10 == 0;
        }
       
    }
    class Cards
    {
        public static string GetCardType(long card_number, New_Cards[] cards)
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
    struct New_Cards
    {
        public string cardtype;
        public int digit1;
        public int digit2;
        public uint digitsCount;
    }
    

class Program
    {
        static New_Cards[] push_back()
        {
            New_Cards[] temp_cards = new New_Cards[1];

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
            return temp_cards;
        }
        static void push(ref New_Cards[] cards, New_Cards[] temp_cards)
        {
            if (cards == null)
            {
                cards = new New_Cards[1];
                cards = temp_cards;
            } 
            else
            {
                New_Cards[] zadolbalca_cards = new New_Cards[cards.Length + 1];
                zadolbalca_cards[cards.Length] = temp_cards[0];
                for (int i = 0; i < cards.Length; i++)
                {
                    zadolbalca_cards[i] = cards[i];
                }
                cards = zadolbalca_cards;
            }
        }
        static void Print(New_Cards[] cards)
        {
            foreach (var item in cards)
            {
                Console.WriteLine("Название: {0}\nРазмер: {1}\nПервая цифра: {2}\nВторая цифра: {3}", item.cardtype, item.digitsCount, item.digit1, item.digit2);
            }
        }

        static void Main(string[] args)
        {
            New_Cards[] cards = null;
            ConsoleKey consoleKey;
            do
            {
                Console.WriteLine("Выберите операцию:\n\n0. Выход;\n1. Работа с существующей карточкой;\n2. Создать новую карточку;\n");
                consoleKey = Console.ReadKey().Key;
                Console.Clear();
                switch (consoleKey)
                {
                    case ConsoleKey.D0:
                        break;
                    case ConsoleKey.D1:
                        Console.Write("Введите номер карточки:\t");
                        long.TryParse(Console.ReadLine(), out long number_cards);

                        string cardType = Cards.GetCardType(number_cards, cards);

                        Console.WriteLine("card_type -- " + cardType);

                        Console.WriteLine("Прошла ли карта идентификацию: " + (Invalid.CardCheck(number_cards) ? "YES" : "NO"));
                        break;
                    case ConsoleKey.D2:
                        push(ref cards, push_back());
                        break;
                    default:
                        Console.WriteLine("Операция выбрана не верно");
                        break;
                }
                Console.WriteLine("\n");
            } while (consoleKey != ConsoleKey.D0);
            
        }
    }
}
