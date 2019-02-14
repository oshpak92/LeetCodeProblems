using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Strings.Easy
{
    /// <summary>
    /// 20. Valid Parentheses
    /// Runtime: 100 ms, faster than 23.46% of C# online submissions for Valid Parentheses.
    /// Memory Usage: 20.1 MB, less than 100.00% of C# online submissions for Valid Parentheses.
    /// </summary>
    public class ValidParenthesesProblem
    {
        private HashSet<char> openParentheses = new HashSet<char>() { '(', '[', '{' };
        private HashSet<char> closeParentheses = new HashSet<char>() { ')', ']', '}' };
        private Dictionary<char, char> map = new Dictionary<char, char>() { { '(', ')' }, { '[',']'}, { '{', '}'} };

        public bool IsValid(string s)
        {
            if (s == null)
                return false;
            if (string.IsNullOrEmpty(s))
                return true;

            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (openParentheses.Contains(s[i]))
                {
                    stack.Push(s[i]);
                }
                else if (closeParentheses.Contains(s[i]))
                {
                    if (stack.Count == 0)
                        return false;

                    var last = stack.Pop();
                    if (!map.ContainsKey(last) || map[last] != s[i])
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
