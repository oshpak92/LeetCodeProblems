using System.Collections.Generic;

namespace LeetCode.Problems.HashTable.Easy
{
	public class ValidAnagramProblem
	{
		public bool IsAnagram(string s, string t)
		{
			if (s.Length != t.Length)
				return false;

			var bufer1 = new Dictionary<char, int>();
			foreach (var ch in s)
			{
				if (bufer1.ContainsKey(ch))
					bufer1[ch]++;
				else
					bufer1[ch] = 1;
			}

			var bufer2 = new Dictionary<char, int>();
			foreach (var ch in t)
			{
				if (bufer2.ContainsKey(ch))
					bufer2[ch]++;
				else
					bufer2[ch] = 1;
			}

			foreach (var keyVal in bufer1)
			{
				if (!bufer2.ContainsKey(keyVal.Key) || bufer2[keyVal.Key] != keyVal.Value)
					return false;
			}

			return true;
		}
	}
}
