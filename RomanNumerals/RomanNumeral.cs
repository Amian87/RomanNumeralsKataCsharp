using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeral
    {

        static Dictionary<int, string> arabicToRoman = new Dictionary<int, string>
        {

            {9, "IX"}

        };



        //public string ConvertToRoman(int arabic)
        //{
        //    string roman = string.Empty;

        //    foreach (int value in arabicToRoman.Keys)
        //    {
        //        while (arabic >= value)
        //        {
        //            roman += arabicToRoman[value];
        //            arabic -= value;
        //        }
        //    }

        //    return roman;

        //}

        public string ConvertToRoman(int arabic)
        {
            string roman = string.Empty;

            foreach(int value in arabicToRoman.Keys)
            {
                while (arabic >= value)
                {
                    roman += arabicToRoman[value];
                    arabic -= value;
                }
            }

            return roman;
        }

        //public string ConvertToRoman(int arabic)
        //{

        //    string roman = string.Empty;

        //    StringBuilder sb = new StringBuilder();
        //    int remaining = arabic;

        //    if(remaining == 9)
        //    {
        //        sb.Append("IX");
        //        remaining -= 9;
        //    }

        //    if(remaining >= 5)
        //    {
        //        sb.Append("V");
        //        remaining -= 5;
        //    }

        //    if(remaining == 4)
        //    {
        //        sb.Append("IV");
        //        remaining -= 4;
        //    }
        //    for(int i = 0; i < remaining; i++)
        //    {
        //        sb.Append("I");
        //    }

        //    return sb.ToString();

        //}

    }
}
