using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetCode.Problems.Strings.Medium
{
    /// <summary>
    /// 91. Decode Ways
    /// https://leetcode.com/problems/decode-ways/
    /// 5%...:-(
    /// </summary>
    public class DecodeWaysProblem
    {
        public int NumDecodings(string s)
        {
            if (s.Length == 0)
                return 0;

            var memory = new int[s.Length];
            var count = 0;
            GetCount(memory, s, 0, ref count);
            return count;
        }

        private void GetCount(int [] memory, string s, int position, ref int count)
        {
            
            if (position == s.Length)
            {
                count++;
                return;
            }
            else if (position > s.Length)
                return;

            if (memory[position] != 0)
            {
                count += memory[position];
                return;
            }

            if (s[position] - '0' <= 26 && s[position] - '0' > 0)
            GetCount(memory, s, position + 1, ref count);

            if( position + 1 < s.Length && s[position] != '0' )
            {
                var subsrt = s.Substring(position, 2);
                var chCode = Convert.ToInt32(subsrt);
                if(chCode <= 26 )
                {
                    GetCount(memory, s, position + 2, ref count);
                }
            }

            memory[position] = count;
        }

        //private Dictionary<int, char> alphabet = new Dictionary<int, char>();

        //public DecodeWaysProblem()
        //{
        //    for (int i = 1; i < 27; i++)
        //    {
        //        alphabet[i] = Convert.ToChar('A' - 1 + i);
        //    }
        //}

        //public int NumDecodings(string s)
        //{
        //    if (s.Length == 0)
        //        return 0;

        //    HashSet<string> duplicates = new HashSet<string>();

        //    GetCount(duplicates, s, "", 0);
        //    return duplicates.Count;
        //}

        //private void GetCount(HashSet<string> duplicates, string s, string code, int position)
        //{
        //    if (position >= s.Length)
        //    {
        //        duplicates.Add(code);
        //        return;
        //    }

        //    int key = Convert.ToInt32(s[position] - '0');

        //    if (!alphabet.ContainsKey(key))
        //        return;

        //    GetCount(duplicates, s, $"{code}{alphabet[key]}", position + 1);

        //    if (position + 1 < s.Length)
        //    {
        //        var subsrt = s.Substring(position, 2);
        //        var chCode = Convert.ToInt32(subsrt);
        //        if (alphabet.ContainsKey(chCode))
        //        {
        //            GetCount(duplicates, s, $"{code}{alphabet[chCode]}", position + 2);
        //        }
        //    }
        //}
    }
}
