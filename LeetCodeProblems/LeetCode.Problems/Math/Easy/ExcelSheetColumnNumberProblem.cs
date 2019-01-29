using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Math.Easy
{
    /// <summary>
    /// 171. Excel Sheet Column Number
    /// Runtime: 96 ms, faster than 42.86% of C# online submissions for Excel Sheet Column Number.
    /// https://leetcode.com/problems/excel-sheet-column-number/
    /// </summary>
    public class ExcelSheetColumnNumberProblem
    {
        public int TitleToNumber(string s)
        {
            int sum = 0;
            for (int i = 0; i< s.Length; i++)
            {
                sum = sum  * 26 + s[i]  - 'A' + 1;
            }
            return sum;
        }
    }
}
