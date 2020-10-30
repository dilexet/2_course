using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    
    class Invalid
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
}
