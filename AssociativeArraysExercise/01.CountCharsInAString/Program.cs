using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInAString
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(" ");

			var dict = new Dictionary<char, int>();

			foreach (string word in input)
			{
				foreach (char letter in word)
				{
					if (!dict.ContainsKey(letter))
					{
						dict[letter] = 0;
					}

					dict[letter]++;
				}
			}

			foreach (var character in dict)
			{
				Console.WriteLine($"{character.Key} -> {character.Value}");
			}
		}
	}
}
