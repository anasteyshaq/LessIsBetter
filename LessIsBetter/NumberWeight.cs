using System;
using System.Collections.Generic;
using System.Text;

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
            List<string> numbers = new List<string>();
            if (input == String.Empty)
                return String.Empty;

            index = SkipWhitespace(input, 0);
            if (index >= input.Length)
                return String.Empty;
            
            while (index < input.Length)
            {
                var nextChar = input[index];
                if (!char.IsNumber(nextChar))
                    throw new Exception("Невірний формат рядка");
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

        private static string ScanNumber(string text, ref int index)
        {
            var sb = new StringBuilder();
            if (text[index] != '0')
                while (text.Length > index && char.IsNumber(text[index]))
                {
                    
                    sb.Append(text[index]);
                    ++index;
                }
            return sb.ToString();
        }

        public int CalcWeight(string number,  int sum = 0)
        {
            var numbers = number.ToCharArray();
            foreach (char num in numbers)
            {
                sum += num - '0';
            }
            return sum;
        }

    }
}
