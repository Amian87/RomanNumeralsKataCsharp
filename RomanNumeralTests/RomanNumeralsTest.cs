using NUnit.Framework;
using RomanNumeralsKata;
using System;

namespace RomanNumeralTests
{
    public class RomanNumeralsTest
    {
        RomanNumerals rn = new RomanNumerals();

        [SetUp]
        public void SetUpRomanNumerals()
        {
            rn = new RomanNumerals();
        }

        [TestCase("I",1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("VII", 7)]
        [TestCase("VIII", 8)]
        [TestCase("IX", 9)]
        [TestCase("MMDCCLI", 2751)]
        public void ConvertToRomanNumeral(string roman, int arabic)
        {
            Assert.AreEqual(roman, rn.ConvertToRoman(arabic));
        }



    }
}
