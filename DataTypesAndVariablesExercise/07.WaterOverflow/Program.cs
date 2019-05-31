using System;

namespace _07.WaterOverflow
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberLines = int.Parse(Console.ReadLine());
			int sum = 0;
			for (int i = 0; i < numberLines; i++)
			{
				int liters = int.Parse(Console.ReadLine());
				sum += liters;
				if (sum > 255)
				{
					sum -= liters;
					Console.WriteLine("Insufficient capacity!");
				}
			}

			Console.WriteLine(sum);
		}
	}
}
