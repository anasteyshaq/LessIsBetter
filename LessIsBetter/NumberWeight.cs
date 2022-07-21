using System;
using System.Collections.Generic;

namespace LessIsBetter
{
    internal class NumberWeight
    {
        private int index;
        public NumberWeight()
        {
            index = 0;
        }
        public string Order(string input)
        {
            List<int> numbers = new List<int>();
            if (input == String.Empty)
                return String.Empty;

            index = SkipWhitespace(input, 0);
            if (index >= input.Length)
                return String.Empty;
            var nextChar = input[index];
            if (!char.IsNumber(nextChar))
                throw new Exception("Невірний формат рядка");
            while (index < input.Length)
            {
                numbers.Add(ScanNumber(input, ref index));
                if (index < input.Length)
                    index = SkipWhitespace(input, index);
            }

            numbers.Sort(new CompareByWeight());
            return string.Join(" ", numbers.ToArray());
        }
        private static int SkipWhitespace(string text, int index)
        {
            while (char.IsWhiteSpace(text[index]))
            {
                ++index;
                if (index >= text.Length)
                    break;
            }

            return index;
        }

        private static int ScanNumber(string text, ref int index)
        {
            var result = 0;
            if (text[index] != '0')
                while (text.Length > index && char.IsNumber(text[index]))
                {
                    result = (result * 10) + (text[index] - '0');
                    ++index;
                }

            return result;
        }

        public int CalcWeight(int number, int sum = 0)
        {
            if (number != 0)
                return CalcWeight(number / 10, sum + (number % 10));
            return sum;
        }

    }
}
