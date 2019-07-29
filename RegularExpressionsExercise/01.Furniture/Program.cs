using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _01.Furniture
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
			var furniture = new List<string>();
			double totalPrice = 0;

			while (input != "Purchase")
			{
				Match match = Regex.Match(input, pattern, RegexOptions.IgnoreCase);

				if (match.Success)
				{
					string name = match.Groups["name"].Value;
					double price = double.Parse(match.Groups["price"].Value);
					int quantity = int.Parse(match.Groups["quantity"].Value);
					furniture.Add(name);
					totalPrice += price * quantity;
				}

				input = Console.ReadLine();
			}

			Console.WriteLine("Bought furniture:");

			if (furniture.Count > 0)
			{
				Console.WriteLine(string.Join(Environment.NewLine, furniture));
			}

			Console.WriteLine($"Total money spend: {totalPrice:F2}");
		}
	}
}
