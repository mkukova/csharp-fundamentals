using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Ranking
{
	class Program
	{
		static void Main(string[] args)
		{
			var contestsList = new Dictionary<string, string>();

			while (true)
			{
				string[] input = Console.ReadLine().Split(":");

				if (input[0] == "end of contests")
				{
					break;
				}

				string contest = input[0];
				string password = input[1];

				if (!contestsList.ContainsKey(contest))
				{
					contestsList[contest] = password;
				}
			}

			var submissionList = new SortedDictionary<string, Dictionary<string, double>>();

			while (true)
			{
				string[] input = Console.ReadLine().Split("=>");

				if (input[0] == "end of submissions")
				{
					break;
				}

				string contest = input[0];
				string password = input[1];
				string username = input[2];
				double points = double.Parse(input[3]);

				if (!contestsList.ContainsKey(contest) || contestsList[contest] != password)
				{
					continue;
				}

				if (!submissionList.ContainsKey(username))
				{
					submissionList[username] = new Dictionary<string, double>();
				}

				if (!submissionList[username].ContainsKey(contest))
				{
					submissionList[username].Add(contest, points);
				}

				if (submissionList[username][contest] < points)
				{
					submissionList[username][contest] = points;
				}
			}

			var totalPoints = new Dictionary<string, double>();

			foreach (var kvp in submissionList)
			{
				totalPoints[kvp.Key] = kvp.Value.Values.Sum();
			}

			double maxPoints = totalPoints.Values.Max();

			foreach (var kvp in totalPoints)
			{
				if (kvp.Value == maxPoints)
				{
					Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");
				}
			}

			Console.WriteLine("Ranking: ");

			foreach (var kvp in submissionList)
			{
				Console.WriteLine(kvp.Key);
				Console.WriteLine(string.Join(Environment.NewLine, kvp.Value
					.OrderByDescending(x => x.Value)
					.Select(a => $"#  {a.Key} -> {a.Value}")
					));
			}
		}
	}
}
