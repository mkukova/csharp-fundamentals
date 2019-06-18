using System;
using System.Linq;

namespace _08.MagicSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();

			int magicNumber = int.Parse(Console.ReadLine());

			for (int i = 0; i < numbers.Length; i++)
			{
				int firstNumber = numbers[i];

				for (int j = i + 1; j < numbers.Length; j++)
				{
					int secondNumber = numbers[j];

					if (firstNumber + secondNumber == magicNumber)
					{
						Console.WriteLine($"{firstNumber} {secondNumber}");
					}
				}
			}
		}
	}
}
