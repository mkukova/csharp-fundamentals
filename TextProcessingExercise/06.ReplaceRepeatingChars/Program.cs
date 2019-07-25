using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReplaceRepeatingChars
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] input = Console.ReadLine().ToCharArray();
			List<char> result = new List<char>();
			result.Add(input[0]);
			foreach (var symbol in input)
			{
				if (symbol != result.Last())
				{
					result.Add(symbol);
				}
			}

			Console.WriteLine(string.Join(string.Empty, result));
		}
	}
}

