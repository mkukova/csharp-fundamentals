using System;
using System.Linq;

namespace _04.Largest3Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();

			int[] sortednumbers = numbers.OrderByDescending(n => n).ToArray();

			for (int i = 0; i < 3; i++)
			{
				if (i < sortednumbers.Length)
				{
					Console.Write($"{sortednumbers[i]} ");
				}
			}
		}
	}
}
