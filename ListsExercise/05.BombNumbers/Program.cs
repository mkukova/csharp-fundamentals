using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();

			int[] specialNumbers = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();
			int bombNum = specialNumbers[0];
			int power = specialNumbers[1];

			while (numbers.Contains(bombNum))
			{
				int indexBombNumber = numbers.IndexOf(bombNum);
				for (int i = indexBombNumber - power; i <= indexBombNumber + power; i++)
				{
					if (i >= 0 && i < numbers.Count)
					{
						numbers[i] = 0;
					}
				}
			}

			int sum = numbers.Sum();
			Console.WriteLine(sum);
		}
	}
}
