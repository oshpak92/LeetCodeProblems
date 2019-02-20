using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problems.Strings.Medium
{
    /// <summary>
    /// 49. Group Anagrams
    /// https://leetcode.com/problems/group-anagrams/
    /// Runtime: 396 ms, faster than 44.40% of C# online submissions for Group Anagrams.
    /// Memory Usage: 38.4 MB, less than 13.84% of C# online submissions for Group Anagrams.
    /// </summary>
    public class GroupAnagramsProblem
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();
            foreach (var str in strs)
            {
                var key = SumStr(str);
                if (dict.ContainsKey(key))
                    dict[key].Add(str);
                else
                    dict[key] = new List<string>() { str };
            }
            return dict.Values.ToList();
        }

        public string SumStr(string s)
        {
            int[] count = new int[26];
            if(s != null)
            foreach (var ch in s)
                count[ch - 'a'] ++;

            var str = new StringBuilder();
            foreach (var item in count)
            {
                str.Append(";");
                str.Append(item);
            }
            return str.ToString();
        }
    }
}
