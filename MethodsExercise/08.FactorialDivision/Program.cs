using System;

namespace _08.FactorialDivision
{
	class Program
	{
		static void Main(string[] args)
		{
			int number1 = int.Parse(Console.ReadLine());
			int number2 = int.Parse(Console.ReadLine());
			Console.WriteLine($"{FactorialDivision(number1, number2):F2}");
		}

		static long Factorial(int a)
		{
			long result = 1;
			for (int i = 1; i <= a; i++)
			{
				result *= i;
			}

			return result;
		}

		static double FactorialDivision(int a, int b)
		{
			double result = 0;
			result = 1.0 * Factorial(a) / Factorial(b);
			return result;
		}
	}
}
