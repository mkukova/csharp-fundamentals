using System;

namespace _02.PrintNumbersInReverseOrder
{
	class Program
	{
		static void Main(string[] args)
		{
			int lenght = int.Parse(Console.ReadLine());
			int[] numbers = new int[lenght];
			for (int i = 0; i < lenght; i++)
			{
				int number = int.Parse(Console.ReadLine());
				numbers[i] = number;
			}

			for (int i = lenght - 1; i >= 0; i--)
			{
				Console.Write($"{numbers[i]} ");
			}
		}
	}
}
