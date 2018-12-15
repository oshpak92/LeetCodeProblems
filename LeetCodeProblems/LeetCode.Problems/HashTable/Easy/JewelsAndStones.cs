using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.HashTable.Easy
{
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string J, string S)
        {
            var hashset = new HashSet<char>();
            foreach (var jelous in J)
            {
                hashset.Add(jelous);
            }

            var count = 0;
            foreach (var stone in S)
            {
                if (hashset.Contains(stone))
                    count++;
            }
            return count;
        }
    }
}
