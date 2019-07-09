using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfTeams = int.Parse(Console.ReadLine());
			List<Team> teams = new List<Team>();

			for (int i = 0; i < countOfTeams; i++)
			{
				string[] input = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);
				List<string> membersList = new List<string>();
				Team currentTeam = new Team(input[0], input[1]);
				currentTeam.Members = membersList;

				if (!teams.Select(x => x.TeamName).Contains(currentTeam.TeamName))
				{
					if (!teams.Select(x => x.CreatorName).Contains(currentTeam.CreatorName))
					{
						teams.Add(currentTeam);
						Console.WriteLine($"Team {currentTeam.TeamName} has been created by {currentTeam.CreatorName}!");
					}
					else
					{
						Console.WriteLine($"{currentTeam.CreatorName} cannot create another team!");
					}
				}
				else
				{
					Console.WriteLine($"Team {currentTeam.TeamName} was already created!");
				}
			}

			string command = Console.ReadLine();

			while (command != "end of assignment")
			{
				string[] input = command.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
				string newUser = input[0];
				string teamName = input[1];

				if (!teams.Select(x => x.TeamName).Contains(teamName))
				{
					Console.WriteLine($"Team {teamName} does not exist!");
				}
				else if (teams.Select(x => x.Members)
					.Any(x => x.Contains(newUser) || teams.Select(y => y.CreatorName)
					.Contains(newUser)))
				{
					Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
				}
				else
				{
					int teamToJoinIndex = teams.FindIndex(x => x.TeamName == teamName);
					teams[teamToJoinIndex].Members.Add(newUser);
				}

				command = Console.ReadLine();
			}

			List<Team> teamsToDisband = teams
				.OrderBy(x => x.TeamName)
				.Where(x => x.Members.Count == 0)
				.ToList();

			List<Team> fullTeams = teams
				.OrderByDescending(y => y.Members.Count)
				.ThenBy(y => y.TeamName)
				.Where(y => y.Members.Count > 0)
				.ToList();

			foreach (var team in fullTeams)
			{
				Console.WriteLine($"{team.TeamName}");
				Console.WriteLine($"- {team.CreatorName}");
				foreach (var member in team.Members.OrderBy(x => x))
				{
					Console.WriteLine($"-- {member}");
				}
			}

			Console.WriteLine($"Teams to disband:");
			foreach (var team in teamsToDisband)
			{
				Console.WriteLine(team.TeamName);
			}

		}
	}
}

