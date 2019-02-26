using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetCode.Problems.Strings.Medium
{
    /// <summary>
    /// 5. Longest Palindromic Substring
    /// https://leetcode.com/problems/longest-palindromic-substring/
    /// Runtime: 100 ms, faster than 99.92% of C# online submissions for Longest Palindromic Substring.
    /// Memory Usage: 21.2 MB, less than 92.45% of C# online submissions for Longest Palindromic Substring.
    /// Next challenges:
    /// </summary>
    public class LongestPalindromicSubstringProblem
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return s;

            var length = 0;
            var start = 0;
            var end = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var length1 = Expand(s, i, i );
                var length2 = Expand(s, i, i + 1 );
                length = System.Math.Max(length1, length2);
                
                if ( length > end - start )
                {
                    start = i - (length - 1) / 2;
                    end = i + length / 2;
                }
            }

            return s.Substring(start, end - start + 1);
        }

        private int Expand(string s, int start, int end)
        {
            int left = start;
            int right = end;
            
            while(left >= 0 && right < s.Length && s[left] == s[right])
            { 
                left--;
                right++;
            }

            return right - left - 1;
        }

        //14 % faster
        //public string LongestPalindrome(string s)
        //{
        //    if (string.IsNullOrWhiteSpace(s))
        //        return s;

        //    var longestPalindrom = s[0].ToString();

        //    var memory = new HashSet<string>();
            
        //    for (int i = 0; i < s.Length - 1; i++)
        //    {
        //        var j = i;
        //        var next = s.LastIndexOf(s[i]);
        //        if (longestPalindrom.Length > next - i + 1)
        //            continue ;

        //        while (next != i)
        //        {
        //            if (IsPalindrom(memory, s, i, next))
        //            {
        //                var str = s.Substring(i, next - i + 1);

        //                longestPalindrom = str.Length > longestPalindrom.Length ? str : longestPalindrom;
        //                break;
        //            }
        //            next = s.LastIndexOf(s[i], next - 1);
        //        }
        //    }

        //    return longestPalindrom;
        //}


        //private bool IsPalindrom(HashSet<string> memory, string word, int start, int end)
        //{
        //    if (memory.Contains(Key(start, end)))
        //        return false;

        //    if (start == end || start > end)
        //        return true;

        //    if(word[start] == word[end] && IsPalindrom(memory, word, start + 1, end - 1))
        //    {
        //        return true;
        //    }
        //    memory.Add(Key(start, end));
        //    return false;
        //}

        //private string Key(int start, int end)
        //{
        //    return $"{start}-{end}";
        //}
    }
}
