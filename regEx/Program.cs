﻿using System.Text.RegularExpressions;

namespace regEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1= "hello123";
            string pattern1= @"[a-z]+\d+";

            oneMatch(input1, pattern1);


        }

        public static void oneMatch(string input, string pattern)
        {
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
