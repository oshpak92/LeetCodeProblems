using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Strings.Medium
{
    /// <summary>
    /// 227. Basic Calculator II
    /// Steps:
    /// 1: Convert infix to postfix expression
    /// 2: Evaluate postfix expression
    /// Note: validate division for null
    /// </summary>
    public class BasicCalculatorIIProblem
    {
        private readonly Dictionary<char, int> operators = new Dictionary<char, int>()
        {
            { '+', 1 },
            { '-', 1 },
            { '*', 2 },
            { '/', 2 },
        };
        // 1+2 = 3
        // 1+ 2 * 2 = 5
        public int Calculate(string s)
        {
            var postfix = ToPostfix(s);
            return Evaluate(postfix);
        }

        private int Evaluate(string postfix)
        {
            var bufer = new Stack<int>();
            var i = 0;
            while (i < postfix.Length)
            {
                if (postfix[i] == ' ') { i++; continue; }

                if (operators.ContainsKey(postfix[i]))
                {
                    var right = bufer.Pop();
                    var left = bufer.Pop();
                    bufer.Push(PrimitiveOperation(left, right, postfix[i]));
                    i++;
                    continue;
                }

                var spaceInd = postfix.IndexOf(' ', i);
                bufer.Push(int.Parse(postfix.Substring(i, spaceInd - i + 1)));
                i = spaceInd;
            }

            return bufer.Pop();
        }

        private int PrimitiveOperation(int left, int right, char op)
        {
            switch (op)
            {
                case '+':
                    return left + right;
                case '-':
                    return left - right;
                case '*':
                    return left * right;
                case '/':
                    return left / right;
                default:
                    throw new NotSupportedException();
            }
        }

        public string ToPostfix(string s)
        {
            var bufer = new Stack<char>();
            var postfix = new StringBuilder();

            var i = 0;
            while(i < s.Length)
            {
                if (s[i] == ' ')
                {
                    i++;
                    continue;
                }

                if (!operators.ContainsKey(s[i]))
                {
                    var poisition = i;
                    while (poisition<s.Length && char.IsDigit(s[poisition]))
                        poisition ++;
                    var length = poisition - i;
                    postfix.Append(s.Substring(i, length) + " ");
                    
                    i = poisition;
                    continue;
                }

                if (bufer.Count == 0)
                {
                    bufer.Push(s[i]);
                    i++;
                    continue;
                }

                var last = bufer.Peek();
                if (operators[last] == operators[s[i]])
                {
                    postfix.Append(bufer.Pop());
                    bufer.Push(s[i]);
                }
                else if(operators[last] < operators[s[i]])
                {
                    bufer.Push(s[i]);
                }
                else if(operators[last] > operators[s[i]])
                {
                    while (bufer.TryPop(out var op))
                    {
                        postfix.Append(op);
                    }
                    bufer.Push(s[i]);
                }
                i++;
            }

            while(bufer.TryPop(out var op))
            {
                postfix.Append(op);
            }

            return postfix.ToString();
        }
    }
}
