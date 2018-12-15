using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.HashTable.Easy
{
    public class KeyboardRow
    {
        public string[] FindWords(string[] words)
        {
            var keyboard = GetKeyboard();
            var result = new List<string>();

            foreach (var word in words)
            {
                if (IsInRow(keyboard[1], word) ||
                    IsInRow(keyboard[2], word) ||
                    IsInRow(keyboard[3], word))
                    result.Add(word);
            }

            return result.ToArray();
        }

        private bool IsInRow(HashSet<char> row, string word)
        {
            var isInRow = true;
            foreach (var letter in word.ToLower())
            {
                isInRow = row.Contains(letter);
                if (!isInRow) break;
            }
            return isInRow;
        }

        private Dictionary<int, HashSet<char>> GetKeyboard()
        {
            var rows = new Dictionary<int, HashSet<char>>();
            rows.Add(1, new HashSet<char>("qwertyuiop"));
            rows.Add(2, new HashSet<char>("asdfghjkl"));
            rows.Add(3, new HashSet<char>("zxcvbnm"));
            return rows;
        }
    }
}
