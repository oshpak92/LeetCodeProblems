using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.HashTable.Easy
{
    public class VerifyingAnAlienDictionary
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            if (words == null) throw new ArgumentNullException(nameof(words));
            if (words.Length > 100 || words.Length < 1) throw new ArgumentException(nameof(words));
            if (string.IsNullOrEmpty(order)) throw new ArgumentException(nameof(order));
            if (order.Length != 26) throw new ArgumentException(nameof(order));

            var alphabet = new Dictionary<char, int>();
            for(int i = 0; i < order.Length; i++)
            {
                alphabet[order[i]] = i;
            }
            
            for(int i = 0; i < words.Length-1 ; i++ )
            {
                for(int j = 0; j < words[i].Length; j++)
                {
                    if (words[i + 1].Length <= j) return false;

                    var fwlIndex = alphabet[words[i][j]];
                    var swlIndex = alphabet[words[i + 1][j]];

                    if (fwlIndex > swlIndex) return false;
                    if (fwlIndex == swlIndex) continue;
                    if (fwlIndex < swlIndex) break;
                }
            }

            return true;
        }
    }
}
