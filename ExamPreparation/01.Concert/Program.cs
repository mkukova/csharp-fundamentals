using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Concert
{
	class Program
	{
		static void Main()
		{
			Dictionary<string, List<string>> bands = new Dictionary<string, List<string>>();
			Dictionary<string, int> playTime = new Dictionary<string, int>();
			string input = Console.ReadLine();
			int totalTime = 0;

			while (input != "start of concert")
			{
				string[] args = input.Split("; ");
				string command = args[0];
				string bandName = args[1];

				if (command == "Add")
				{
					List<string> members = args[2].Split(", ").ToList();

					if (!bands.ContainsKey(bandName))
					{
						bands.Add(bandName, members);
					}
					else
					{
						foreach (var member in members)
						{
							if (!bands[bandName].Contains(member))
							{
								bands[bandName].Add(member);
							}
						}
					}
				}
				else
				{
					int time = int.Parse(args[2]);
					totalTime += time;

					if (!playTime.ContainsKey(bandName))
					{
						playTime.Add(bandName, time);
					}
					else
					{
						playTime[bandName] += time;
					}
				}

				input = Console.ReadLine();
			}

			Console.WriteLine($"Total time: {totalTime}");

			foreach (var band in playTime.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
			{
				Console.WriteLine($"{band.Key} -> {band.Value}");
			}

			string name = Console.ReadLine();
			Console.WriteLine(name);

			foreach (var member in bands[name])
			{
				Console.WriteLine($"=> {member}");
			}			
		}
	}
}
