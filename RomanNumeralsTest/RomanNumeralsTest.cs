using NUnit.Framework;
using RomanNumeralsKata;
using System;

namespace RomanNumeralsTest
{
    public class RomanNumeralsTest
    {
        RomanNumerals rn = new RomanNumerals();

        [SetUp]
        public void SetUpRomanNumerals()
        {
            rn = new RomanNumerals(); 
        }

        [Test]
        public void ConvertOneTwoThreeToRoman()
        {
            Assert.AreEqual("I", rn.ConvertToRoman(1));
            Assert.AreEqual("II", rn.ConvertToRoman(2));
            Assert.AreEqual("III", rn.ConvertToRoman(3));  
        }

        [Test]
        public void ConvertFourToRoman()
        {
            Assert.AreEqual("IV", rn.ConvertToRoman(4));

        }

        [Test]
        public void ConvertFiveToRoman()
        {
            Assert.AreEqual("V", rn.ConvertToRoman(5));
        }

        [Test]
        public void ConvertSixSevenEightToRoman()
        {
            Assert.AreEqual("VI", rn.ConvertToRoman(6));
            Assert.AreEqual("VII", rn.ConvertToRoman(7));
            Assert.AreEqual("VIII", rn.ConvertToRoman(8));
        }
        
        [Test]
        public void ConvertNineToRoman()
        {
            Assert.AreEqual("IX", rn.ConvertToRoman(9));
        }


    }
}
