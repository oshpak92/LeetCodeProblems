using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 380. Insert Delete GetRandom O(1)
    /// https://leetcode.com/problems/insert-delete-getrandom-o1/
    /// Runtime: 280 ms, faster than 25.00% of C# online submissions for Insert Delete GetRandom O(1).
    /// </summary>
    public class InsertDeleteGetRandomProblem
    {
        public class RandomizedSet
        {
            private readonly Random rnd = new Random();
            private readonly HashSet<int> _container;

            public RandomizedSet()
            {
                _container = new HashSet<int>();
            }

            /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
            public bool Insert(int val)
            {
                return _container.Add(val);
            }

            /** Removes a value from the set. Returns true if the set contained the specified element. */
            public bool Remove(int val)
            {
                return _container.Remove(val);

            }
            /** Get a random element from the set. */
            public int GetRandom()
            {
                return _container.ElementAt(rnd.Next(_container.Count));
            }
        }
    }
}
