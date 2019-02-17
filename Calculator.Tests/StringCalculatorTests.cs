using System;
using NUnit.Framework;
using Calculator;

namespace Calculator.Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public int Add_NumbersString_SumOfNumbers(string numbers)
        {
            return StringCalculator.Add(numbers);
        }
    }
}
