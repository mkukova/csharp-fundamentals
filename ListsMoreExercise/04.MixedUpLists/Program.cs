using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.MixedUpLists
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> firstLine = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();

			List<int> secondLine = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();

			List<int> midResult = new List<int>();
			List<int> result = new List<int>();
			int[] range = new int[2];

			int firstLineLenght = firstLine.Count;
			int secondLineLenght = secondLine.Count;

			if (firstLineLenght > secondLineLenght)
			{
				secondLine.Reverse();

				for (int i = 0; i < secondLineLenght; i++)
				{
					midResult.Add(firstLine[i]);
					midResult.Add(secondLine[i]);
				}

				range[0] = firstLine[firstLineLenght - 1];
				range[1] = firstLine[firstLineLenght - 2];
			}
			else
			{
				secondLine.Reverse();
				range[0] = secondLine[secondLineLenght - 1];
				range[1] = secondLine[secondLineLenght - 2];
				secondLine.RemoveAt(secondLineLenght - 1);
				secondLine.RemoveAt(secondLineLenght - 2);

				for (int i = 0; i < firstLineLenght; i++)
				{
					midResult.Add(firstLine[i]);
					midResult.Add(secondLine[i]);
				}
			}

			midResult.Sort();

			if (range[0] > range[1])
			{
				int temp = range[0];
				range[0] = range[1];
				range[1] = temp;
			}

			foreach (int number in midResult)
			{
				if (number > range[0] && number < range[1])
				{
					result.Add(number);
				}
			}

			Console.WriteLine(string.Join(" ", result));
		}
	}
}
