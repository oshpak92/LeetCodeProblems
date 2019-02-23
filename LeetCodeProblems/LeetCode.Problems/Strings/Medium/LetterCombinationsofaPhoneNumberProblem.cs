using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Strings.Medium
{
    /// <summary>
    /// 17. Letter Combinations of a Phone Number
    /// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    /// Runtime: 288 ms
    /// Memory Usage: 28.7 MB
    /// </summary>
    public class LetterCombinationsofaPhoneNumberProblem
    {
        private Dictionary<char, char[]> map = new Dictionary<char, char[]>()
        {
            { '2', new char[] { 'a', 'b', 'c'} },
            { '3', new char[] { 'd', 'e', 'f'} },
            { '4', new char[] { 'g', 'h', 'i'} },
            { '5', new char[] { 'j', 'k', 'l'} },
            { '6', new char[] { 'm', 'n', 'o'} },
            { '7', new char[] { 'p', 'q', 'r', 's'} },
            { '8', new char[] { 't', 'u', 'v'} },
            { '9', new char[] { 'w', 'x', 'y', 'z'} }
        };

        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();
            if(!string.IsNullOrWhiteSpace(digits))
                LetterCombination(result, "", 0, digits);
            return result;
        }

        public void LetterCombination(IList<string> result, string word, int position, string input)
        {
            if (word.Length == input.Length)
            {
                result.Add(word);
                return;
            }

            for (int i = 0; i < map[input[position]].Length; i++)
            {
                LetterCombination(result, word + map[input[position]][i], position + 1, input);
            }
        }
    }
}
