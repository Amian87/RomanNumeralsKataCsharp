using NUnit.Framework;
using RomanNumerals;
using System;

namespace RomanNumeralsTest
{
    public class RomanNumeralsTest
    {
        RomanNumeral rn = new RomanNumeral();

        [SetUp]
        public void CreateRomanNumerals()
        {
            rn = new RomanNumeral();
        }

        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
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
        [TestCase("MMM", 3000)]
        public void ConvertToRomanNumeral(string numeral, int arabic)
        {
            Assert.AreEqual(numeral, rn.ConvertToRoman(arabic));
        }

        //[TestCase("I", 1)]
        //public void ConvertToArabic(string numeral, int arabic)
        //{
        //    Assert.AreEqual(arabic, rn.ConvertToArabic(arabic));
        //}


    }
}
