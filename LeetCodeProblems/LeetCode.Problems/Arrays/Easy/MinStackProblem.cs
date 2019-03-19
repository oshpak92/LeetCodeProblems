using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Easy
{
    public class MinStackProblem
    {
        /// <summary>
        /// 155. Min Stack
        /// https://leetcode.com/problems/min-stack/
        /// </summary>
        public class MinStack
        {
            int min = int.MaxValue;
            Stack<int> stack = new Stack<int>();
            public void Push(int x)
            {
                // only push the old minimum value when the current 
                // minimum value changes after pushing the new value x
                if (x <= min)
                {
                    stack.Push(min);
                    min = x;
                }
                stack.Push(x);
            }

            public void Pop()
            {
                // if pop operation could result in the changing of the current minimum value, 
                // pop twice and change the current minimum value to the last minimum value.
                if (stack.Pop() == min) min = stack.Pop();
            }

            public int Top()
            {
                return stack.Peek();
            }

            public int GetMin()
            {
                return min;
            }
        }

    }
}
