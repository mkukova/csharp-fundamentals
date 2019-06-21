using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.GaussTrick
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();

			List<int> result = new List<int>();
			int numbersLenght = numbers.Count;

			for (int i = 0; i < numbersLenght / 2; i++)
			{
				int newNumber = numbers[i] + numbers[numbersLenght - 1 - i];
				result.Add(newNumber);
			}

			if (numbersLenght % 2 == 1)
			{
				result.Add(numbers[numbersLenght / 2]);
			}

			Console.WriteLine(string.Join(" ", result));
		}
	}
}
