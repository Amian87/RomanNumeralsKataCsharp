using NUnit.Framework;
using RomanNumerals;
using System;

namespace RomanNumeralsTest
{
    public class RomanNumeralsTest
    {
        private RomanNumeral rn = new RomanNumeral();

        [SetUp]
        public void SetUpRomanNumerals()
        {
            rn = new RomanNumeral();
        }

        [Test]
        public void ConvertOneToRomanNumeral()
        {
            Assert.AreEqual("I", rn.ConvertToRoman(1));
            Assert.AreEqual("II", rn.ConvertToRoman(2));
            Assert.AreEqual("III", rn.ConvertToRoman(3));
        }

        [Test]
        public void ConvertFourToRomanNumeral()
        {
            Assert.AreEqual("IV", rn.ConvertToRoman(4));
        }

        [Test]
        public void ConvertFiveToRomanNumeral()
        {
            Assert.AreEqual("V", rn.ConvertToRoman(5));
        }

        [Test]
        public void ConvertSixSevenEightToRomanNumeral()
        {
            Assert.AreEqual("VI", rn.ConvertToRoman(6));
            Assert.AreEqual("VII", rn.ConvertToRoman(7));
            Assert.AreEqual("VIII", rn.ConvertToRoman(8));
        }

        [Test]
        public void ConvertNineToRomanNumeral()
        {
            Assert.AreEqual("XI", rn.ConvertToRoman(9));
        }

    }
}
