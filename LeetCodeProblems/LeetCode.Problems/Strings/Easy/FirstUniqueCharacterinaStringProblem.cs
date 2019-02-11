using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Problems.Strings
{
    /// <summary>
    /// 387. First Unique Character in a String
    /// https://leetcode.com/problems/first-unique-character-in-a-string/
    /// Runtime: 144 ms, faster than 55.75% of C# online submissions for First Unique Character in a String.
    /// Memory Usage: 30.2 MB, less than 3.74% of C# online submissions for First Unique Character in a String.
    /// </summary>
    public class FirstUniqueCharacterinaStringProblem
    {
        public int FirstUniqChar(string s)
        {
            //[0] - count
            //[1] - first index
            if (string.IsNullOrEmpty(s))
                return -1;

            var bufer = new HashSet<char>();
            var firstUnique = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if(bufer.Contains(s[i]))
                {
                    firstUnique.Remove(s[i]);
                }
                else
                {
                    bufer.Add(s[i]);
                    firstUnique[s[i]] = i;
                }
            }

            //TODO: try to solve without ordering
            return firstUnique.Count > 0 ? firstUnique.OrderBy(item => item.Value).First().Value: 0;
        }
    }
}
