using System;

namespace _11.MultiplicationTable2._0PP1
{
	class Program
	{
		static void Main(string[] args)
		{
			int integer = int.Parse(Console.ReadLine());
			int multiplier = int.Parse(Console.ReadLine());
			if (multiplier > 10)
			{
				Console.WriteLine($"{integer} X {multiplier} = {(integer * multiplier)}");
			}
			else
			{
				for (int times = multiplier; times <= 10; times++)
				{
					Console.WriteLine($"{integer} X {times} = {(integer * times)}");
				}
			}

		}
	}
}
