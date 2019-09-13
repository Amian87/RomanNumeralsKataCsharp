using System;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeral
    {
        public static int[] values = { 10, 9, 5, 4 };
        public static String[] symbols = { "X", "IX", "V", "IV" }; 

        public string ConvertToRoman(int arabic)
        {
            StringBuilder sb = new StringBuilder();

            int remaining = arabic;

            for(int i = 0; i < values.Length; i++)
            {
                remaining = convert(remaining, values[i], symbols[i], sb);
            }

            for (int i = 0; i < remaining; values - i++)
            {
                sb.Append("I");
            }

            return sb.ToString();

        }

        private static int convert(int remaining, int value, string roman, StringBuilder sb)
        {
            if (remaining >= value)
            {
                sb.Append(roman);
                remaining -= value;
            }

            return remaining;
        }
    }
}
