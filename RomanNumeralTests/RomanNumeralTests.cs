using NUnit.Framework;
using RomanNumerals;
using System;

namespace RomanNumeralTests
{
    public class RomanNumeralTest
    {
        RomanNumeral rn = new RomanNumeral();

        [SetUp]
        public void SetupRomanNumeral()
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
        [TestCase("X", 10)]
        [TestCase("XL", 40)]
        [TestCase("L", 50)]
        [TestCase("XC", 90)]
        [TestCase("C", 100)]
        [TestCase("CD", 400)]
        [TestCase("D", 500)]
        [TestCase("CM", 900)]
        [TestCase("M", 1000)]
        [TestCase("MMVIII", 2008)]
        [TestCase("MMM", 3000)]
        public void ConvertOneTwoToRomanNumeral(string numeral, int arabic)
        {
            Assert.AreEqual(numeral, rn.ConvertToRoman(arabic));
        }

    }
}
