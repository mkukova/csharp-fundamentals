using System;

namespace _10.TopNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			for (int i = 1; i < number; i++)
			{
				TopInteger(i);
			}
		}

		static int SumOfDigits(int a)
		{
			int sum = 0;
			while (a > 0)
			{
				sum += a % 10;
				a /= 10;
			}

			return sum;
		}

		static bool OddDigit(int a)
		{
			bool isOddDigit = false;
			while (a > 0)
			{
				int digit = a % 10;
				if (digit % 2 != 0)
				{
					isOddDigit = true;
					break;
				}

				a = a / 10;
			}

			return isOddDigit;
		}

		static void TopInteger(int a)
		{
			if (OddDigit(a) && SumOfDigits(a) % 8 == 0)
			{
				Console.WriteLine(a);
			}
		}
	}
}
