using System;

namespace _04.RefactoringPrimeChecker
{
	class Program
	{
		static void Main(string[] args)
		{
			int counter = int.Parse(Console.ReadLine());
			for (int number = 2; number <= counter; number++)
			{
				bool isPrime = true;
				for (int dividend = 2; dividend < number; dividend++)
				{
					if (number % dividend == 0)
					{
						isPrime = false;
						break;
					}
				}

				Console.WriteLine($"{number} -> {isPrime.ToString().ToLower()}");
			}
		}
	}
}
