using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Strings.Easy
{
    /// <summary>
    /// 28. Implement strStr()
    /// https://leetcode.com/problems/implement-strstr/
    /// Runtime: 1876 ms, faster than 2.94% of C# online submissions for Implement strStr().
    /// Memory Usage: 20.1 MB, less than 0.84% of C# online submissions for Implement strStr().
    /// </summary>
    public class ImplementstrStrProblem
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
                return 0;
            
            if (string.IsNullOrEmpty(haystack) || string.IsNullOrEmpty(needle) || haystack.Length < needle.Length)
                return -1;

            for (int i = 0; i < haystack.Length; i++)
            {
                if(haystack[i] == needle[0])
                {
                    var _i = i++;
                    var j = 1;
                    for (; j < needle.Length && i < haystack.Length; j++, i++)
                    {
                        if (haystack[i] != needle[j])
                            break;
                    }
                    if (j == needle.Length)
                        return _i;
                    else
                        i = _i;
                }
            }

            return -1;
        }
    }
}
