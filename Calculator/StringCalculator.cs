using System;
using System.Collections.Generic;

namespace Calculator
{
    public static class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (numbers == string.Empty)
            {
                return 0;
            }

            string[] numbersArray = numbers.Split(',');

            int result = 0;
           
            foreach (var number in numbersArray)
            {
                result += Int32.Parse(number);
            }

            return result;
        }
    }
}
