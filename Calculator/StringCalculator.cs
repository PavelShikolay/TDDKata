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

            if (numbers.StartsWith("//"))
            {
                numbers = numbers.Remove(0, 2);
                var delimiter = numbers[0];
                numbers = numbers.Remove(0, 1).Replace(delimiter, ',');
            }

            string[] numbersArray = numbers.Replace('\n', ',').Split(',');

            int result = 0;

            foreach (var number in numbersArray)
            {
                if (!(number == string.Empty))
                {
                    result += int.Parse(number);
                }
            }

            return result;
        }      
    }
}
