using System;

namespace _12.RefactorSpecialNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int counter = int.Parse(Console.ReadLine());
			int sum = 0;
			for (int i = 1; i <= counter; i++)
			{
				int number = i;
				while (number > 0)
				{
					sum += number % 10;
					number = number / 10;
				}

				bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
				Console.WriteLine($"{i} -> {isSpecial}");
				sum = 0;
			}
		}
	}
}
