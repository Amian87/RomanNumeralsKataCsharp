using NUnit.Framework;
using RomanNumerals;
using System;

namespace RomanNumeralsTest
{
    public class RomanNumeralsTest
    {
        RomanNumeral rn = new RomanNumeral();

        [SetUp]
        public void SetupRomanNumerals()
        {
            rn = new RomanNumeral();
        }

        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("IX", 9)]
        public void ConvertOneTwoThreeToRomanNumeral(string numeral, int arabic)
        {
            Assert.AreEqual(numeral, rn.ConvertToRoman(arabic));
        }
    }
}
