﻿using System;
using NUnit.Framework;
using Calculator;

namespace Calculator.Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [TestCase("", ExpectedResult = 0)]
        [TestCase("1", ExpectedResult = 1)]
        [Test]
        public int Add_NumbersString_SumOfNumbers(string numbers)
        {
            return StringCalculator.Add(numbers);
        }
    }
}
