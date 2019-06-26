using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.AppendArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> numbers = Console.ReadLine()
				.Split('|', StringSplitOptions.RemoveEmptyEntries)
				.Reverse()
				.ToList();

			for (int i = 0; i < numbers.Count; i++)
			{
				List<string> arrays = numbers[i]
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.ToList();

				for (int j = 0; j < arrays.Count; j++)
				{
					Console.Write($"{arrays[j]} ");
				}
			}
		}
	}
}
