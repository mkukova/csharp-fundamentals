using System;

namespace _01.SmallestOfThreeNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int number1 = int.Parse(Console.ReadLine());
			int number2 = int.Parse(Console.ReadLine());
			int number3 = int.Parse(Console.ReadLine());
			int smallestNumber = SmallestNumber(number1, number2, number3);
			Console.WriteLine(smallestNumber);
		}

		static int SmallestNumber(int a, int b, int c)
		{
			int smallestNumber = int.MaxValue;

			if (a <= b && a <= c)
			{
				smallestNumber = a;
			}
			else if (b <= a && b <= c)
			{
				smallestNumber = b;
			}
			else if (c <= a && c <= b)
			{
				smallestNumber = c;
			}

			return smallestNumber;
		}
	}
}
