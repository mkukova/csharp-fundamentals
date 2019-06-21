using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.ListManipulationAdvanced
{
	class Program
	{
		static void PrintEvenNumbers(List<int> numbers)
		{
			List<int> result = new List<int>();

			for (int i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] % 2 == 0)
				{
					result.Add(numbers[i]);
				}
			}

			Console.WriteLine(string.Join(" ", result));
		}

		static void PrintOddNumbers(List<int> numbers)
		{
			List<int> result = new List<int>();

			for (int i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] % 2 != 0)
				{
					result.Add(numbers[i]);
				}
			}

			Console.WriteLine(string.Join(" ", result));
		}

		static void FilterList(List<int> numbers, int boardNumber, string operators)
		{
			List<int> result = new List<int>();
			switch (operators)
			{
				case "<":
					for (int i = 0; i < numbers.Count; i++)
					{
						if (numbers[i] < boardNumber)
						{
							result.Add(numbers[i]);
						}
					}

					break;
				case ">":
					for (int i = 0; i < numbers.Count; i++)
					{
						if (numbers[i] > boardNumber)
						{
							result.Add(numbers[i]);
						}
					}

					break;
				case ">=":
					for (int i = 0; i < numbers.Count; i++)
					{
						if (numbers[i] >= boardNumber)
						{
							result.Add(numbers[i]);
						}
					}

					break;
				case "<=":
					for (int i = 0; i < numbers.Count; i++)
					{
						if (numbers[i] <= boardNumber)
						{
							result.Add(numbers[i]);
						}
					}

					break;
				default:
					Console.WriteLine("Incorrect operator!");
					break;
			}

			Console.WriteLine(string.Join(" ", result));
		}
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();

			string command = Console.ReadLine();
			int countChanges = 0;

			while (command != "end")
			{
				string[] tokens = command.Split();
				switch (tokens[0])
				{
					case "Contains":
						int itemToContain = int.Parse(tokens[1]);
						if (numbers.Contains(itemToContain))
						{
							Console.WriteLine("Yes");
						}
						else
						{
							Console.WriteLine("No such number");
						}

						break;
					case "PrintEven":
						PrintEvenNumbers(numbers);
						break;
					case "PrintOdd":
						PrintOddNumbers(numbers);
						break;
					case "GetSum":
						int sum = numbers.Sum();
						Console.WriteLine(sum);
						break;
					case "Filter":
						int boardNumber = int.Parse(tokens[2]);
						FilterList(numbers, boardNumber, tokens[1]);
						break;
					case "Add":
						int numberToAdd = int.Parse(tokens[1]);
						numbers.Add(numberToAdd);
						countChanges++;
						break;
					case "Remove":
						int numberToRemove = int.Parse(tokens[1]);
						numbers.Remove(numberToRemove);
						countChanges++;
						break;
					case "RemoveAt":
						int indexToRemove = int.Parse(tokens[1]);
						numbers.RemoveAt(indexToRemove);
						countChanges++;
						break;
					case "Insert":
						int numberToInsert = int.Parse(tokens[1]);
						int indexToInsert = int.Parse(tokens[2]);
						numbers.Insert(indexToInsert, numberToInsert);
						countChanges++;
						break;
					default:
						Console.WriteLine("Incorrect command!");
						break;
				}

				command = Console.ReadLine();
			}

			if (countChanges != 0)
			{
				Console.WriteLine(string.Join(" ", numbers));
			}
		}
	}
}
