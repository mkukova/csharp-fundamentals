using System;

namespace _01.SignOfIntegerNumbers
{
	class Program
	{
		static void SignOfInteger(int number)
		{
			if (number == 0)
			{
				Console.WriteLine($"The number {number} is zero.");
			}
			else if (number > 0)
			{
				Console.WriteLine($"The number {number} is positive.");
			}
			else
			{
				Console.WriteLine($"The number {number} is negative.");
			}
		}
		static void Main(string[] args)
		{
			int integer = int.Parse(Console.ReadLine());
			SignOfInteger(integer);
		}
	}
}
