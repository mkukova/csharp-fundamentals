using System;
using System.Linq;

namespace _03.TreasureFinder
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] keyNumbers = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();

			string input = Console.ReadLine();

			while (input != "find")
			{
				string result = string.Empty;
				int inputLenght = input.Length;
				int counter = 0;

				while (counter < inputLenght)
				{
					for (int i = 0; i < keyNumbers.Length; i++)
					{
						int currentChar = (int)input[counter];
						int newChar = currentChar - keyNumbers[i];
						result += (char)newChar;
						counter++;
						if (counter == inputLenght)
						{
							break;
						}
					}
				}

				int indexStartType = result.IndexOf('&');
				string searchType = result.Substring(indexStartType + 1);
				int indexEndType = searchType.IndexOf('&');
				string type = result.Substring(indexStartType + 1, indexEndType);

				int indexStartCoordinates = result.IndexOf('<');
				int indexEndCoordinates = result.IndexOf('>');
				int coordinatesLenght = indexEndCoordinates - indexStartCoordinates - 1;
				string coordinates = result.Substring(indexStartCoordinates + 1, coordinatesLenght);

				Console.WriteLine($"Found {type} at {coordinates}");
				input = Console.ReadLine();
			}
		}
	}
}
