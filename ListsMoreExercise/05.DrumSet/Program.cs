using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.DrumSet
{
	class Program
	{
		static void Main(string[] args)
		{
			double savings = double.Parse(Console.ReadLine());
			List<int> drumSet = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();

			List<int> price = new List<int>();
			price.AddRange(drumSet);

			string command = Console.ReadLine();

			while (command != "Hit it again, Gabsy!")
			{
				int power = int.Parse(command);
				for (int i = 0; i < drumSet.Count; i++)
				{
					drumSet[i] -= power;
					if (drumSet[i] <= 0)
					{
						if (savings - (price[i] * 3) >= 0)
						{
							savings -= price[i] * 3;
							drumSet[i] = price[i];
						}
					}
				}

				for (int i = 0; i < drumSet.Count; i++)
				{
					if (drumSet[i] <= 0)
					{
						drumSet.Remove(drumSet[i]);
						price.Remove(price[i]);
					}
				}

				command = Console.ReadLine();
			}

			foreach (var drum in drumSet)
			{
				Console.Write(drum + " ");
			}

			Console.WriteLine();
			Console.WriteLine($"Gabsy has {savings:f2}lv.");
		}
	}
}
