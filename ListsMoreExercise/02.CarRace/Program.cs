using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.CarRace
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();

			int countOfNumbers = numbers.Count;
			double firstCarTime = 0;

			for (int i = 0; i < countOfNumbers / 2; i++)
			{
				firstCarTime += numbers[i];

				if (numbers[i] == 0)
				{
					firstCarTime = 0.8 * firstCarTime;
				}
			}

			double secondCarTime = 0;

			for (int i = countOfNumbers - 1; i > countOfNumbers / 2; i--)
			{
				secondCarTime += numbers[i];

				if (numbers[i] == 0)
				{
					secondCarTime = 0.8 * secondCarTime;
				}
			}

			if (firstCarTime < secondCarTime)
			{
				Console.WriteLine($"The winner is left with total time: {firstCarTime}");
			}
			else
			{
				Console.WriteLine($"The winner is right with total time: {secondCarTime}");
			}

		}
	}
}
