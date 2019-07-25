using NUnit.Framework;
using System;

namespace RomanNumeralConverter.Library.Tests
{
    public class RomanNumeralConverterTests
    {
        private RomanNumeralConverter romanNumeralConverter;

        [SetUp]
        public void SetupRomanNumeralConverter()
        {
            romanNumeralConverter = new RomanNumeralConverter();
        }

        [Test]
        public void ConvertOneTwoThree()
        {
            Assert.AreEqual("I", romanNumeralConverter.Convert(1));
            Assert.AreEqual("II", romanNumeralConverter.Convert(2));
            Assert.AreEqual("III", romanNumeralConverter.Convert(3));

        }

        [Test]
        public void ConvertFour()
        {
            Assert.AreEqual("IV", romanNumeralConverter.Convert(4));
        }

        [Test]
        public void ConvertFive()
        {
            Assert.AreEqual("V", romanNumeralConverter.Convert(5));
        }

        [Test]
        public void ConvertSixSevenEight()
        {
            Assert.AreEqual("VI", romanNumeralConverter.Convert(6));
            Assert.AreEqual("VII", romanNumeralConverter.Convert(7));
            Assert.AreEqual("VIII", romanNumeralConverter.Convert(8));
        }

        [Test]
        public void ConvertNine()
        {
            Assert.AreEqual("IX", romanNumeralConverter.Convert(9));
        }

        [Test]
        public void ConvertTen()
        {
            Assert.AreEqual("XL", romanNumeralConverter.Convert(40));
        }


    }
}
