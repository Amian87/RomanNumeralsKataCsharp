using NUnit.Framework;
using RomanNumerals;
using System;

namespace RomanNumeralTests
{
    public class RomanNumeralTests
    {
        RomanNumeral rn = new RomanNumeral();

        [SetUp]
        public void SetUpRomanNumeral()
        {
            rn = new RomanNumeral();
        }

        [Test]
        public void ConvertOneTwoThreeRomanNumeral()
        {
            Assert.AreEqual("I", rn.ConvertToRoman(1));
            Assert.AreEqual("II", rn.ConvertToRoman(2));
            Assert.AreEqual("III", rn.ConvertToRoman(3));
        }

        [Test]
        public void ConvertFour()
        {
            Assert.AreEqual("IV", rn.ConvertToRoman(4));
        }

        [Test]
        public void ConvertFive()
        {
            Assert.AreEqual("V", rn.ConvertToRoman(5));
        }

        [Test]
        public void ConvertSixSevenEight()
        {
            Assert.AreEqual("VI", rn.ConvertToRoman(6));
            Assert.AreEqual("VII", rn.ConvertToRoman(7));
            Assert.AreEqual("VIII", rn.ConvertToRoman(8));
        }

        [Test]
        public void ConvertNine()
        {
            Assert.AreEqual("IX", rn.ConvertToRoman(9));
        }

        [Test]
        public void ConvertTen()
        {
            Assert.AreEqual("X", rn.ConvertToRoman(10));
        }

        [Test]
        public void ConvertLargeNumber()
        {
            Assert.AreEqual("MMDCXLVIII", rn.ConvertToRoman(2648));
        }

    }
}
