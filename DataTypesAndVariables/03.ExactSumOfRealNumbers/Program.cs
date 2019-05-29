using System;

namespace _03.ExactSumOfRealNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int counter = int.Parse(Console.ReadLine());
			decimal sum = 0;
			for (int i = counter; i > 0; i--)
			{
				decimal number = decimal.Parse(Console.ReadLine());
				sum += number;
			}

			Console.WriteLine(sum);
		}
	}
}
