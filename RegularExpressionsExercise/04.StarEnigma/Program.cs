using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _04.StarEnigma
{
	class Program
	{
		static void Main(string[] args)
		{
			int countMessages = int.Parse(Console.ReadLine());
			string firstPattern = @"[starSTAR]";
			List<string> attackedPlanets = new List<string>();
			List<string> destroyedPlanets = new List<string>();

			for (int i = 0; i < countMessages; i++)
			{
				string message = Console.ReadLine();
				MatchCollection lettersMatched = Regex.Matches(message, firstPattern);
				int countOfLetters = lettersMatched.Count();
				string newMessage = string.Empty;

				foreach (var letter in message)
				{
					newMessage += (char)(letter - countOfLetters);
				}

				string plannetPattern = @"@(?<name>[A-Za-z]+)[^@\-!:>]*:(?<population>[0-9]+)[^@\-!:>]*!(?<type>A|D)![^@\-!:>]*->(?<soldierCount>[0-9]+)";

				Match planetArgs = Regex.Match(newMessage, plannetPattern);

				if (planetArgs.Success)
				{
					string planetName = planetArgs.Groups["name"].Value;
					string type = planetArgs.Groups["type"].Value;

					if (type == "A")
					{
						attackedPlanets.Add(planetName);
					}
					else if (type == "D")
					{
						destroyedPlanets.Add(planetName);
					}
				}
			}

			Console.WriteLine($"Attacked planets: {attackedPlanets.Count()}");
			foreach (var planet in attackedPlanets.OrderBy(x => x))
			{
				Console.WriteLine($"-> {planet}");
			}

			Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count()}");
			foreach (var planet in destroyedPlanets.OrderBy(x => x))
			{
				Console.WriteLine($"-> {planet}");
			}
		}
	}
}
