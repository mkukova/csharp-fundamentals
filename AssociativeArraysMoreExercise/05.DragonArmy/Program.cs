using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.DragonArmy
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberDragons = int.Parse(Console.ReadLine());
			var dragons = new Dictionary<string, SortedDictionary<string, int[]>>();

			for (int i = 0; i < numberDragons; i++)
			{
				string[] input = Console.ReadLine().Split();
				string type = input[0];
				string name = input[1];
				string damage = input[2];
				string health = input[3];
				string armor = input[4];

				if (!dragons.ContainsKey(type))
				{
					dragons[type] = new SortedDictionary<string, int[]>();
				}

				if (!dragons[type].ContainsKey(name))
				{
					dragons[type][name] = new int[3];
					dragons[type][name][0] = 45;
					dragons[type][name][1] = 250;
					dragons[type][name][2] = 10;
				}

				if (damage == "null")
				{
					dragons[type][name][0] = 45;
				}
				else
				{
					dragons[type][name][0] = int.Parse(damage);
				}

				if (health == "null")
				{
					dragons[type][name][1] = 250;
				}
				else
				{
					dragons[type][name][1] = int.Parse(health);
				}

				if (armor == "null")
				{
					dragons[type][name][2] = 10;
				}
				else
				{
					dragons[type][name][2] = int.Parse(armor);
				}
			}

			foreach (var typesDragon in dragons)
			{
				var damages = typesDragon.Value.Values.Select(x => x[0])
					.ToArray();
				double averageDamages = damages.Average();
				var healths = typesDragon.Value.Values.Select(x => x[1])
					.ToArray();
				double averageHealths = healths.Average();
				var armors = typesDragon.Value.Values.Select(x => x[2])
					.ToArray();
				double averageArmors = armors.Average();
				Console.WriteLine($"{typesDragon.Key}::({averageDamages:F2}/{averageHealths:F2}/{averageArmors:F2})");

				foreach (var dragon in typesDragon.Value)
				{
					Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
				}
			}
		}
	}
}
