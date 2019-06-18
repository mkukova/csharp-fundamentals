using System;

namespace _01.SortNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			double firstNumber = double.Parse(Console.ReadLine());
			double secondNumber = double.Parse(Console.ReadLine());
			double thirdNumber = double.Parse(Console.ReadLine());
			if (firstNumber > secondNumber && firstNumber > thirdNumber)
			{
				if (secondNumber > thirdNumber)
				{
					Console.WriteLine(firstNumber);
					Console.WriteLine(secondNumber);
					Console.WriteLine(thirdNumber);
				}
				else
				{
					Console.WriteLine(firstNumber);
					Console.WriteLine(thirdNumber);
					Console.WriteLine(secondNumber);
				}
			}
			else if (secondNumber > firstNumber && secondNumber > thirdNumber)
			{
				if (firstNumber > thirdNumber)
				{
					Console.WriteLine(secondNumber);
					Console.WriteLine(firstNumber);
					Console.WriteLine(thirdNumber);
				}
				else
				{
					Console.WriteLine(secondNumber);
					Console.WriteLine(thirdNumber);
					Console.WriteLine(firstNumber);
				}
			}
			else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
			{
				if (firstNumber > secondNumber)
				{
					Console.WriteLine(thirdNumber);
					Console.WriteLine(firstNumber);
					Console.WriteLine(secondNumber);
				}
				else
				{
					Console.WriteLine(thirdNumber);
					Console.WriteLine(secondNumber);
					Console.WriteLine(firstNumber);
				}
			}


		}
	}
}
