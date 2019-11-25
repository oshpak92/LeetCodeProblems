using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCode.Problems.Strings.Easy
{
	public class DefanginganIPAddressProblem
	{
		public string DefangIPaddr(string address)
		{
			var result = new StringBuilder();
			foreach (var character in address)
			{
				if (character == '.')
					result.Append("[.]");
				else
					result.Append(character);

			}
			return result.ToString();
		}

		//public string DefangIPaddr(string address)
		//{
		//	string pattern = "[.]";
		//	string replacement = "[.]";

		//	var regEx = new Regex(pattern);
		//	var result = regEx.Replace(address, replacement);// = Regex.Replace(regEx.Replace(address, replacement), @"\s+", " ");
		//	return result;
		//}
	}
}
