using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MOBAChallenger
{
	class Program
	{
		static void Main(string[] args)
		{
			var playersList = new Dictionary<string, Dictionary<string, int>>();

			while (true)
			{
				string input = Console.ReadLine();

				if (input == "Season end")
				{
					break;
				}

				if (input.Contains("->"))
				{
					string[] splittedInput = input.Split(" -> ");
					string player = splittedInput[0];
					string position = splittedInput[1];
					int skill = int.Parse(splittedInput[2]);

					if (!playersList.ContainsKey(player))
					{
						playersList[player] = new Dictionary<string, int>();
					}

					if (!playersList[player].ContainsKey(position))
					{
						playersList[player].Add(position, 0);
					}

					if (playersList[player][position] <= skill)
					{
						playersList[player][position] = skill;
					}
				}
				else
				{
					string[] splittedInput = input.Split(" ");
					string player1 = splittedInput[0];
					string player2 = splittedInput[2];

					if (playersList.ContainsKey(player1) && playersList.ContainsKey(player2))
					{
						List<string> player1Positions = playersList[player1].Keys.ToList();
						List<string> player2Positions = playersList[player2].Keys.ToList();
						string position = "";
						bool commonPosition = false;

						for (int i = 0; i < player1Positions.Count; i++)
						{
							if (player2Positions.Contains(player1Positions[i]))
							{
								position = player1Positions[i];
								commonPosition = true;
								break;
							}
						}

						if (commonPosition)
						{
							int totalSkills1 = playersList[player1].Values.Sum();
							int totalSkills2 = playersList[player2].Values.Sum();

							if (totalSkills1 > totalSkills2)
							{
								playersList.Remove(player2);
							}
							else if (totalSkills1 < totalSkills2)
							{
								playersList.Remove(player1);
							}
						}
					}
					else
					{
						continue;
					}
				}
			}

			foreach (var item in playersList
				.OrderByDescending(x => x.Value.Values.Sum())
				.ThenBy(y => y.Key))
			{
				Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()} skill");

				foreach (var player in item.Value
					.OrderByDescending(x => x.Value)
					.ThenBy(y => y.Key))
				{
					Console.WriteLine($"- {player.Key} <::> {player.Value}");
				}
			}
		}
	}
}
