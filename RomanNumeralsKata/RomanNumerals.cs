using System;
using System.Text;

namespace RomanNumeralsKata
{
    public class RomanNumerals
    {
        public string ConvertToRoman(int arabic)
        {
            StringBuilder sb = new StringBuilder();

            int remaining = arabic;

            if(remaining == 9)
            {
                sb.Append("IX");
                remaining -= 9;
            }
            if(remaining >= 5)
            {
                sb.Append("V");
                remaining -= 5;
            }
            if(remaining == 4)
            {
                sb.Append("IV");
                remaining -= 4;
            }

            for(int i = 0; i < remaining; i++)
            {
                sb.Append("I");
            }

            return sb.ToString();
            
        }
        
    }
}
