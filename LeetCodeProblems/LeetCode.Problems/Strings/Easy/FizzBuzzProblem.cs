using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Strings.Easy
{
    /// <summary>
    /// 412. Fizz Buzz
    /// https://leetcode.com/problems/fizz-buzz/
    /// Runtime: 252 ms, faster than 91.46% of C# online submissions for Fizz Buzz.
    /// Memory Usage: 31.8 MB, less than 15.71% of C# online submissions for Fizz Buzz.
    /// </summary>
    public class FizzBuzzProblem
    {
        private const string fizz = "Fizz";
        private const string buzz = "Buzz";
        private const string fizzbuzz = "FizzBuzz";

        public IList<string> FizzBuzz(int n)
        { 
            var result = new List<string>();
            int flag = 0;
            for (int i = 1; i <= n; i++)
            {
                flag = 0;
                if( i % 3 == 0)
                {
                    flag |= 1;
                }
                if(i % 5 == 0)
                {
                    flag |= 10;
                }
                switch (flag)
                {
                    case 0:
                        result.Add(i.ToString());
                        break;
                    case 1:
                        result.Add(fizz);
                        break;
                    case 10:
                        result.Add(buzz);
                        break;
                    case 11:
                        result.Add(fizzbuzz);
                        break;
                }
            }

            return result;
        }
    }
}
