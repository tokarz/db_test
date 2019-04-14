using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Challanges.StringReverse
{
    public class StringReverse
    {
        public string InvertString(string input)
        {
            StringBuilder strB = new StringBuilder();

            for (int x = 0; x < input.Length; x++)
            {
                strB.Append(input[input.Length - x - 1]);
            }

            return strB.ToString();
        }

        public char[] InvertTable(char[] input)
        {
            char[] result = new char[input.Length];

            for (int x = 0; x < input.Length; x++)
            {
                result[x] = input[input.Length - x - 1];
            }

            return result;
        }

        public void Swap(char[] input)
        {
            for (int x = 0; x < input.Length / 2; x++)
            {
                char temp = input[x];
                input[x] = input[input.Length - x - 1];
                input[input.Length - 1 - x] = temp;
            }
        }
    }

}

