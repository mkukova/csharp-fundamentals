using System;

namespace _09.SumOfOddNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			int sum = 0;
			int counter = 1;
			while (number > 0)
			{
				Console.WriteLine(counter);
				sum += counter;
				counter += 2;
				number--;
			}

			Console.WriteLine($"Sum: {sum}");
		}
	}
}
