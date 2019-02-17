using System;
using NUnit.Framework;
using Calculator;

namespace Calculator.Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [TestCase("", ExpectedResult = 0)]
        [TestCase("1", ExpectedResult = 1)]
        [TestCase("1, 2", ExpectedResult = 3)]
        [TestCase("1,2,3", ExpectedResult = 6)]
        [TestCase("1\n2,3", ExpectedResult = 6)]
        [TestCase("//;\n1;2", ExpectedResult = 3)]
        [Test]
        public int Add_NumbersString_SumOfNumbers(string numbers)
        {
            return StringCalculator.Add(numbers);
        }

        [Test]
        public void Add_NegativeNumbersString_ThrowsArgumentException()
        {
            string numbers = "-1,2\n-4";
            var exception = Assert.Throws<ArgumentException>(() => StringCalculator.Add(numbers));
            Assert.AreEqual("Negatives not allowed -1 -4", exception.Message);
        }
    }
}
