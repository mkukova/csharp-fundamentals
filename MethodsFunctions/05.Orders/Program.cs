using System;

namespace _05.Orders
{
	class Program
	{
		static void Main(string[] args)
		{
			string product = Console.ReadLine().ToLower();
			int quantity = int.Parse(Console.ReadLine());
			OrderPrice(product, quantity);
		}

		static void OrderPrice(string product, int quantity)
		{
			switch (product)
			{
				case "coffee":
					Console.WriteLine($"{(quantity * 1.5):F2}");
					break;
				case "water":
					Console.WriteLine($"{(quantity * 1.0):F2}");
					break;
				case "coke":
					Console.WriteLine($"{(quantity * 1.4):F2}");
					break;
				case "snacks":
					Console.WriteLine($"{(quantity * 2.0):F2}");
					break;
				default:
					Console.WriteLine("Wrong product name");
					break;
			}
		}
	}
}
