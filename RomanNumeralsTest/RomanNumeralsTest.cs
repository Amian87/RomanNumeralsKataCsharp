using NUnit.Framework;
using RomanNumerals;
using System;

namespace RomanNumeralsTest
{
    public class RomanNumeralsTest
    {
        [Test]
        public void createConverter()
        {
            Converter Converter = new Converter();
        }


        [Test]
        public void convert_1_Roman_Numeral()
        {
            Converter Converter = new Converter();

            Converter.Convert(1);

            Assert.AreEqual("I", Converter.Convert(1));
        }

        [Test]
        public void convert_2_Roman_Numeral()
        {
            Converter Converter = new Converter();

            Converter.Convert(2);

            Assert.AreEqual("II", Converter.Convert(2));
        }

    }
}
