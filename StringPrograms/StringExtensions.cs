using System;
using System.Collections.Generic;
using System.Text;

namespace StringPrograms
{
    public static class StringExtensions
    {
        public static void PrintReverse(this string input)
        {
            if (input == null || input.Length <= 0)
                Console.WriteLine(input);
            else
            {
                Console.WriteLine(input[input.Length - 1]);
                PrintReverse(input.Substring(0, input.Length - 1));
            }
        }
        private static bool IsAlphabet(char ch)
        {
            return ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'));
        }


        public static void ReverseWithoutReversingSpecialCharacters(this string str)
        {
            char[] input = str.ToCharArray();
            int forwardIndex = 0, backwardIndex = input.Length - 1;
            while (forwardIndex < backwardIndex)
            {
                if (!IsAlphabet(input[forwardIndex]))
                {
                    forwardIndex++;
                }
                if (!IsAlphabet(input[backwardIndex]))
                {
                    backwardIndex--;
                }
                if (Char.IsLetter(input[forwardIndex]) &&
                    Char.IsLetter(input[backwardIndex]))
                {
                    char temp = input[forwardIndex];
                    input[forwardIndex] = input[backwardIndex];
                    input[backwardIndex] = temp;
                    forwardIndex++;
                    backwardIndex--;
                }
            }
            str = new string(input);
            Console.WriteLine(str);
        }

        public static void RemoveDuplicates(this string input)
        {
            String str = string.Empty;
            foreach (var s in input)
            {
                if (str.IndexOf(s) == -1)
                    str = str + s;
            }
            input = str;
            Console.WriteLine(input);
        }
    }
}
