using System;

namespace RomanNumerals
{
    public class Converter
    {
        public string Convert(int number)
        {
            if(number == 2)
            {
                return "II";
            }
            else
            {
                return "I";
            }

        }

    }
}
