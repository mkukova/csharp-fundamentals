using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Train
{
	class Program
	{
		static void AddPassengers(List<int> wagons, int peopleToAdd, int maxCapacity)
		{
			for (int i = 0; i < wagons.Count; i++)
			{
				if ((wagons[i] + peopleToAdd) <= maxCapacity)
				{
					wagons[i] += peopleToAdd;
					break;
				}
			}
		}

		static void Main(string[] args)
		{
			List<int> wagons = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();

			int maxCapacity = int.Parse(Console.ReadLine());
			string command = Console.ReadLine();

			while (command != "end")
			{
				string[] tokens = command.Split(" ");

				if (tokens[0] == "Add")
				{
					int wagonToAdd = int.Parse(tokens[1]);
					wagons.Add(wagonToAdd);
				}
				else
				{
					int passengersToAdd = int.Parse(tokens[0]);
					AddPassengers(wagons, passengersToAdd, maxCapacity);
				}

				command = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", wagons));
		}
	}
}
