using System;
using System.Text;

namespace RomanNumeralConverter.Library
{
    public class RomanNumeralConverter
    {

        public static int[] Values = {50 ,10, 9, 5, 4, 1 };
        public static string[] Symbols = {"L","X", "IX", "V", "IV", "I"};

        public string Convert(int number)
        {
            StringBuilder sb = new StringBuilder();

            int remaining = number;

            for (int i = 0; i < Values.Length; i++)
            {
                remaining = ConvertToRoman(sb, remaining, Values[i], Symbols[i]);
            }

            return sb.ToString();

        }

        private static int ConvertToRoman(StringBuilder sb, int remaining, int value, string roman )
        {
            while (remaining >= value)
            {
                sb.Append(roman);
                remaining -= value;
            }

            return remaining;
        }
    }
}
