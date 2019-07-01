using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Messaging
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();

			List<char> text = Console.ReadLine().ToList();
			string result = string.Empty;

			for (int i = 0; i < numbers.Count; i++)
			{
				int number = numbers[i];
				int sumOfDigits = 0;

				while (number > 0)
				{
					sumOfDigits += number % 10;
					number /= 10;
				}

				int textLenght = text.Count;

				while (sumOfDigits > textLenght)
				{
					sumOfDigits -= textLenght;
				}

				result += text[sumOfDigits];
				text.RemoveAt(sumOfDigits);
			}

			Console.WriteLine(result);
		}
	}
}
