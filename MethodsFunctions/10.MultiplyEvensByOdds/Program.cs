using System;

namespace _10.MultiplyEvensByOdds
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			number = Math.Abs(number);
			Console.WriteLine(GetMultipleOfEvenAndOdds(number));
		}

		static int GetSumOfEvenDigits(int number)
		{
			int sum = 0;
			while (number > 0)
			{
				int digit = number % 10;
				if (digit % 2 == 0)
				{
					sum += digit;
				}

				number = number / 10;
			}

			return sum;
		}

		static int GetSumOfOddDigits(int number)
		{
			int sum = 0;
			while (number > 0)
			{
				int digit = number % 10;
				if (digit % 2 != 0)
				{
					sum += digit;
				}

				number = number / 10;
			}

			return sum;
		}

		static int GetMultipleOfEvenAndOdds(int number)
		{
			int result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
			return result;
		}
	}
}
