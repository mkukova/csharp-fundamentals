using System;
using System.Linq;
using System.Collections.Generic;

namespace _10.SoftUniExamResults
{
	class Program
	{
		static void Main(string[] args)
		{
			var namesAndPoints = new Dictionary<string, double>();
			var counterForLanguages = new Dictionary<string, int>();
			double current = 0;

			while (true)
			{
				string[] splitedCommand = Console.ReadLine().Split("-");
				string name = splitedCommand[0];

				if (splitedCommand[0] == "exam finished")
				{
					break;
				}

				string language = splitedCommand[1];

				if (language == "banned")
				{
					namesAndPoints.Remove(name);
					continue;
				}

				double points = double.Parse(splitedCommand[2]);

				if (!namesAndPoints.ContainsKey(name))
				{
					namesAndPoints[name] = points;
					current = points;
				}
				else
				{
					current = namesAndPoints[name];

					if (current < points)
					{
						current = points;
						namesAndPoints[name] = current;
					}
				}

				if (!counterForLanguages.ContainsKey(language))
				{
					counterForLanguages[language] = 1;
				}
				else
				{
					counterForLanguages[language]++;
				}
			}

			namesAndPoints = namesAndPoints
				.OrderByDescending(x => x.Value)
				.ThenBy(x => x.Key)
				.ToDictionary(x => x.Key, x => x.Value);

			Console.WriteLine($"Results:");
			foreach (var item in namesAndPoints)
			{
				Console.WriteLine($"{item.Key} | {item.Value}");
			}

			counterForLanguages = counterForLanguages
				.OrderByDescending(x => x.Value)
				.ThenBy(x => x.Key)
				.ToDictionary(x => x.Key, x => x.Value);

			Console.WriteLine("Submissions:");
			foreach (var item in counterForLanguages)
			{
				Console.WriteLine($"{item.Key} - {item.Value}");
			}
		}
	}
}
