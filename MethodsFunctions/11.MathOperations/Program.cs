using System;

namespace _11.MathOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			double number1 = double.Parse(Console.ReadLine());
			char operators = char.Parse(Console.ReadLine());
			double number2 = double.Parse(Console.ReadLine());
			Console.WriteLine(Calculate(number1, operators, number2));
		}

		static double Calculate(double number1, char operators, double number2)
		{
			double result = 0;
			switch (operators)
			{
				case '/':
					result = number1 / number2;
					break;
				case '+':
					result = number1 + number2;
					break;
				case '-':
					result = number1 - number2;
					break;
				case '*':
					result = number1 * number2;
					break;
				default:
					Console.WriteLine("Invalid operator!");
					break;
			}

			return result;
		}
	}
}
