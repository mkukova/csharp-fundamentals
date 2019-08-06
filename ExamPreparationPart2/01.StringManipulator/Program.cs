using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.StringManipulator
{
	class Program
	{
		static void Main(string[] args)
		{
			string result = string.Empty;
			string input = Console.ReadLine();

			while (input != "End")
			{
				string[] splittedInput = input.Split(" ");
				string command = splittedInput[0];

				if (command == "Add")
				{
					string newStrToAdd = splittedInput[1];
					result += newStrToAdd;
				}
				else if (command == "Upgrade")
				{
					char oldChar = char.Parse(splittedInput[1]);
					result = result.Replace(oldChar, (char)(oldChar + 1));
				}
				else if (command == "Print")
				{
					Console.WriteLine(result);
				}
				else if (command == "Index")
				{
					char symbol = char.Parse(splittedInput[1]);
					List<int> indexes = new List<int>();

					indexes = result
						.Select((x, i) => i)
						.Where(x => result[x] == symbol)
						.ToList();

					if (!indexes.Any())
					{
						Console.WriteLine("None");
					}
					else
					{
						Console.WriteLine(string.Join(" ", indexes));
					}

				}
				else if (command == "Remove")
				{
					string searchedString = splittedInput[1];

					while (result.Contains(searchedString))
					{
						int index = result.IndexOf(searchedString);
						result = result.Remove(index, searchedString.Length);
					}
				}

				input = Console.ReadLine();
			}
		}
	}
}
