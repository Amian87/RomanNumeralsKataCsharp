using NUnit.Framework;
using RomanNumerals;
using System;

namespace RomanNumeralsTest
{
    public class RomanNumeralsTests
    {
        RomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();

        [SetUp]
        public void createRomanNumeralConverter()
        {
            romanNumeralConverter = new RomanNumeralConverter();
        }

        [Test]
        public void convert_1_2_3_ToRomanNumeral()
        {
            Assert.AreEqual("I", romanNumeralConverter.ConvertToRoman(1));
            Assert.AreEqual("II", romanNumeralConverter.ConvertToRoman(2));
            Assert.AreEqual("III", romanNumeralConverter.ConvertToRoman(3));
            Assert.AreEqual("V", romanNumeralConverter.ConvertToRoman(4));

        }

    }
}
