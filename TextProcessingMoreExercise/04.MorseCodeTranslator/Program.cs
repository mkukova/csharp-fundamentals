using System;
using System.Linq;

namespace _04.MorseCodeTranslator
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(" ");
			string result = string.Empty;

			for (int i = 0; i < input.Length; i++)
			{
				string currentCode = input[i];
				char currentLetter = ' ';

				switch (currentCode)
				{
					case ".-":
						currentLetter = 'A';
						break;
					case "-...":
						currentLetter = 'B';
						break;
					case "-.-.":
						currentLetter = 'C';
						break;
					case "-..":
						currentLetter = 'D';
						break;
					case ".":
						currentLetter = 'E';
						break;
					case "..-.":
						currentLetter = 'F';
						break;
					case "--.":
						currentLetter = 'G';
						break;
					case "....":
						currentLetter = 'H';
						break;
					case "..":
						currentLetter = 'I';
						break;
					case ".---":
						currentLetter = 'J';
						break;
					case "-.-":
						currentLetter = 'K';
						break;
					case ".-..":
						currentLetter = 'L';
						break;
					case "--":
						currentLetter = 'M';
						break;
					case "-.":
						currentLetter = 'N';
						break;
					case "---":
						currentLetter = 'O';
						break;
					case ".--.":
						currentLetter = 'P';
						break;
					case "--.-":
						currentLetter = 'Q';
						break;
					case ".-.":
						currentLetter = 'R';
						break;
					case "...":
						currentLetter = 'S';
						break;
					case "-":
						currentLetter = 'T';
						break;
					case "..-":
						currentLetter = 'U';
						break;
					case "...-":
						currentLetter = 'V';
						break;
					case ".--":
						currentLetter = 'W';
						break;
					case "-..-":
						currentLetter = 'X';
						break;
					case "-.--":
						currentLetter = 'Y';
						break;
					case "--..":
						currentLetter = 'Z';
						break;
					case "|":
						currentLetter = ' ';
						break;
				}

				result += currentLetter;
			}

			Console.WriteLine(result);
		}
	}
}
