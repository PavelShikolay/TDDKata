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

            return Int32.Parse(numbers);
        }
    }
}
