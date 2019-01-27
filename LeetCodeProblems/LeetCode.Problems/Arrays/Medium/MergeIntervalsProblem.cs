using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace LeetCode.Problems.Arrays.Medium
{
    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }

    /// <summary>
    /// 56. Merge Intervals
    /// https://leetcode.com/problems/merge-intervals/submissions/
    /// Runtime: 496 ms, faster than 10.53% of C# online submissions for Merge Intervals.
    /// </summary>
    public class MergeIntervalsProblem
    {
        public IList<Interval> Merge(IList<Interval> intervals)
        {
            var result = new List<Interval>();
            if (intervals == null)
                return null;

            var ordered = intervals.OrderBy(i => i.start).ToList();
            var current = 0;

            while (current < ordered.Count - 1)
            {
                if (Merge(ordered[current], ordered[current + 1]))
                {
                    // move to the end
                    ordered.RemoveAt(current + 1);
                }
                else
                {
                    current++;
                }
            }

            //Print(ordered);
            return ordered;
        }

        private bool Merge(Interval left, Interval right)
        {
            if (left.end - right.start >= 0)
            {
                left.start = System.Math.Min(left.start, right.start);
                left.end = System.Math.Max(left.end, right.end);
                return true;
            }
            return false;
        }

        private void Print(IEnumerable<Interval> arr)
        {
            foreach (var item in arr)
            {
                Debug.WriteLine($"[{item.start}, {item.end}]");
            }
        }
    }
}
