using System;

namespace _05.SpecialNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int counter = int.Parse(Console.ReadLine());
			bool isSpecial = false;
			for (int i = 1; i <= counter; i++)
			{
				int number = i;
				int sum = 0;
				while (number > 0)
				{
					sum += number % 10;
					number = number / 10;
				}

				if (sum == 5 || sum == 7 || sum == 11)
				{
					isSpecial = true;
				}
				else
				{
					isSpecial = false;
				}

				if (isSpecial)
				{
					Console.WriteLine($"{i} -> True");
				}
				else
				{
					Console.WriteLine($"{i} -> False");
				}
			}
		}
	}
}
