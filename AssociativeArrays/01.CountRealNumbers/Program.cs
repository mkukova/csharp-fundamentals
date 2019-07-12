using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] nums = Console.ReadLine()
				.Split(" ")
				.Select(double.Parse)
				.ToArray();

			var counts = new SortedDictionary<double, int>();

			foreach (var number in nums)
			{
				if (counts.ContainsKey(number))
				{
					counts[number]++;
				}
				else
				{
					counts[number] = 1;
				}
			}

			foreach (var num in counts)
			{
				Console.WriteLine($"{num.Key} -> {num.Value}");
			}

		}
	}
}
