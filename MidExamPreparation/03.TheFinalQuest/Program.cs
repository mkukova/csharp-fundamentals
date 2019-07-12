using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TheFinalQuest
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> instructions = Console.ReadLine().Split(" ").ToList();
			string command = Console.ReadLine();

			while (command != "Stop")
			{
				string[] splittedCommand = command.Split(" ");
				string commandType = splittedCommand[0];

				switch (commandType)
				{
					case "Delete":
						int indexToDelete = int.Parse(splittedCommand[1]) + 1;
						if (indexToDelete >= 0 && indexToDelete < instructions.Count)
						{
							instructions.RemoveAt(indexToDelete);
						}

						break;
					case "Swap":
						string word1 = splittedCommand[1];
						string word2 = splittedCommand[2];
						if (instructions.Contains(word1) && instructions.Contains(word2))
						{
							int indexOfWord1 = instructions.IndexOf(word1);
							int indexOfWord2 = instructions.IndexOf(word2);
							instructions[indexOfWord1] = word2;
							instructions[indexOfWord2] = word1;
						}

						break;
					case "Put":
						string wordToPut = splittedCommand[1];
						int indexToPut = int.Parse(splittedCommand[2]) - 1;
						if (indexToPut >= 0 && indexToPut <= instructions.Count)
						{
							instructions.Insert(indexToPut, wordToPut);
						}

						break;
					case "Sort":
						instructions.Sort();
						instructions.Reverse();
						break;
					case "Replace":
						string word = splittedCommand[1];
						string wordToReplace = splittedCommand[2];
						if (instructions.Contains(wordToReplace))
						{
							int index = instructions.IndexOf(wordToReplace);
							instructions[index] = word;
						}

						break;
					default:
						Console.WriteLine("Incorrect command!");
						break;
				}

				command = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", instructions));
		}
	}
}
