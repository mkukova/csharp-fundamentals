using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.Judge
{
	class Program
	{
		static void Main(string[] args)
		{
			var contestsList = new Dictionary<string, Dictionary<string, int>>();
			var participantsList = new Dictionary<string, int>();

			while (true)
			{
				string[] input = Console.ReadLine().Split(" -> ");

				if (input[0] == "no more time")
				{
					break;
				}

				string username = input[0];
				string contest = input[1];
				int points = int.Parse(input[2]);

				if (!contestsList.ContainsKey(contest))
				{
					contestsList[contest] = new Dictionary<string, int>();
					contestsList[contest][username] = points;
				}

				if (!contestsList[contest].ContainsKey(username))
				{
					contestsList[contest][username] = points;
				}

				if (contestsList[contest][username] < points)
				{
					contestsList[contest][username] = points;
				}
			}

			foreach (var contest in contestsList)
			{
				Console.WriteLine($"{contest.Key}: {contest.Value.Count()} participants");
				int counter = 0;
				var currentContest = contest.Value
					.OrderByDescending(x => x.Value)
					.ThenBy(x => x.Key);

				foreach (var name in currentContest)
				{
					counter++;
					Console.WriteLine($"{counter}. {name.Key} <::> {name.Value}");
				}

				counter = 0;
			}

			Console.WriteLine("Individual standings:");

			foreach (var contest in contestsList)
			{
				foreach (var name in contest.Value)
				{
					if (!participantsList.ContainsKey(name.Key))
					{
						participantsList.Add(name.Key, name.Value);
					}
					else
					{
						participantsList[name.Key] = participantsList[name.Key] + name.Value;
					}
				}
			}

			int secondCounter = 1;
			participantsList = participantsList
				.OrderByDescending(x => x.Value)
				.ThenBy(y => y.Key)
				.ToDictionary(y => y.Key, x => x.Value);

			foreach (var user in participantsList)
			{
				Console.WriteLine($"{secondCounter}. {user.Key} -> {user.Value}");
				secondCounter++;
			}
		}
	}
}
