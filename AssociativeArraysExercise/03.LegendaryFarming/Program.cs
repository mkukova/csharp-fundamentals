using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.LegendaryFarming
{
	class Program
	{
		static void Main(string[] args)
		{
			var keyMaterials = new Dictionary<string, int>()
			{
				["shards"] = 0,
				["fragments"] = 0,
				["motes"] = 0
			};

			var junkMaterials = new Dictionary<string, int>();
			string winner = string.Empty;
			bool hasToBreak = false;

			while (true)
			{
				string[] input = Console.ReadLine()
				.ToLower()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

				for (int i = 0; i < input.Length; i += 2)
				{
					string material = input[i + 1];
					int quantity = int.Parse(input[i]);

					if (keyMaterials.ContainsKey(material))
					{
						keyMaterials[material] += quantity;

						if (keyMaterials[material] >= 250)
						{
							winner = material;
							hasToBreak = true;
							break;
						}
					}
					else
					{
						if (!junkMaterials.ContainsKey(material))
						{
							junkMaterials[material] = 0;
						}

						junkMaterials[material] += quantity;
					}
				}

				if (hasToBreak)
				{
					break;
				}
			}

			switch (winner)
			{
				case "shards":
					Console.WriteLine("Shadowmourne obtained!");
					keyMaterials[winner] -= 250;
					break;
				case "fragments":
					Console.WriteLine("Valanyr obtained!");
					keyMaterials[winner] -= 250;
					break;
				case "motes":
					Console.WriteLine("Dragonwrath obtained!");
					keyMaterials[winner] -= 250;
					break;
			}

			var firstPartOfResult = keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
			var secondPartOfResult = junkMaterials.OrderBy(x => x.Key);

			foreach (var item in firstPartOfResult)
			{
				Console.WriteLine($"{item.Key}: {item.Value}");
			}

			foreach (var item in secondPartOfResult)
			{
				Console.WriteLine($"{item.Key}: {item.Value}");
			}
		}
	}
}
