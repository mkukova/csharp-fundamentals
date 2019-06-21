﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.ListOfProducts
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberProducts = int.Parse(Console.ReadLine());
			List<string> products = new List<string>();

			for (int i = 0; i < numberProducts; i++)
			{
				string currentProduct = Console.ReadLine();
				products.Add(currentProduct);
			}

			products.Sort();

			for (int i = 0; i < numberProducts; i++)
			{
				Console.WriteLine($"{i + 1}.{products[i]}");
			}
		}
	}
}
