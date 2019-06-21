using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.ChangeList
{
	class Program
	{
		static void DeleteElement(List<int> numbers, int numberToDelete)
		{
			for (int i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] == numberToDelete)
				{
					numbers.Remove(numbers[i]);
				}
			}
		}

		static void Main()
		{
			List<int> numbers = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();

			string command = Console.ReadLine();

			while (command != "end")
			{
				string[] tokens = command.Split(" ");

				if (tokens[0] == "Insert")
				{
					int numberToInsert = int.Parse(tokens[1]);
					int position = int.Parse(tokens[2]);
					numbers.Insert(position, numberToInsert);
				}
				else if (tokens[0] == "Delete")
				{
					int numberToDelete = int.Parse(tokens[1]);
					DeleteElement(numbers, numberToDelete);
				}

				command = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", numbers));
		}
	}
}
