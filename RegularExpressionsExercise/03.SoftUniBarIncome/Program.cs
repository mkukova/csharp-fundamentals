﻿using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _03.SoftUniBarIncome
{
	class Program
	{
		static void Main(string[] args)
		{
			string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
			double totalIncome = 0;

			while (true)
			{
				string input = Console.ReadLine();

				if (input == "end of shift")
				{
					break;
				}

				if (Regex.IsMatch(input, pattern))
				{
					Match match = Regex.Match(input, pattern);
					string customer = match.Groups["customer"].Value;
					string product = match.Groups["product"].Value;
					int count = int.Parse(match.Groups["count"].Value);
					double price = double.Parse(match.Groups["price"].Value);
					double money = price * count;
					Console.WriteLine($"{customer}: {product} - {money:F2}");
					totalIncome += money;
				}
			}

			Console.WriteLine($"Total income: {totalIncome:F2}");
		}
	}
}
