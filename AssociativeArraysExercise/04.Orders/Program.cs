using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Orders
{
	class Program
	{
		static void Main(string[] args)
		{
			var products = new Dictionary<string, double[]>();

			while (true)
			{
				string[] input = Console.ReadLine().Split(" ");

				if (input[0] == "buy")
				{
					break;
				}

				string productName = input[0];
				double price = double.Parse(input[1]);
				int quantity = int.Parse(input[2]);

				if (!products.ContainsKey(productName))
				{
					products.Add(productName, new double[2]);
				}

				products[productName][0] = price;
				products[productName][1] += quantity;
			}

			foreach (var item in products)
			{
				Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):F2}");
			}
		}
	}
}
