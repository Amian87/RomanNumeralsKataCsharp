using System;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        public string ConvertToRoman(int number)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < number; i++)
            {
                sb.Append("I");
            }
            
            return sb.ToString(); 
              
        }
    }
}
